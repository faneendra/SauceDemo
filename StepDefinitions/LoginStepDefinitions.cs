using TechTalk.SpecFlow;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class LoginStepDefinitions
    {
        [Given("I am on the login page")]
        public void GivenIAmOnTheLoginPage()
        {
            // Implementation to navigate to login page
        }

        [When("I enter valid credentials")]
        public void WhenIEnterValidCredentials()
        {
            // Implementation to enter credentials and submit
        }

        [Then("I should be redirected to the products page")]
        public void ThenIShouldBeRedirectedToTheProductsPage()
        {
            // Implementation to verify redirection to products page
        }
    }
}