using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Onlineshoeportal.Global
{
    public class CommonTestDataCollections
    {
        public static IWebDriver Driver { get; set; }
        public static IWebElement GetElementIfPresent(By locator)
        {

            
            try
            {
                Driver = Onlineshoeportal.GenericUtilities.DriverSetUp.Driver;
                return Driver.FindElement(locator);
            }
            catch(Exception e)
            {
                return null;
            }
        }
    }
}
