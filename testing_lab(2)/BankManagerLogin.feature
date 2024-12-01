Feature: Bank Manager Login
  As a bank manager
  I want to be able to login and view customers
  So that I can manage the bank effectively

Scenario: Sorting customers by first name
  Given I navigate to the bank application
  When I login as a bank manager
  And I view the customers list
  Then the customers should be sorted by first name
