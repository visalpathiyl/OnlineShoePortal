using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Onlineshoeportal.GenericUtilities.DriverSetUp;

namespace Onlineshoeportal.GenericUtilities
{
    public class GenericUtilitiesClass
    {
        public void  waitforanEleImplicitily()
        {
            DriverSetUp.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }

        public string validate_Title()
        {
            String pageTitle = DriverSetUp.Driver.Title;
            return pageTitle;
        }
    }
}
