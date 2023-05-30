Feature: ValidRegistration

In order to take the full advantage on the website 
I will need to first be a registered customer

@tag1
Scenario: Valid Registration
	Given I Navigate to the Website
	And   I click on Sign up
	And   I enter My Username
	#And   I forget to add something 
	And   I enter My Email
	And   I enter my Password
	When  I click on the Sign up Button
	Then  I should be able to register successfully
