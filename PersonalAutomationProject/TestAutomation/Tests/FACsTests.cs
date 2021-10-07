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
using FACsLoginStepFunctions;
using System.Threading;

namespace FACsTests
{
    public class FACsTestCases : FACsLoginFunctions
    {
        SetupBrowser setup = new SetupBrowser();
        FACsLoginFunctions login = new FACsLoginFunctions();
        FACsLoginPageElements pageElement = new FACsLoginPageElements();
        LoginPageObjects pageObject = new LoginPageObjects();

        //Need to debug setup function
        /*
        [SetUp]
        public void setupFACsTests()
        {
            setup.navigateToFACS();
        }*/

        [Test]
            public void loginToFacsQa()
        {
            driver.Navigate().GoToUrl("https://apiqa.facsware.com/login");
            driver.Manage().Window.FullScreen();
            driver.Wait().ForElement(By.XPath("//*[@name='portal']")).ToExist();
            driver.FindElement(By.XPath("//*[@name='portal']")).Click();
            driver.FindElement(By.XPath("//*[@name='portal']")).SendKeys(QaPortal);
            driver.FindElement(By.XPath("//*[@id='email']")).Click();
            driver.FindElement(By.XPath("//*[@id='email']")).SendKeys(MyUsername);
            driver.FindElement(By.XPath("//*[@id='password']")).Click();
            driver.FindElement(By.XPath("//*[@id='password']")).SendKeys(MyPassword);
            driver.FindElement(By.XPath("//*[@type='submit']")).Click();
            bool assertLoggedIn = driver.FindElement(By.XPath("//*[@class='custom-select-opener']")).Displayed;
            Assert.That(assertLoggedIn);
            driver.Close();
        }

        [Test]
        public void loginToFacsQaInvalidCredentials()
        {
            driver.Navigate().GoToUrl("https://apiqa.facsware.com/login");
            driver.Manage().Window.FullScreen();
            driver.Wait().ForElement(By.XPath("//*[@name='portal']")).ToExist();
            driver.FindElement(By.XPath("//*[@name='portal']")).Click();
            driver.FindElement(By.XPath("//*[@name='portal']")).SendKeys(QaPortal);
            driver.FindElement(By.XPath("//*[@id='email']")).Click();
            driver.FindElement(By.XPath("//*[@id='email']")).SendKeys(InvalidUsername);
            driver.FindElement(By.XPath("//*[@id='password']")).Click();
            driver.FindElement(By.XPath("//*[@id='password']")).SendKeys(InvalidPassword);
            driver.FindElement(By.XPath("//*[@type='submit']")).Click();
            bool assertErrorInvalidLogin = driver.FindElement(By.XPath("//*[@class='help-block --red']")).Displayed;
            Assert.That(assertErrorInvalidLogin);
            driver.Close();
        }

        [Test]
        public void selectFacsProject()
        {
            driver.Navigate().GoToUrl("https://apiqa.facsware.com/login");
            driver.Manage().Window.FullScreen();
            driver.Wait().ForElement(By.XPath("//*[@name='portal']")).ToExist();
            driver.FindElement(By.XPath("//*[@name='portal']")).Click();
            driver.FindElement(By.XPath("//*[@name='portal']")).SendKeys(QaPortal);
            driver.FindElement(By.XPath("//*[@id='email']")).Click();
            driver.FindElement(By.XPath("//*[@id='email']")).SendKeys(MyUsername);
            driver.FindElement(By.XPath("//*[@id='password']")).Click();
            driver.FindElement(By.XPath("//*[@id='password']")).SendKeys(MyPassword);
            driver.FindElement(By.XPath("//*[@type='submit']")).Click();
            driver.Wait().ForElement(By.XPath("//*[@class='custom-select-opener']")).ToExist();
            driver.FindElement(By.XPath("//*[@class='custom-select-opener']")).Click();
            driver.Wait().ForElement(By.XPath("//*[@data-project-name='Test Project']")).ToExist();
            Thread.Sleep(10000);
            //Debug selecting item from list
            driver.FindElement(By.XPath("//*[@data-project-name='Test Project']")).Click();
            bool verifyUserCanSelectProject = driver.FindElement(By.XPath("//*[@data-project-name='Test Project']")).Displayed;
        }

        [Test]
        public void selectFacsBMPInspectionService()
        {
            driver.Navigate().GoToUrl("https://apiqa.facsware.com/login");
            driver.Manage().Window.FullScreen();
            driver.Wait().ForElement(By.XPath("//*[@name='portal']")).ToExist();
            driver.FindElement(By.XPath("//*[@name='portal']")).Click();
            driver.FindElement(By.XPath("//*[@name='portal']")).SendKeys(QaPortal);
            driver.FindElement(By.XPath("//*[@id='email']")).Click();
            driver.FindElement(By.XPath("//*[@id='email']")).SendKeys(MyUsername);
            driver.FindElement(By.XPath("//*[@id='password']")).Click();
            driver.FindElement(By.XPath("//*[@id='password']")).SendKeys(MyPassword);
            driver.FindElement(By.XPath("//*[@type='submit']")).Click();
            driver.Wait().ForElement(By.XPath("//*[@data-name='Icon Service']")).ToExist();
            driver.FindElement(By.XPath("//*[@data-name='Icon Service']")).Click();
            driver.FindElement(By.XPath("//*[@href='/admin/BMPInspection']")).Click();
            string BMPHeader = driver.FindElement(By.XPath("//*[@class='Grid-heading-title']")).Text;
            Assert.AreEqual(BMPHeader, "BMP Inspection");
            driver.Close();
        }

        [Test]
        public void addEntry()
        {
            driver.Navigate().GoToUrl("https://apiqa.facsware.com/login");
            driver.Manage().Window.FullScreen();
            driver.Wait().ForElement(By.XPath("//*[@name='portal']")).ToExist();
            driver.FindElement(By.XPath("//*[@name='portal']")).Click();
            driver.FindElement(By.XPath("//*[@name='portal']")).SendKeys(QaPortal);
            driver.FindElement(By.XPath("//*[@id='email']")).Click();
            driver.FindElement(By.XPath("//*[@id='email']")).SendKeys(MyUsername);
            driver.FindElement(By.XPath("//*[@id='password']")).Click();
            driver.FindElement(By.XPath("//*[@id='password']")).SendKeys(MyPassword);
            driver.FindElement(By.XPath("//*[@type='submit']")).Click();
        }
            /*
            [TearDown]
            public void endFACsTests()
            {
                setup.closeBrowser();
            }*/
        }
}
