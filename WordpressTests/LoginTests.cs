using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordpressAutomation;


namespace WordpressTests
{
    [TestClass]
    public class LoginTests
    {
        [TestInitialize]
        public void Init()
        {
            Driver.Initialize();
        }

        [TestMethod]
        public void AdminUserCanLogin()
        {
            LoginPage.GoTo();
            LoginPage.LoginAs("myklobe").WithPassword("T3stT3st").Login();
            
            Assert.IsTrue(DashboardPage.IsAt, "Failed to Log in.");
        }

        [TestCleanup]
        public void Cleanup()
        {
            Driver.Close();
        }
    }
}
