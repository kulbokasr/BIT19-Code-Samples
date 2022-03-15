using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.ObjectModel;
using System.Threading;

namespace SeleniumLearning
{
    public class Tests
    {
        public IWebDriver Driver;
        [SetUp]
        public void Setup()
        {
            Driver = new ChromeDriver();
            Driver.Manage().Window.Maximize();
        }
        [OneTimeTearDown]
        public void Finish()
        {
          //  Driver.Quit();
        }

        [Test]
        public void Test1()
        {
            Driver.Navigate().GoToUrl("http://www.skelbiu.lt");
            // Thread.Sleep(10000); -- not good practise
            WebDriverWait w = new WebDriverWait(Driver, TimeSpan.FromSeconds(20));
            w.Until(ExpectedConditions.ElementToBeClickable(By.Id("onetrust-accept-btn-handler")));
            IWebElement PrivacyBtn = Driver.FindElement(By.Id("onetrust-accept-btn-handler"));
            PrivacyBtn.Click();
            Driver.FindElement(By.Id("searchKeyword")).SendKeys("bulves");
            Driver.FindElement(By.Id("searchButton")).Click();
            IWebElement ul = Driver.FindElement(By.Id("itemsList")).FindElement(By.TagName("ul"));
            ReadOnlyCollection<IWebElement> Cards = ul.FindElements(By.ClassName("simpleAds"));
            foreach (IWebElement Card in Cards)
            {
                Card.FindElement(By.TagName("a")).Click();
                String price = Driver.FindElement(By.XPath("//*[@id=\"contentArea\"]/div[3]/div[1]/div[1]/div[5]/div/div[2]/p")).Text;
                Console.WriteLine(price);
                Driver.Navigate().Back();
            }
        }
    }
}