using System;
namespace PersonalAutomationProject.TestAutomation.PageObjects
{
    public class GooglePageObjects
    {
        //PageObjects searchBar = new PageObjects("//*[@class="gLFyf gsfi"]", "Search Bar");
        public readonly string SearchBar = "//*[@class='gLFyf gsfi']";
        public readonly string GmailAccountLoginSearchResult = "//*[@href='https://accounts.google.com/b/1/AddMailService']";
        public readonly string EmailField = "//*[@type='email']";
    }
}
