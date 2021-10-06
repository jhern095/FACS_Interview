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
using PersonalAutomationProject.TestAutomation.PageObjects;

namespace GoogleTests
{
    public class GoogleSearch : SetupBrowser
    {

        SetupBrowser setup = new SetupBrowser();

        //Need to debug setup function
        [SetUp]
        public void setupGoogleTests()
        {
            setup.navigateToGoogle();
        }

        [Test]
            public void googleSearch()
        {
            driver.FindElement(By.XPath(SearchBar)).Click();
            driver.FindElement(By.XPath(SearchBar)).SendKeys("gmail.com");
            driver.Wait(10000);
            driver.FindElement(By.XPath(SearchBar)).SendKeys(Keys.Enter);
        }
        [Test]
            public void gmailLoginPasswordExists()
        {
            driver.Navigate().GoToUrl("https://google.com");
            driver.FindElement(By.XPath(SearchBar)).Click();
            driver.FindElement(By.XPath(SearchBar)).SendKeys("gmail.com");
            driver.Wait(10000);
            driver.FindElement(By.XPath(SearchBar)).SendKeys(Keys.Enter);
            driver.Wait(10000);
            driver.FindElement(By.XPath(GmailAccountLoginSearchResult)).Click();
            driver.FindElement(By.XPath(EmailField)).Click();
            driver.FindElement(By.XPath(EmailField)).SendKeys("jeremycitestemail@gmail.com");
            driver.FindElement(By.XPath(EmailField)).SendKeys(Keys.Enter);
        }

        [TearDown]
        public void endGoogleTests()
        {
            setup.closeBrowser();
        }
    }
}
