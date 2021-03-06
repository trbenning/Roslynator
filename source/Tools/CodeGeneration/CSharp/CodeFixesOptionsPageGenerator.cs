﻿// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Collections.Generic;
using System.Linq;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Roslynator.CSharp;
using Roslynator.Metadata;
using Roslynator.Utilities;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;
using static Roslynator.CSharp.CSharpFactory;

namespace Roslynator.CodeGeneration.CSharp
{
    public static class CodeFixesOptionsPageGenerator
    {
        public static CompilationUnitSyntax Generate(IEnumerable<CodeFixDescriptor> codeFixes, IComparer<string> comparer)
        {
            return CompilationUnit(
                UsingDirectives(
                    "System.Collections.Generic",
                    "Roslynator.CSharp.CodeFixes"),
                NamespaceDeclaration(
                    "Roslynator.VisualStudio",
                    ClassDeclaration(
                        Modifiers.PublicPartial(),
                        "CodeFixesOptionsPage",
                        CreateMembers(codeFixes, comparer).ToSyntaxList())));
        }

        private static IEnumerable<MemberDeclarationSyntax> CreateMembers(IEnumerable<CodeFixDescriptor> codeFixes, IComparer<string> comparer)
        {
            yield return PropertyDeclaration(
                Modifiers.ProtectedOverride(),
                StringType(),
                Identifier("DisabledByDefault"),
                AccessorList(AutoGetAccessorDeclaration()),
                ParseExpression(
                    "$\"" +
                    string.Join(",", codeFixes
                        .Where(f => !f.IsEnabledByDefault)
                        .OrderBy(f => f.Identifier, comparer)
                        .Select(f => $"{{CodeFixIdentifiers.{f.Identifier}}}")) +
                    "\""));

            yield return PropertyDeclaration(
                Modifiers.ProtectedOverride(),
                StringType(),
                Identifier("MaxId"),
                AccessorList(AutoGetAccessorDeclaration()),
                ParseExpression($"CodeFixIdentifiers.{codeFixes.OrderBy(f => f.Id, comparer).Last().Identifier}"));

            yield return MethodDeclaration(
                Modifiers.ProtectedOverride(),
                VoidType(),
                "Fill",
                ParameterList(Parameter(ParseTypeName("ICollection<BaseModel>"), Identifier("codeFixes"))),
                Block(
                    SingletonList(ExpressionStatement(ParseExpression("codeFixes.Clear()")))
                        .AddRange(codeFixes
                            .OrderBy(f => f.Id, comparer)
                            .Select(codeFix =>
                            {
                                return ExpressionStatement(
                                    ParseExpression($"codeFixes.Add(new BaseModel(CodeFixIdentifiers.{codeFix.Identifier}, \"{StringUtility.EscapeQuote(codeFix.Title)} (fixes {string.Join(", ", codeFix.FixableDiagnosticIds)})\", IsEnabled(CodeFixIdentifiers.{codeFix.Identifier})))"));
                            }))));
        }
    }
}
