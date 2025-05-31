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
        public DriverSetUp driver_setup = new DriverSetUp();
        public static BrowserLaunch browser_launch = new BrowserLaunch();
        public static SignUp signup = new SignUp();
        public static User_Registration_Page loginPage = new User_Registration_Page();
        public static LogInMethod loginMethod = new LogInMethod();
        public static GenericUtilitiesClass generic_methods = new GenericUtilitiesClass();
        public static User_Login_Page user_login_page = new User_Login_Page();
    }
}
