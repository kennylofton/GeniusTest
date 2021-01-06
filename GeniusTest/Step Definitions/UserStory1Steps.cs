using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace GeniusTest.Step_Definitions
{
    [Binding]
    public class UserStory1Steps
    {
        IWebDriver driver = new ChromeDriver();

        [Given(@"I am on the homepage")]
        public void GivenIAmOnTheHomepage()
        {
            driver.Navigate().GoToUrl("http://saucedemo.com/");
            driver.Manage().Window.Maximize();
        }
        
        [Given(@"I enter my credentials")]
        public void GivenIEnterMyCredentials()
        {
            IWebElement usernameField = driver.FindElement(By.XPath("//input[@id='user-name']"));
            usernameField.SendKeys("standard_user");
            IWebElement passwordField = driver.FindElement(By.XPath("//input[@id='password']"));
            passwordField.SendKeys("secret_sauce");
        }
        
        [When(@"i click the sign in button")]
        public void WhenIClickTheSignInButton()
        {
            IWebElement loginButon = driver.FindElement(By.XPath("//input[@id='login-button']"));
            loginButon.Click();
        }
        
        [Then(@"I should be signed in")]
        public void ThenIShouldBeSignedIn()
        {
            IWebElement products = driver.FindElement(By.XPath("//div[@class='product_label']"));
            bool isDisplayed = products.Displayed;
            driver.Quit();
        }
    }
}
