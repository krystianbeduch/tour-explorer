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
- Oracle Database 11g Release 2
- [Oracle.ManagedDataAccess 23.4](https://www.nuget.org/packages/Oracle.ManagedDataAccess/23.4.0) NuGet package

## Setup  
1. Clone or download the repository:
```sh
git clone https://github.com/YourUsername/TourExplorer.git
```
2. Open the project `TourExplorer.sln` in Visual Studio.
3. Check if the required NuGet package is installed - if not, install it, you can do it from the IDE or in the NuGet console:
```sh
Install-Package Oracle.ManagedDataAccess -Version 23.4.0
```
4. Run the `SetupDatabase.sql` script from the `Resources` folder to set up the database. The script includes tables and sample entries in them. 
In the `Klienci` and `Przewodnicy` tables (clients and guides), there are `Login` and `Haslo` (password) columns that can be used to log in to the client/admin panel. 
The password for a specific user is the same as his login. In the database, however, the password is stored as an MD5 hash.
5. Prepare the configuration file `DBConfig.xml` and place it in the `Config` folder:
```xml
<?xml version="1.0" encoding="utf-8" ?>
<DatabaseConfig>
    <DataSource>your_data_source</DataSource>
    <UserId>your_user_id</UserId>
    <Password>your_password</Password>
</DatabaseConfig>
```
6. Set up your Oracle database and enter the configuration details in the DBConfig.xml file.
7. Compile the project in Release mode.
<!--
```sh
dotnet publish -c Release -r win-x64 --self-contained
```
-->

## Usage
If you have properly configured the database, the `DBConfig.xml` configuration file, and compiled the application with the file, you can run the `TourExplorer.exe` app located in the `bin/Release` folder.

## Project Structure
### WelcomeForm
The start screen of the application, here we choose the method of login:
- as a guest `Gość`
- as a customer (registered user) `Klient`
- as administrator (tour guide) `Admin`
  
![WelcomeForm](https://github.com/krystianbeduch/tour-explorer/blob/main/TourExplorer/Resources/FormsScreenShots/WelcomeForm.png)

### LoginForm
User login window, analogous window we will see when we log in as administrators. Login attempt is made by pressing the `Zaloguj się` button. Use the `Anuluj` button to exit the window.

![LoginForm](https://github.com/krystianbeduch/tour-explorer/blob/main/TourExplorer/Resources/FormsScreenShots/LoginForm.png)

### UserToursForm
User window, here the customer can see the tours he is signed up for, he can write out from them by clicking on the appropriate button `Wypisz się z wycieczki`, go to the tour directory by clicking on `Przeglądaj katalog wycieczek`. 
The client can also log out by clicking on `Wyloguj się`, this will delete the current session.

![UserToursForm](https://github.com/krystianbeduch/tour-explorer/blob/main/TourExplorer/Resources/FormsScreenShots/UserToursForm.png)

### ToursCatalogForm
Catalog of available tours, if you are logged in as a customer you can sign up for a tour by clicking on the appropriate button `Zapisz się na wycieczkę`. Use the `Wyjdź z katalogu wycieczek` button to exit the catalog.

![ToursCatalogForm](https://github.com/krystianbeduch/tour-explorer/blob/main/TourExplorer/Resources/FormsScreenShots/ToursCatalogForm.png)

### AdminForm
- First button - editing the catalog of tours
- Second button - editing tours of specific customers
- Third button - logging out the administrator from the current session

![AdminForm](https://github.com/krystianbeduch/tour-explorer/blob/main/TourExplorer/Resources/FormsScreenShots/AdminForm.png)

### UserToursEditorForm
- First button - editing customer tours
- Second button - adding a new tour for the client 
- Third button - deleting the tours to which the selected client is enrolled.

![UserToursEditorForm](https://github.com/krystianbeduch/tour-explorer/blob/main/TourExplorer/Resources/FormsScreenShots/UserToursEditorForm.png)

### EditUsersToursForm
Window for editing customer tours, the admin can only change the content of the fields in the `Miejsce odbioru` column responsible for the pickup location.
Changes are saved only after pressing the `Zapisz zmiany` button. Use the `Wyjdź z edytora` button to exit the editor.

![EditUsersToursForm](https://github.com/krystianbeduch/tour-explorer/blob/main/TourExplorer/Resources/FormsScreenShots/EditUsersToursForm.png)

### AddTourForUserForm
Window to sign up a customer for a new tour. Tours and customers available from the select list. Click on `Dodaj` to sign up the customer for a tour. Use the `Anuluj` button to exit the window.

![AddTourForUserForm](https://github.com/krystianbeduch/tour-explorer/blob/main/TourExplorer/Resources/FormsScreenShots/AddTourForUserForm.png)

### DeleteTourFromUserForm
Window to write out a customer from his tours. First, select the customer from the selection list, after selecting their tours appear. Click on `Usuń` to write out the customer for a tour. Use the `Anuluj` button to exit the window.

![DeleteTourFromUserForm](https://github.com/krystianbeduch/tour-explorer/blob/main/TourExplorer/Resources/FormsScreenShots/DeleteTourFromUserForm.png)

### ToursCatalogEditorForm
- First button - editing existing tours in the catalog
- Second button - adding a new tour to the catalog
- Third button - deleting an existing tour from the catalog

![ToursCatalogEditorForm](https://github.com/krystianbeduch/tour-explorer/blob/main/TourExplorer/Resources/FormsScreenShots/ToursCatalogEditorForm.png)

### EditToursForm
Window for editing existing tours in the catalog, the administrator can change the content of the fields in the column `Nazwa wycieczki` and `Cena` responsible for the tour name and price respectively.
Changes are saved only after pressing the `Zapisz zmiany` button. Use the `Wyjdź z edytora` button to exit the editor.

![EditToursForm](https://github.com/krystianbeduch/tour-explorer/blob/main/TourExplorer/Resources/FormsScreenShots/EditToursForm.png)

### AddNewTourForm
Window for adding a new tours to the catalog. Here we enter the name of the tours and its price as an integer. Click on `Dodaj` to add tour. Use the `Anuluj` button to exit the window.

![AddNewTourForm](https://github.com/krystianbeduch/tour-explorer/blob/main/TourExplorer/Resources/FormsScreenShots/AddNewTourForm.png)

### DeleteTourForm
Window for removing tours from the catalog. We select the tours we want to delete from the selection list. Click on `Usuń` to delete tour. Use the `Anuluj` button to exit the window.

![DeleteTourForm](https://github.com/krystianbeduch/tour-explorer/blob/main/TourExplorer/Resources/FormsScreenShots/DeleteTourForm.png)