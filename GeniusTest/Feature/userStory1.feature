Feature: userStory1
	login

@login
Scenario: login with credentials
	Given I am on the homepage
	And I enter my credentials
	When i click the sign in button
	Then I should be signed in