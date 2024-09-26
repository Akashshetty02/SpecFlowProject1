using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;
using WebDriverManager.DriverConfigs.Impl;


namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class OrangeHRMStepDefinitions
    {
        private readonly ScenarioContext _scenarioContext;
        private IWebDriver _driver;

        public OrangeHRMStepDefinitions(ScenarioContext scenarioContext)
        {

            _scenarioContext = scenarioContext;
            _driver = _scenarioContext["WebDriver"] as IWebDriver;

        }


        [Given(@"User is on the orange hrm login page")]
        public void GivenUserIsOnTheOrangeHrmLoginPage()
        {


            _driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login");
            _driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
        }
        

            [When(@"User enters the ""([^""]*)"" and ""([^""]*)"" in the text fields")]
        public void WhenUserEntersTheAndInTheTextFields(string username, string password)
        {
        _driver.FindElement(By.XPath("//input[@name = 'username']")).SendKeys(username);

       


        _driver.FindElement(By.XPath("//input[@name = 'password']")).SendKeys(password);

      
}

        [When(@"User clicks on submit button")]
        public void WhenUserClicksOnSubmitButton()
        {
            IWebElement loginbutton = _driver.FindElement(By.XPath("//button[@type = 'submit']"));

            loginbutton.Click();

            Thread.Sleep(1000);
        }

        [Then(@"User is navigated to the home page")]
        public void ThenUserIsNavigatedToTheHomePage()
        {
            //IWebElement Admin = _driver.FindElement(By.XPath("(//a[@class = 'oxd-main-menu-item'])[1]"));

            //Admin.Click();
            Thread.Sleep(2000);

            _driver.Close();

        }
    }
}
