﻿// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Diagnostics;
using Microsoft.CodeAnalysis.Text;
using Roslynator.CSharp;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace Roslynator.CSharp.Refactorings
{
    internal static class MergeSwitchSectionsRefactoring
    {
        public static void AnalyzeSwitchStatement(SyntaxNodeAnalysisContext context)
        {
            var switchStatement = (SwitchStatementSyntax)context.Node;

            if (!switchStatement.ContainsDiagnostics)
            {
                SyntaxList<SwitchSectionSyntax> sections = switchStatement.Sections;

                if (sections.Count > 1)
                {
                    SyntaxList<StatementSyntax> statements = GetStatements(sections[0]);

                    for (int i = 1; i < sections.Count; i++)
                    {
                        SyntaxList<StatementSyntax> statements2 = GetStatements(sections[i]);

                        if (AreEquivalent(statements, statements2))
                        {
                            int firstIndex = i - 1;

                            i++;

                            while (i < sections.Count
                                && AreEquivalent(statements, GetStatements(sections[i])))
                            {
                                i++;
                            }

                            Analyze(context, switchStatement, sections, firstIndex, i - 1);
                            return;
                        }

                        statements = statements2;
                    }
                }
            }
        }

        private static void Analyze(
            SyntaxNodeAnalysisContext context,
            SwitchStatementSyntax switchStatement,
            SyntaxList<SwitchSectionSyntax> sections,
            int firstIndex,
            int lastIndex)
        {
            SwitchSectionSyntax firstSection = sections[firstIndex];
            SwitchSectionSyntax lastSection = sections[lastIndex];

            if (!switchStatement.ContainsDirectives(TextSpan.FromBounds(firstSection.SpanStart, lastSection.Span.End)))
            {
                context.ReportDiagnostic(
                    DiagnosticDescriptors.MergeSwitchSectionsWithEquivalentContent,
                    Location.Create(switchStatement.SyntaxTree, firstSection.Statements.Span));
            }
        }

        private static bool AreEquivalent(SyntaxList<StatementSyntax> statements, SyntaxList<StatementSyntax> statements2)
        {
            if (statements.Count == 1)
            {
                if (statements2.Count == 1)
                    return AreEquivalent(statements[0], statements2[0]);
            }
            else if (statements.Count == 2
                && statements2.Count == 2
                && statements[1].IsKind(SyntaxKind.BreakStatement)
                && statements2[1].IsKind(SyntaxKind.BreakStatement))
            {
                return AreEquivalent(statements[0], statements2[0]);
            }

            return false;
        }

        private static bool AreEquivalent(StatementSyntax statement, StatementSyntax statement2)
        {
            return statement.Kind() == statement2.Kind()
                && SyntaxComparer.AreEquivalent(statement, statement2)
                && statement.DescendantTrivia().All(f => f.IsWhitespaceOrEndOfLineTrivia())
                && statement2.DescendantTrivia().All(f => f.IsWhitespaceOrEndOfLineTrivia());
        }

        private static SyntaxList<StatementSyntax> GetStatements(SwitchSectionSyntax section)
        {
            SyntaxList<StatementSyntax> statements = section.Statements;

            if (statements.Count == 1)
            {
                StatementSyntax statement = statements[0];

                if (statement.IsKind(SyntaxKind.Block))
                    return ((BlockSyntax)statement).Statements;
            }

            return statements;
        }

        public static Task<Document> RefactorAsync(
            Document document,
            SwitchSectionSyntax switchSection,
            int numberOfAdditionalSectionsToMerge,
            CancellationToken cancellationToken)
        {
            var switchStatement = (SwitchStatementSyntax)switchSection.Parent;

            SyntaxList<SwitchSectionSyntax> sections = switchStatement.Sections;

            int index = sections.IndexOf(switchSection);

            IEnumerable<SwitchSectionSyntax> sectionsWithoutStatements = sections
                .Skip(index)
                .Take(numberOfAdditionalSectionsToMerge + 1)
                .Select(CreateSectionWithoutStatements);

            SyntaxList<SwitchSectionSyntax> newSections = sections.Take(index)
                .Concat(sectionsWithoutStatements)
                .Concat(sections.Skip(index + numberOfAdditionalSectionsToMerge + 1))
                .ToSyntaxList();

            SwitchStatementSyntax newSwitchStatement = switchStatement.WithSections(newSections);

            return document.ReplaceNodeAsync(switchStatement, newSwitchStatement, cancellationToken);
        }

        private static SwitchSectionSyntax CreateSectionWithoutStatements(SwitchSectionSyntax section)
        {
            SwitchSectionSyntax newSection = section.WithStatements(List<StatementSyntax>());

            if (newSection
                .GetTrailingTrivia()
                .All(f => f.IsWhitespaceTrivia()))
            {
                newSection = newSection.WithoutTrailingTrivia();
            }

            if (section
                .SyntaxTree
                .IsSingleLineSpan(TextSpan.FromBounds(section.Labels.Last().SpanStart, section.Span.End)))
            {
                newSection = newSection.AppendToTrailingTrivia(section.GetTrailingTrivia());
            }

            return newSection;
        }
    }
}
