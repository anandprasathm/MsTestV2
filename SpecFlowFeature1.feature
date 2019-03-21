Feature: Sample Feature
	

@mytag
Scenario Outline: Google Search
	Given I launch Google Search Engine
	And I have entered the <SearchValue>
	Then I press Enter
	
	Examples: 
	| SearchValue |
	| Specflow    |
	| MsTest      |
	| SpecRun     |
	| UnitTest    |

