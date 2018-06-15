﻿Feature: AGameWithStrikes
	In order to calculate the score for a game of bowling
	As someone who has played a game of ten pin bowling and inputs the results
	I want to be told the score from my game


Scenario: A Game Where Every Frame Is A Strike
	Given I have the following score:
		| ScoreCard                          |
		| X\|X\|X\|X\|X\|X\|X\|X\|X\|X\|\|XX |
	When I request a final score 
	Then the result should be:
		| FinalScore |
		| 300        |

