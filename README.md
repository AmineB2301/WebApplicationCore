# Bugs Management API

## REST API | ASP.NET CORE Web API C# | ASP.NET | .NET 5

## Project Status

**In Progress...**

## Overview

This project is a simple API for managing projects and tickets using ASP.NET Core and Entity Framework Core.

## Features

- **Projects**: Create, read, update, and delete projects.
- **Tickets**: Create, read, update, and delete tickets associated with projects.
- **In-Memory Database**: Utilizes an in-memory database for development and testing purposes.

## Technologies

- **ASP.NET Core**: Framework for building the web API.
- **Entity Framework Core**: ORM for database interactions.
- **In-Memory Database**: Used during development to simplify setup and testing.

## Setup

### Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/download) (version 6.0 or higher)

### Installation

1. Clone the repository:

   ```bash
   git clone https://github.com/AmineB2301/WebApplicationCore.git
   ```

2. Navigate to the project directory:

   ```bash
   cd WebApplicationCore
   ```

3. Restore the dependencies:

   ```bash
   dotnet restore
   ```

4. Build the project:

   ```bash
   dotnet build
   ```

5. Run the project:

   ```bash
   dotnet run
   ```

## Usage

- **Base URL**: `https://localhost:5001/api`

### Endpoints

- **Projects**

  - `GET /api/projects`: Retrieve all projects.
  - `GET /api/projects/{id}`: Retrieve a specific project by ID.
  - `POST /api/projects`: Create a new project.
  - `PUT /api/projects/{id}`: Update an existing project.
  - `DELETE /api/projects/{id}`: Delete a project.

- **Tickets**

  - `GET /api/tickets`: Retrieve all tickets.
  - `GET /api/tickets/{id}`: Retrieve a specific ticket by ID.
  - `POST /api/tickets`: Create a new ticket.
  - `PUT /api/tickets/{id}`: Update an existing ticket.
  - `DELETE /api/tickets/{id}`: Delete a ticket.

## License

This project is licensed under the [Non-Commercial License Agreement](LICENSE).
