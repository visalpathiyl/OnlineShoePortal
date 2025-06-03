using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Onlineshoeportal.GenericUtilities;
using static Onlineshoeportal.GenericUtilities.DriverSetUp;
using static Onlineshoeportal.ObjectInitialization.ObjectInitializations;

namespace Onlineshoeportal.Tests
{
    [TestClass]
    public class TCID_03_LogIn_Error
    {
        [DriverSetUp]
        public void Login_error()
        {
            browser_launch.NavigateToURL();
            loginMethod.Login_error();
        }
    }
}
