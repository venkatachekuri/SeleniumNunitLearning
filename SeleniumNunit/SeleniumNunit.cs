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
    public class SeleniumNunit
    {
        private IWebDriver driver;
        string testUrl = string.Empty;


        [SetUp]
        public void SetUp()
        {
            try
            {
                testUrl = "http://demo.mahara.org/register.php";

                driver = new ChromeDriver("C:\\chromedriver_win32");

                driver.Manage().Timeouts().SetPageLoadTimeout(TimeSpan.FromSeconds(120));




            }

            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);

            }


            //driver = new ChromeDriver("C:\\chromedriver_win32");
        }

        //public void RegisterNewUser()
        //{
        //    driver.Navigate().GoToUrl(testUrl);
        //    WaitForElementVisible(GetFirstnameInputTextFieldByInfo(), 60);
            
        //}

        //public void WaitForElementVisible(By by, int timeOutInSeconds)
        //{
        //    Stopwatch stopwatch = new Stopwatch();
        //    stopwatch.Start();

        //    try
        //    {
        //        var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeOutInSeconds));
        //        wait.Until(ExpectedConditions.ElementIsVisible(by));
        //    }
        //    catch(Exception)
        //    {
        //        Console.WriteLine("Time elapsed {0}", stopwatch.Elapsed.Seconds);
        //    }
        //    finally
        //    {
        //        stopwatch.Stop();
        //    }
        //}

        //public static By GetFirstnameInputTextFieldByInfo()
        //{
        //    return By.XPath("//table/tbody/tr[contains(@id,'register')]//label[contains(text(),'First')]//following::input[1]");
        //}

        [Test]
        public void TestSeleniumMasterLoadingPage()
        {
            driver.Navigate().GoToUrl("http://www.seleniummaster.com");
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();

            driver.Dispose();
        }
    }
}
