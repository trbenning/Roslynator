## Roslynator Refactorings

#### Add braces (RR0002)

* **Syntax**: do statement, else clause, fixed statement, for statement, foreach statement, if statement, lock statement, using statement, while statement
* **Scope**: embedded statement

![Add braces](../../images/refactorings/AddBraces.png)

#### Add braces to if\-else (RR0003)

* **Syntax**: if\-else chain
* **Scope**: embedded statement

![Add braces to if\-else](../../images/refactorings/AddBracesToIfElse.png)

#### Add braces to switch section (RR0004)

* **Syntax**: switch section
* **Scope**: statements

![Add braces to switch section](../../images/refactorings/AddBracesToSwitchSection.png)

#### Add braces to switch sections (RR0005)

* **Syntax**: switch statement
* **Scope**: switch keyword

![Add braces to switch sections](../../images/refactorings/AddBracesToSwitchSections.png)

#### Add cast expression (RR0006)

* **Syntax**: argument, assignment expression, return statement, variable declaration

![Add cast expression](../../images/refactorings/AddCastExpressionToArgument.png)

![Add cast expression](../../images/refactorings/AddCastExpressionToAssignmentExpression.png)

![Add cast expression](../../images/refactorings/AddCastExpressionToReturnStatement.png)

![Add cast expression](../../images/refactorings/AddCastExpressionToVariableDeclaration.png)

#### Add default value to parameter (RR0007)

* **Syntax**: parameter without default value
* **Scope**: identifier

![Add default value to parameter](../../images/refactorings/AddDefaultValueToParameter.png)

#### Add default value to return statement (RR0008)

* **Syntax**: return statement without expression

![Add default value to return statement](../../images/refactorings/AddDefaultValueToReturnStatement.png)

#### Add exception to documentation comment (RR0009)

* **Syntax**: throw statement

![Add exception to documentation comment](../../images/refactorings/AddExceptionToDocumentationComment.png)

#### Add identifier to variable declaration (RR0010)

* **Syntax**: variable declaration

![Add identifier to variable declaration](../../images/refactorings/AddIdentifierToVariableDeclaration.png)

#### Add parameter name to argument (RR0011)

* **Syntax**: argument list

![Add parameter name to argument](../../images/refactorings/AddParameterNameToArgument.png)

#### Add parameter name to parameter (RR0012)

* **Syntax**: parameter
* **Scope**: missing identifier

![Add parameter name to parameter](../../images/refactorings/AddParameterNameToParameter.png)

#### Add type parameter (RR0178)

* **Syntax**: class declaration, struct declaration, interface declaration, delegate declaration, method declaration, local function

![Add type parameter](../../images/refactorings/AddTypeParameter.png)

#### Add using directive (RR0013)

* **Syntax**: qualified name
* **Scope**: selected namespace

![Add using directive](../../images/refactorings/AddUsingDirective.png)

#### Add using static directive (RR0014)

* **Syntax**: member access expression \(public or internal static class\)
* **Scope**: selected class name

![Add using static directive](../../images/refactorings/AddUsingStaticDirective.png)

#### Call 'ConfigureAwait\(false\)' (RR0015)

* **Syntax**: awaitable method invocation
* **Scope**: method name

![Call 'ConfigureAwait\(false\)'](../../images/refactorings/CallConfigureAwait.png)

#### Call extension method as instance method (RR0016)

* **Syntax**: method invocation

![Call extension method as instance method](../../images/refactorings/CallExtensionMethodAsInstanceMethod.png)

#### Call 'To\.\.\.' method \(ToString, ToArray, ToList\) (RR0017)

* **Syntax**: argument, assignment expression, return statement, variable declaration

![Call 'To\.\.\.' method \(ToString, ToArray, ToList\)](../../images/refactorings/CallToMethod.png)

#### Change accessibility (RR0186)

* **Syntax**: access modifier

![Change accessibility](../../images/refactorings/ChangeAccessibility.png)

#### Change explicit type to 'var' (RR0018)

* **Syntax**: variable declaration, foreach statement
* **Scope**: type

![Change explicit type to 'var'](../../images/refactorings/ChangeExplicitTypeToVar.png)

#### Change method return type to 'void' (RR0021)

* **Syntax**: method

![Change method return type to 'void'](../../images/refactorings/ChangeMethodReturnTypeToVoid.png)

#### Change method/property/indexer type according to return expression (RR0019)

* **Syntax**: return statement in method/property/indexer

![Change method/property/indexer type according to return expression](../../images/refactorings/ChangeMemberTypeAccordingToReturnExpression.png)

#### Change method/property/indexer type according to yield return expression (RR0020)

* **Syntax**: yield return statement in method/property/indexer

![Change method/property/indexer type according to yield return expression](../../images/refactorings/ChangeMemberTypeAccordingToYieldReturnExpression.png)

