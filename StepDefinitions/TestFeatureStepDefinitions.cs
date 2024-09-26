using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class TestFeatureStepDefinitions
    {
        [Given(@"User is on Login Page")]
        public void GivenUserIsOnLoginPage()
        {
            Console.WriteLine("Test user is on the login page");
            
        }

        [When(@"User enters the username and password")]
        public void WhenUserEntersTheUsernameAndPassword()
        {
            Console.WriteLine("Test user enters the username and password");
        }

        [When(@"User clicks on login button")]
        public void WhenUserClicksOnLoginButton()
        {
            Console.WriteLine("Test ");
            
        }

        [Then(@"User is navigated to home page")]
        public void ThenUserIsNavigatedToHomePage()
        {
            Console.WriteLine("test user");
        }
    }
}
