﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Onlineshoeportal.POM;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static Onlineshoeportal.GenericUtilities.GenericUtilitiesClass;
using static Onlineshoeportal.ObjectInitialization.ObjectInitializations;

namespace Onlineshoeportal.POM_Methods
{
    public class LogInMethod
    {

        public void SignIn_Page()
        {
            String title = generic_methods.validate_Title();
            Assert.AreEqual(title, "Ace Online Shoe Portal");
            signup.hamberger.Click();
            generic_methods.waitforanEleImplicitily();
            signup.SignIn.Click();
            Assert.IsTrue(signup.signin_UN.Displayed, "User Name is visible");
            Assert.IsTrue(signup.signin_PD.Displayed, "Password is visible");
            Assert.IsTrue(signup.signin_LogIn.Displayed, "Log in button is visible");
            Assert.IsTrue(signup.Register_button.Displayed, "Register button is visible");

        }

        public void Log_In(string login_un, string login_pass)
        {
            signup.hamberger.Click();
            generic_methods.waitforanEleImplicitily();
            signup.SignIn.Click();
            user_login_page.Login_UserName.SendKeys(login_un);
            user_login_page.Login_Password.SendKeys(login_pass);
            signup.signin_LogIn.Click();
        }

        public void Login_error()
        {
            signup.hamberger.Click();
            generic_methods.waitforanEleImplicitily();
            signup.SignIn.Click();
            signup.signin_LogIn.Click();
            string actual_error = user_login_page.login_error.Text;
            string expected_error = "Both Username and Password field are required";
            Assert.AreEqual(actual_error, expected_error);

        }
        public void validate_errormessage_Registerpage()
        {
            String errormsg = loginPage.Login_errormsg.Text;
            String Actual_errmsg = "This field is required";
            Assert.AreEqual(errormsg, Actual_errmsg);
        }
        public void login_method(String FN, String LN, String email, String phone, String UN, String pass)
        {

            signup.Register_button.Click();
            SelectElement select = new SelectElement(loginPage.Salutation_dropdown);
            select.SelectByText(ConfigurationManager.AppSettings["Salutation"]);
            loginPage.First_Name.SendKeys(FN);
            loginPage.Last_Name.SendKeys(LN);
            loginPage.email_id.SendKeys(email);
            loginPage.contact_number.SendKeys(phone);
            loginPage.User_Name.SendKeys(UN);
            loginPage.password.SendKeys(pass);
            loginPage.button.Click();
        }
    }
}
