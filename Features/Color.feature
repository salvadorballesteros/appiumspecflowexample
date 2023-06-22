Feature: Color

A short summary of the feature

@android_prod
Scenario: [Positive] Color Change on click
	Given the application has been launched
	When the user takes note of the current text color then clicks on the Color button
	Then the text color should be changed

@android_prod
Scenario: [Negative] Color Change when clicking Notification
	Given the application has been launched
	When the user takes note of the current text color then clicks on the Notification button
	Then the text color should not be changed

@android_prod
Scenario: [Negative] Color Change when clicking Text twice
	Given the application has been launched
	When the user takes note of the current text color then clicks on the Text button twice
	Then the text color should not be changed