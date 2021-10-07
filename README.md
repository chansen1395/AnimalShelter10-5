# Project Name

#### This console application allows a user to enter Vendor information and Order information. The user can also view the information using the UI.

#### By Your Name Here

## Technologies Used

* C#
* .NET
* Razor
* HTML

## Description

_This application will run a web application. The user may navigate the site to enter information about vendors. Specific information about orders may be added to each vendor. The vendors and order information may be viewed by the user via intuitive site navigation._

## Setup/Installation Requirements

- _To clone and run from [GitHub Repo](https://github.com/chansen1395/REPO):_

- _Use a program such as VSCode to view, run, and test the program._

-_Constructing the database:_
  -_Using MySQL Workbench or a similar DBMS, follow the instructions to set up the database heirarchy:_
  1. _Create a database with the name:_ database_name
  
  2. _Create a table with the name:_ table_name01
    i. Parameter name: PrimaryKeyName01, datatype: int, primary key, auto-increment, ...
    ii. Parameter name: Parameter01, datatype: int, primary key, auto-increment, ...
    iii. Parameter name: Parameter02, datatype: VARCHAR(xyz), ...
    iv. Parameter name: ForeignKeyName01, datatype: int, ...
  
  3. _Create a table with the name:_ table_name02
    i. Parameter name: PrimaryKeyName01 (same as foreign key from Table01), datatype: int, primary key, auto-increment, ...
    ii. Parameter name: Parameter02, datatype: int, primary key, auto-increment, ...
    iii. Parameter name: Parameter03, datatype: VARCHAR(xyz), ...
  
- _In order to set up the project environment:_
  - _In bash at a folder of your choice, type the following:_
    1. $ git clone https://github.com/chansen1395/VendorTracker.Solution10-1
    2. $  code .
    3. Install packages if not already installed:
      i. $ dotnet add package Microsoft.EntityFrameworkCore -v 5.0.0
      ii. $ dotnet add package Pomelo.EntityFrameworkCore.MySql -v 5.0.0-alpha.2
      iii. $ dotnet add package Microsoft.EntityFrameworkCore.Proxies -v 5.0.0
    4. cd PROJECT/APPFOLDER
    5. $ dotnet restore
- _In order to run the program, follow along with the previous steps. After step 4, navigate to the PROJECTNAME/APP directory:_
    1. $ cd ../PROJECTNAME
    2. $ dotnet watch run
    3. _Navigate to http://localhost:5000/ in your browser.

- Create a file named "appsettings.json" in the BestRestaurants directory
  * add the following code to the appsettings.json file:

```
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=best_restaurants;uid=root;pwd=[YOUR-PASSWORD-HERE];"
  }
}
```
  * replace [YOUR-PASSWORD-HERE] with your unique MySql password
* Launch the MySql server:
  - In the terminal, run the command "$ mySql -uroot -p[YOUR-PASSWORD-HERE]", replacing [YOUR-PASSWORD-HERE] with your unique MySql password
* To Import the required database:
  - Open MySql Workbench
  - Select your preferred server(default is root)
  - In the "Navigator > Administration" window, select "Data Import/ Restore"
  - In "Import Options", select "Import From Self-Contained File"
  - Navigate to "BestRestaurants.Solutions/best_restaurants.sql" in the search input
  - Under "Default Schema to be Imported to" select the "New" button
  - Enter "best_restaurants" and click "OK"
  - Navigate to the "Import Progress" tab and click "Start Import" in the bottom right corner of the window
  - Reopen the "Navigator>Schemas" tab, Right click and select "refresh all" to see the imported database
* To Restore, build, and run the project:
  - Navigate to the BestRestaurants.Solutions/BestRestaurants folder in the command line or terminal
    - Run the command "$ dotnet restore" to restore the project dependencies
    - Run the command "$ dotnet build" to build and compile the project
    - Run the command "$ dotnet run" to build and compile the project


## Known Bugs

* _No Known Bugs._

## License

{Let me know if you run into any issues or have questions, ideas or concerns. I encourage you to contact me or make a contribution to the code.}

## Contact Information

- Connor Hansen: _{<chansen13@georgefox.edu>}_
- _{[GitHub Repo - main](https://github.com/chansen1395/VendorTracker.Solution10-1)}_