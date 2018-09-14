Feature: CountUsersCompletedTodos

@mytag
Scenario Outline: Count completed todos of one user
	Given I have endpoint /todos
	When I call GET method using <userId> and <completed>
	Then the result must be <completedTodosQuantity>

	Examples: 
	| userId | completed | completedTodosQuantity |
	| 5      | true      | 12                     |