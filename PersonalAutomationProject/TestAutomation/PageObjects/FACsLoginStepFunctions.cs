using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Selenium.WebDriver;
using Selenium.Helper;
using Selenium.Internal.SeleniumEmulation;
using SeleniumExtras.PageObjects;
using Selenium.WebDriver.WaitExtensions;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using NUnit.Framework.Internal.Builders;
using NUnit.Framework;

using BrowserSetup;

namespace FACsLoginStepFunctions
{
    public class FACsLoginFunctions : SetupBrowser
    {
        public IWebElement facsWaitForPageToLoad()
         {
            return driver.Wait().ForElement(By.XPath("//*[@name='portal']")).ToExist();
        }
     }

    public class FACsLoginPageElements : SetupBrowser
    {
        public IWebElement facsLoginPortalInputField()
        {
            return driver.FindElement(By.XPath("//*[@name='portal']"));
        }
        public IWebElement facsLoginEmailInputField()
        {
            return driver.FindElement(By.XPath("//*[@id='email']"));
        }
        public IWebElement facsLoginPasswordInputField()
        {
            return driver.FindElement(By.XPath("//*[@id='password']"));
        }

    }
}
