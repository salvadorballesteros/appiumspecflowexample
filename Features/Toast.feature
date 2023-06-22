Feature: Toast

A short summary of the feature

@android_prod
Scenario: [Positive] Toast appears on click
	Given the application has been launched
	When the user clicks the Toast button
	Then the toast should should be displayed

Scenario: [Negative] Toast appears on click
	Given the application has been launched
	When the user clicks on the Color button
	Then the toast should should not be displayed