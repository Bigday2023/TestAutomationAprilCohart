Feature: DataDrivenWithParameter

A short summary of the feature

@tag1
Scenario: Data Driven With Parameter
	Given I Navigate to "https://angularjs.realworld.io/#"
	And   I click on Sign up
	And   I enter My Username test "LWPLONNDON"
	And   I enter My Email text "lwplondon@gdemo.com"
	And   I enter my Password text "Passwordsecure" 
	When  I click on the Sign up Button
	Then  I should be able to register successfully

