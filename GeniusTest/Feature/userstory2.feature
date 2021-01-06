Feature: User story 2

	
@addtocart
Scenario: Add Item to cart
	Given I am logged in
	And the Sauce labs Backpack
	When I select the add to cart button
	Then the item is added to the cart