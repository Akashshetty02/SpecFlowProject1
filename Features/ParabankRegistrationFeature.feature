Feature: ParabankRegistrationFeature
Feature: TestRegistrationWithParms

A short summary of the feature


Scenario Outline: Registration with test parameters
	Given User is on the  Registration Page
	When User Enter s "<FirstName>", "<LastName>", "<Address>","<City>", "<State>", "<ZipCode>", "<Phone>", "<Ssn>", "<Username>", "<Password>" and "<ConfirmPass>"
	And User Clicks on  Register Button
	Then User is navigated  to Registration page 

	Examples: 
| FirstName | LastName | Address | City      | State     | ZipCode | Phone    | Ssn | Username | Password | ConfirmPass |
| sharat    | naik     | abc     | mangalore | karnataka | 581262  | 56587859 | 111 | sharath  | 12345    | 12345       |