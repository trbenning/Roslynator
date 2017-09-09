﻿// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Threading;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Roslynator.CSharp.Syntax;

namespace Roslynator.CSharp.Refactorings.UseMethodChaining
{
    internal class MethodChainingWithAssignmentRefactoring : UseMethodChainingRefactoring
    {
        protected override bool IsFixableStatement(
            StatementSyntax statement,
            string name,
            ITypeSymbol typeSymbol,
            SemanticModel semanticModel,
            CancellationToken cancellationToken)
        {
            if (statement.SpanOrLeadingTriviaContainsDirectives())
                return false;

            if (!(statement is ExpressionStatementSyntax expressionStatement))
                return false;

            if (!SimpleAssignmentExpression.TryCreate(expressionStatement.Expression, out SimpleAssignmentExpression simpleAssignment))
                return false;

            if (name != (simpleAssignment.Left as IdentifierNameSyntax)?.Identifier.ValueText)
                return false;

            if (!MemberInvocationExpression.TryCreate(simpleAssignment.Right, out MemberInvocationExpression memberInvocation))
                return false;

            if (!(WalkDownMethodChain(memberInvocation).Expression is IdentifierNameSyntax identifierName))
                return false;

            if (name != identifierName.Identifier.ValueText)
                return false;

            if (!semanticModel.TryGetMethodInfo(memberInvocation.InvocationExpression, out MethodInfo methodInfo, cancellationToken))
                return false;

            if (!methodInfo.ReturnType.Equals(typeSymbol))
                return false;

            if (IsReferenced(memberInvocation.InvocationExpression, identifierName, name, semanticModel, cancellationToken))
                return false;

            return true;
        }

        private static bool IsReferenced(
            SyntaxNode node,
            IdentifierNameSyntax identifierName,
            string name,
            SemanticModel semanticModel,
            CancellationToken cancellationToken)
        {
            ISymbol symbol = null;

            foreach (SyntaxNode descendant in node.DescendantNodes())
            {
                if ((descendant is IdentifierNameSyntax identifierName2)
                    && identifierName != identifierName2
                    && name == identifierName2.Identifier.ValueText)
                {
                    if (symbol == null)
                        symbol = semanticModel.GetSymbol(identifierName, cancellationToken);

                    if (semanticModel.GetSymbol(identifierName2, cancellationToken)?.Equals(symbol) == true)
                        return true;
                }
            }

            return false;
        }

        protected override InvocationExpressionSyntax GetInvocationExpression(ExpressionStatementSyntax expressionStatement)
        {
            if (!(expressionStatement.Expression is AssignmentExpressionSyntax assignmentExpression))
                return null;

            if (assignmentExpression.Kind() != SyntaxKind.SimpleAssignmentExpression)
                return null;

            return assignmentExpression.Right as InvocationExpressionSyntax;
        }
    }
}