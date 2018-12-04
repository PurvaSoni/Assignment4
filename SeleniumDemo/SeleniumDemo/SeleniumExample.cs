using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace SeleniumTests
{
    [TestFixture]
    public class UntitledTestCase
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;
        private bool acceptNextAlert = true;

        [SetUp]
        public void SetupTest()
        {
            driver = new FirefoxDriver();
            baseURL = "https://www.katalon.com/";
            verificationErrors = new StringBuilder();
        }

        [TearDown]
        public void TeardownTest()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            Assert.AreEqual("", verificationErrors.ToString());
        }

        [Test]
        public void TheUntitledTestCaseTest()
        {
            driver.Navigate().GoToUrl("http://localhost:5600/");
            driver.FindElement(By.Id("name")).Click();
            driver.FindElement(By.Id("name")).Click();
            driver.FindElement(By.Id("name")).Clear();
            driver.FindElement(By.Id("name")).SendKeys("p");
            driver.FindElement(By.Id("name")).SendKeys(Keys.Down);
            driver.FindElement(By.Id("name")).SendKeys(Keys.Down);
            driver.FindElement(By.Id("name")).SendKeys(Keys.Down);
            driver.FindElement(By.Id("name")).SendKeys(Keys.Tab);
            driver.FindElement(By.Id("address")).Clear();
            driver.FindElement(By.Id("address")).SendKeys("jgyg");
            driver.FindElement(By.Id("city")).Clear();
            driver.FindElement(By.Id("city")).SendKeys("hgkgk");
            driver.FindElement(By.Id("phonenumber")).Clear();
            driver.FindElement(By.Id("phonenumber")).SendKeys("768755");
            driver.FindElement(By.Id("email")).Clear();
            driver.FindElement(By.Id("email")).SendKeys("hjgigiug@.com");
            driver.FindElement(By.Id("make")).Clear();
            driver.FindElement(By.Id("make")).SendKeys("l");
            driver.FindElement(By.Id("make")).SendKeys(Keys.Down);
            driver.FindElement(By.Id("make")).SendKeys(Keys.Tab);
            driver.FindElement(By.Id("model")).Clear();
            driver.FindElement(By.Id("model")).SendKeys("ES 300h");
            driver.FindElement(By.Id("year")).Clear();
            driver.FindElement(By.Id("year")).SendKeys("2018");
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Vehile Information'])[1]/following::button[1]")).Click();
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='hjgigiug@.com'])[1]/following::a[1]")).Click();
            Assert.AreEqual("ES 300h", driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Compare'])[1]/following::div[4]")).Text);
        }
            [Test]
            public void TheUntitledTestCase2Test()
            {
                driver.Navigate().GoToUrl("http://localhost:5600/");
                driver.FindElement(By.Id("name")).Click();
                driver.FindElement(By.Id("name")).Clear();
                driver.FindElement(By.Id("name")).SendKeys("u");
                driver.FindElement(By.Id("name")).SendKeys(Keys.Down);
                driver.FindElement(By.Id("name")).SendKeys(Keys.Tab);
                driver.FindElement(By.Id("address")).Clear();
                driver.FindElement(By.Id("address")).SendKeys("200 old carriage dr");
                driver.FindElement(By.Id("city")).Clear();
                driver.FindElement(By.Id("city")).SendKeys("vadodara");
                driver.FindElement(By.Id("phonenumber")).Clear();
                driver.FindElement(By.Id("phonenumber")).SendKeys("09099696");
                driver.FindElement(By.Id("email")).Clear();
                driver.FindElement(By.Id("email")).SendKeys("urva@123gmil.com");
                driver.FindElement(By.Id("make")).Clear();
                driver.FindElement(By.Id("make")).SendKeys("mazda");
                driver.FindElement(By.Id("model")).Clear();
                driver.FindElement(By.Id("model")).SendKeys("cx-3");
                driver.FindElement(By.Id("year")).Clear();
                driver.FindElement(By.Id("year")).SendKeys("2018");
                driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Vehile Information'])[1]/following::button[1]")).Click();
                driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='urva@123gmil.com'])[3]/following::a[1]")).Click();
                Assert.AreEqual("Grand Touring", driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Compare'])[1]/following::div[4]")).Text);
            }

            [Test]
            public void TheUntitledTestCase3Test()
            {
                driver.Navigate().GoToUrl("http://localhost:5600/");
                driver.FindElement(By.Id("name")).Click();
                driver.FindElement(By.Id("name")).Clear();
                driver.FindElement(By.Id("name")).SendKeys("urvangi");
                driver.FindElement(By.Id("address")).Clear();
                driver.FindElement(By.Id("address")).SendKeys("jgyg");
                driver.FindElement(By.Id("city")).Clear();
                driver.FindElement(By.Id("city")).SendKeys("vadodara");
                driver.FindElement(By.Id("phonenumber")).Clear();
                driver.FindElement(By.Id("phonenumber")).SendKeys("2268081334");
                driver.FindElement(By.Id("email")).Clear();
                driver.FindElement(By.Id("email")).SendKeys("urva@123gmil.com");
                driver.FindElement(By.Id("make")).Clear();
                driver.FindElement(By.Id("make")).SendKeys("Honda");
                driver.FindElement(By.Id("model")).Clear();
                driver.FindElement(By.Id("model")).SendKeys("Civic");
                driver.FindElement(By.Id("year")).Clear();
                driver.FindElement(By.Id("year")).SendKeys("2018");
                driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Vehile Information'])[1]/following::button[1]")).Click();
                driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='urva@123gmil.com'])[7]/following::a[1]")).Click();
                Assert.AreEqual("EX-L", driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Compare'])[1]/following::div[4]")).Text);
            }

            [Test]
            public void TheUntitledTestCase4Test()
            {
                driver.Navigate().GoToUrl("http://localhost:5600/");
                driver.FindElement(By.Id("name")).Click();
                driver.FindElement(By.Id("name")).Clear();
                driver.FindElement(By.Id("name")).SendKeys("purv");
                driver.FindElement(By.Id("address")).Clear();
                driver.FindElement(By.Id("address")).SendKeys("ahgsdadg");
                driver.FindElement(By.Id("city")).Clear();
                driver.FindElement(By.Id("city")).SendKeys("kit");
                driver.FindElement(By.Id("phonenumber")).Clear();
                driver.FindElement(By.Id("phonenumber")).SendKeys("2268081334");
                driver.FindElement(By.Id("email")).Clear();
                driver.FindElement(By.Id("email")).SendKeys("hjgigiug@.com");
                driver.FindElement(By.Id("make")).Clear();
                driver.FindElement(By.Id("make")).SendKeys("ford");
                driver.FindElement(By.Id("model")).Click();
                driver.FindElement(By.Id("model")).Clear();
                driver.FindElement(By.Id("model")).SendKeys("mustang");
                driver.FindElement(By.Id("year")).Click();
                driver.FindElement(By.Id("year")).Clear();
                driver.FindElement(By.Id("year")).SendKeys("2018");
                driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Vehile Information'])[1]/following::button[1]")).Click();
                driver.FindElement(By.LinkText("ford")).Click();
                Assert.AreEqual("EcoBoost", driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Compare'])[1]/following::div[4]")).Text);
            }

            [Test]
            public void TheUntitledTestCase5Test()
            {
                driver.Navigate().GoToUrl("http://localhost:5600/");
                driver.FindElement(By.Id("name")).Click();
                driver.FindElement(By.Id("name")).Clear();
                driver.FindElement(By.Id("name")).SendKeys("nish");
                driver.FindElement(By.Id("name")).SendKeys(Keys.Down);
                driver.FindElement(By.Id("name")).SendKeys(Keys.Tab);
                driver.FindElement(By.Id("address")).Clear();
                driver.FindElement(By.Id("address")).SendKeys("vi");
                driver.FindElement(By.Id("address")).SendKeys(Keys.Down);
                driver.FindElement(By.Id("address")).SendKeys(Keys.Down);
                driver.FindElement(By.Id("address")).SendKeys(Keys.Tab);
                driver.FindElement(By.Id("city")).Clear();
                driver.FindElement(By.Id("city")).SendKeys("ki");
                driver.FindElement(By.Id("city")).SendKeys(Keys.Down);
                driver.FindElement(By.Id("city")).SendKeys(Keys.Tab);
                driver.FindElement(By.Id("phonenumber")).Clear();
                driver.FindElement(By.Id("phonenumber")).SendKeys("987654325");
                driver.FindElement(By.Id("email")).Clear();
                driver.FindElement(By.Id("email")).SendKeys("ni");
                driver.FindElement(By.Id("email")).SendKeys(Keys.Down);
                driver.FindElement(By.Id("email")).SendKeys(Keys.Tab);
                driver.FindElement(By.Id("make")).Clear();
                driver.FindElement(By.Id("make")).SendKeys("hyundai");
                driver.FindElement(By.Id("model")).Clear();
                driver.FindElement(By.Id("model")).SendKeys("elantra");
                driver.FindElement(By.Id("year")).Clear();
                driver.FindElement(By.Id("year")).SendKeys("2018");
                driver.FindElement(By.Id("year")).SendKeys(Keys.Down);
                driver.FindElement(By.Id("year")).Clear();
                driver.FindElement(By.Id("year")).SendKeys("2018");
                driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Vehile Information'])[1]/following::button[1]")).Click();
                driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='nis@1234.gmail.com'])[3]/following::a[1]")).Click();
                Assert.AreEqual("ECO", driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Compare'])[1]/following::div[4]")).Text);
            }


            private bool IsElementPresent(By by)
            {
                try
                {
                    driver.FindElement(by);
                    return true;
                }
                catch (NoSuchElementException)
                {
                    return false;
                }
            }

            private bool IsAlertPresent()
            {
                try
                {
                    driver.SwitchTo().Alert();
                    return true;
                }
                catch (NoAlertPresentException)
                {
                    return false;
                }
            }

            private string CloseAlertAndGetItsText()
            {
                try
                {
                    IAlert alert = driver.SwitchTo().Alert();
                    string alertText = alert.Text;
                    if (acceptNextAlert)
                    {
                        alert.Accept();
                    }
                    else
                    {
                        alert.Dismiss();
                    }
                    return alertText;
                }
                finally
                {
                    acceptNextAlert = true;
                }
            }
        }
    }