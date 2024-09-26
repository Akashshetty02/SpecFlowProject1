Feature: OrangeHRM

A short summary of the feature


Scenario: Verify login for orange hrm website
	Given User is on the orange hrm login page
	When User enters the "<username>" and "<password>" in the text fields
	When User clicks on submit button
	Then User is navigated to the home page

Examples:
	| username | password |
	| Admin    | admin123 |
