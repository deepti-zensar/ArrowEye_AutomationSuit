using ArrowEye_ClientPortal_Automation.Common;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrowEye_ClientPortal_Automation
{
    [TestFixture]
    public class TestBase
    {
        [SetUp]
        public void TestSetup()
        {
            Browser.Initialize();
        }

        [TearDown]
        public void TestTearDown()
        {
            Browser.Close();
        }

    }
}
