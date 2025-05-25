using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onlineshoeportal.GenericUtilities
{
    public class DriverSetUp : TestMethodAttribute
    {
        public static IWebDriver Driver { get; private set; }

        public override TestResult[] Execute(ITestMethod testMethod)
        {
            if (Driver == null)
            {
                var options = new ChromeOptions();
                options.AddArgument("--start-maximized");
                options.AddArgument("incognito");
                Driver = new ChromeDriver(options);

            }

            try
            {
                return base.Execute(testMethod);
            }
            finally
            {
                Driver.Close();
                Driver.Quit();
            }
        }


        public static void Quit()
        {
            Driver?.Quit();
            Driver = null;
        }
    }
}
