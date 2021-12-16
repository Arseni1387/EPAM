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



        private readonly By txtLogin = By.XPath("/html/body/skilling-root/div/div/div/div/login/div/div[1]/div[3]/email-password-form/div/div[2]/mdl-textfield[1]/div/input");
        private readonly By txtPassword = By.XPath("/html/body/skilling-root/div/div/div/div/login/div/div[1]/div[3]/email-password-form/div/div[2]/mdl-textfield[2]/div/input");
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
