using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab9DealTests.PageObject
{
    class StartPage : BasePage
    {
        public StartPage(IWebDriver webDriver) : base(webDriver) { }

        private static readonly string HOMEPAGE_URL = "https://skilling.com/eu/en/";
        private readonly By btnInLoginCabinet = By.XPath("//*[@id='btn-login']");

        public StartPage OpenPage()
        {
            driver.Navigate().GoToUrl(HOMEPAGE_URL);
            return this;
        }
        public LoginPage SignIn()
        {
            WaitForVisibilityOfElemen(driver, btnInLoginCabinet).Click();
            return new LoginPage(driver);
        }
    }
}