#### Change type according to expression (RR0022)

* **Syntax**: variable declaration, foreach statement
* **Scope**: type

![Change type according to expression](../../images/refactorings/ChangeTypeAccordingToExpression.png)

![Change type according to expression](../../images/refactorings/ChangeForEachTypeAccordingToExpression.png)

#### Change 'var' to explicit type (RR0023)

* **Syntax**: variable declaration, foreach statetement
* **Scope**: type

![Change 'var' to explicit type](../../images/refactorings/ChangeVarToExplicitType.png)

#### Check expression for null (RR0024)

* **Syntax**: local declaration \(identifier\), assignment expression \(left\)

![Check expression for null](../../images/refactorings/CheckExpressionForNull.png)

#### Check parameter for null (RR0025)

* **Syntax**: parameter
* **Scope**: parameter identifier

![Check parameter for null](../../images/refactorings/CheckParameterForNull.png)

#### Collapse to initalizer (RR0026)

* **Syntax**: object creation followed with assignment\(s\)

![Collapse to initalizer](../../images/refactorings/CollapseToInitializer.png)

#### Comment out member (RR0027)

* **Syntax**: method, constructor, property, indexer, operator, event, namespace, class, struct, interface
* **Scope**: opening or closing brace

![Comment out member](../../images/refactorings/CommentOutMember.png)

#### Comment out statement (RR0028)

* **Syntax**: do statement, fixed statement, for statement, foreach statement, checked statement, if statement, lock statement, switch statement, try statement, unchecked statement, unsafe statement, using statement, while statement
* **Scope**: opening or closing brace

![Comment out statement](../../images/refactorings/CommentOutStatement.png)

#### Copy documentation comment from base member (RR0029)

* **Syntax**: constructor, method, property, indexer, event

![Copy documentation comment from base member](../../images/refactorings/CopyDocumentationCommentFromBaseMember.png)

![Copy documentation comment from base member](../../images/refactorings/CopyDocumentationCommentFromImplementedMember.png)

#### Duplicate argument (RR0030)

* **Syntax**: missing argument

![Duplicate argument](../../images/refactorings/DuplicateArgument.png)

#### Duplicate member (RR0031)

* **Syntax**: method, constructor, property, indexer, operator, event, namespace, class, struct, interface
* **Scope**: opening or closing brace

![Duplicate member](../../images/refactorings/DuplicateMember.png)

#### Duplicate parameter (RR0032)

* **Syntax**: missing parameter

![Duplicate parameter](../../images/refactorings/DuplicateParameter.png)

#### Duplicate statement (RR0033)

* **Syntax**: do statement, fixed statement, for statement, foreach statement, checked statement, if statement, lock statement, switch statement, try statement, unchecked statement, unsafe statement, using statement, while statement
* **Scope**: opening or closing brace

![Duplicate statement](../../images/refactorings/DuplicateStatement.png)

#### Expand assignment expression (RR0034)

* **Syntax**: assignment expression
* **Scope**: operator

![Expand assignment expression](../../images/refactorings/ExpandAssignmentExpression.png)

#### Expand coalesce expression (RR0035)

* **Syntax**: coalesce expression
* **Scope**: ?? operator

![Expand coalesce expression](../../images/refactorings/ExpandCoalesceExpression.png)

#### Expand event (RR0036)

* **Syntax**: event field declaration

![Expand event](../../images/refactorings/ExpandEvent.png)

#### Expand expression body (RR0037)

* **Syntax**: expression body

![Expand expression body](../../images/refactorings/ExpandExpressionBody.png)

#### Expand initializer (RR0038)

* **Syntax**: initializer

![Expand initializer](../../images/refactorings/ExpandInitializer.png)

#### Expand lambda expression body (RR0039)

* **Syntax**: lambda expression
* **Scope**: body

![Expand lambda expression body](../../images/refactorings/ExpandLambdaExpressionBody.png)

#### Expand property (RR0040)

* **Syntax**: auto\-property

![Expand property](../../images/refactorings/ExpandProperty.png)

#### Expand property and add backing field (RR0041)

* **Syntax**: auto\-property

![Expand property and add backing field](../../images/refactorings/ExpandPropertyAndAddBackingField.png)

#### Extract expression from condition (RR0043)

* **Syntax**: if statement, while statement
* **Scope**: condition

![Extract expression from condition](../../images/refactorings/ExtractExpressionFromCondition.png)

#### Extract generic type (RR0044)

* **Syntax**: generic name with single type argument
* **Scope**: type argument

![Extract generic type](../../images/refactorings/ExtractGenericType.png)

#### Extract statement\(s\) (RR0045)

* **Syntax**: else clause, fixed statement, for statement, foreach statement, checked statement, if statement, lock statement, try statement, unsafe statement, using statement, while statement

![Extract statement\(s\)](../../images/refactorings/ExtractStatement.png)

