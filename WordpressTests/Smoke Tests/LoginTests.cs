using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordpressAutomation;


namespace WordpressTests
{
    [TestClass]
    public class LoginTests : WordpressTest // inheret WordpressTest (Setup and Cleanup)
    {
        
        [TestMethod]
        public void AdminUserCanLogin()
        {
            Assert.IsTrue(DashboardPage.IsAt, "Failed to Log in.");
        }

    }
}
