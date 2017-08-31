﻿// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Collections.Immutable;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Diagnostics;
using Roslynator.CSharp.Analysis;
using Roslynator.CSharp;
using Roslynator.CSharp.Refactorings;

namespace Roslynator.CSharp.DiagnosticAnalyzers
{
    [DiagnosticAnalyzer(LanguageNames.CSharp)]
    public class IfStatementSyntaxDiagnosticAnalyzer : BaseDiagnosticAnalyzer
    {
        public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics
        {
            get
            {
                return ImmutableArray.Create(
                    DiagnosticDescriptors.AddBracesToIfElse,
                    DiagnosticDescriptors.RemoveBracesFromIfElse,
                    DiagnosticDescriptors.RemoveBracesFromIfElseFadeOut,
                    DiagnosticDescriptors.MergeIfStatementWithNestedIfStatement,
                    DiagnosticDescriptors.MergeIfStatementWithNestedIfStatementFadeOut,
                    DiagnosticDescriptors.ReplaceIfStatementWithReturnStatement,
                    DiagnosticDescriptors.ReplaceIfStatementWithReturnStatementFadeOut,
                    DiagnosticDescriptors.ReplaceIfStatementWithAssignment);
            }
        }

        public override void Initialize(AnalysisContext context)
        {
            if (context == null)
                throw new ArgumentNullException(nameof(context));

            base.Initialize(context);

            context.RegisterSyntaxNodeAction(AnalyzeIfStatement, SyntaxKind.IfStatement);
        }

        private void AnalyzeIfStatement(SyntaxNodeAnalysisContext context)
        {
            var ifStatement = (IfStatementSyntax)context.Node;

            AnalyzeBraces(context, ifStatement);

            MergeIfStatementWithNestedIfStatementRefactoring.Analyze(context, ifStatement);

            ReplaceIfStatementWithReturnStatementRefactoring.Analyze(context, ifStatement);

            ReplaceIfStatementWithAssignmentRefactoring.Analyze(context, ifStatement);
        }

        private static void AnalyzeBraces(SyntaxNodeAnalysisContext context, IfStatementSyntax ifStatement)
        {
            if (!ifStatement.IsParentKind(SyntaxKind.ElseClause)
                && ifStatement.Else != null)
            {
                BracesAnalysisResult result = CSharpAnalysis.AnalyzeBraces(ifStatement);

                if ((result & BracesAnalysisResult.AddBraces) != 0)
                {
                    context.ReportDiagnostic(DiagnosticDescriptors.AddBracesToIfElse, ifStatement);
                }

                if ((result & BracesAnalysisResult.RemoveBraces) != 0)
                {
                    context.ReportDiagnostic(DiagnosticDescriptors.RemoveBracesFromIfElse, ifStatement);

                    foreach (SyntaxNode node in ifStatement.DescendantNodes())
                    {
                        if (node.IsKind(SyntaxKind.Block))
                            context.ReportBraces(DiagnosticDescriptors.RemoveBracesFromIfElseFadeOut, (BlockSyntax)node);
                    }
                }
            }
        }
    }
}
