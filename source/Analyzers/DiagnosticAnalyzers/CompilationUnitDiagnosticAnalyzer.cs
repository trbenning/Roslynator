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
    public class CompilationUnitDiagnosticAnalyzer : BaseDiagnosticAnalyzer
    {
        public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics
        {
            get
            {
                return ImmutableArray.Create(
                    DiagnosticDescriptors.DeclareEachTypeInSeparateFile,
                    DiagnosticDescriptors.RemoveFileWithNoCode);
            }
        }

        public override void Initialize(AnalysisContext context)
        {
            if (context == null)
                throw new ArgumentNullException(nameof(context));

            base.Initialize(context);

            context.RegisterSyntaxNodeAction(AnalyzeCompilationUnit, SyntaxKind.CompilationUnit);
        }

        private void AnalyzeCompilationUnit(SyntaxNodeAnalysisContext context)
        {
            var compilationUnit = (CompilationUnitSyntax)context.Node;

            DeclareEachTypeInSeparateFileRefactoring.Analyze(context, compilationUnit);

            SyntaxToken token = compilationUnit.EndOfFileToken;

            if (compilationUnit.Span == token.Span
                && !token.HasTrailingTrivia
                && token.LeadingTrivia.All(f => !f.IsDirective))
            {
                context.ReportDiagnostic(
                    DiagnosticDescriptors.RemoveFileWithNoCode,
                    Location.Create(compilationUnit.SyntaxTree, default(TextSpan)));
            }
        }
    }
}
