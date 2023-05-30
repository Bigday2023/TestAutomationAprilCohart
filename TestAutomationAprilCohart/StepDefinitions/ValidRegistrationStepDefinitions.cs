using NUnit.Framework;
using System;
using TechTalk.SpecFlow;
using TestAutomationAprilCohart.PageObject;

namespace TestAutomationAprilCohart.StepDefinitions
{
    [Binding]
    public class ValidRegistrationStepDefinitions
    {
        RegistrationPage registrationPage;

        public ValidRegistrationStepDefinitions() 
        {
            registrationPage = new RegistrationPage();
        }
        
        
        
        
        
        
        
        [Given(@"I Navigate to the Website")]
        public void GivenINavigateToTheWebsite()
        {
            registrationPage.NavigateToWebsite();
        }

        [Given(@"I click on Sign up")]
        public void GivenIClickOnSignUp()
        {
            registrationPage.ClickOnSignUp(); 
        }

        [Given(@"I enter My Username")]
        public void GivenIEnterMyUsername()
        {
            registrationPage.EnterUsername();
        }

        [Given(@"I enter My Email")]
        public void GivenIEnterMyEmail()
        {
            registrationPage.EnterEmail();
        }

        [Given(@"I enter my Password")]
        public void GivenIEnterMyPassword()
        {
            registrationPage.EnterPassword();
        }

        [When(@"I click on the Sign up Button")]
        public void WhenIClickOnTheSignUpButton()
        {
            registrationPage.ClickOnSignUpButton();
        }

        [Then(@"I should be able to register successfully")]
        public void ThenIShouldBeAbleToRegisterSuccessfully()
        {
            Thread.Sleep(5000);
            Assert.That(registrationPage.IsNewArticleDisplayed);
        }

        [Given(@"I forget to add something")]
        public void GivenIForgetToAddSomething()
        {
            throw new PendingStepException();
        }

    }
}
