﻿// © 2019 Koninklijke Philips N.V. See License.md in the project root for license information.

namespace Philips.CodeAnalysis.Common
{

	internal enum DiagnosticIds
	{
		TestMethodName = 2000,
		EmptyXmlComments = 2001,
		AssertAreEqual = 2003,
		ExpectedExceptionAttribute = 2004,
		TestContext = 2005,
		NamespaceMatchAssembly = 2006,
		AssertAreEqualTypesMatch = 2008,
		AssertIsEqual = 2009,
		AssertIsTrueParenthesis = 2010,
		AvoidDescriptionAttribute = 2011,
		TestHasTimeoutAttribute = 2012,
		AvoidIgnoreAttribute = 2013,
		AvoidOwnerAttribute = 2014,
		AvoidTestInitializeMethod = 2016,
		AvoidClassInitializeMethod = 2017,
		AvoidClassCleanupMethod = 2018,
		AvoidTestCleanupMethod = 2019,
		AvoidThreadSleep = 2020,
		AvoidInlineNew = 2021,
		AvoidSuppressMessage = 2026,
		AvoidStaticMethods = 2027,
		AvoidPragma = 2029,
		RemoveEmptyConstructors = 2032,
		DataTestMethodsHaveDataRows = 2033,
		TestMethodsMustBeInTestClass = 2034,
		TestMethodsMustHaveTheCorrectNumberOfArguments = 2035,
		TestMethodsMustBePublic = 2036,
		TestMethodsMustHaveUniqueNames = 2037,
		TestClassesMustBePublic = 2038,
		ServiceContractsMustHaveOperationContractAttributes = 2040,
		AvoidMsFakes = 2041,
		InitializeComponentMustBeCalledOnce = 2042,
		DynamicKeywordProhibited = 2044,
		AvoidPublicMemberVariables = 2047,
		MockArgumentsMustMatchConstructor = 2048,
		TestMethodsMustNotBeEmpty = 2050,
		PreventUncessaryRangeChecks = 2051,
		MockRaiseArgumentsMustMatchEvent = 2053,
		MockRaiseArgumentCountMismatch = 2054,
		AssertIsTrueLiteral = 2055,
		AssertAreEqualLiteral = 2056,
		AvoidNonConstStrings = 2057,
		AvoidAssertConditionalAccess = 2058,
		TestClassPublicMethodShouldBeTestMethod = 2059,
		EnforceBoolNamingConvention = 2060,
		EnforceNonDuplicateRegion = 2064,
		LocksShouldBeReadonly = 2066,
		NoNestedStringFormats = 2067,
		GotoNotAllowed = 2068,
		NoUnnecessaryStringFormats = 2069,
		NoProtectedFields = 2070,
	}
}