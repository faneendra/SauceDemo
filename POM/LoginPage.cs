using OpenQA.Selenium;

namespace SauceDemoAutomation.POM
{
    public class LoginPage
    {
        private IWebDriver _driver;
        private By _usernameField = By.Id("user-name");
        private By _passwordField = By.Id("password");
        private By _loginButton = By.Id("login-button");

        public LoginPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public void NavigateToLoginPage()
        {
            _driver.Navigate().GoToUrl("https://www.saucedemo.com");
        }

        public void EnterCredentials(string username, string password)
        {
            _driver.FindElement(_usernameField).SendKeys(username);
            _driver.FindElement(_passwordField).SendKeys(password);
            _driver.FindElement(_loginButton).Click();
        }

        public void VerifySuccessfulLogin()
        {
            // This method should check for elements that are only visible after a successful login
            // For example, checking for the presence of the inventory container
            bool isLoggedIn = _driver.FindElement(By.Id("inventory_container")).Displayed;
            if (!isLoggedIn)
            {
                throw new Exception("Login failed");
            }
        }
    }
}