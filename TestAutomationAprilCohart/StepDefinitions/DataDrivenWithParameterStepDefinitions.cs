using System;
using TechTalk.SpecFlow;
using TestAutomationAprilCohart.PageObject;

namespace TestAutomationAprilCohart.StepDefinitions
{
    [Binding]
    public class DataDrivenWithParameterStepDefinations
    { 
        DataDrivenWithParameterPage dataDrivenWithParameterpage;

        public DataDrivenWithParameterStepDefinations()
        {
            dataDrivenWithParameterpage = new DataDrivenWithParameterPage();

        }
    




        [Given(@"I Navigate to ""([^""]*)""")]
        public void GivenINavigateTo(string url)
        {
            dataDrivenWithParameterpage.NavigateToWebsite(url); 
        }

        [Given(@"I enter My Username test ""([^""]*)""")]
        public void GivenIEnterMyUsernameTest(string username)
        {
            dataDrivenWithParameterpage.EnterUsername(username); 
        }

        [Given(@"I enter My Email text ""([^""]*)""")]
        public void GivenIEnterMyEmailText(string email)
        {
            dataDrivenWithParameterpage.EnterEmail(email);
        }

        [Given(@"I enter my Password text ""([^""]*)""")]
        public void GivenIEnterMyPasswordText(string password)
        {
            dataDrivenWithParameterpage.EnterPassword(password);
        }
    }
}
