using System;
namespace PersonalAutomationProject.TestAutomation.PageObjects
{
    public class InputData
    {
        public readonly string QaPortal = "qaqc";
        public readonly string MyUsername = "jeremyhernandez382@gmail.com";
        public readonly string MyPassword = "q4t3S7m$st3rFLe#";
        public readonly string InvalidUsername = "testusername@test.com";
        public readonly string InvalidPassword = "testpassword";
    }
    public class LoginPageObjects
    {
        public readonly string loginPortal = "//*[@name='portal']";
    }
}
