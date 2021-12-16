using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab9DealTests.PageObject
{
    class TradingPage :BasePage
    {
        public TradingPage(IWebDriver webDriver) : base(webDriver) { }

        private readonly By btnCloseContinueRegistrationWindow = By.XPath("//*[@id='skillingRouter']/skilling-app-shell/verify-your-account-modal/div[2]/button");
        private readonly By instrumentEURUSD = By.XPath("//*[@id='panes-holder']/div[1]/watchlist-desktop/div[1]/instruments-table/div/div[2]/ul/li[1]/span[1]/instrument/div");
        private readonly By buyMode = By.XPath("/html/body/skilling-root/div/div/div/div/skilling-app-shell/div[2]/trading-dashboard/div/div/div[4]/trade-ticket/div/div/div/div/div[1]/mat-tab-group/mat-tab-header/div[2]/div/div/div[2]");
        private readonly By sellMode = By.XPath("/html/body/skilling-root/div/div/div/div/skilling-app-shell/div[2]/trading-dashboard/div/div/div[4]/trade-ticket/div/div/div/div/div[1]/mat-tab-group/mat-tab-header/div[2]/div/div/div[1]");
        private readonly By typeOfBuy = By.XPath("//*[@id='tradeTicketBody']/div/section/div[1]/div/div[3]/single-select/span");
        private readonly By marketOption = By.XPath("//*[@id='order-type']/option[1]");
        private readonly By btnOpenBuySellSubMenu = By.XPath("//*[@id='panes-holder']/div[3]/expandable-button/div");
        private readonly By btnBuy = By.XPath("//*[@id='panes-holder']/div[4]/trade-ticket/div/div/div/div/div[2]/section/div/div/buy-sell-button/div/button");
        private readonly By windowText = By.XPath("//*[@class='toast__text']");

        public TradingPage CloseContinueRegistrationWindow()
        {
            WaitForVisibilityOfElemen(driver, btnCloseContinueRegistrationWindow).Click();
            return this;
        }

        public TradingPage ChoiceInstrumentEURUSD()
        {
            WaitForVisibilityOfElemen(driver, instrumentEURUSD).Click();
            return this;
        }

        public TradingPage ChoiceBuyMode()
        {
            WaitForVisibilityOfElemen(driver, buyMode).Click();           
            return this;
        }

        public TradingPage ChoiceSellMode()
        {
            WaitForVisibilityOfElemen(driver, sellMode).Click();
            return this;
        }

        public TradingPage ChoiceTypeOfBuy()
        {
            WaitForVisibilityOfElemen(driver, typeOfBuy).Click();
            return this;
        }

        public TradingPage ChoiceMarketOption()
        {
            WaitForVisibilityOfElemen(driver, marketOption).Click();
            return this;
        }

        public TradingPage OpenBuySellSubMenu()
        {
            WaitForVisibilityOfElemen(driver, btnOpenBuySellSubMenu).Click();
            return this;
        }

        public TradingPage TradingOperation()
        {
            Thread.Sleep(15000);
            WaitForVisibilityOfElemen(driver, btnBuy).Click();
            return this;
        }

        public string GetActual()
        {
            string text = WaitForVisibilityOfElemen(driver, windowText).Text;
            return text.Substring(text.Length - 12, 12);
        }

    }
}
