Feature: OrangeHRMInvalid

Test arrange hrm website invalid functionality

@tag1
Scenario: Verify invalid login for HRM website
	Given User is on hrm login page
	When User inputs  "<username>" and <"password>" in the text fields
	When User clicks on the  button
	Then User gets a invalid popup


	Examples: 
	| username | password |
	| admin    | admin    |

