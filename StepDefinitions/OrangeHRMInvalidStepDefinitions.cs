using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;
using WebDriverManager.DriverConfigs.Impl;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class OrangeHRMInvalidStepDefinitions
    {
        private IWebDriver _driver;
        [Given(@"User is on hrm login page")]
        public void GivenUserIsOnHrmLoginPage()
        {
            // confifgure the web driver manager to set up the chrome capabilities
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            // intialize the web driver 
            _driver = new ChromeDriver();
            _driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login");
            _driver.Manage().Window.Maximize();
            Thread.Sleep(2000);


        }

        [When(@"User inputs  ""([^""]*)"" and <""([^""]*)"" in the text fields")]
        public void WhenUserInputsAndInTheTextFields(string username, string password)
        {
            _driver.FindElement(By.XPath("//input[@name = 'username']")).SendKeys(username);




            _driver.FindElement(By.XPath("//input[@name = 'password']")).SendKeys(password);

        }

        [When(@"User clicks on the  button")]
        public void WhenUserClicksOnTheButton()
        {
            IWebElement loginbutton = _driver.FindElement(By.XPath("//button[@type = 'submit']"));

            loginbutton.Click();

            Thread.Sleep(1000);
        }

        [Then(@"User gets a invalid popup")]
        public void ThenUserGetsAInvalidPopup()
        {
            IWebElement Msg = _driver.FindElement(By.XPath("//p[contains(normalize-space(),'Invalid credentials')]"));

            string txt = Msg.Text;

            Assert.AreEqual("Invalid credentials", txt);
            _driver.Close();

            Thread.Sleep(2000);
        }
    }
}
