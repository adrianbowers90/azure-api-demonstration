# Azure API Demo (.NET 9 Web API)

A lightweight .NET 9 Web API built to demonstrate clean backend engineering practices, including REST API design, service-layer architecture, dependency injection, and API documentation using Swagger.

This project was built as a personal exercise to strengthen skills in backend development, cloud-ready architecture, and DevOps-aligned practices.

---

## Tech Stack

- .NET 9 (ASP.NET Core Web API)
- C#
- REST APIs
- Swagger / OpenAPI
- Dependency Injection
- xUnit (basic testing structure)
- Git & GitHub

---

## Features

- RESTful API endpoints
- Clean separation of concerns (Controllers / Services / Models)
- Swagger UI for testing endpoints
- Basic in-memory data handling
- Testable service-layer design
- GitHub-based version control

---

## API Endpoints

### Health Check

GET /health


### Tasks

GET /api/tasks
POST /api/tasks


Example POST request:
```json
{
  "title": "Example task",
  "isComplete": false
}


**Running the Project**

dotnet run


Then navigate to:
https://localhost:xxxx/swagger
