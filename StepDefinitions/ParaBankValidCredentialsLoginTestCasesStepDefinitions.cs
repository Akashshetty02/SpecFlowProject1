using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;
using WebDriverManager.DriverConfigs.Impl;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class ParaBankValidCredentialsLoginTestCasesStepDefinitions
    {
        private IWebDriver _driver;
        [Given(@"User is on the Para bank Login Page")]
        public void GivenUserIsOnTheParaBankLoginPage()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            // initiialize web driver
            _driver = new ChromeDriver();
            _driver.Navigate().GoToUrl("https://parabank.parasoft.com");
            _driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
        }

        [When(@"User enters valid  ""([^""]*)"" and ""([^""]*)"" in the input\.")]
        public void WhenUserEntersValidAndInTheInput_(string username, string password)
        {
            IWebElement User = _driver.FindElement(By.Name("username"));
            User.SendKeys(username);

            IWebElement Pass = _driver.FindElement(By.Name("password"));
            Pass.SendKeys(password);
            Thread.Sleep(2000);
        }

        [When(@"User clicks on the Login button")]
        public void WhenUserClicksOnTheLoginButton()
        {
            IWebElement LoginButton = _driver.FindElement(By.XPath("//input[@value='Log In']"));
            LoginButton.Click();
            Thread.Sleep(2000);
        }

        [Then(@"User is displayed with")]
        public void ThenUserIsDisplayedWith()
        {

            IWebElement find = _driver.FindElement(By.XPath("//a[normalize-space()='Find Transactions']"));

            find.Click();

            _driver.Close();

            Thread.Sleep(2000);
        }
    }
}
