Feature: Notifications

A short summary of the feature

@android_prod
Scenario: [Positive] Recieve Notification on click
	Given the application has been launched
	When the user clicks on the Notification button
	Then a notification should be recieved

@android_prod
Scenario: [Negative] Recieve Notification on click
	Given the application has been launched
	When the user clicks on the Color button
	Then a notification should not be recieved