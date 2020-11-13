Feature: FlamengoNews
	In different websites
	As a fanatic user
	I want to see the news from Flamengo

@espn
Scenario: Search for Flamengo news in ESPN
	Given acess ESPN website
	And it is possible to search
	When user search for Flamengo
	Then user will be redirected to news list

Scenario: User click in any news
	Given user is in ESPN webpage
	And already searched for Flamengo
	When exists news
	Then the user clicks on any news