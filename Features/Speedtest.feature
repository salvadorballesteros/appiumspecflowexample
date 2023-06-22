Feature: Speedtest

A short summary of the feature

Scenario: [Positive] Speedtest results are recorded
	Given the application has been launched
	When the user clicks the Speed Test button
	And I click on the Go button on the Speed Test screen
	And I record the results of the Speed Test
	And I click on the Home Button
	Then I should see the Home Screen