#### Extract type declaration to a new file (RR0046)

* **Syntax**: class declaration, struct declaration, interface declaration, enum declaration, delegate declaration
* **Scope**: identifier

![Extract type declaration to a new file](../../images/refactorings/ExtractTypeDeclarationToNewFile.png)

#### Format accessor braces (RR0047)

* **Syntax**: get accessor, set accessor, add accessor, remove accessor
* **Scope**: block

![Format accessor braces](../../images/refactorings/FormatAccessorBracesOnMultipleLines.png)

![Format accessor braces](../../images/refactorings/FormatAccessorBracesOnSingleLine.png)

#### Format argument list (RR0048)

* **Syntax**: argument list

![Format argument list](../../images/refactorings/FormatEachArgumentOnSeparateLine.png)

![Format argument list](../../images/refactorings/FormatAllArgumentsOnSingleLine.png)

#### Format binary expression (RR0049)

* **Syntax**: logical and/or expression, bitwise and/or expression

![Format binary expression](../../images/refactorings/FormatBinaryExpression.png)

#### Format conditional expression (RR0050)

* **Syntax**: conditional expression

![Format conditional expression](../../images/refactorings/FormatConditionalExpressionOnMultipleLines.png)

![Format conditional expression](../../images/refactorings/FormatConditionalExpressionOnSingleLine.png)

#### Format constraint clauses (RR0187)

* **Syntax**: type parameter constraint clause

![Format constraint clauses](../../images/refactorings/FormatConstraintClauses.png)

#### Format expression chain (RR0051)

* **Syntax**: expression chain

![Format expression chain](../../images/refactorings/FormatExpressionChainOnMultipleLines.png)

![Format expression chain](../../images/refactorings/FormatExpressionChainOnSingleLine.png)

#### Format initializer (RR0052)

* **Syntax**: initializer

![Format initializer](../../images/refactorings/FormatInitializerOnMultipleLines.png)

![Format initializer](../../images/refactorings/FormatInitializerOnSingleLine.png)

#### Format parameter list (RR0053)

* **Syntax**: parameter list

![Format parameter list](../../images/refactorings/FormatEachParameterOnSeparateLine.png)

![Format parameter list](../../images/refactorings/FormatAllParametersOnSingleLine.png)

#### Generate base constructors (RR0054)

* **Syntax**: class declaration
* **Scope**: identifier

![Generate base constructors](../../images/refactorings/GenerateBaseConstructors.png)

#### Generate combined enum member (RR0055)

* **Syntax**: enum declaration \(with FlagsAttribute\)

![Generate combined enum member](../../images/refactorings/GenerateCombinedEnumMember.png)

#### Generate enum member (RR0056)

* **Syntax**: enum declaration \(with FlagsAttribute\)

![Generate enum member](../../images/refactorings/GenerateEnumMember.png)

#### Generate enum values (RR0057)

* **Syntax**: enum declaration \(with FlagsAttribute\)

![Generate enum values](../../images/refactorings/GenerateEnumValues.png)

#### Generate event invoking method (RR0058)

* **Syntax**: event
* **Scope**: identifier

![Generate event invoking method](../../images/refactorings/GenerateEventInvokingMethod.png)

#### Generate switch sections (RR0059)

* **Syntax**: switch statement \(that is empty or contains only default section\)

![Generate switch sections](../../images/refactorings/GenerateSwitchSections.png)

#### Implement IEquatable\<T\> (RR0179)

* **Syntax**: class declaration, struct declaration, interface declaration
* **Scope**: base list

![Implement IEquatable\<T\>](../../images/refactorings/ImplementIEquatableOfT.png)

#### Initialize local with default value (RR0060)

* **Syntax**: local declaration without initializer
* **Scope**: identifier

![Initialize local with default value](../../images/refactorings/InitializeLocalWithDefaultValue.png)

#### Inline alias expression (RR0061)

* **Syntax**: using alias directive
* **Scope**: identifier

![Inline alias expression](../../images/refactorings/InlineAliasExpression.png)

#### Inline constant (RR0181)

* **Syntax**: constant declaration

![Inline constant](../../images/refactorings/InlineConstant.png)

#### Inline method (RR0062)

* **Syntax**: static/extension method invocation

![Inline method](../../images/refactorings/InlineMethod.png)

#### Inline using static (RR0180)

* **Syntax**: using static directive

![Inline using static](../../images/refactorings/InlineUsingStatic.png)

#### Insert string interpolation (RR0063)

* **Syntax**: string literal, interpolated string

![Insert string interpolation](../../images/refactorings/InsertInterpolationIntoStringLiteral.png)

![Insert string interpolation](../../images/refactorings/InsertInterpolationIntoInterpolatedString.png)

#### Introduce and initialize field (RR0064)

* **Syntax**: constructor parameter

