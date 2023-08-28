Feature: TMFeature
I would like to create, edit and delete time and material records
So that I can manage employees time and materials successfully

@regression	
	Scenario: create time record with valid details
		Given I logged in to TurnUp portal successfully
		And I navigate to Time and Material page
		When I create a new time record
		Then the record should be created successfully
		
Scenario Outline: : edit time record with valid detail
		Given I logged in to TurnUp portal successfully
		And I navigate to Time and Material page
		When I update '<Code>' and '<Description>' an existing record
		Then the record should have an updated '<Code>'and '<Description>'
		
		Examples: 
		| Code   | Description |
		| Red    | Bottle      |
		| Green  | Papaya      |
		| Yellow | Banana      |
  
 Scenario Outline: Delete time record with valid detail
 	Given I logged in to TurnUp portal successfully
 	And I navigate to Time and Material page
 	When I delete an existing record
 	Then the record should be deleted successfully
  


		
		
			