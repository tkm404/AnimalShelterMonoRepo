# Animal Shelter

## Animal Shelter API
#### A web application that uses a home-made API. The app should have the following features:
* CRUD functionality for API commands
* Exploration of Pagination
* An MVC Front-End with Search capability (see Animal_Shelter_Client.Solution)

## Animal Shelter Client
#### A web application that consumes a home-made API. The app should have the following features:
* CRUD functionality for animals model.
* Exploration of Pagination
* Search functionality

#### By Thomas McDowell  

## Technologies Used:
* C#
* .NET 6.0
* MySql
* ASP.NET Core
* Entity Framework Core
* Pomelo Entity Framework Core
* HTML Helpers
* Swashbuckle API visualizer


## Description:
This is a web API built with VS Code for the 12th Independent Code Review for Epicodus Coding program. It features an additional web application that consumes and serves as the front end, and a database popluated with famous test-subject animals. A user should be able to see the animals in the database as a JSON response by issuing a GET command, add an animal with POST, update an animal with PUT, and delete an animal with DELETE.

For the MVC, a user should be able to see the animals in the database by using the various buttons to return views. Views are populated by sending GET, POST, PUT, or DELETE (and SEARCH, but that's really just GET again) to the API and database to pull information.

## Further Exploration:
I used this project as a means to explore Pagination. I ran into some issues on the API side of things, as documented in the commit history of these repos: Original draft of Animal_Shelter_API.Solution [https://github.com/tkm404/Animal_Shelter_API.Solution/commits/Pagination] / Original draft of Animal_Shelter_Client.Solution [https://github.com/tkm404/Animal_Shelter_Client.Solution/tree/PaginationSortingSearching]. Please exucse some scrambling of commits here, it was my first time committing to two repos in tandem.

Interestingly, though pagination didn't turn out as expected on the API side, it did work to return the correct number of entries per page on the Client side. 

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

```json
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*"
}

```

7. Navigate to the Client project's production directory called "AnimalShelterClient" in VS Code or your Terminal. 
8. Within the production directory "AnimalShelterClient", create a new file called `appsettings.json`.
9. Within `appsettings.json`, put in the following code

```json
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*"
}

```

## API Endpoints:
```
{
  GET 
  (production) https://localhost:7138/api/animals/
  (development) http://localhost:8492/api/animals/
    To return animals by species, breed, name, or age n or older:
    (.../animals?species=(text) .../animals?breed=(text) .../animals?name=(text) .../animals?minimumAge=(number))
    Combine queries with "&": .../animals?species=dog&name=laika

  GET (by ID)
  (production) https://localhost:7138/api/animals/{id}
  (development) http://localhost:8492/api/animals/{id}
    To return by ID, enter the number of ID you wish to find in place of {id}.

  POST 
  (production) https://localhost:7138/api/animals/
  (development) http://localhost:8492/api/animals/
    A body is requrired for POST requests. in JSON:

    {
      "name": "Laika",
      "species": "Dog",
      "breed": "Golden Retriever",
      "age": 4
    }

  PUT 
  (production) https://localhost:7138/api/animals/{id}
  (development) http://localhost:8492/api/animals/{id}
    Replace {id} with a number corresponding to an animal in the database
    A body is required for PUT requests, and the Animal Id must be included. In JSON:

    {
      "animalId": 1,
      "name": "Laika",
      "species": "Dog",
      "breed": "Golden Retriever",
      "age": 4
    }

  DELETE http://localhost:8492/api/animals/{id}
}
```


## Known Bugs:

I merged a branch used for further exploration of Pagination into my main branch. I got about half of it to work properly, but some features were still evading me by two days after submission. The good news is that the Animals Index view actually displays page 1-2 for my database of 4 animals (3 to a page). The bad news is that I haven't yet been able to get buttons to change the page to work. I did manage to make a Search feature from almost-scratch, as I got fed up with online tutorials, and repurposed the API's GET call (which already had sorting) to take a logic gate as an input. If the search bar was blank, return all animals. If the search bar had an integer and the "Minimum Age" category was selected, properly return the animals above the specified age. There is a caveat, in that the search terms do have to match up exactly with thier corresponding categories. It can't take partial entries... yet.


## License:
MIT Copyright (C) 2023 Thomas McDowell
