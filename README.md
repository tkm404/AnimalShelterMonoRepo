# Animal Shelter

#### A web application that uses a home-made API. The app should have the following features:
* CRUD functionality for API commands
* Exploration of Pagination
* An MVC Front-End with Search capability (see Animal_Shelter_Client.Solution)

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
This is a web API built with VS Code for the 12th Independent Code Review for Epicodus Coding program. It features a database popluated with famous test-subject animals. A user should be able to see the animals in the database as a JSON response by issuing a GET command, add an animal with POST, update an animal with PUT, and delete an animal with DELETE.

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

```
{
  GET http://localhost:8492/api/animals/
    To return animals by species, breed, name, or age n or older:
    (.../animals?species=(text) .../animals?breed=(text) .../animals?name=(text) .../animals?minimumAge=(number))
    Combine queries with "&": .../animals?species=dog&name=laika

  GET http://localhost:8492/api/animals/{id}

  POST hhtp://localhost:8492/api/animals/
    A body is requrired for POST requests. in JSON:

    {
      "name": "Laika",
      "species": "Dog",
      "breed": "Golden Retriever"
      "age": 4
    }

  PUT http://localhost:8492/api/animals/{id}
    A body is required for PUT requests, and the Animal Id must be included. In JSON:

    {
      "animalId": 1,
      "name": "Laika",
      "species": "Dog",
      "breed": "Golden Retriever"
      "age": 4
    }

  DELETE http://localhost:8492/api/animals/{id}
}
```

## Known Bugs:

There is a second branch in this repository that explores Pagination. Unfortunately, I wasn't able to get everything to work on this end, as I discovered that many of the online tutorials and resources I found involved recreating this project in a different format than I'm used to, and by the point I made that discovery, I wasn't about to start from scratch. There should be some commit history on that branch, as I ran into issues with having to go back and making a "DAL," or "Data Access Layer", and both "Repository" and "IRepository" folders. These items would have effectively undone what I had just spent the first half of my day doing and involved making a View folder on the API side of my project... which I was using in my MVC API-consuming app. I ran out of time to reconcile the issues between the projects, but I did manage to get some Search functionality working on the MVC end!


## License:
MIT Copyright (C) 2023 Thomas McDowell

## Database Structure
![image of schema connections]
