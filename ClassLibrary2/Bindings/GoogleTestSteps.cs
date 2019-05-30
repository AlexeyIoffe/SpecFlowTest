using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;

namespace SpecFlowTest
{
    [Binding]
    public sealed class GoogleTestSteps
    {
        private IWebDriver driver = new FirefoxDriver();

        [Given("I open (.*) page")]
        public void GivenIOpenSomePage(string page)
        {
            driver.Navigate().GoToUrl("http://www.google.com/");

        }

        [When("I type (.*)")]
        public void WhenITypeSome(string searchStr)
        {
            IWebElement searchField = driver.FindElement(By.Name("q"));
            searchField.SendKeys(searchStr);
            searchField.Submit();
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(d => d.Title.StartsWith("github", StringComparison.OrdinalIgnoreCase));

        }

        [Then("the result should contain (.*)")]
        public void ThenTheResultShouldBe(string result)
        {
            Assert.AreEqual(driver.Title, result);
            driver.Close();
        }
    }
}
