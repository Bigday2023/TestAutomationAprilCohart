using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAutomationAprilCohart.Utilities;

namespace TestAutomationAprilCohart.PageObject
{
    class RegistrationPage
    {
        public RegistrationPage() 
        {
            driver = Hooks1.driver;
        }

        IWebDriver driver;

        IWebElement Signup => driver.FindElement(By.CssSelector("body > div > app-header > nav > div > ul:nth-child(2) > li:nth-child(3) > a"));
        IWebElement Username => driver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/form/fieldset/fieldset[1]/input"));
        IWebElement Email => driver.FindElement(By.CssSelector("body > div > div > div > div > div > div > form > fieldset > fieldset:nth-child(2) > input"));
        IWebElement Password => driver.FindElement(By.XPath("//input[@placeholder='Password']"));
        IWebElement SignUpButton => driver.FindElement(By.XPath("//button[ text( )='Sign up'] "));
        IWebElement NewArticle => driver.FindElement(By.XPath("(//a[@class='nav-link'])[3]"));
        public void ClickOnSignUp()
        {
            Signup.Click();
        }

        public void EnterUsername()
        {
            Username.SendKeys ("Pork");
        }

        public void NavigateToWebsite()
        {
            driver.Navigate().GoToUrl("https://angularjs.realworld.io/#");
        }

        public void EnterEmail()
        {
            Email.SendKeys("Pork@learnwithpride.com");
        }

        public void EnterPassword()
        {
            Password.SendKeys("enterpassword");
        }

        public void ClickOnSignUpButton()
        {
            SignUpButton.Click();
        }

        public bool IsNewArticleDisplayed()
        {
            return NewArticle.Displayed;
        }













    }
}
