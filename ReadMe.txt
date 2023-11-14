CONTENTS OF THIS FILE
-------------------------------------

 * Introduction
 * Requirements
 * Installation
 * How to compile and run
 * Reference List

Please note: I am well aware that the software shall not persist the user data between runs and that the data shall only be stored in memory while the software is running.
AND
All classes are in the PartOneLibrary which is my CUSTOM CLASS LIBRARY( DLL FILE which I used in the PartOne application and called it using the "using System.PartOneLibrary as shown in the textbook and online on how to use a dll file in an application)
My application has errors and might not run but all the code is there!


INTRODUCTION
--------------------------

This application is for students who want to keep track of their modules and the hours they have on a specific module for a week. The first thing that needs to be done is for the user to open up the application. 


REQUIREMENTS
----------------------------

This application requires the following as input:

 * Users module information which includes ( module code, when they click the specific module code it will then automatically check in the database and fetch all of the corresponding information of that module, which will then populate in the text boxes, user will have to enter the semester weeks and start date)
 * Number of hours, module code and date (when submitting information to calculate the remaining hours for a specific module)



INSTALLATION
-----------------------

In order for the user to be able to use this application, they will need to install Visual Studio, any version will work, this is the link to the 2022 one(https://visualstudio.microsoft.com/vs/) 



HOW TO COMPILE AND RUN:
-----------------------------------------------

All that is needed to do to run this application is for the user to just look at the top of the page by the headings and then the user will see a green arrow and next to it, it says: IIS Express , the user must click that and the program will start running. Once the application is open and running a page will pop up on the browser they choose that will have a welcome message and two buttons. The user can either click the "LOG IN" button, if they have already logged in or the "SIGN UP" button to create some sort of profile. Depending on the button which they click, it will take them to the relevant next page. For the "LOG IN" button , they will be required to enter the username and password. After that information is provided and is correct ( checks in the database) a new page will open that says "Add new module". It will require the user to fill in the details and press the "SUBMIT" button once done. On the top of the page it consists of a navigation bar that will have the headings "AddModules", "Log Study Hours" and "ViewModules", this will give the user the opportunity to move along the different pages depending on what they would like to do.


REFERENCE LIST:
----------------------------

Microsoft Visual Studio 2019 https://www.techspot.com/downloads/7241-visual-studio-2019.html
ReadMe Template https://www.drupal.org/docs/develop/managing-a-drupalorg-theme-module-or-distribution-project/documenting-your-project/readme-template
GeeksForGeeks https://www.geeksforgeeks.org/
