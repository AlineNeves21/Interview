# Google Search Tests
## Overview
This is a UI test project where were made 2 tests.

## How to set up and execute the tests
You will need to clone this respository on your local repository, for this it is necessary to:
 - Create a folder where you will clone this;
 - Download visual studio or any other tool that supports *C#*;
 - Download git;

### How to clone
Go to the following page "https://github.com/AlineNeves21/Interview" and click on the green button *"Code"* and then click to copy the *"https"* link

![image](https://github.com/AlineNeves21/Interview/assets/29339551/d25c8a00-12a0-4c0a-9074-30f893f57762)

 - Open your local respository and with the right button click on *"Open Git Bash here"*
 - Put the following command on the git window that will open and press enter:
```
git clone + *(the copied link above)*
```
 - After the git finishes the cloning you can open the project solution.
 - The tests are on the *"GoogleSearch.cs"* file

### Are there any prerequisites?
On this project, besides having the tools said above and cloning the project, there are no prerequisites to run the tests

### How to execute the tests
Assuming you are on the *"GoogleSearch.cs"* file, you can just click with the right button e select *"Run tests"*.

## The tests design

### ValidateGoogleSearch
This test will open the google search page, search for a specific topic - in this case is *"uci kinoplex"* -, click on the search button and verify if the search brought a specific information, - in this case *"Programação UCI Kinoplex Independência"*.

### ClickOnAGoogleSearchAndValidatePage
This test will do what the above did plus will click the first link and verifying if the page changed by search for a specific text on the new page - in this case the text is *"PROGRAMAÇÃO"*.

### More details
The opened window will always be maximized and will always close at the end of the test.
To locate the informations on the screen it was used *CssSelector*.
