# School Management System - Desktop Application


![0](https://github.com/BorisPaunovic/School-Managment-System-Desktop-Application/assets/119711363/098d7ef4-c392-4885-9f73-9076b2ee4ed8)

## Build and Run Instructions

### Prerequisites

Before you begin, ensure you have the following prerequisites installed:

- [Visual Studio](https://visualstudio.microsoft.com/): The project is developed using C# with the .NET Framework.
- [Microsoft SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads): Required for the database component.
-[.Net Framework](https://support.microsoft.com/en-us/topic/microsoft-net-framework-4-8-offline-installer-for-windows-9d23f658-3b97-68ab-d013-aa3c3e7495e0)
### Clone the Repository

```bash
git clone https://github.com/your-username/School-Managment-System-Desktop-Application.git
```
## Build the Solution
### Visual Studio

   1. Open the project in Visual Studio.
   2. Build the solution by pressing Ctrl + Shift + B or navigating to Build > Build Solution in the menu.

### CMD Alternative
```
cd path/to/your/project

# Build the solution
dotnet build

# Run the application
dotnet run
```
## Configure Database Connection
  ### Visual Studio
   1. Open the project in Visual Studio.
   2. Navigate to the App.config file in the project.
   3. Locate the connection string in Settings1.settings file and modify it according to your SQL Server configuration.
```
 
﻿<?xml version='1.0' encoding='utf-8'?>
<SettingsFile xmlns="http://schemas.microsoft.com/VisualStudio/2004/01/settings" CurrentProfile="(Default)" GeneratedClassNamespace="SchoolDAL" GeneratedClassName="Settings1">
  <Profiles />
  <Settings>
    <Setting Name="ConnectionString" Type="(Connection string)" Scope="Application">
      <DesignTimeValue Profile="(Default)">&lt;?xml version="1.0" encoding="utf-16"?&gt;
&lt;SerializableConnectionString xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema"&gt;
  &lt;ConnectionString&gt;Data Source= *********YOUR SERVER*********;Initial Catalog=SchoolDB;Integrated Security=True&lt;/ConnectionString&gt;
  &lt;ProviderName&gt;System.Data.SqlClient&lt;/ProviderName&gt;
&lt;/SerializableConnectionString&gt;</DesignTimeValue>
      <Value Profile="(Default)">Data Source= *********YOUR SERVER********* ;Initial Catalog=SchoolDB;Integrated Security=True</Value>
    </Setting>
  </Settings>
</SettingsFile>
```
### CMD Alternative

Use your preferred text editor to edit the Settings1.settings file.

```
notepad path/to/your/project/Settings1.settings
```
## Run the Application
### Visual Studio
  1. Set the startup project to the main application.
  2. Press F5 or select Debug > Start Debugging from the menu.

### CMD Alternative

Navigate to the project's executable directory and run the application.

```
cd path/to/your/project/bin/Debug
YourApplicationName.exe

///////////////
OR
//////////////

cd path/to/your/project

# Build the solution
dotnet build

# Run the application
dotnet run
```
## Access the Application

Once the application is running, log in with your credentials and start using the School Management System directly within the application.

# User Manual

The School Management System is a comprehensive application designed to streamline school data management. This repository contains the source code for a desktop application developed in C# using the .NET Framework. The system consists of two main components: the database (Microsoft SQL) and the desktop application itself.

## School Management System/Dashboard




## Logging in to the Application

To access the School Management System, launch the application and enter your username and password on the login page.

![4](https://github.com/BorisPaunovic/School-Managment-System-Desktop-Application/assets/119711363/bb91d1fe-f660-42a5-967d-a4c6a7f47e7a)


Figure 1 - Logging in to the application

Upon successful login, you will be redirected to the main page, known as "Main."
Creating a New Account

New users can create an account by clicking the "Sign in" button on the login page.

## New User Creation Page


![6](https://github.com/BorisPaunovic/School-Managment-System-Desktop-Application/assets/119711363/b4de88e3-653f-401b-9f60-e29d27551ed9)

Figure 2 - New User Creation Page

Fill in the required information to create an account, and choose the option to be an administrator if needed. Afterward, log in to the application.

## Working with the Application

The main page provides a quick menu on the left side, displaying commands such as Dashboard, Courses, Students, Teachers, Countries, Subjects, and Users (visible only for administrators). The Dashboard page serves the same purpose.

## Main Page

![7](https://github.com/BorisPaunovic/School-Managment-System-Desktop-Application/assets/119711363/8a17dc86-338f-4d97-a2f5-40c2b73599cd)

Figure 3 - Main Page

## Viewing Data

Data related to specific topics is presented in tables at the bottom of the page. Controls for entering, deleting, and updating data are available at the top. A search bar with filters enhances the data viewing experience.

## Data Management and Viewing Page
![8](https://github.com/BorisPaunovic/School-Managment-System-Desktop-Application/assets/119711363/302cc6f6-087f-4728-83e1-f9b749f54cc7)


Figure 4 - Data Management and Viewing Page

## Entering Data

To add new data, click the "Add" button for the respective data type. Fill in all required fields on the data entry page and click "Save." Confirmation or error messages will guide you.

New Data Entry Page


![9](https://github.com/BorisPaunovic/School-Managment-System-Desktop-Application/assets/119711363/45b9b2a6-c814-405e-b317-696594fb5900)


Figure 5 - New Data Entry Page

## Deleting Data

Select the item to delete from the list and click the "Delete" button for the respective data type. Confirm the deletion when prompted.

![13](https://github.com/BorisPaunovic/School-Managment-System-Desktop-Application/assets/119711363/d67c3983-2f29-43ca-9ebd-616746281d19)

Figure 6 -Delete entry prompt
## Updating Data

Updating data involves selecting the item from the table, clicking the "Update" button, and modifying the fields on the update page. Save the changes, and error notifications will guide you if needed.

![14](https://github.com/BorisPaunovic/School-Managment-System-Desktop-Application/assets/119711363/6c397dde-6241-4c1b-8749-3090f814366e)

Figure 7 -   Data Updating Page

## Database

The School Management System utilizes Microsoft SQL as its relational database, comprising nine tables for efficient data organization.
SMS Database Diagram

![1](https://github.com/BorisPaunovic/School-Managment-System-Desktop-Application/assets/119711363/f61bd198-60d3-4601-894f-2a8ceb6e1ae3)

Figure 8 - SMS Database Diagram
For more information, refer to the detailed [Database Documentation](https://github.com/BorisPaunovic/School-Database).

## Issues and Contributions

If you encounter any issues or would like to contribute, please open an issue or fork the repository and submit a pull request.
