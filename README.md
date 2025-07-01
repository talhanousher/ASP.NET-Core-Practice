# Calculator Solution (.NET Learning Projects)

This repository contains a collection of beginner-to-intermediate level C#/.NET projects created as part of a structured learning journey.  
Each project focuses on different core concepts of C#, OOP, and ASP.NET Core Web APIs.

---

## 📦 Projects Included

### 1. 🧮 Calculator (Console App)
A basic console calculator to perform simple arithmetic operations.

- 📘 Concepts:
  - Console input/output
  - Type conversion
  - Control flow (`switch`, `if`)
  - Loops & program structure

- ✅ Bonus Features:
  - Looping support for repeated calculations
  - Operation history tracking

---

### 2. ✅ TaskManager (Console App with OOP)
A console-based task manager demonstrating Object-Oriented Programming in action.

- 📘 Concepts:
  - Classes, objects, properties, and methods
  - `List<T>` for task storage
  - CRUD-like operations via console
  - Clean separation of concerns

---

### 3. 🌐 TaskApi (ASP.NET Core Web API)
A full-featured RESTful API built with ASP.NET Core.

- 📘 Concepts:
  - Controllers and routing
  - Models and DTOs
  - Data annotations and validation
  - Service/Repository pattern
  - Swagger/OpenAPI for testing
  - Ready for EF Core & database integration

- ✅ Endpoints:
  - `GET /api/task`
  - `POST /api/task`
  - `PUT /api/task/{id}`
  - `DELETE /api/task/{id}`

---

## 🚀 How to Run the Solution

### Prerequisites
- [.NET SDK 6/7/8](https://dotnet.microsoft.com/download)
- Visual Studio 2022 or newer

### Run Individual Projects

```bash
# Navigate to project folder
cd TaskApi

# Restore and run
dotnet restore
dotnet run

Or, open the entire Calculator.sln solution in Visual Studio and run any project from the Solution Explorer.

Calculator.sln
│
├── Calculator/            # Console app: Basic calculator
├── TaskManager/           # Console app: OOP task management
├── TaskApi/               # ASP.NET Core Web API project
│   ├── Controllers/
│   ├── DTOs/
│   ├── Models/
│   └── Services/
└── README.md

By completing these projects, you will have practiced:

C# fundamentals

OOP concepts

ASP.NET Core APIs

Validation & DTOs

Code organization & architecture

👤 Author
Built with ❤️ by [Your Name]
GitHub: github.com/yourusername


---

## 🛠️ Next Steps

- Paste this `README.md` into the root of your repo (same level as `Calculator.sln`)
- Rename `Your Name` and GitHub links as needed
- Run `git add README.md && git commit -m "Add root README for solution"` and push

---

Would you like:
- A separate `README.md` inside each project folder (`TaskApi`, `TaskManager`, etc.)?
- Help preparing for Day 8 (Entity Framework Core)?
