# School-Managment-System-Desktop-Application






















School Management System - User Manual

Table of Contents

3...........................................................................Introduction
4..............................................................Logging in to the application
5........................................................Creating a new account
6.............................................................Working with the application
7....................................................................Viewing data
8..........................................................................Entering data
9............................................................................Deleting data
10.......................................................................Updating data
11............................................................................Database

Introduction

The School Management System is an application designed to easily manage data for a school.

The SMS consists of two main parts: the database [Figure 1] and the application itself [Figure 2].

Figure 1 - School Management System/Dashboard
image

Figure 2 - SMS Database Diagram

Logging in to the application

To use the SMS, you need to enter your username and password after launching the application [Figure 3].

Figure 3 - Logging in to the application

If the username and password are correct, you will be redirected to the main page of the application, called "Main."

Creating a new account

If you are a new user or want to create a new account, click on the "Sign in" button at the bottom right of the login page [Figure 3].

Figure 4 - New User Creation Page

After filling in the necessary fields with the required information, you can create an account as an administrator (this will allow you to add, delete, and modify the admin privileges of other users).

Once a new user account is created, log in to the application [Figure 3].

Working with the application

On the main page, you will see:

    Quick menu - on the left side - with the names of commands you will use  :
        Dashboard (Display all controls)
        Courses (Display all courses)
        Students (Display all students)
        Teachers (Display all teachers)
        Countries (Display all countries)
        Subjects (Display all subjects within a course)
        Users (Display all users / note: this command will not be displayed if you are not logged in as an administrator)
    The open Dashboard page, which serves the same purpose as the quick menu  

Note: Working with the entire application and its data follows the same principles as in this example.

 

To enter, modify, or delete data, select an item from the quick menu or the Dashboard  .

Viewing data

All data related to a specific topic is presented in a table at the bottom of the page  .
At the top of the page, there are controls for:

    Entering data (top left)
    Deleting data (top center)
    Updating existing data from the list (top right)
    Search bar with additional filters on the right side [Drop-down menu / Right above the list]
    Refresh button and search button [Left above the list]

Viewing data is done similar to using a standard browser, with the use of filters.

Figure 6 - Data Management and Viewing Page

Entering data

Data entry is performed by clicking the "Add" button for the respective data type  .
This opens the data entry page  .
You need to fill in all the fields and then click the "Save" button at the bottom.
If everything is entered correctly, you will receive a confirmation message.
Otherwise, you will be notified of any missing or incorrect information  .

Figure 7 - New Data Entry Page
Figure 8 - Error in data entry

Deleting data

To delete data, select the item you want to delete from the list [Figure 6] and click the "Delete" button for the respective data type.
A confirmation prompt will appear  , and you must confirm the deletion if you are sure you want to delete something from the list.

 

Updating data

Updating data is done as follows:

    Select the data from the table
    Click the "Update" button for the respective data type [Figure 6]
    This opens a new page for updating [Figure 10].
    The process is similar to adding data:
    Fill in the fields
    Click the "Save" button
    If the entered data is not correct, you will be notified [Figure 11].

 

Database

The database used in the SMS is Microsoft SQL, which is a relational database consisting of 9 tables  .

 





