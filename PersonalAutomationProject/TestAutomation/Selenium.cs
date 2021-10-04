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
using BrowserSetup;

namespace Selenium
{
    public class GettingStarted
    {
        public static void Main(string[] args)
        {
            SetupBrowser setup = new SetupBrowser();

            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://google.com");
            driver.Close();
        }
    }
} 
