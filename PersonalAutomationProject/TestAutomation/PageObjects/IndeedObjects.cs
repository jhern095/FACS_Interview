using System;
using OpenQA.Selenium;
using BrowserSetup;

namespace IndeedObjects
{
    /*
     * This is another method of selecting elements in Indeed. However, the IndeedElements simplifies the steps by adding in the
     * IElements into individual variables and making things more readable.
     */

    public class IndeedPageObjects : SetupBrowser
    {

        public readonly string loginButtonIndeedString = "//*[@class='gnav-header-yxxskk emf9s7v0']";
        
    }
}