![Introduce and initialize field](../../images/refactorings/IntroduceAndInitializeField.png)

#### Introduce and initialize property (RR0065)

* **Syntax**: constructor parameter

![Introduce and initialize property](../../images/refactorings/IntroduceAndInitializeProperty.png)

#### Introduce constructor (RR0066)

* **Syntax**: field, property

![Introduce constructor](../../images/refactorings/IntroduceConstructor.png)

#### Introduce field to lock on (RR0067)

* **Syntax**: lock statement
* **Scope**: missing expression

![Introduce field to lock on](../../images/refactorings/IntroduceFieldToLockOn.png)

#### Introduce local variable (RR0068)

* **Syntax**: expression statement, expression in using statement

![Introduce local variable](../../images/refactorings/IntroduceLocalVariable.png)

#### Join string expressions (RR0078)

* **Syntax**: concatenated string expressions

![Join string expressions](../../images/refactorings/JoinStringExpressions.png)

![Join string expressions](../../images/refactorings/JoinStringLiterals.png)

![Join string expressions](../../images/refactorings/JoinStringLiteralsIntoMultilineStringLiteral.png)

#### Make member abstract (RR0069)

* **Syntax**: non\-abstract indexer/method/property in abstract class
* **Scope**: indexer/method/property header

![Make member abstract](../../images/refactorings/MakeMemberAbstract.png)

#### Make member virtual (RR0070)

* **Syntax**: method declaration, indexer declaration

![Make member virtual](../../images/refactorings/MakeMemberVirtual.png)

#### Merge assignment expression with return statement (RR0073)

* **Syntax**: assignment expression followed with return statement

![Merge assignment expression with return statement](../../images/refactorings/MergeAssignmentExpressionWithReturnStatement.png)

#### Merge attributes (RR0074)

* **Syntax**: selected attribute lists

![Merge attributes](../../images/refactorings/MergeAttributes.png)

#### Merge if statements (RR0075)

* **Syntax**: selected if statements

![Merge if statements](../../images/refactorings/MergeIfStatements.png)

#### Merge interpolation into interpolated string (RR0076)

* **Syntax**: interpolation

![Merge interpolation into interpolated string](../../images/refactorings/MergeInterpolationIntoInterpolatedString.png)

#### Merge local declarations (RR0077)

* **Syntax**: local declarations with same type

![Merge local declarations](../../images/refactorings/MergeLocalDeclarations.png)

#### Negate binary expression (RR0079)

* **Syntax**: logical and/or expression

![Negate binary expression](../../images/refactorings/NegateBinaryExpression.png)

#### Negate boolean literal (RR0080)

* **Syntax**: boolean literal

![Negate boolean literal](../../images/refactorings/NegateBooleanLiteral.png)

#### Negate is expression (RR0081)

* **Syntax**: is expression
* **Scope**: operator

![Negate is expression](../../images/refactorings/NegateIsExpression.png)

#### Negate operator (RR0082)

* **Syntax**: \!=, &&, ||, \<, \<=, ==, \>, \>=

![Negate operator](../../images/refactorings/NegateOperator.png)

#### Notify property changed (RR0083)

* **Syntax**: property in class/struct that implements INotifyPropertyChanged
* **Scope**: setter

![Notify property changed](../../images/refactorings/NotifyPropertyChanged.png)

#### Parenthesize expression (RR0084)

* **Syntax**: selected expression

![Parenthesize expression](../../images/refactorings/ParenthesizeExpression.png)

#### Promote local to parameter (RR0085)

* **Syntax**: local declaration in method

![Promote local to parameter](../../images/refactorings/PromoteLocalToParameter.png)

#### Reduce if nesting (RR0189)

* **Syntax**: if statement
* **Scope**: if keyword

![Reduce if nesting](../../images/refactorings/ReduceIfNesting.png)

#### Remove all comments (RR0086)

* **Syntax**: singleline/multiline comment, singleline/multiline documentation documentation comment

![Remove all comments](../../images/refactorings/RemoveAllComments.png)

#### Remove all comments \(except documentation comments\) (RR0087)

* **Syntax**: singleline/multiline comment

![Remove all comments \(except documentation comments\)](../../images/refactorings/RemoveAllCommentsExceptDocumentationComments.png)

#### Remove all documentation comments (RR0088)

* **Syntax**: singleline/multiline documentation comment

![Remove all documentation comments](../../images/refactorings/RemoveAllDocumentationComments.png)

#### Remove all member declarations (RR0089)

* **Syntax**: namespace, class, struct, interface
* **Scope**: opening or closing brace

![Remove all member declarations](../../images/refactorings/RemoveAllMemberDeclarations.png)

#### Remove all preprocessor directives (RR0090)

* **Syntax**: preprocessor directive

![Remove all preprocessor directives](../../images/refactorings/RemoveAllPreprocessorDirectives.png)

