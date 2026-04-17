[# Course](https://img.shields.io/badge/.NET-8.0-blueviolet  
https://img.shields.io/badge/Architecture-4--Tier-success  
https://img.shields.io/badge/AutoMapper-Enabled-orange  
https://img.shields.io/badge/EF%20Core-ORM-green  
https://img.shields.io/badge/License-MIT-lightgrey  
https://img.shields.io/badge/Status-Active-brightgreen

A clean and scalable ASP.NET Core Web API built using a professional 4‑tier architecture:

API Layer – Controllers, request/response models

Service Layer – Business logic, AutoMapper

Repository Layer – Data access abstraction

Data Layer – EF Core, DbContext, Entities

📁 Project Structure
Code
/ProjectName
 ├── ProjectName.API              → Controllers, API endpoints
 ├── ProjectName.Core             → Interfaces, DTOs, Entities
 ├── ProjectName.Infrastructure   → Repositories, EF Core, DbContext
 └── ProjectName.Services         → Business logic, AutoMapper profiles
🧩 Tech Stack
Component	Technology
Framework	ASP.NET Core 7 / 8
Architecture	4‑Tier (API → Service → Repository → Data)
ORM	Entity Framework Core
Mapping	AutoMapper
Docs	Swagger / OpenAPI
Language	C#

🛠️ Features
✔️ Repository Pattern

✔️ Service Layer Abstraction

✔️ AutoMapper for DTO ↔ Entity mapping

✔️ Clean separation of concerns

✔️ EF Core database operations

✔️ Swagger UI enabled

✔️ Fully testable architecture

⚙️ Setup Instructions
1️⃣ Clone the repository
bash
git clone https://github.com/yourname/yourproject.git
cd yourproject
2️⃣ Restore dependencies
bash
dotnet restore
3️⃣ Apply EF Core migrations
bash
dotnet ef database update
4️⃣ Run the API
bash
dotnet run
Swagger will be available at:

Code
https://localhost:5001/swagger
🌐 API Endpoints (Example: Categories)
Method	Endpoint	Description
GET	/api/categories	Get all categories
GET	/api/categories/{id}	Get category by ID
POST	/api/categories	Create category
DELETE	/api/categories/{id}	Delete category

🔄 AutoMapper Configuration
csharp
public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Category, CategoryDto>();
        CreateMap<CategoryCreateDto, Category>();
    }
}
🧱 Dependency Injection Setup
csharp
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddAutoMapper(typeof(MappingProfile));
🎯 Learning Goals
This project helps you understand:

Multi‑layer enterprise architecture

Repository + Service patterns

AutoMapper best practices

DTO‑driven API design

EF Core CRUD operations

Clean dependency injection

📄 License
MIT License — free for learning and personal use.)
