using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class LoginStepDefinitions
    {
        private readonly LoginPage _loginPage;

        public LoginStepDefinitions(LoginPage loginPage)
        {
            _loginPage = loginPage;
        }

        [Given("I am on the SauceDemo login page")]
        public void GivenIAmOnTheSauceDemoLoginPage()
        {
            _loginPage.NavigateToLoginPage();
        }

        [When("I enter valid credentials")]
        public void WhenIEnterValidCredentials()
        {
            _loginPage.EnterCredentials("standard_user", "secret_sauce");
        }

        [Then("I should be redirected to the products page")]
        public void ThenIShouldBeRedirectedToTheProductsPage()
        {
            _loginPage.VerifySuccessfulLogin();
        }
    }
}