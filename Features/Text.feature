Feature: Text

A short summary of the feature

@android_prod
Scenario: [Positive] Text changes on click
	Given the application has been launched
	When the user takes note of the text and clicks on the Text button
	Then the text should should be changed

@android_prod
Scenario: [Negative] Recieve Notification on click
	Given the application has been launched
	When the user takes note of the text and clicks on the Color button
	Then the text should should not be changed