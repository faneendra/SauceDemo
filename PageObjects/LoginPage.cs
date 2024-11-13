using OpenQA.Selenium;

namespace SpecFlowProject1.PageObjects
{
    public class LoginPage
    {
        private IWebDriver _driver;

        public LoginPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public void NavigateTo()
        {
            _driver.Navigate().GoToUrl("https://www.saucedemo.com");
        }

        public void EnterCredentials(string username, string password)
        {
            _driver.FindElement(By.Id("user-name")).SendKeys(username);
            _driver.FindElement(By.Id("password")).SendKeys(password);
            _driver.FindElement(By.Id("login-button")).Click();
        }
    }
}