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
                driver = new ChromeDriver("/Users/HernandezJeremy/Documents/Personals/PersonalAutomationProject/packages/chromedriver");
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
