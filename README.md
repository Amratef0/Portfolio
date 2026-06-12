# 🧑‍💻 Portfolio Website

A personal developer portfolio website built with **ASP.NET Core MVC (.NET 8)**. Showcases projects, skills, and experience with a dynamic contact form that saves messages to a SQL Server database via Entity Framework Core. The project follows the **Repository Pattern** for clean data access separation.

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

## 📁 Project Structure

```
Portfolio/
├── Controllers/          # MVC Controllers (Home, Contact...)
├── Models/               # Entity models (Contact, ApplicationDbContext...)
├── Views/                # Razor view templates
├── Interfaces/
│   └── IContactRepository.cs   # Contact repository interface
├── Repositories/
│   └── ContactRepository.cs    # Concrete contact data access implementation
├── Migrations/           # EF Core database migrations
├── wwwroot/              # Static files (CSS, JS, images, fonts)
├── Properties/           # Launch settings
├── Program.cs            # App entry point & dependency injection
├── appsettings.json      # Configuration & connection strings
└── Portfolio.csproj      # Project file & NuGet packages
```

---

## ⚙️ Prerequisites

- **Visual Studio 2022** or later
- **.NET 8 SDK** — [Download here](https://dotnet.microsoft.com/download/dotnet/8.0)
- **SQL Server LocalDB** or **SQL Server Express**

---

## 🛠️ Installation

```bash
# 1. Clone the repository
git clone https://github.com/Amratef0/Portfolio.git
cd Portfolio
```

Open the solution in **Visual Studio 2022**, then restore NuGet packages automatically on build, or run:

```bash
dotnet restore
```

---

## 🔧 Configuration

Update `appsettings.json` with your SQL Server connection string:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=PortfolioDB;Trusted_Connection=True;"
  }
}
```

---

## 🗄️ Database Setup

Run migrations to create the database. In **Package Manager Console** (Visual Studio):

```powershell
Update-Database
```

Or via the .NET CLI:

```bash
dotnet ef database update
```

---

## ▶️ Running the App

```bash
dotnet run
```

Or press **F5** in Visual Studio. The app will be available at `https://localhost:5001`.

---

## 🎯 Features

- **Home / Hero** — Introduction and personal branding section
- **About** — Skills, experience, and background
- **Projects** — Showcase of built projects
- **Contact Form** — Visitors can send messages; submissions are saved to the database via `IContactRepository`
- **Responsive Design** — Mobile-friendly layout with CSS & JavaScript

---

## 🏗️ Architecture

The project uses the **Repository Pattern** to keep data access logic separate from the controllers:

```
Controller → IContactRepository → ContactRepository → DbContext (EF Core) → SQL Server
```

| Interface | Implementation |
|---|---|
| `IContactRepository` | `ContactRepository` |

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
