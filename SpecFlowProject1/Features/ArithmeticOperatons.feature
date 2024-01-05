﻿Feature: Calculator
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
Simple calculator for adding **two** numbers

Link to a feature: [Calculator](SpecFlowProject1/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

@mytag
Scenario: Subtract two numbers
	Given the first number is 100
	And the second number is 70
	When the two numbers are Subtracted
	Then the result should be 30

Scenario: Multiply two numbers
	Given the first number is 30
	And the second number is 20
	When the two numbers Multiply
	Then the result is multiplication 600

Scenario: Division two numbers
	Given the first number is 80
	And the second number is 20
	When the two numbers Divided
	Then the result is division 4