Feature: GetUserInfo

@mytag
Scenario Outline: Get user info using id
	Given I have endpoint /users
	When I call GET method of api to get user info using <id>
	Then I compaare user information to <id> and <name> and <username> and <email> and <street> and <suite> and <city> and <zipcode> and <lat> and <lng> and <phone> and <website> and <cname> and <catchPhrase> and <bs> 

	Examples: 
	| id | name             | username | email                    | street       | suite     | city       | zipcode | lat      | lng     | phone         | website      | cname        | catchPhrase                          | bs                               |
	| 5  | Chelsey Dietrich | Kamren   | Lucio_Hettinger@annie.ca | Skiles Walks | Suite 351 | Roscoeview | 33263   | -31.8129 | 62.5342 | (254)954-1289 | demarco.info | Keebler LLC | User-centric fault-tolerant solution | revolutionize end-to-end systems |
