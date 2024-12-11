using System;
using NUnit.Framework;

namespace ArrowEye_ClientPortal_Automation.Tests.Regression
{
    [TestFixture]
    class EVM : TestBase
    {
        [Test]
        [Description("Simple test")]
        [Category("Smoke")]
        [TestCase("Testing Certified", 123, "Certified", "Testing Issuer")]
        [TestCase("Testing CNS", 123, "CNS", "Testing Issuer")]
        [TestCase("Testing EasyPath", 123, "EasyPath", "Testing Issuer")]
        [TestCase("Testing PE", 123, "PE", "Testing Issuer")]

        public void SampleBasicTest(string name, int cpv, string appPath, string notes)
        {
            CP_Pages.Login.LogIn("deeptikulkarni", "Deepti@12345");
            CP_Pages.Home.ValidateHomePageTitle();
            CP_Pages.Home.NavigateToIssuers();
            CP_Pages.IssuersPage.AddNewIssuer(name, cpv, appPath, notes);
        }


    }
}
