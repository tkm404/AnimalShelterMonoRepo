# Animal Shelter

#### A web application that uses a home-made API. The app should have the following features:
* (Filler for now)
* (Secondary Objective)
* (Tertiary Objective)

#### By Thomas McDowell  

## Technologies Used:
* C#
* .NET 6.0
* MySql
* ASP.NET Core
* Entity Framework Core
* Pomelo Entity Framework Core
* HTML Helpers
* Custom Tag Helpers
* ASP.NET Identity

## Description:
This is a web application built with VS Code for the 11th Independent Code Review for Epicodus Coding program. There is a demonstration of a Many-to-Many relationship between Treats and Flavors, and an authorization level between general users, customers, and administrators. Administrators have control over the Create, Delete, and Update functions for Flavors and Treats. Customers and non-roled users have Read functionality. An unauthorized user will be redirected to an Access Denied page if they try to Create, Delete or Update.

## Setup/Installation Req's:

### Set Up and Run Project
1. Clone this repo.
2. Open the terminal and navigate to this project's production directory called "AnimalShelterApi". 
3. Within the production directory "AnimalShelterApi", create a new file called `appsettings.json`.
4. Within `appsettings.json`, put in the following code, replacing the `uid` and `pwd` values with your own username and password for MySQL. For the LearnHowToProgram.com lessons, we always assume the `uid` is `root` and the `pwd` is `epicodus`.

```json
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=animal_shelter_api;uid=[YOUR SQL USERNAME];pwd=[YOUR SQL PASSWORD];"
  }
}
```

5. Set up the Database. In your terminal in the project directory (Animal_Shelter_Api.Solution/AnimalShelterApi), run ```dotnet ef database update```

6. Run ```dotnet watch run``` to view the project in your web browser. Enter your computer password when prompted.


### Endpoints:
{
  GET hhtp://localhost:8492/api/animals/
  GET hhtp://localhost:8492/api/animals/{id}
  POST hhtp://localhost:8492/api/animals/
  PUT hhtp://localhost:8492/api/animals/{id}
  DELETE hhtp://localhost:8492/api/animals/{id}
}

## Known Bugs:


## License:
MIT Copyright (C) 2023 Thomas McDowell

## Database Structure
![image of schema connections]