@setup_feature
Feature: Add a customer

Scenario: Add a customer
	Given open the XYZ Bank page
	And click on the Bank Manager Login button
	And click on the add customer button
	When insert data into inputs and press button
	Then webpage shoudld contain alert
