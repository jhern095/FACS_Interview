using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalAutomationProject.TestAutomation
{
    public class NUnit
    {
            IWebDriver driver;

            [SetUp]
            public void startBrowser()
            {
            //If you want to hard-code the path, set it here. Otherwise, we set the path to chromedriver on the local machine.
            //driver = new ChromeDriver("/Users/HernandezJeremy/Documents/Personals/PersonalAutomationProject/packages/chromedriver");
            driver = new ChromeDriver();
            }

            [Test]
            public void test()
            {
                driver.Url = "http://www.google.co.in";
            }

            [TearDown]
            public void closeBrowser()
            {
                driver.Close();
            }
    }
}
