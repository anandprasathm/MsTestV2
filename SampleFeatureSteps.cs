using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace UnitTestProject1
{
    [Binding]
    public class SampleFeatureSteps
    {
        IWebDriver driver;

        [Given(@"I launch Google Search Engine")]
        public void GivenILaunchGoogleSearchEngine()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.google.com/");
        }
        
        [Given(@"I have entered the (.*)")]
        public void GivenIHaveEnteredThe(string SearchResult)
        {
            driver.FindElement(By.Name("q")).SendKeys(SearchResult);
        }
        
        [Then(@"I press Enter")]
        public void ThenIPressEnter()
        {
            driver.FindElement(By.Name("q")).SendKeys(Keys.Enter);
        }
    }
}
