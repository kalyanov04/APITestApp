Feature: GetUsersPosts

@mytag
Scenario Outline: Get user's posts using userId
	Given I have endpoint /posts
	When I call GET method of api to get users posts using <userId>
	Then I get <postQuantity> posts

	Examples:
	| userId | postQuantity |
	| 3      | 10           |
	| 10     | 10           |

