﻿// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Collections.Immutable;
using System.Linq;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Diagnostics;
using Microsoft.CodeAnalysis.Text;
using Roslynator.CSharp.Refactorings;

namespace Roslynator.CSharp.DiagnosticAnalyzers
{
    [DiagnosticAnalyzer(LanguageNames.CSharp)]
    public class SplitVariableDeclarationDiagnosticAnalyzer : BaseDiagnosticAnalyzer
    {
        public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics
        {
            get { return ImmutableArray.Create(DiagnosticDescriptors.SplitVariableDeclaration); }
        }

        public override void Initialize(AnalysisContext context)
        {
            if (context == null)
                throw new ArgumentNullException(nameof(context));

            base.Initialize(context);

            context.RegisterSyntaxNodeAction(AnalyzeVariableDeclaration, SyntaxKind.VariableDeclaration);
        }

        private void AnalyzeVariableDeclaration(SyntaxNodeAnalysisContext context)
        {
            var variableDeclaration = (VariableDeclarationSyntax)context.Node;

            if (SplitVariableDeclarationRefactoring.CanRefactor(variableDeclaration))
            {
                SeparatedSyntaxList<VariableDeclaratorSyntax> variables = variableDeclaration.Variables;

                TextSpan span = TextSpan.FromBounds(variables[1].Span.Start, variables.Last().Span.End);

                if (context.Node
                    .DescendantTrivia(span)
                    .All(f => f.IsWhitespaceOrEndOfLineTrivia()))
                {
                    context.ReportDiagnostic(DiagnosticDescriptors.SplitVariableDeclaration, variableDeclaration);
                }
            }
        }
    }
}
