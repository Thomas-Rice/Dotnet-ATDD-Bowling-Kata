Feature: AGameWithMisses
	In order to calculate the score for a game of bowling
	As someone who has played a game of ten pin bowling and inputs the results
	I want to be told the score from my game


Scenario: A game that has the bowler miss for one of the two bowls per frame
	
	Given I have the following score:
		| ScoreCard                                   |
		| 9-\|9-\|9-\|9-\|9-\|9-\|9-\|9-\|9-\|9-\|\|3 |  
	When I request a final score 
	Then the result should be:
		| FinalScore |
		| 93         |

Scenario: A game that has the bowler miss for one round
	Given I have the following score:
		| ScoreCard                                  |
		| 9-\|11\|11\|11\|11\|11\|11\|11\|11\|11\|\| |  
	When I request a final score 
	Then the result should be:
		| FinalScore |
		| 27         |




#Scenario: A Mixed Game
#	Given I have the following score:
#		| ScoreCard                                  |
#		| X\|7/\|9-\|X\|-8\|8/\|-6\|X\|X\|X\|\|81 |  
#	When I request a final score 
#	Then the result should be:
#		| FinalScore |
#		| 167        |