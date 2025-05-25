using Microsoft.VisualStudio.TestTools.UnitTesting;
using Onlineshoeportal.GenericUtilities;
using Onlineshoeportal.POM_Methods;
using System;
using System.Configuration;
using static Onlineshoeportal.ObjectInitialization.ObjectInitializations;

namespace Onlineshoeportal
{
    [TestClass]
    public class TCID_01_UserRegistration 
    {
        [DriverSetUp]
        public void SignInPage_and_LoginPage()
        {
            browser_launch.NavigateToURL();
            loginMethod.SignIn_Page();
            loginMethod.login_method(ConfigurationManager.AppSettings["First_Name"], ConfigurationManager.AppSettings["Last_Name"], ConfigurationManager.AppSettings["Email_ID"], ConfigurationManager.AppSettings["Phone_Number"], ConfigurationManager.AppSettings["User_Name"], ConfigurationManager.AppSettings["Password"]);
        }
    }
}
