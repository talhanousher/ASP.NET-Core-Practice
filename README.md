# Task API

A simple ASP.NET Core Web API that lets you manage tasks with full CRUD operations.  
Built with clean architecture using services, DTOs, and validation.

---

## 🚀 Features

- ✅ Create, Read, Update, Delete (CRUD) tasks
- ✅ Input validation with Data Annotations
- ✅ Clean architecture using Repository/Service pattern
- ✅ DTOs for API contracts
- ✅ Swagger UI for testing endpoints
- ✅ Ready for Entity Framework Core integration

---

## 🧱 Tech Stack

- ASP.NET Core (.NET 6/8)
- C#
- Swagger / OpenAPI
- In-memory storage (replaceable with DB later)

---

## 📂 Project Structure

TaskApi/
├── Controllers/
│ └── TaskController.cs
├── DTOs/
│ ├── CreateTaskDto.cs
│ └── UpdateTaskDto.cs
├── Models/
│ └── TaskItem.cs
├── Services/
│ ├── ITaskService.cs
│ └── TaskService.cs
├── Program.cs
├── README.md
└── .gitignore


---

## 🧪 Testing the API

After running the project:

1. Navigate to: `https://localhost:5001/swagger`
2. Test these endpoints:
   - `GET /api/task`
   - `POST /api/task`
   - `PUT /api/task/{id}`
   - `DELETE /api/task/{id}`

---

## 🛠️ How to Run

```bash
# Restore dependencies
dotnet restore

# Run the app
dotnet run

Or just hit ▶️ in Visual Studio.

📦 Coming Soon
✅ EF Core Integration (SQLite / SQL Server)

✅ Async Methods

✅ Real database and persistence

✅ Unit Testing

🧑‍💻 Author
Made by Talha Nousher Ali