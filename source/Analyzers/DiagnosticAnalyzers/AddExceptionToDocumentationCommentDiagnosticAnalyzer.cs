﻿// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Collections.Immutable;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Diagnostics;
using Roslynator.CSharp.Refactorings.AddExceptionToDocumentationComment;

namespace Roslynator.CSharp.DiagnosticAnalyzers
{
    [DiagnosticAnalyzer(LanguageNames.CSharp)]
    public class AddExceptionToDocumentationCommentDiagnosticAnalyzer : BaseDiagnosticAnalyzer
    {
        public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics
        {
            get { return ImmutableArray.Create(DiagnosticDescriptors.AddExceptionToDocumentationComment); }
        }

        public override void Initialize(AnalysisContext context)
        {
            if (context == null)
                throw new ArgumentNullException(nameof(context));

            base.Initialize(context);
            context.EnableConcurrentExecution();

            context.RegisterSyntaxNodeAction(AnalyzeThrowStatement, SyntaxKind.ThrowStatement);
            context.RegisterSyntaxNodeAction(AnalyzeThrowExpression, SyntaxKind.ThrowExpression);
        }

        private static void AnalyzeThrowStatement(SyntaxNodeAnalysisContext context)
        {
            var throwStatement = (ThrowStatementSyntax)context.Node;

            AddExceptionToDocumentationCommentAnalysis analysis = AddExceptionToDocumentationCommentRefactoring.Analyze(throwStatement, context.SemanticModel, context.CancellationToken);

            if (analysis.Success)
            {
                context.ReportDiagnostic(
                    DiagnosticDescriptors.AddExceptionToDocumentationComment,
                    throwStatement);
            }
        }

        private static void AnalyzeThrowExpression(SyntaxNodeAnalysisContext context)
        {
            var throwExpression = (ThrowExpressionSyntax)context.Node;

            AddExceptionToDocumentationCommentAnalysis analysis = AddExceptionToDocumentationCommentRefactoring.Analyze(throwExpression, context.SemanticModel, context.CancellationToken);

            if (analysis.Success)
            {
                context.ReportDiagnostic(
                    DiagnosticDescriptors.AddExceptionToDocumentationComment,
                    throwExpression);
            }
        }
    }
}
