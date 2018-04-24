using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System.Threading;

namespace WebDriver.GeckoDriver.Test
{
    [TestClass]
    public class GeckoTests
    {
        [TestMethod]
        public void GeckoTest()
        {
            using (var driver = new FirefoxDriver { Url = "https://www.google.com" })
            {
                Thread.Sleep(500);
                var searchbar = driver.FindElementById("lst-ib");
                Thread.Sleep(500);
                searchbar.SendKeys("James Laurence");
                Thread.Sleep(500);
                searchbar.SendKeys(Keys.Enter);
                Thread.Sleep(2500);
                var results = driver.FindElementByTagName("body").Text;
                Assert.IsTrue(results.Contains("James Laurence Group"), "Search Results Missing");
                Thread.Sleep(2500);
                driver.Close();
            }
        }
    }
}
