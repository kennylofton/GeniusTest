using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace GeniusTest.Step_Definitions
{
    [Binding]
    public class UserStory2Steps
    {
        IWebDriver driver = new ChromeDriver();
        [Given(@"I am logged in")]
        public void GivenIAmLoggedIn()
        {
            driver.Navigate().GoToUrl("http://saucedemo.com/");
            driver.Manage().Window.Maximize();
            IWebElement usernameField = driver.FindElement(By.XPath("//input[@id='user-name']"));
            usernameField.SendKeys("standard_user");
            IWebElement passwordField = driver.FindElement(By.XPath("//input[@id='password']"));
            passwordField.SendKeys("secret_sauce");
            IWebElement loginButon = driver.FindElement(By.XPath("//input[@id='login-button']"));
            loginButon.Click();
            }
        
        [Given(@"the Sauce labs Backpack")]
        public void GivenTheSauceLabsBackpack()
        {
            IWebElement sauceLabsBackpack = driver.FindElement(By.XPath("//div[.='Sauce Labs Backpack']"));
            bool isDisplayed = sauceLabsBackpack.Displayed;
        }
        
        [When(@"I select the add to cart button")]
        public void WhenISelectTheAddToCartButton()
        {
            IWebElement addToCart = driver.FindElement(By.XPath("//div[@class='inventory_list']/div[1]//button[@class='btn_primary btn_inventory']"));
            addToCart.Click();
            }
        
        [Then(@"the item is added to the cart")]
        public void ThenTheItemIsAddedToTheCart()
        {
            IWebElement cartIcon = driver.FindElement(By.XPath("//body[@class='main-body']"));
            cartIcon.Click();
            IWebElement cartItemSauceLabsBackpack = driver.FindElement(By.XPath("//*[@id='item_4_title_link']/div[1]"));
            bool isDisplayed = cartItemSauceLabsBackpack.Displayed;

            }
    }
}
