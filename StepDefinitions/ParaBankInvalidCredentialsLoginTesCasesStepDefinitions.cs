using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;
using WebDriverManager.DriverConfigs.Impl;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class ParaBankInvalidCredentialsLoginTesCasesStepDefinitions
    {
        private IWebDriver _driver;
        [Given(@"User is on the Para bank Login Page\.")]
        public void GivenUserIsOnTheParaBankLoginPage_()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            // initiialize web driver
            _driver = new ChromeDriver();
            _driver.Navigate().GoToUrl("https://parabank.parasoft.com");
            _driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
        }

        [When(@"User enters the ""([^""]*)"" and ""([^""]*)"" in the input\.")]
        public void WhenUserEntersTheAndInTheInput_(string username, string password)
        {
            IWebElement User = _driver.FindElement(By.Name("username"));
            User.SendKeys(username);

            IWebElement Pass = _driver.FindElement(By.Name("password"));
            Pass.SendKeys(password);
            Thread.Sleep(2000);
        }

        [When(@"User clicks on the Login button\.")]
        public void WhenUserClicksOnTheLoginButton_()
        {

            IWebElement LoginButton = _driver.FindElement(By.XPath("//input[@value='Log In']"));
            LoginButton.Click();
            Thread.Sleep(2000);
        }

        [Then(@"User is displayed with Invalid Credentials Message\.")]
        public void ThenUserIsDisplayedWithInvalidCredentialsMessage_()
        {
            IWebElement Msg = _driver.FindElement(By.ClassName("title"));

            string txt = Msg.Text;

            Assert.AreEqual("Error!", txt);
            _driver.Close();

            Thread.Sleep(2000);

        }
    }
}
