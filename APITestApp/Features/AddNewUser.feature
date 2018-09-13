Feature: AddNewUser

@mytag
Scenario Outline: Add new user
	Given I have endpoint /users
	When I call POST method with body <name> and <username> and <email> and <street> and <suite> and <city> and <zipcode> and <lat> and <lng> and <phone> and <website> and <cname> and <catchPhrase> and <bs> 
	Then response status is ok and user added

	Examples: 
	| name | username | email | street | suite | city | zipcode | lat      | lng     | phone         | website      | cname       | catchPhrase                          | bs                               |
	| Alex | kalyan   | asd   | ads    | asd   | ad   | 33263   | -31.8129 | 62.5342 | (254)954-1289 | demarco.info | Keebler LLC | User-centric fault-tolerant solution | revolutionize end-to-end systems |
