# AnimalShelter.Solution API

#### By **Anastasia Han**

#### An API to help organize animals in a shelter.

## Technologies Used

- C#
- NET 5.0
- dotnet
- MySQL
- Entity Framework
- Swashbuckle.AspNetCore

## Description

This is an API to help organize animals in a shelter.

## Setup/Installation Requirements

- Clone repository.
- Open code in your preferred code editor
- Run "dotnet ef migrations update" to create a local instance of the database.
- Create an appsettings.json file in the/AnimalShelter directory, and input the code { "ConnectionStrings": { "DefaultConnection": "Server=localhost;Port=3306;database=anastasia_han;uid=root;pwd=[YOUR-PASSWORD];" } }
- Make sure to replace 'YOUR-PASSWORD' with your MySQL Workbench password.
- Run "dotnet build"
- Run "dotnet run"

## API Documentation
API endpoints can be used in Postman or on your preferred brower. Once the API is running you can also go to <code>[Your-server-address]/swagger</code>.  
* Example: <code>http://localhost:5001/swagger</code>

No authentication is needed to use CRUD functionalities.

### Endpoints
Base URL: http://localhoust:5001

HTTP Request structure
```
GET /api/Animals
POST /api/Animals
GET /api/Animals/{id}
PUT /api/Animals/{id}
DELETE /api/Animals/{id}
```

Example query
```
https://localhost:5001/api/animals/1
```

Example Response
```
{
  "animalId": 1,
  "name": "Nyangs",
  "species": "Cat",
  "age": 3,
  "gender": "Male",
}
```

## Known Bugs

- N/A

## License
MIT

Copyright (c) _04/26/2022_ _Anastasia Han_
