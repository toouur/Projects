Feature: ConsoleCalculator
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@SmokeTest
Scenario: 01 - Add two numbers

	Given I have entered 50 into the calculator
		And I have entered 70 into the calculator
	When I press add
		Then the result should be 120 on the screen

Scenario: 02 - Create a new employee with mandatory details

	#Given I have opened my application
	#Then I should see employee details
	When I fill all the mandatory details in the form
	
	| Name		| Age | Phone         | Email                       |
	| Andrei	| 26  | +375299134123 | andrei.patsiomkin@gmail.com |
	| Natallia	| 21  | +375456785432 | markava.natallia@gmail.com	|

	#And I click the save button
	#Then I should see all the details saved in my application and DB
