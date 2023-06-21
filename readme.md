# OracleFTW

**OracleFTW** is a .NET 7 Web API that provides a functional CRUD (Create, Read, Update, Delete) interface for Oracle 11g. This project serves as a template for future projects requiring similar functionality with Oracle databases.

## Project Structure

The project consists of two main layers:

1. API Layer (`ApiLayer`):
   - Responsible for handling HTTP requests and routing.
   - Implements basic routing for the CRUD operations.
   - Utilizes Swagger for API documentation.

2. Data Layer (`DataLayer`):
   - Contains interfaces and implementations for data access.
   - Includes the following components:
     - `IRepository`: Interface defining common database operations.
     - `IStudentService`: Interface defining operations specific to the `Student` entity.
     - `Student` Model: Represents the `Student` entity with its properties.
     - `Repository` and `StudentService`: Implementations of the interfaces.
     - `DataFactory`: A static public class that serves as a centralized access point for the data layer components.

## Getting Started

1. Clone the repository.
2. Set up the Oracle 11g database and ensure it is accessible.
3. Configure the connection string in the `DataLayer` path: `/Repository/Database.cs` and edit the connection string. *(i will make use of the application.json in future :) )*
5. Build and run the project.
6. Access the API endpoints using a tool like Postman or Open the `[Swagger UI](https://localhost:7196/swagger/index.html)`
7. Refer to the Swagger documentation for detailed API specifications.

## Dependencies

The project has the following dependencies:

- .NET 7
- Oracle.ManagedDataAccess.Core
- Swashbuckle.AspNetCore (Swagger)

## Usage

1. Make sure the API project is running.
2. Access the API endpoints according to the defined routes and HTTP methods.
3. Refer to the Swagger documentation for detailed usage instructions.

![Swagger UI](https://i.imgur.com/5OfzU5C.png)
