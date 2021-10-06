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
using Selenium.WebDriver.Extensions;
using Selenium.WebDriver.WaitExtensions.WaitTypeSelections;
using Selenium.WebDriver.WaitExtensions.WaitConditions;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework.Internal.Builders;
using NUnit.Framework;

using PersonalAutomationProject.TestAutomation.PageObjects;

namespace BrowserSetup
{
    public class SetupBrowser : GooglePageObjects
    {
        //Another method to instantiate the Driver.
        //ChromeDriver driver = new ChromeDriver("/Users/HernandezJeremy/Documents/Personals/PersonalAutomationProject/PersonalAutomationProject/Drivers/");

        public IWebDriver driver = new ChromeDriver();

        public IWebDriver startBrowserTest()
        {
            driver.Wait(10000);
            driver.Manage().Window.Maximize();
            return driver;
        }

        public IWebDriver navigateToGoogle()
        {
            driver.Url = "https://google.com";
            driver.Navigate().GoToUrl("https://google.com");
            driver.Wait(10000);
            driver.Manage().Window.Maximize();
            return driver;
        }

        public IWebDriver navigateToIndeed()
        {
            driver.Url = "https://indeed.com";
            driver.Navigate().GoToUrl("https://indeed.com");
            driver.Wait(10000);
            driver.Manage().Window.Maximize();
            return driver;
        }

        public void browserConfig()
        {
            ChromeOptions options = new ChromeOptions();
            
        }
        public void closeBrowser()
        {
            driver.Close();
        }
    }
}