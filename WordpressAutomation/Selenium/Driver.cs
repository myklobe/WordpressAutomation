using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;

namespace WordpressTests
{
    public class Driver
    {
        public static IWebDriver Instance { get; set; }

        public static string BaseAddress
        {
            get { return "http://www.myklobe.com/Test/"; }
        }

        public static void Initialize()
        {
            // For Chrome //
            Instance = new ChromeDriver(@"C:\Installs\Apps\seleniumdrivers");
            
            // For Firefox //
            // Instance = new FirefoxDriver();
            
            // For Internet Explorer
            // Instance = new InternetExplorerDriver(@"C:\Installs\Apps\seleniumdrivers");
            
            Instance.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(5));
        }

        public static void Close()
        {
            Instance.Close();
        }

        internal static void Wait(TimeSpan timeSpan)
        {
            throw new NotImplementedException();
        }
    }
}
