Feature: TMFeature
I would like to create, edit and delete time and material records
So that I can manage employees time and materials successfully

@regression	
	Scenario: create time record with valid details
		Given I logged in to TurnUp portal successfully
		And I navigate to Time and Material page
		When I create a new time record
		Then the record should be created successfully