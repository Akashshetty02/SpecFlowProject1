using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class TestLoginWithParamsStepDefinitions
    {
        [When(@"User enters the ""([^""]*)"" and ""([^""]*)""")]
        public void WhenUserEntersTheAnd(string username, string password)
        {
            Console.WriteLine(username + " " + password);
        }

        [Then(@"User seleceted city and country information")]
        public void ThenUserSelecetedCityAndCountryInformation(Table table)
        {
            foreach (var row in table.Rows)
            {
                string city = row["city"];
                string country = row["country"];

                Console.WriteLine(city + " " + country);
            }



        }

    }
}
