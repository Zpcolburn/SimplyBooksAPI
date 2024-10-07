<h1 align="center" style="font-weight: bold;">Simply Books API</h1>

<p align="center">
 <a href="#tech">Technologies</a> • 
 <a href="#started">Getting Started</a> • 
  <a href="#routes">API Endpoints</a> 
</p>

<p align="center">
    <b>The SimplyBooks API is a RESTful service that powers a fictional online bookstore, enabling users to browse, and manage. This API provides full CRUD (Create, Read, Update, Delete) functionality for books and authors, allowing complete control over the bookstore's catalog and author profiles.

Key functionalities supported by the API include:

Full CRUD operations on books and authors
This documentation outlines the API endpoints, request and response formats, and usage examples. It adheres to REST principles and returns data in JSON format. You can interact with the API using the provided Postman collection to explore the endpoints in depth.</b>
</p>

<h2 id="technologies">💻 Technologies</h2>

- list of all technologies you used
- C#
- .NET
- Postman
- SQL

<h2 id="started">🚀 Getting started</h2>

<h3>Prerequisites</h3>

Here you list all the prerequisites necessary for running your project. For example:

- [Visual Studio](https://visualstudio.microsoft.com/downloads/)
- [.NET](https://learn.microsoft.com/en-us/dotnet/framework/install/on-windows-11)
- [pgAdmin](https://www.pgadmin.org/download/)

<h3>Cloning the Repository</h3>

Clone this repo by copying and pasting this command into your terminal 
git clone git@github.com:Zpcolburn/SimplyBooksAPI.git

<h3>Install Required Packages</h3>
Once the repository is cloned, go to the project directory in your terminal and run the following commands to install necessary packages:
dotnet add package Npgsql.EntityFrameworkCore.PostgreSQL --version 6.0
dotnet add package Microsoft.EntityFrameworkCore.Design --version 6.0

<h3>Set up Secrets for PostgreSQL</h2>
To initialize the secrets use the following command:
dotnet user-secrets init

Then set the connection string, make sure to replace the password section with your password for PostgreSQL:
dotnet user-secrets set "SimplyBooksAPIDbConnectionString" "Host=localhost;Port=5432;Username=postgres;Password=<your_postgresql_password>;Database=SimplyBooksAPI"

<h3>Migrations</h3>
Run this comand to apply migrations:
dotnet ef database update

<h3>Starting</h3>
At the top of visual studio you will see a green play button, make sure it says HTTPS if not change it in the drop down. 
If it says HTTPS click the green play button, Swagger will load automatically and you can see all the API calls 

<h2 id="routes">📍 API Endpoints</h2>

Here you can list the main routes of your API, and what are their expected request bodies.
​
| route               | description                                          
|----------------------|-----------------------------------------------------
| <kbd>GET /authors</kbd>     | retrieves all Authors 
| <kbd>GET /authors/{id}</kbd>     | retrieves a single Author info
| <kbd>POST /authors</kbd>     | creates a new Author
| <kbd>PUT /authors/{id}</kbd>     | edit a single Author
| <kbd>DELETE authors{id}</kbd>     | deletes a single Author 
| <kbd>GET /books</kbd>     | retrieves all Books
| <kbd>GET /books/{id}</kbd>     | retrieves single Book info 
| <kbd>POST /books</kbd>     | creates a new Book
| <kbd>PUT /books/{id}</kbd>     | edit a single Book 
| <kbd>DELETE /books/{id}</kbd>     | Deletes a single Book 


<h3>Documentations that might help</h3>

[Postman Documentation](https://documenter.getpostman.com/view/31920812/2sAXxP9CfF)
