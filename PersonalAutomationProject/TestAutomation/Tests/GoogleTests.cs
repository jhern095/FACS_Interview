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
//using Selenium.WebDriver.Extensions;
using Selenium.WebDriver.WaitExtensions.WaitTypeSelections;
using Selenium.WebDriver.WaitExtensions.WaitConditions;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework.Internal.Builders;
using NUnit.Framework;

using BrowserSetup;
using PersonalAutomationProject.TestAutomation.PageObjects;

namespace GoogleTests
{
    public class GettingStarted
    {
        public static void Main(string[] args)
        {
            SetupBrowser setup = new SetupBrowser();

            //IWebDriver driver = new ChromeDriver(@"/Users/HernandezJeremy/Documents/Personals/PersonalAutomationProject/PersonalAutomationProject/Drivers/chromedriver");
            IWebDriver driver = new ChromeDriver();
            setup.startBrowser();
            driver.Navigate().GoToUrl("http://google.com");
            driver.Wait(10000);
            driver.Manage().Window.Maximize();
            driver.Wait(10000);
            driver.FindElement(By.XPath("//*[@class='gLFyf gsfi']")).Click();
            driver.Wait(10000);
            driver.FindElement(By.XPath("//*[@class='gLFyf gsfi']")).SendKeys("gmail.com");

            driver.Close();
        }
    }
} 
