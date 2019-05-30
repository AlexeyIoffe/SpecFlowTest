Feature: Calculator
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

Scenario Outline: Add numbers
	Given I have entered <firstValue> into the calculator
	And I have also entered <secondValue> into the calculator
	When I press add
	Then the result should be <result> on the screen

	Examples: 
		| firstValue | secondValue | result |
		| 0          | 10          | 10     |
		| 20         | 0           | 20     |
		| -10        | 20          | 10     |
		| 1          | -1          | 0   |

@mytag
Scenario Outline: Multiply numbers
	Given I have entered <firstValue> into the calculator
	And I have also entered <secondValue> into the calculator
	When I press mult
	Then the result should be <result> on the screen

	Examples: 
		| firstValue | secondValue | result |
		| 0          | 10          | 0      |
		| 20         | 0           | 0      |
		| -10        | 20          | -200   |
		| 1          | -2          | -2     |