#### Remove all region directives (RR0091)

* **Syntax**: region directive

![Remove all region directives](../../images/refactorings/RemoveAllRegionDirectives.png)

#### Remove all statements (RR0092)

* **Syntax**: method, constructor, operator
* **Scope**: opening or closing brace

![Remove all statements](../../images/refactorings/RemoveAllStatements.png)

#### Remove all switch sections (RR0093)

* **Syntax**: switch statement
* **Scope**: opening or closing brace

![Remove all switch sections](../../images/refactorings/RemoveAllSwitchSections.png)

#### Remove braces (RR0094)

* **Syntax**: do statement, else clause, fixed statement, for statement, foreach statement, if statement, lock statement, using statement, while statement
* **Scope**: block with a single statement

![Remove braces](../../images/refactorings/RemoveBraces.png)

#### Remove braces from if\-else (RR0095)

* **Syntax**: if\-else chain
* **Scope**: embedded statement

![Remove braces from if\-else](../../images/refactorings/RemoveBracesFromIfElse.png)

#### Remove braces from switch section (RR0096)

* **Syntax**: switch section
* **Scope**: block

![Remove braces from switch section](../../images/refactorings/RemoveBracesFromSwitchSection.png)

#### Remove braces from switch sections (RR0097)

* **Syntax**: switch statement
* **Scope**: switch keyword

![Remove braces from switch sections](../../images/refactorings/RemoveBracesFromSwitchSections.png)

#### Remove comment (RR0098)

* **Syntax**: singleline/multiline comment, singleline/multiline xml documentation comment

![Remove comment](../../images/refactorings/RemoveComment.png)

#### Remove condition from last else clause (RR0099)

* **Syntax**: else clause
* **Scope**: else keyword

![Remove condition from last else clause](../../images/refactorings/RemoveConditionFromLastElse.png)

#### Remove directive and related directives (RR0100)

* **Syntax**: preprocessor directive, region directive

![Remove directive and related directives](../../images/refactorings/RemoveDirectiveAndRelatedDirectives.png)

#### Remove empty lines (RR0101)

* **Syntax**: selected lines

![Remove empty lines](../../images/refactorings/RemoveEmptyLines.png)

#### Remove interpolation (RR0102)

* **Syntax**: string interpolation
* **Scope**: opening or closing brace

![Remove interpolation](../../images/refactorings/RemoveInterpolation.png)

#### Remove member (RR0103)

* **Syntax**: method, constructor, property, indexer, operator, event, namespace, class, struct, interface
* **Scope**: opening or closing brace

![Remove member](../../images/refactorings/RemoveMember.png)

#### Remove member declarations above/below (RR0104)

* **Syntax**: empty line between member declarations

![Remove member declarations above/below](../../images/refactorings/RemoveMemberDeclarations.png)

#### Remove parameter name from argument (RR0105)

* **Syntax**: selected argument\(s\)

![Remove parameter name from argument](../../images/refactorings/RemoveParameterNameFromArgument.png)

#### Remove parentheses (RR0106)

* **Syntax**: parenthesized expression
* **Scope**: opening or closing parenthesis

![Remove parentheses](../../images/refactorings/RemoveParentheses.png)

#### Remove property initializer (RR0107)

* **Syntax**: property initializer

![Remove property initializer](../../images/refactorings/RemovePropertyInitializer.png)

#### Remove region (RR0108)

* **Syntax**: region directive

![Remove region](../../images/refactorings/RemoveRegion.png)

#### Remove statement (RR0109)

* **Syntax**: do statement, fixed statement, for statement, foreach statement, checked statement, if statement, lock statement, switch statement, try statement, unchecked statement, unsafe statement, using statement, while statement
* **Scope**: open/close brace

![Remove statement](../../images/refactorings/RemoveStatement.png)

#### Remove statements from switch sections (RR0110)

* **Syntax**: selected switch sections

![Remove statements from switch sections](../../images/refactorings/RemoveStatementsFromSwitchSections.png)

#### Rename backing field according to property name (RR0111)

* **Syntax**: field identifier inside property declaration

![Rename backing field according to property name](../../images/refactorings/RenameBackingFieldAccordingToPropertyName.png)

#### Rename identifier according to type name (RR0112)

* **Syntax**: foreach statement, local/field/constant declaration
* **Scope**: identifier

![Rename identifier according to type name](../../images/refactorings/RenameForEachIdentifierAccordingToTypeName.png)

![Rename identifier according to type name](../../images/refactorings/RenameFieldIdentifierAccordingToTypeName.png)

#### Rename method according to type name (RR0113)

* **Syntax**: method

![Rename method according to type name](../../images/refactorings/RenameMethodAccordingToTypeName.png)

#### Rename parameter according to its type name (RR0114)

* **Syntax**: parameter
* **Scope**: parameter identifier

