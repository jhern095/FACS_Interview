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


namespace BrowserSetup
{
    public class SetupBrowser
    {
        //Another method to instantiate the Driver.
        //ChromeDriver driver = new ChromeDriver("/Users/HernandezJeremy/Documents/Personals/PersonalAutomationProject/PersonalAutomationProject/Drivers/");

        IWebDriver driver;

        [SetUp]
        public void startBrowser()
        {
            driver = new ChromeDriver(@"/Users/HernandezJeremy/Documents/Personals/PersonalAutomationProject/PersonalAutomationProject/Drivers/");
            driver.Wait(10000);
            driver.Manage().Window.Maximize();
        }
        [Test]
        public void testSetup()
        {
            driver.Url = "http://google.com";
        }
        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
        }

        public void launchBrower()
        {
            ChromeOptions options = new ChromeOptions();
            
        }
    }
}