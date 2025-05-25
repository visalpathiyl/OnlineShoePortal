using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Onlineshoeportal.POM;
using Onlineshoeportal.POM_Methods;
using System.Threading.Tasks;
using Onlineshoeportal.GenericUtilities;

namespace Onlineshoeportal.ObjectInitialization
{
    public class ObjectInitializations
    {
        public static DriverSetUp driver_setup = new DriverSetUp();
        public static BrowserLaunch browser_launch = new BrowserLaunch();
        public static SignUp signup = new SignUp();
        public static LoginPage loginPage = new LoginPage();
        public static LogInMethod loginMethod = new LogInMethod();
        public static GenericUtilitiesClass generic_methods = new GenericUtilitiesClass();
    }
}
