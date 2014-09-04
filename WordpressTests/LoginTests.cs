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
            LoginPage.GoTo();
            LoginPage.LoginAs("myklobe").WithPassword("T3stT3st").Login();
            
            Assert.IsTrue(DashboardPage.IsAt, "Failed to Log in.");
        }

    }
}
