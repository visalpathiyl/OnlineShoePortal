using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Onlineshoeportal.GenericUtilities;
using static Onlineshoeportal.Global.CommonTestDataCollections;
using Onlineshoeportal.Global;
using Onlineshoeportal.POM;
using static Onlineshoeportal.ObjectInitialization.ObjectInitializations;
using System.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Onlineshoeportal.Tests
{
    [TestClass]
    public class TCID_02_LogIn
    {
        [DriverSetUp]
        public void User_Log_In()
        {
            browser_launch.NavigateToURL();
            loginMethod.Log_In(ConfigurationManager.AppSettings["Log_In_UserName"], ConfigurationManager.AppSettings["Log_In_passwor"]);
        }

    }
}
