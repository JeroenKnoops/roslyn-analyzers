﻿// © 2019 Koninklijke Philips N.V. See License.md in the project root for license information.

using System;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Philips.CodeAnalysis.Common;
using Philips.CodeAnalysis.MsTestAnalyzers;

namespace Philips.CodeAnalysis.Test
{
	[TestClass]
	public class TestClassPublicMethodShouldBeTestMethodTest : DiagnosticVerifier
	{
		[DataTestMethod]
		[DataRow(@"public", true)]
		[DataRow(@"private", false)]
		[DataRow(@"internal", false)]
		[DataRow(@"protected", false)]
		[DataRow(@"protected internal", false)]
		[DataRow(@"private protected", false)]
		public void MethodAccessModifierTest(string given, bool isError)
		{
			string baseline = @"
using Microsoft.VisualStudio.TestTools.UnitTesting;
[TestClass]
class Foo 
{{

  {0} void Foo()
  {{
  }}
}}
";

			VerifyError(baseline, given, isError);

		}

		[DataTestMethod]
		[DataRow(@"[TestClass]", true)]
		[DataRow(@"", false)]
		public void ClassTypeTest(string given, bool isError)
		{
			string baseline = @"
using Microsoft.VisualStudio.TestTools.UnitTesting;
{0}
class Foo 
{{

  public void Foo()
  {{
  }}
}}
";
			VerifyError(baseline, given, isError);
		}

		[DataTestMethod]
		[DataRow(@"[TestMethod]", false)]
		[DataRow(@"[DataTestMethod]", false)]
		[DataRow(@"[AssemblyInitialize()]", false)]
		[DataRow(@"[TestCleanup()]", false)]
		[DataRow(@"[ClassInitialize()]", false)]
		[DataRow(@"[TestInitialize()]", false)]
		[DataRow(@"[ClassCleanup()]", false)]
		[DataRow(@"[ClassInitialize()", false)]
		[DataRow(@"", true)]
		public void MethodTypeTest(string given, bool isError)
		{
			string baseline = @"
using Microsoft.VisualStudio.TestTools.UnitTesting;
[TestClass]
class Foo 
{{
  {0}
  public void Foo()
  {{
  }}
}}
";
			VerifyError(baseline, given, isError);

		}

		private void VerifyError(string baseline, string given, bool isError)
		{
			string givenText = string.Format(baseline, given);
			DiagnosticResult[] results;
			if (isError)
			{
				results = new[] { new DiagnosticResult()
					{
						Id = Helper.ToDiagnosticId(DiagnosticIds.TestClassPublicMethodShouldBeTestMethod),
						Message = new System.Text.RegularExpressions.Regex(TestClassPublicMethodShouldBeTestMethodAnalyzer.MessageFormat),
						Severity = DiagnosticSeverity.Error,
						Locations = new[]
						{
							new DiagnosticResultLocation("Test0.cs", 7, 3)
						}
					}
				};
			}
			else
			{
				results = Array.Empty<DiagnosticResult>();
			}
			VerifyCSharpDiagnostic(givenText, results);
		}

		protected override DiagnosticAnalyzer GetCSharpDiagnosticAnalyzer()
		{
			return new TestClassPublicMethodShouldBeTestMethodAnalyzer();
		}
	}
}
