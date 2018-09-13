Feature: DeleteUser

@mytag
Scenario Outline: Delete user
	Given I have endpoint /users
	When I call DELETE method using <id> 
	Then I get API response

	Examples: 
	| id |
	| 11 |