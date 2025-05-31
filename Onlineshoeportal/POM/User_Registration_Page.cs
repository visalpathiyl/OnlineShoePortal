using OpenQA.Selenium;
using static Onlineshoeportal.Global.CommonTestDataCollections;
using Onlineshoeportal.GenericUtilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onlineshoeportal.POM
{
    
    public class User_Registration_Page
    {

        //Register Page

        public IWebElement Salutation_dropdown => GetElementIfPresent(By.Id("Salutation"));
        public IWebElement First_Name => GetElementIfPresent(By.Id("firstname"));
        public IWebElement Last_Name => GetElementIfPresent(By.Id("lastname"));

        public IWebElement email_id => GetElementIfPresent(By.Id("emailId"));

        public IWebElement contact_number => GetElementIfPresent(By.Id("contactNumber"));

        public IWebElement User_Name => GetElementIfPresent(By.Id("usr"));

        public IWebElement password => GetElementIfPresent(By.Id("pwd"));

        public IWebElement button => GetElementIfPresent(By.XPath("//form[@id='first_form']/div/div[2]/center/input"));

        public IWebElement Login_errormsg => GetElementIfPresent(By.XPath("//form[@id='first_form']/div/span"));



    }
}
