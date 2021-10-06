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
using IndeedObjects;
using IndeedElementsWorkspace;

namespace GoogleTests
{
    public class IndeedTests : IndeedPageObjects
    {

        SetupBrowser setup = new SetupBrowser();
        IndeedElements elements = new IndeedElements();

        //Need to debug setup function
        /*[SetUp]
        public void setupIndeedTests()
        {
            setup.navigateToIndeed();
        }*/

        [Test]
        public void signInToIndeed()
        {
            driver.Navigate().GoToUrl("https://indeed.com");
            elements.indeedLoginElement().Click();
            
        }

        [TearDown]
        public void endIndeedTests()
        {
            setup.closeBrowser();
        }
    }
}
