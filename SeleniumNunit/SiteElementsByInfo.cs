using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumNunit
{
    class SiteElementsByInfo
    {
        protected static IWebDriver driver = null;

        public static By GetUsernameFieldByInfo()
        {
            return By.Id("login_login_username");
        }

        public static By GetRegisterLinkByInfo()
        {
            return By.LinkText("Register");
        }
        public static By GetFirstnameInputTextFieldByInfo()
        {
          return By.XPath("//input[@name='username']");
        }

        public static By GetLoginButtonByInfo()
        {
            return By.XPath("//button[contains(.,'Login')]");
        }
        public static By GetLastnameInputTextFieldByInfo()
        {
            return By.XPath("//input[@name='password']");
        }
        public static By GetEmailInputTextFieldByInfo()
        {
            return By.XPath("//table/tbody/tr[contains(@id,'register')]//label[contains(text(),'First')]//following::input[3]");
        }

        public static By GetInstitutionSelectByInfo()
        {
            return By.XPath("//select[contains(@id,'register')]");
        }

        public static By GetRegisterButtonByInfo()
        {

            return By.XPath("//a[@href='/desktop/login']");
        }
        public static By GetRegistrationConfirmationMessageByInfo()
        {
            return By.CssSelector("p");
        }


    }
}
