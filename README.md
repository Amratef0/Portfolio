# 🧑‍💻 Portfolio Website

![.NET](https://img.shields.io/badge/.NET-8.0-512BD4?logo=dotnet)
![EF Core](https://img.shields.io/badge/EF%20Core-8-512BD4)
![SQL Server](https://img.shields.io/badge/SQL%20Server-LocalDB%20%2F%20Express-CC2927?logo=microsoftsqlserver&logoColor=white)
![License](https://img.shields.io/badge/License-MIT-green)

A personal developer portfolio website built with **ASP.NET Core MVC (.NET 8)**. It showcases projects, skills, and experience, and includes a dynamic contact form that saves visitor messages to a SQL Server database through **Entity Framework Core**. Data access follows the **Repository Pattern** for a clean separation from the controllers.

---

## 📌 Table of Contents

- [Tech Stack](#-tech-stack)
- [Features](#-features)
- [Architecture](#️-architecture)
- [Project Structure](#-project-structure)
- [Getting Started](#️-getting-started)
- [Contributing](#-contributing)

---

## 🚀 Tech Stack

| Technology | Purpose |
|---|---|
| [ASP.NET Core MVC](https://learn.microsoft.com/en-us/aspnet/core/mvc/) (.NET 8) | Web framework |
| [Entity Framework Core](https://learn.microsoft.com/en-us/ef/core/) v8 | ORM & database access |
| [SQL Server](https://www.microsoft.com/en-us/sql-server) (LocalDB / Express) | Relational database |
| C# / Razor Views | Backend logic & HTML templating |
| HTML5, CSS3, JavaScript | Frontend UI & interactivity |

---

## 🎯 Features

- **Home / Hero** — introduction and personal branding section
- **About** — skills, experience, and background
- **Projects** — showcase of built projects
- **Contact Form** — visitors can send messages; submissions are saved to the database through `IContactRepository`
- **Responsive Design** — mobile-friendly layout with CSS & JavaScript

---

## 🏗️ Architecture

The project uses the **Repository Pattern** to keep data access logic separate from the controllers, and dependencies are wired through ASP.NET Core's built-in dependency injection in `Program.cs`.

```
Controller → IContactRepository → ContactRepository → DbContext (EF Core) → SQL Server
```

| Interface | Implementation |
|---|---|
| `IContactRepository` | `ContactRepository` |

---

## 📁 Project Structure

```
Portfolio/
├── Controllers/          # MVC controllers (Home, Contact, ...)
├── Models/               # Entity models (Contact, ApplicationDbContext, ...)
├── Views/                # Razor view templates
├── Interfaces/
│   └── IContactRepository.cs   # Contact repository interface
├── Repositories/
│   └── ContactRepository.cs    # Contact data access implementation
├── Migrations/           # EF Core database migrations
├── wwwroot/              # Static files (CSS, JS, images, fonts)
├── Properties/           # Launch settings
├── Program.cs            # App entry point & dependency injection
├── appsettings.json      # Configuration & connection strings
└── Portfolio.csproj      # Project file & NuGet packages
```

---

## ⚙️ Getting Started

### Prerequisites

- **Visual Studio 2022** or later (or any editor with the .NET CLI)
- **.NET 8 SDK** — [Download here](https://dotnet.microsoft.com/download/dotnet/8.0)
- **SQL Server LocalDB** or **SQL Server Express**

### 1. Clone and restore

```bash
git clone https://github.com/Amratef0/Portfolio.git
cd Portfolio
dotnet restore
```

### 2. Configure the connection string

Update `appsettings.json` with your SQL Server connection string:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=PortfolioDB;Trusted_Connection=True;"
  }
}
```

### 3. Create the database

Run the EF Core migrations. In **Package Manager Console** (Visual Studio):

```powershell
Update-Database
```

Or with the .NET CLI:

```bash
dotnet ef database update
```

### 4. Run the app

```bash
dotnet run
```

Or press **F5** in Visual Studio. The app is available at `https://localhost:5001`.

---

## 🤝 Contributing

Contributions are welcome!

1. Fork the repository
2. Create a new branch: `git checkout -b feature/your-feature`
3. Commit your changes with clear messages
4. Submit a pull request

---

## 📜 License

This project is open source under the **MIT License**.

---

## 👤 Author

**Amr Atef** — [@Amratef0](https://github.com/Amratef0)
