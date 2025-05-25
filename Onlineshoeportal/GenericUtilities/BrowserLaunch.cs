using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Onlineshoeportal.GenericUtilities;

namespace Onlineshoeportal.GenericUtilities
{
    public class BrowserLaunch
    {
         public void NavigateToURL()
        {
            DriverSetUp.Driver.Navigate().GoToUrl(ConfigurationManager.AppSettings["URL"]);
        }
    }
}
