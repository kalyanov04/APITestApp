Feature: UpdateTodoStatus
	
@mytag
Scenario Outline: Make todo ctatus completed
	Given I have an endpoint /todos
	When I call PUT method using <id> and <completed>
	Then I get API response

	Examples: 
	| id | completed |
	| 1  | true      |
	| 1  | false     |
