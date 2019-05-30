Feature: GoogleTest
	As a user I want to open google search and find the github site

Scenario: Add two numbers
	Given I open google page
	When I type github
	Then the result should contain github - Поиск в Google
