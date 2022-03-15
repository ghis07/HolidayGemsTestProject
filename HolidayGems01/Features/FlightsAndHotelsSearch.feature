Feature: FlightsAndHotelsSearch
	Search Flights and Hotels in a particuler location

@mytag
Scenario: validate that a user search for flights and hotel when valid credentials are provided
	Given I Navigate to HolidayGem Website
	And   I select the destination
	And   I select the departing Airport
	And   I select the Date
	And   I select the number of Nights
	And   I select the board basic
	#And   I  select the Number of people in the Roon
	When  I  Click on  Search button
	#Then  I should be able  to view the available hotels and Flights offer 