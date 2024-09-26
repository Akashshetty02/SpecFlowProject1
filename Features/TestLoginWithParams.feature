Feature: TestLoginWithParams

A short summary of the feature

@tag1
Scenario Outline: Verify login with test parameters
	Given User is on Login Page
	When User enters the "<username>" and "<password>"
	And  User clicks on login button
	Then User is navigated to home page
	Then User seleceted city and country information
	| city   | country |
	| Delhi  | India   |
	| Boston | USA     |


	Examples:

	| username | password |
	| tom      | Harry    |
	| jerry    | yoy      |
