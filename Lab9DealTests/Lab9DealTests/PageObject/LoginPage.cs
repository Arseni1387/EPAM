using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9DealTests.PageObject
{
    class LoginPage : BasePage
    {
        public LoginPage(IWebDriver webDriver) : base(webDriver) { }



        private readonly By txtLogin = By.XPath("//*[@id='mat-input-0']");
        private readonly By txtPassword = By.XPath("//*[@id='mat-input-1']");
        private readonly By btnEnter = By.XPath("//*[@id='continue']");

        public LoginPage EnterLogin(string login)
        {
            WaitForVisibilityOfElemen(driver, txtLogin).SendKeys(login);
            return this;
        }

        public LoginPage EnterPassword(string password)
        {
            WaitForVisibilityOfElemen(driver, txtPassword).SendKeys(password);
            return this;
        }
        public TradingPage SignIn()
        {
            WaitForVisibilityOfElemen(driver, btnEnter).Click();
            return new TradingPage(driver);
        }

    }
}
