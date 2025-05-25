using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V135.HeapProfiler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Onlineshoeportal.Global.CommonTestDataCollections;

namespace Onlineshoeportal.POM
{
    public class SignUp
    {
        public IWebElement hamberger => GetElementIfPresent(By.XPath("//div[@id='menuToggle']/input"));
        public IWebElement SignIn => GetElementIfPresent(By.XPath("//ul[@id='menu']/a[2]"));
        public IWebElement Register_button => GetElementIfPresent(By.Id("NewRegistration"));
        public  IWebElement signin_UN => GetElementIfPresent(By.XPath("//form[@id='second_form']/div[1]/b/h4/label"));
        public  IWebElement signin_PD => GetElementIfPresent(By.XPath("//form[@id='second_form']/div[2]/h4/label"));

        public  IWebElement signin_LogIn => GetElementIfPresent(By.XPath("//form[@id='second_form']/input"));


    }
}
