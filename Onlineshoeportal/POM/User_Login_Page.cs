using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using static Onlineshoeportal.Global.CommonTestDataCollections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onlineshoeportal.POM
{
    public class User_Login_Page
    {
        public IWebElement Login_UserName => GetElementIfPresent(By.XPath("//form[@id='second_form']/div[1]/input"));
        public IWebElement Login_Password => GetElementIfPresent(By.XPath("//form[@id='second_form']/div[2]/input"));

        public IWebElement login_error => GetElementIfPresent(By.XPath("//form[@id='second_form']/div[2]/span"));

        
    }
}
