# Tour Explorer
The project was created as part of my IT studies as part of desktop application programming classes. 
The project was to be realised in our chosen environment for developing window applications and implement a connection to a database and perform several operations on it.
I decided to go with Visual Studio, using the "Windows Forms Application" template, and used the Oracle database we used during our studies.

## General Info
TourExplorer is a desktop application for travel agency clients and guides. It allows you to:
- for clients (registered users):
    - access to tours for which the client is enrolled
    - possibility to review the catalog of tours and also sign up for a new tour
- for guides (administrators):
    - adding new tours, deleting and editing existing tours in the catalog
    - signing up client for tours, writing out client from tours, editing specific client tours

## Technologies
- .NET Framework 4.8
- C# 12
- Oracle Database
- [Oracle.ManagedDataAccess 23.4](https://www.nuget.org/packages/Oracle.ManagedDataAccess/23.4.0) NuGet package

## Setup  
1. Clone or download the repository:
```sh
git clone https://github.com/YourUsername/TourExplorer.git
```
2. Open the project in Visual Studio.
3. Install the required NuGet package - you can install extensions within the IDE:
```sh
Install-Package Oracle.ManagedDataAccess -Version 23.4.0
```
4. Run the `Resources/SetupDatabase.sql` script to set up the database.
5. Prepare the configuration file `DBConfig.xml` and place it in the `Config` directory:
```xml
<?xml version="1.0" encoding="utf-8" ?>
<DatabaseConfig>
    <DataSource>your_data_source</DataSource>
    <UserId>your_user_id</UserId>
    <Password>your_password</Password>
</DatabaseConfig>
```
6. Set up your Oracle database and enter the configuration details in the DBConfig.xml file.
7. Compile the project in Release mode:
```sh
dotnet publish -c Release -r win-x64 --self-contained
```

## Usage
## Project Structure


