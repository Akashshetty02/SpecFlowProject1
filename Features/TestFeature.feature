Feature: TestFeature

A short summary of the feature

@tag1
Scenario: Verify login functionality
	Given User is on Login Page
	When User enters the username and password
	And User clicks on login button
	Then User is navigated to home page
