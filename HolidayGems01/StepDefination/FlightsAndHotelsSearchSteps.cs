using HolidayGems01.PageObjects;
using System;
using TechTalk.SpecFlow;

namespace HolidayGems01.StepDefination
{
    [Binding]
    public class FlightsAndHotelsSearchSteps
    {

        FlightsAndHotelsSearchPage flightsAndHotelsSearchPage;

        public FlightsAndHotelsSearchSteps()
        {
            flightsAndHotelsSearchPage = new FlightsAndHotelsSearchPage();
        }

        //or this will work as well: 
        // FlightsAndHotelsSearchPage flightsAndHotelsSearchPage = new FlightsAndHotelsSearchPage();
        [Given(@"I Navigate to HolidayGem Website")]
        public void GivenINavigateToHolidayGemWebsite()
        {
            flightsAndHotelsSearchPage.NavigateToWebsite();
        }
        
        [Given(@"I select the destination")]
        public void GivenISelectTheDestination()
        {
            flightsAndHotelsSearchPage.ClickOnDestinationList();
        }
        
        [Given(@"I select the departing Airport")]
        public void GivenISelectTheDepartingAirport()
        {
            flightsAndHotelsSearchPage.SelectAirportDropdown();
        }
        
        [Given(@"I select the Date")]
        public void GivenISelectTheDate()
        {
            flightsAndHotelsSearchPage.SelectDateDropdown();
        }
        
        [Given(@"I select the number of Nights")]
        public void GivenISelectTheNumberOfNights()
        {
          flightsAndHotelsSearchPage.SelectNightDropdown();
        }
        
        [Given(@"I select the board basic")]
        public void GivenISelectTheBoardBasic()
        {
            flightsAndHotelsSearchPage.SelectBoardBasicDropdown();
        }
        
       
        [When(@"I  Click on  Search button")]
        public void WhenIClickOnSearchButton()
        {
            flightsAndHotelsSearchPage.ClickOnSearchButton();
        }
        
        [Then(@"I should be able  to view the available hotels and Flights offer")]
        public void ThenIShouldBeAbleToViewTheAvailableHotelsAndFlightsOffer()
        {
            flightsAndHotelsSearchPage.FilterYourResultDisplay();
        }
    }
}
