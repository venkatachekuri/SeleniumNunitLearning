using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using System.Diagnostics;

namespace SeleniumNunit
{
    [TestFixture]
     class SeleniumNunit : SiteModel
    {
        // private IWebDriver driver;
        private static string testUrl;
        private WebDriverWait wait;

        static void Main(string[] args)
        {
            //start new test
            SeleniumNunit program = new SeleniumNunit();
            //set up test
            program.SetUp();
            //register new user
            program.RegisterNewUser();
            //end test
            program.TearDown();
            //validate user in DB
            //var temp = program.VerifyUserInDatabase("newuser");
            //Assert.AreEqual("newuser", temp);
        }

        [SetUp]
        public void SetUp()
        {
            try
            {
                //testUrl = "http://demo.mahara.org/register.php";

                testUrl = "https://www.freecharge.in";

                //driver = new ChromeDriver("C:\\chromedriver_win32");
                driver = new FirefoxDriver();

                driver.Manage().Timeouts().SetPageLoadTimeout(TimeSpan.FromSeconds(120));
            }

            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);

            }


            //driver = new ChromeDriver("C:\\chromedriver_win32");
        }

        public void RegisterNewUser()
        {
            //navigate to the registration page
            driver.Navigate().GoToUrl(testUrl);


            //wait until find the first name text field
            //WaitForElementVisible(SiteElementsByInfo.GetFirstnameInputTextFieldByInfo(), 10);
            //////enter first name
            //SiteModel.GetElement(SiteElementsByInfo.GetFirstnameInputTextFieldByInfo()).SendKeys("new");
            // //wait until find last name text field
            // WaitForElementVisible(SiteElementsByInfo.GetLastnameInputTextFieldByInfo(), 60);
            // //end last name
            // SiteModel.GetElement(SiteElementsByInfo.GetLastnameInputTextFieldByInfo()).SendKeys("user");
            // //wait until find email text field
            // WaitForElementVisible(SiteElementsByInfo.GetEmailInputTextFieldByInfo(), 60);
            // //enter email address
            // SiteModel.GetElement(SiteElementsByInfo.GetEmailInputTextFieldByInfo()).SendKeys("newuser@newuser.com");
            // //wait until find institution select drop down menu displayed
            // WaitForElementVisible(SiteElementsByInfo.GetInstitutionSelectByInfo(), 60);
            // //select demo for the institution
            // var institutionSelect = new SelectElement(SiteModel.GetElement(SiteElementsByInfo.GetInstitutionSelectByInfo()));
            // institutionSelect.SelectByText("Demo");
            //wait until find the register button
            WaitForElementVisible(SiteElementsByInfo.GetRegisterButtonByInfo(), 60);
            //click on the register button
            SiteModel.GetElement(SiteElementsByInfo.GetRegisterButtonByInfo()).Click();


            //wait until find the first name text field
            WaitForElementVisible(SiteElementsByInfo.GetFirstnameInputTextFieldByInfo(), 10);
            ////enter first name
            SiteModel.GetElement(SiteElementsByInfo.GetFirstnameInputTextFieldByInfo()).SendKeys("ch.v.s.s.raju@gmail.com");

            WaitForElementVisible(SiteElementsByInfo.GetLastnameInputTextFieldByInfo(), 10);
            ////enter first name
            SiteModel.GetElement(SiteElementsByInfo.GetLastnameInputTextFieldByInfo()).SendKeys("freecharge");


            SiteModel.GetElement(SiteElementsByInfo.GetLoginButtonByInfo()).Click();

            //wait until find the confirmation message
            // WaitForElementVisible(SiteElementsByInfo.GetRegistrationConfirmationMessageByInfo(), 60);
            // var confirmationText = SiteModel.GetElement(SiteElementsByInfo.GetRegistrationConfirmationMessageByInfo()).Text;
            //Console.WriteLine(confirmationText);
            //assert confirmation message
            // Assert.AreEqual("You have successfully registered. Please check your email account for instructions on how to activate your account", confirmationText);
        }

        private void WaitForElementVisible(By by, int timeOutInSeconds)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            try
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeOutInSeconds));
                wait.Until(ExpectedConditions.ElementIsVisible(by));
            }
            catch (Exception)
            {
                Console.WriteLine("Time elapsed: {0}", stopwatch.Elapsed.Seconds);
            }
            finally
            {
                stopwatch.Stop();
            }
        }

        //[Test]
        //public void TestSeleniumMasterLoadingPage()
        //{
        //    driver.Navigate().GoToUrl("http://www.seleniummaster.com");
        //}

        [TearDown]
        public void TearDown()
        {
            driver.Quit();

            driver.Dispose();
        }
    }
}
