Feature: FlamengoNews
	In different websites
	As a fanatic user
	I want to see the news from Flamengo

@mytag
Scenario: Search for Flamengo news in ESPN
	Given there are search actions
	And it is possible to search
	When user search for Flamengo
	Then user will be redirected to news list