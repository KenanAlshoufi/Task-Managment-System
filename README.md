# 🚀TaskFlow — Task Management System

![C#](https://img.shields.io/badge/C%23-512BD4?style=for-the-badge&logo=csharp&logoColor=white)
![.NET 8](https://img.shields.io/badge/.NET%208-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![ASP.NET Core](https://img.shields.io/badge/ASP.NET%20Core-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![SQL Server](https://img.shields.io/badge/SQL%20Server-CC2927?style=for-the-badge&logo=microsoftsqlserver&logoColor=white)
![REST API](https://img.shields.io/badge/REST%20API-005571?style=for-the-badge)
![Windows Forms](https://img.shields.io/badge/Windows%20Forms-0078D4?style=for-the-badge&logo=windows&logoColor=white)
![ADO.NET](https://img.shields.io/badge/ADO.NET-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![GitHub](https://img.shields.io/badge/GitHub-181717?style=for-the-badge&logo=github&logoColor=white)

TaskFlow is a modern task management system built with **C#**, **ASP.NET Core Web API**, **SQL Server**, and **Windows Forms**.

The project is designed around a **single backend API** that can serve multiple client applications.
The current client is a Windows Forms desktop application, while the architecture is ready for future web or mobile clients.

> **Plan. Track. Deliver.**

---

## 📋Overview

TaskFlow helps teams organize projects, assign tasks, monitor progress, manage priorities, and keep track of deadlines from one centralized system.

The project demonstrates:

- RESTful API design
- Layered architecture
- Client/server communication
- DTO-based data transfer
- Authentication and password hashing
- File upload/download
- SQL Server database design
- ADO.NET
- Async/Await
- Reusable Windows Forms controls

---

## ✨Main Features

### 🔐Authentication

- User login
- Secure password hashing
- User validation
- Role-based access structure

### 📁Project Management

- Create projects
- Update project information
- Assign users to projects
- View project details
- View project progress
- Add tasks to projects

### ✅Task Management

- Create tasks
- Update tasks
- Delete tasks
- Assign tasks to employees
- Set task priority
- Set task status
- Set due dates
- Track task progress
- Filter tasks by status

### 👥User Management

- Manage users
- Assign roles
- Assign users to projects
- Assign tasks to employees

### 📎File Handling

- Upload files/images to the server
- Download files/images through the API
- `multipart/form-data` support

### 📊Dashboard

The system is designed to display useful statistics such as:

- Total Tasks
- Completed Tasks
- Tasks In Progress
- Overdue Tasks
- Recent Tasks
- Project Progress

---

## 🏗️Architecture

TaskFlow follows a layered architecture.

```text
Windows Forms Client
        |
        | HTTP / JSON
        v
ASP.NET Core Web API
        |
        v
Business Layer
        |
        v
Data Access Layer
        |
        v
SQL Server
```

The client does **not** connect directly to the database.

All communication goes through the REST API.

---

## Solution Structure

```text
TaskFlow
│
├── TaskFlow.API
│   ├── Controllers
│   ├── Configuration
│   └── API Endpoints
│
├── TaskFlow.Business
│   ├── Users
│   ├── Projects
│   ├── Tasks
│   └── Security
│
├── TaskFlow.DataAccess
│   ├── UsersData
│   ├── ProjectsData
│   └── TasksData
│
├── TaskFlow.DTOs
│   ├── UserDTOs
│   ├── ProjectDTOs
│   └── TaskDTOs
│
└── TaskFlow.WinForms
    ├── Forms
    ├── UserControls
    ├── API
    ├── Services
    └── Resources
```

---

## 🛠️Technologies

### 💻Backend

- C#
- .NET 8
- ASP.NET Core Web API
- RESTful API
- ADO.NET
- Microsoft.Data.SqlClient
- System.Text.Json

### Database

- Microsoft SQL Server
- T-SQL
- Stored Procedures
- Foreign Keys
- Constraints
- Relational Database Design

### Client

- Windows Forms
- HttpClient
- Async / Await
- JSON Serialization / Deserialization
- Reusable UserControls

### 🔒Security

- ASP.NET Core `PasswordHasher`
- Password hashing and verification
- HTTPS-ready API architecture
- Authentication / Authorization structure

---

## 🗃️Database Design

Main tables include:

```text
Users
Roles
Projects
Tasks
Priorities
Statuses
Comments
Attachments
```

Example Task structure:

```text
TaskID
Title
Description
PriorityID
UserID
ProjectID
StatusID
CreatedBy
CreatedDate
DueDate
```

### Task Relationship

```text
User 1 -------- * Tasks

Project 1 ----- * Tasks

Priority 1 ---- * Tasks

Status 1 ------ * Tasks
```

A single employee can have multiple tasks, while each task is assigned to one employee.

---

## 🌐REST API

TaskFlow uses standard HTTP methods.

| Method | Purpose |
|---|---|
| `GET` | Retrieve data |
| `POST` | Create new data |
| `PUT` | Update existing data |
| `DELETE` | Delete data |

Example endpoints:

```http
GET    /api/users
GET    /api/users/{id}
POST   /api/users
PUT    /api/users/{id}
DELETE /api/users/{id}

GET    /api/projects
GET    /api/projects/{id}
POST   /api/projects
PUT    /api/projects/{id}
DELETE /api/projects/{id}

GET    /api/tasks
GET    /api/tasks/{id}
POST   /api/tasks
PUT    /api/tasks/{id}
DELETE /api/tasks/{id}
```

> Endpoint names may vary as development continues.

---

## 📦DTOs

The project uses **Data Transfer Objects (DTOs)** to separate internal application data from the data exposed through the API.

Example:

```csharp
public class TaskDTO
{
    public int TaskID { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string PriorityName { get; set; }
    public string StatusName { get; set; }
    public string ProjectName { get; set; }
    public string AssignedUserName { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime DueDate { get; set; }
}
```

DTOs are kept in a separate project so they can be reused where needed.

---

## 🔑Password Security

![Password Hashing](https://img.shields.io/badge/Security-Password%20Hashing-success?style=for-the-badge)
![HTTPS](https://img.shields.io/badge/Security-HTTPS-blue?style=for-the-badge)
![Authentication](https://img.shields.io/badge/Security-Authentication-purple?style=for-the-badge)

Passwords are never stored as plain text.

TaskFlow uses ASP.NET Core password hashing.

```csharp
public static string HashPassword(string password)
{
    return _hasher.HashPassword(null, password);
}
```

Password verification:

```csharp
public static bool VerifyPassword(
    string hashedPassword,
    string password)
{
    var result = _hasher.VerifyHashedPassword(
        null,
        hashedPassword,
        password);

    return result == PasswordVerificationResult.Success;
}
```

---

## File Upload

Files can be sent from the Windows Forms client to the API using:

```text
multipart/form-data
```

Client flow:

```text
File
 |
FileStream
 |
StreamContent
 |
MultipartFormDataContent
 |
HTTP POST
 |
API
```

The API receives uploaded files using `IFormFile`.

---

## HTTP Request / Response Flow

```text
Client
  |
  | HTTP Request
  |
  v
Web API
  |
  | Business Logic
  |
  v
Database
  |
  | Result
  |
  v
Web API
  |
  | HTTP Response
  |
  v
Client
```

The API returns HTTP status codes such as:

- `200 OK`
- `201 Created`
- `204 No Content`
- `400 Bad Request`
- `401 Unauthorized`
- `403 Forbidden`
- `404 Not Found`
- `409 Conflict`
- `500 Internal Server Error`

---

## User Interface

TaskFlow uses a dark navy and electric-blue visual identity.

Main UI areas include:

- Login
- Dashboard
- Projects
- Tasks
- Task Cards
- Project Cards
- User Management
- Filters
- Status indicators
- Priority indicators

### Status Colors

| Status | Color |
|---|---|
| To Do | Gray |
| In Progress | Blue |
| Completed | Green |
| Overdue | Red |

### Priority Colors

| Priority | Color |
|---|---|
| Low | Green |
| Medium | Orange |
| High | Red |

---

## Example Project

### E-Commerce Platform

Example tasks:

- Design Database
- Build REST API
- Implement User Authentication
- Create Product Management
- Implement Shopping Cart
- Build Order Management
- Add Payment Integration
- Create Admin Dashboard
- Implement Notifications
- Testing & Bug Fixing

---

## 🚀Getting Started

### Requirements

- Visual Studio 2022 or later
- .NET 8 SDK
- SQL Server
- SQL Server Management Studio

---

## 1. Clone the Repository

```bash
git clone https://github.com/KenanAlshoufi/TaskFlow.git
```


## 2. Configure the Database

Create the TaskFlow database in SQL Server.

Update the connection string used by the Data Access Layer.

Example:

```text
Server=.;
Database=TaskFlow;
Trusted_Connection=True;
TrustServerCertificate=True;
```

## 3. Run the API

Set the API project as the startup project and run it.

Example local address:

```text
https://localhost:5001/
```



## 4. Configure the Client

Update the API base address in the Windows Forms client.

```csharp
public static readonly HttpClient Client = new HttpClient
{
    BaseAddress = new Uri("https://localhost:5001/api/")
};
```

Then run the Windows Forms project.

---

## 🖼️Screenshots

<img width="1371" height="724" alt="image" src="https://github.com/user-attachments/assets/b44b83f5-9cdc-446f-b03e-8a481fe2d8fd" />
<img width="709" height="389" alt="image" src="https://github.com/user-attachments/assets/5078c64f-fb9b-4d8e-9191-b0c0b4d636c7" />




---

## 🗺️Roadmap

- [ ] Complete dashboard analytics
- [ ] Improve role-based authorization
- [ ] Add task comments
- [ ] Add task attachments
- [ ] Add notifications
- [ ] Add advanced search and filtering
- [ ] Add activity history
- [ ] Add project progress reports
- [ ] Add Web Client using the same backend
- [ ] Add automated API tests
- [ ] Improve logging and exception handling

---

## 📚What I Learned

This project helped me practice and understand:

- Building REST APIs with ASP.NET Core
- Request and response objects
- HTTP methods and status codes
- DTO architecture
- Layered application architecture
- Client/server communication
- Using HttpClient
- Async/Await
- SQL Server integration
- Password hashing
- File upload/download
- Reusable Windows Forms components
- Designing one backend for multiple client applications

---

## 🚧Project Status

> **Under active development**

The backend and Windows Forms client are being developed and improved continuously.

---

## 👨‍💻Author

**Kenan Alshoufi**

.NET Backend Developer

- GitHub: [KenanAlshoufi](https://github.com/KenanAlshoufi)
- LinkedIn: [Kenan Alshoufi](https://linkedin.com/in/kenan-al-shoufi)

---

## 📄License

This project is created for learning, portfolio, and demonstration purposes.

You may add an open-source license later if you want to allow reuse or contributions.

---

<p align="center">
  <b>TaskFlow</b><br>
  Plan. Track. Deliver.
</p>
