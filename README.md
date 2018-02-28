# Runner

## General Instructions (How to use)

1. Download the solution from Git (https://github.com/saleslessa/Runner)
2. Enter in project through file Runner.sln using Visual Studio 2017 (Or Visual Studio 2017 for MAC)
3. To execute project, hit F5 button and follow the console menu 

### Tools and dependencies:
- Visual Studio 2017 for Mac
- .NET Core SDK 2.0
- System.Linq
- MSTest Framework

## Design Patterns
- Unit Tests using AAA Pattern
- Methods implemented following SOLID and DRY principles

## Architecture
- The project was divided into 4 libraries with different responsibilities as described below:
	- **Runner**
		- Main project responsible for program execution.
	- **SequenceAnalysis**
		- Class library containing SequenceAnalysis class which is responsible for finding the uppercase words in a string, provided as input, and order all characters in these words alphabetically.
	- **SumOfMultiple** 
		- Class library containing SumOfMultiple class which is responsible for finding the sum of all natural numbers that are a multiple of 3 or 5 below a limit provided as input.
    - **Tests** 
        - Test project containing unit tests to cover all methods and scenarios of the project.
