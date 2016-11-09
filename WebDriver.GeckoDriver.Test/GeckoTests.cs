using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Firefox;

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
                driver.Close();
            }
        }
    }
}
