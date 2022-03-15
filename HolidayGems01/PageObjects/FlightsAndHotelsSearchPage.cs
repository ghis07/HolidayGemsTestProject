using HolidayGems01.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HolidayGems01.PageObjects
{
    class FlightsAndHotelsSearchPage
    {
        IWebDriver driver;
        public FlightsAndHotelsSearchPage()
        {
            driver = Hooks1.driver;
        }

       // IWebElement destinametionListIcon => driver.FindElement(By.XPath("//span[text()='List']"));
        IWebElement dropdownSelect_location => driver.FindElement(By.XPath("//span[text()='Barcelona - Spain']"));
        IWebElement SelectDestination => driver.FindElement(By.Id("destinationListInner"));

        IWebElement SelectAirport => driver.FindElement(By.Id("Departure-text "));


        IWebElement SelectDate => driver.FindElement(By.Id("DateControl"));

        IWebElement SelectNight => driver.FindElement(By.Id("NightsControl "));

        IWebElement SelectboadBasic => driver.FindElement(By.Id("dropdownbb "));

        IWebElement Searchbutton => driver.FindElement(By.XPath("//button[@class='btn btn-default form-control']"));

        IWebElement FilterYourResult => driver.FindElement(By.XPath("//div[@class='col-md-7 col-lg-8 no-padding']"));




        public void NavigateToWebsite()
        {
            driver.Navigate().GoToUrl("https://www.holidaygems.co.uk/");
        }

        public void ClickOnDestinationList()
        {
            SelectDestination.Click();

            IJavaScriptExecutor executor = (IJavaScriptExecutor)driver;
            executor.ExecuteScript("arguments[0].click();", 
                dropdownSelect_location);
        }


        public void SelectAirportDropdown()
        {
            IJavaScriptExecutor executor = (IJavaScriptExecutor)driver;
            executor.ExecuteScript("arguments[0].click();",
                driver.FindElement(By.XPath("(//i[@class='fa fa-chevron-down'])[4]")));

            executor.ExecuteScript("arguments[0].click();",
                driver.FindElement(By.XPath("//input[@id='Manchester']")));

            executor.ExecuteScript("arguments[0].click();",
               driver.FindElement(By.Id("CloseDepartBox")));

        }

        public void SelectDateDropdown()
        {
            IJavaScriptExecutor executor = (IJavaScriptExecutor)driver;
            executor.ExecuteScript("arguments[0].click();",
              driver.FindElement(By.XPath("//i[@class='fas fa-calendar-alt']")));

            executor.ExecuteScript("arguments[0].click();",
              driver.FindElement(By.XPath("(//a[@href='#'])[20]")));
        }

        public void SelectNightDropdown()
        {
            IJavaScriptExecutor executor = (IJavaScriptExecutor)driver;
            executor.ExecuteScript("arguments[0].click();",
              driver.FindElement(By.XPath("//div[@class='dropbtn']")));

            executor.ExecuteScript("arguments[0].click();",
              driver.FindElement(By.XPath("(//div[@id='w21'])")));
        }

        public void SelectBoardBasicDropdown()
        {
            IJavaScriptExecutor executor = (IJavaScriptExecutor)driver;
            executor.ExecuteScript("arguments[0].click();",
              driver.FindElement(By.XPath("(//div[@class='dropdownbb'])[1]")));

           
            executor.ExecuteScript("arguments[0].click();",
              driver.FindElement(By.XPath("(//div[@class='brd-item'])[5]")));

        }

        public void ClickOnSearchButton()
        {
            Searchbutton.Click();
        }

        public bool FilterYourResultDisplay()
        {
            return FilterYourResult.Displayed;

        }

    }
}
