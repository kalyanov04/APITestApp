Feature: APIResponse

@mytag
Scenario Outline: get API response using given endpoint
	Given I have an endpoint <endpoint>
	When I call GET method of api
	Then I get API response

	Examples:
	| endpoint  |
	| /posts    |
	| /comments |
	| /albums   |
	| /photos   |
	| /todos    |
	| /users    |