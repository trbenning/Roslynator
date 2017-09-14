﻿// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Xml;
using System.Xml.Linq;
using Microsoft.CodeAnalysis;
using Roslynator.CSharp;
using Roslynator.Metadata;
using Roslynator.Utilities;

namespace Roslynator.CodeGeneration.Xml
{
    public static class XmlGenerator
    {
        public static string CreateDefaultConfigFile(
            IEnumerable<RefactoringDescriptor> refactorings,
            IEnumerable<CodeFixDescriptor> codeFixes)
        {
            var doc = new XDocument(
                new XElement("Roslynator",
                    new XElement("Settings",
                        new XElement("General",
                            new XElement("PrefixFieldIdentifierWithUnderscore", new XAttribute("IsEnabled", true))),
                        new XElement("Refactorings",
                            refactorings
                                .OrderBy(f => f.Id)
                                .Select(f =>
                                {
                                    return new XNode[] {
                                        new XElement("Refactoring",
                                        new XAttribute("Id", f.Id),
                                        new XAttribute("IsEnabled", f.IsEnabledByDefault)),
                                        new XComment($" {f.Identifier} ")
                                    };
                                })
                        ),
                        new XElement("CodeFixes",
                            codeFixes
                                .OrderBy(f => f.Id)
                                .Select(f =>
                                {
                                    return new XNode[] {
                                        new XElement("CodeFix",
                                        new XAttribute("Id", f.Id),
                                        new XAttribute("IsEnabled", f.IsEnabledByDefault)),
                                        new XComment($" {f.Identifier} (fixes {string.Join(", ", f.FixableDiagnosticIds)}) ")
                                    };
                                })
                        )
                    )
                )
            );

            var xmlWriterSettings = new XmlWriterSettings()
            {
                OmitXmlDeclaration = false,
                NewLineChars = "\r\n",
                IndentChars = "  ",
                Indent = true
            };

            using (var sw = new Utf8StringWriter())
            {
                using (XmlWriter xmlWriter = XmlWriter.Create(sw, xmlWriterSettings))
                    doc.WriteTo(xmlWriter);

                string s = sw.ToString();

                s = _regex.Replace(s, "${grp} ${comment}");

                return s;
            }
        }

        private static readonly Regex _regex = new Regex(@"
            (?<grp><(Refactoring|CodeFix)\ Id=""(RR|RCF)[0-9]{4}""\ IsEnabled=""(true|false)""\ />)
            \s+
            (?<comment><!--\ [a-zA-Z0-9 (),]+\ -->)
            ", RegexOptions.IgnorePatternWhitespace);

        public static string CreateAnalyzersXml()
        {
            FieldInfo[] fieldInfos = typeof(DiagnosticDescriptors).GetFields(BindingFlags.Public | BindingFlags.Static);

            var doc = new XDocument();

            var root = new XElement("Analyzers");

            foreach (FieldInfo fieldInfo in fieldInfos.OrderBy(f => ((DiagnosticDescriptor)f.GetValue(null)).Id))
            {
                if (fieldInfo.Name.EndsWith("FadeOut"))
                    continue;

                var descriptor = (DiagnosticDescriptor)fieldInfo.GetValue(null);

                var analyzer = new AnalyzerDescriptor(
                    descriptor.Id,
                    fieldInfo.Name,
                    descriptor.Title.ToString(),
                    descriptor.MessageFormat.ToString(),
                    descriptor.Category,
                    descriptor.DefaultSeverity.ToString(),
                    descriptor.IsEnabledByDefault,
                    descriptor.CustomTags.Contains(WellKnownDiagnosticTags.Unnecessary),
                    fieldInfos.Any(f => f.Name == fieldInfo.Name + "FadeOut"));

                root.Add(new XElement(
                    "Analyzer",
                    new XElement("Id", analyzer.Id),
                    new XAttribute("Identifier", analyzer.Identifier),
                    new XElement("Title", analyzer.Title),
                    new XElement("MessageFormat", analyzer.MessageFormat),
                    new XElement("Category", analyzer.Category),
                    new XElement("DefaultSeverity", analyzer.DefaultSeverity),
                    new XElement("IsEnabledByDefault", analyzer.IsEnabledByDefault),
                    new XElement("SupportsFadeOut", analyzer.SupportsFadeOut),
                    new XElement("SupportsFadeOutAnalyzer", analyzer.SupportsFadeOutAnalyzer)
                ));
            }

            doc.Add(root);

            using (var sw = new Utf8StringWriter())
            {
                doc.Save(sw);

                return sw.ToString();
            }
        }
    }
}
