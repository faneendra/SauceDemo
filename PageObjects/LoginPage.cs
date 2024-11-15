using OpenQA.Selenium;

namespace PageObjects
{
    public class LoginPage
    {
        private IWebDriver driver;

        public LoginPage(IWebDriver webDriver)
        {
            driver = webDriver;
        }

        public void EnterUsername(string username)
        {
            driver.FindElement(By.Id("user-name")).SendKeys(username);
        }

        public void EnterPassword(string password)
        {
            driver.FindElement(By.Id("password")).SendKeys(password);
        }

        public void ClickLoginButton()
        {
            driver.FindElement(By.Id("login-button")).Click();
        }

        public bool IsLoginSuccessful()
        {
            return driver.FindElement(By.Id("inventory_container")).Displayed;
        }
    }
}