![Rename parameter according to its type name](../../images/refactorings/RenameParameterAccordingToTypeName.png)

#### Rename property according to type name (RR0115)

* **Syntax**: property identifier

![Rename property according to type name](../../images/refactorings/RenamePropertyAccordingToTypeName.png)

#### Replace \(yield\) return statement with if\-else (RR0143)

* **Syntax**: return statement, yield return statement
* **Scope**: selected statement, yield keyword or return keyword

![Replace \(yield\) return statement with if\-else](../../images/refactorings/ReplaceReturnStatementWithIfElse.png)

#### Replace Any with All \(or All with Any\) (RR0116)

* **Syntax**: Any\(Func\<T, bool\> or All\(Func\<T, bool\> from System\.Linq\.Enumerable namespace
* **Scope**: method name

![Replace Any with All \(or All with Any\)](../../images/refactorings/ReplaceAnyWithAllOrAllWithAny.png)

#### Replace as expression with cast expression (RR0117)

* **Syntax**: as expression

![Replace as expression with cast expression](../../images/refactorings/ReplaceAsWithCast.png)

#### Replace cast expression with as expression (RR0118)

* **Syntax**: cast expression

![Replace cast expression with as expression](../../images/refactorings/ReplaceCastWithAs.png)

#### Replace conditional expression with expression (RR0119)

* **Syntax**: conditional expression
* **Scope**: selected true/false expression

![Replace conditional expression with expression](../../images/refactorings/ReplaceConditionalExpressionWithExpression.png)

#### Replace constant with field (RR0121)

* **Syntax**: constant declaration

![Replace constant with field](../../images/refactorings/ReplaceConstantWithField.png)

#### Replace do statement with while statement (RR0123)

* **Syntax**: do statement
* **Scope**: do keyword

![Replace do statement with while statement](../../images/refactorings/ReplaceDoStatementWithWhileStatement.png)

#### Replace equals expression with string\.Equals (RR0124)

* **Syntax**: equals expression, not equals expression
* **Scope**: operator

![Replace equals expression with string\.Equals](../../images/refactorings/ReplaceEqualsExpressionWithStringEquals.png)

#### Replace equals expression with string\.IsNullOrEmpty (RR0125)

* **Syntax**: equals expression, not equals expression
* **Scope**: operator

![Replace equals expression with string\.IsNullOrEmpty](../../images/refactorings/ReplaceEqualsExpressionWithStringIsNullOrEmpty.png)

#### Replace equals expression with string\.IsNullOrWhiteSpace (RR0126)

* **Syntax**: equals expression, not equals expression
* **Scope**: operator

![Replace equals expression with string\.IsNullOrWhiteSpace](../../images/refactorings/ReplaceEqualsExpressionWithStringIsNullOrWhiteSpace.png)

#### Replace expression with constant value (RR0127)

* **Syntax**: expression that has constant value

![Replace expression with constant value](../../images/refactorings/ReplaceExpressionWithConstantValue.png)

#### Replace for statement with foreach statement (RR0130)

* **Syntax**: for statement

![Replace for statement with foreach statement](../../images/refactorings/ReplaceForWithForEach.png)

#### Replace for statement with while statement (RR0131)

* **Syntax**: for statement

![Replace for statement with while statement](../../images/refactorings/ReplaceForWithWhile.png)

#### Replace foreach statement with for statement (RR0129)

* **Syntax**: foreach statement

![Replace foreach statement with for statement](../../images/refactorings/ReplaceForEachWithFor.png)

#### Replace foreach with for and reverse loop (RR0188)

* **Syntax**: foreach statement

![Replace foreach with for and reverse loop](../../images/refactorings/ReplaceForEachWithForAndReverseLoop.png)

#### Replace hexadecimal literal with decimal literal (RR0132)

* **Syntax**: hexadecimal literal

![Replace hexadecimal literal with decimal literal](../../images/refactorings/ReplaceHexadecimalLiteralWithDecimalLiteral.png)

#### Replace if\-else with switch statement (RR0133)

* **Syntax**: if statement
* **Scope**: top if keyword or selected if statement

![Replace if\-else with switch statement](../../images/refactorings/ReplaceIfElseWithSwitch.png)

#### Replace increment operator with decrement operator (RR0134)

* **Syntax**: prefix/postfix unary expression

![Replace increment operator with decrement operator](../../images/refactorings/ReplaceIncrementOperatorWithDecrementOperator.png)

#### Replace interpolated string with interpolation expression (RR0135)

* **Syntax**: interpolated string with single interpolation and no text
* **Scope**: interpolation

![Replace interpolated string with interpolation expression](../../images/refactorings/ReplaceInterpolatedStringWithInterpolationExpression.png)

#### Replace interpolated string with string literal (RR0136)

* **Syntax**: Interpolated string without any interpolation

![Replace interpolated string with string literal](../../images/refactorings/ReplaceInterpolatedStringWithStringLiteral.png)

#### Replace method group with lambda (RR0137)

* **Syntax**: method group

![Replace method group with lambda](../../images/refactorings/ReplaceMethodGroupWithLambda.png)

#### Replace method with property (RR0138)

* **Syntax**: method
* **Scope**: method header

![Replace method with property](../../images/refactorings/ReplaceMethodWithProperty.png)

#### Replace null literal expression with default expression (RR0139)

* **Syntax**: argument

![Replace null literal expression with default expression](../../images/refactorings/ReplaceNullLiteralExpressionWithDefaultExpression.png)

#### Replace object creation with default value (RR0185)

* **Syntax**: object creation expression

![Replace object creation with default value](../../images/refactorings/ReplaceObjectCreationWithDefaultValue.png)

#### Replace prefix operator to postfix operator (RR0140)

* **Syntax**: prefix/postfix unary expression

![Replace prefix operator to postfix operator](../../images/refactorings/ReplacePrefixOperatorWithPostfixOperator.png)

#### Replace property with method (RR0141)

* **Syntax**: read\-only property
* **Scope**: property header

![Replace property with method](../../images/refactorings/ReplacePropertyWithMethod.png)

#### Replace regular string literal with verbatim string literal (RR0142)

* **Syntax**: regular string literal

![Replace regular string literal with verbatim string literal](../../images/refactorings/ReplaceRegularStringLiteralWithVerbatimStringLiteral.png)

#### Replace string\.Contains with string\.IndexOf (RR0144)

* **Syntax**: method invocation
* **Scope**: method name

![Replace string\.Contains with string\.IndexOf](../../images/refactorings/ReplaceStringContainsWithStringIndexOf.png)

#### Replace string\.Format with interpolated string (RR0145)

* **Syntax**: string\.Format method

![Replace string\.Format with interpolated string](../../images/refactorings/ReplaceStringFormatWithInterpolatedString.png)

#### Replace switch statement with if\-else (RR0147)

* **Syntax**: switch statement
* **Scope**: switch keyword

![Replace switch statement with if\-else](../../images/refactorings/ReplaceSwitchWithIfElse.png)

#### Replace verbatim string literal with regular string literal (RR0148)

* **Syntax**: verbatim string literal

![Replace verbatim string literal with regular string literal](../../images/refactorings/ReplaceVerbatimStringLiteralWithRegularStringLiteral.png)

#### Replace verbatim string literal with regular string literals (RR0149)

* **Syntax**: multiline verbatim string literal

![Replace verbatim string literal with regular string literals](../../images/refactorings/ReplaceVerbatimStringLiteralWithRegularStringLiterals.png)

#### Replace while statement with do statement (RR0150)

* **Syntax**: while statement
* **Scope**: while keyword

![Replace while statement with do statement](../../images/refactorings/ReplaceWhileStatementWithDoStatement.png)

#### Replace while statement with for statement (RR0151)

* **Syntax**: while statement

![Replace while statement with for statement](../../images/refactorings/ReplaceWhileWithFor.png)

#### Reverse for loop (RR0152)

* **Syntax**: for statement

![Reverse for loop](../../images/refactorings/ReverseForLoop.png)

#### Simplify if (RR0153)

* **Syntax**: if statement
* **Scope**: top if keyword or selected if statement

![Simplify if](../../images/refactorings/SimplifyIf.png)

#### Simplify lambda expression (RR0154)

* **Syntax**: lambda expression with block with single single\-line statement
* **Scope**: body

![Simplify lambda expression](../../images/refactorings/SimplifyLambdaExpression.png)

#### Sort member declarations (RR0155)

* **Syntax**: namespace declarations, class declarations, struct declarations, interface declarations, enum declarations
* **Scope**: selected member declarations

![Sort member declarations](../../images/refactorings/SortMembersByKind.png)

![Sort member declarations](../../images/refactorings/SortMembersByName.png)

![Sort member declarations](../../images/refactorings/SortEnumMembersByName.png)

![Sort member declarations](../../images/refactorings/SortEnumMembersByValue.png)

#### Split attributes (RR0156)

* **Syntax**: selected attribute list

![Split attributes](../../images/refactorings/SplitAttributes.png)

#### Split if statement (RR0184)

* **Syntax**: if statement that has logical or expression as a condition
* **Scope**: top if keyword or selected if statement

![Split if statement](../../images/refactorings/SplitIfStatement.png)

#### Split switch labels (RR0157)

* **Syntax**: selected switch labels

![Split switch labels](../../images/refactorings/SplitSwitchLabels.png)

#### Split variable declaration (RR0158)

* **Syntax**: local declaration, field declaration, event field declaration

![Split variable declaration](../../images/refactorings/SplitLocalDeclaration.png)

#### Swap expressions in binary expression (RR0159)

* **Syntax**: logical and/or expression
* **Scope**: binary operator

![Swap expressions in binary expression](../../images/refactorings/SwapExpressionsInBinaryExpression.png)

#### Swap expressions in conditional expression (RR0160)

* **Syntax**: conditional expression
* **Scope**: condition

![Swap expressions in conditional expression](../../images/refactorings/SwapExpressionsInConditionalExpression.png)

#### Swap member declarations (RR0161)

* **Syntax**: empty line between member declarations

![Swap member declarations](../../images/refactorings/SwapMemberDeclarations.png)

#### Swap statements in if\-else (RR0162)

* **Syntax**: if statement
* **Scope**: top if keyword or selected if statement

![Swap statements in if\-else](../../images/refactorings/SwapStatementsInIfElse.png)

#### Uncomment (RR0163)

* **Syntax**: single\-line comment\(s\)

![Uncomment](../../images/refactorings/Uncomment.png)

#### Use "" instead of string\.Empty (RR0168)

* **Syntax**: string\.Empty field

![Use "" instead of string\.Empty](../../images/refactorings/UseEmptyStringLiteralInsteadOfStringEmpty.png)

#### Use bitwise operation instead of calling 'HasFlag' (RR0164)

* **Syntax**: Enum\.HasFlag method invocation

![Use bitwise operation instead of calling 'HasFlag'](../../images/refactorings/UseBitwiseOperationInsteadOfCallingHasFlag.png)

#### Use coalesce expression instead of if (RR0165)

* **Syntax**: if statement
* **Scope**: top if keyword or selected if statement

![Use coalesce expression instead of if](../../images/refactorings/UseCoalesceExpressionInsteadOfIf.png)

#### Use conditional expression instead of if (RR0166)

* **Syntax**: if statement
* **Scope**: top if keyword or selected if statement

![Use conditional expression instead of if](../../images/refactorings/UseConditionalExpressionInsteadOfIf.png)

#### Use constant instead of field (RR0128)

* **Syntax**: read\-only field

![Use constant instead of field](../../images/refactorings/UseConstantInsteadOfField.png)

#### Use element access instead of 'First/Last'ElementAt' method (RR0167)

* **Syntax**: First/Last/ElementAt method invocation
* **Scope**: method name

![Use element access instead of 'First/Last'ElementAt' method](../../images/refactorings/UseElementAccessInsteadOfEnumerableMethod.png)

#### Use expression\-bodied member (RR0169)

* **Syntax**: method, property, indexer, operator
* **Scope**: body or accessor list

![Use expression\-bodied member](../../images/refactorings/UseExpressionBodiedMember.png)

#### Use if\-else instead of conditional expression (RR0120)

* **Syntax**: local declaration statement with conditional expression, assignment with conditional expression, return statement conditional expression, yield statement conditional expression

![Use if\-else instead of conditional expression](../../images/refactorings/UseIfElseInsteadOfConditionalExpression.png)

#### Use lambda expression instead of anonymous method (RR0170)

* **Syntax**: anonymous method
* **Scope**: delegate keyword

![Use lambda expression instead of anonymous method](../../images/refactorings/UseLambdaExpressionInsteadOfAnonymousMethod.png)

#### Use List\<T\> instead of yield (RR0183)

* **Syntax**: yield return, yield break

![Use List\<T\> instead of yield](../../images/refactorings/UseListInsteadOfYield.png)

#### Use string\.Empty instead of "" (RR0171)

* **Syntax**: empty string literal

![Use string\.Empty instead of ""](../../images/refactorings/UseStringEmptyInsteadOfEmptyStringLiteral.png)

#### Use StringBuilder instead of concatenation (RR0182)

* **Syntax**: string concatenation

![Use StringBuilder instead of concatenation](../../images/refactorings/UseStringBuilderInsteadOfConcatenation.png)

#### Wrap in \#if directive (RR0174)

* **Syntax**: selected lines

![Wrap in \#if directive](../../images/refactorings/WrapInIfDirective.png)

#### Wrap in condition (RR0172)

* **Syntax**: selected statements

![Wrap in condition](../../images/refactorings/WrapInCondition.png)

#### Wrap in else clause (RR0173)

* **Syntax**: statement

![Wrap in else clause](../../images/refactorings/WrapInElseClause.png)

#### Wrap in region (RR0175)

* **Syntax**: selected lines

![Wrap in region](../../images/refactorings/WrapInRegion.png)

#### Wrap in try\-catch (RR0176)

* **Syntax**: selected statements

![Wrap in try\-catch](../../images/refactorings/WrapInTryCatch.png)

#### Wrap in using statement (RR0177)

* **Syntax**: local declaration of type that implements IDisposable

![Wrap in using statement](../../images/refactorings/WrapInUsingStatement.png)
