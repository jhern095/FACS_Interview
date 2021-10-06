using System;
using OpenQA.Selenium;
using NUnit.Framework;

using BrowserSetup;
using PersonalAutomationProject.TestAutomation.PageObjects;
using IndeedObjects;

namespace IndeedElementsWorkspace
{
    public class IndeedElements : SetupBrowser
    {

        public IWebElement indeedLoginElement()
        {
            return driver.FindElement(By.XPath("//*[@class='gnav-header-yxxskk emf9s7v0']"));
        }


    }


}
