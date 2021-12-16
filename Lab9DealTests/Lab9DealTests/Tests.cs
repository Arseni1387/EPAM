using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.IO;
using Lab9DealTests.PageObject;

namespace Lab9DealTests
{
    public class Tests
    {
        private IWebDriver driver;
        private TradingPage tradingPage;
        private string expected = "was executed";
        private const string login = "Kravzhul2002@mail.ru";
        private const string testPassword = "Arseni1387";
        [SetUp]
        public void StartPageSetup() 
        {
            var chromeOptions = new ChromeOptions();
            driver = new ChromeDriver(Directory.GetCurrentDirectory(), chromeOptions);
            driver.Manage().Window.Maximize();
            tradingPage = new StartPage(driver).OpenPage().SignIn().EnterLogin(login).EnterPassword(testPassword).SignIn().CloseContinueRegistrationWindow();
        }

        [Test]
        public void BuyMarketTest()
        {     
            string actual=  tradingPage.OpenBuySellSubMenu().ChoiceInstrumentEURUSD().ChoiceBuyMode().ChoiceTypeOfBuy().ChoiceMarketOption().TradingOperation().GetActual();
            Assert.AreEqual(expected, actual);          
        }

        [Test]
        public void SellMarketTest()
        {
            string actual = tradingPage.OpenBuySellSubMenu().ChoiceInstrumentEURUSD().ChoiceSellMode().ChoiceTypeOfBuy().ChoiceMarketOption().TradingOperation().GetActual();
            Assert.AreEqual(expected, actual);
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}

