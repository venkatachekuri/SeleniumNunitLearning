using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumNunit
{
    class SiteModel : SiteElementsByInfo
    {
        public static IWebElement GetElement(By by)
        {
            return driver.FindElement(by);
        }
    }
}
