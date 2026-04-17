# ASP.NET Core 4‑Tier Web API

![.NET](https://img.shields.io/badge/.NET-10.0-blueviolet)
![Architecture](https://img.shields.io/badge/Architecture-4--Tier-success)
![AutoMapper](https://img.shields.io/badge/AutoMapper-Enabled-orange)
![EF Core](https://img.shields.io/badge/EF%20Core-ORM-green)
![License](https://img.shields.io/badge/License-MIT-lightgrey)
![Status](https://img.shields.io/badge/Status-Active-brightgreen)

A clean and scalable **ASP.NET Core Web API** built using a professional **4‑tier architecture**.

---

## 📐 Architecture Overview

### **API Layer**
- Controllers  
- Request/Response Models  

### **Service Layer**
- Business Logic  
- AutoMapper Profiles  

### **Repository Layer**
- Data Access Abstraction  
- Repository Pattern  

### **Data Layer**
- EF Core  
- DbContext  
- Entities  

---

## 📁 Project Structure

/Dotnet-Core-Web-API-Course-Sample  
├── Course.API              → Controllers, Views  
├── Course.Business         → Interfaces, DTOs, Entities  
├── Course.Infrastructure   → Repositories, EF Core, DbContext  
└── Course.Domain           → Models, AutoMapper profiles  



---

## 🧩 Tech Stack

| Component     | Technology                     |
|---------------|--------------------------------|
| Framework     | ASP.NET Core  10             |
| Architecture  | 4‑Tier (API → Service → Repository → Data) |
| ORM           | Entity Framework Core          |
| Mapping       | AutoMapper                     |
| Docs          | Swagger                        |
| Language      | C#                             |

---

## 🛠️ Features

✔️ Repository Pattern  
✔️ Service Layer Abstraction  
✔️ AutoMapper for DTO ↔ Entity mapping  
✔️ Clean separation of concerns  
✔️ EF Core CRUD operations  
✔️ Swagger UI enabled  
✔️ Fully testable architecture  

---

## ⚙️ Setup Instructions

### **1️⃣ Clone the repository**
```
git clone https://github.com/ribasmohaideen/Dotnet-Core-Web-API-Course-Sample.git
cd Dotnet-Core-Web-API-Course-Sample
```
### **2️⃣ Restore dependencies**
```
dotnet restore
```
### **3️⃣ Apply EF Core migrations**
```
dotnet ef database update
```
### **4️⃣ Run the API**
```
dotnet run
```
Swagger will be available at:
https://localhost/swagger

---

## 🌐 API Endpoints (Categories)

| Method| Endpoint              | Description       |
|-------|-----------------------|-------------------|
|GET    | /api/categories	      | Get all categories|
|GET    | /api/categories/{id}  |	Get category by ID|
|POST  	| /api/categories       |	Create category   |
|PUT   	| /api/categories       |	Update category   |
|DELETE | /api/categories/{id}  |	Delete category   |

---

## 🔄 AutoMapper Configuration  
```
public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Category, CategoryDto>();
        CreateMap<CategoryCreateDto, Category>();
    }
}
```

---

## 🧱 Dependency Injection Setup
```csharp
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddAutoMapper(typeof(MappingProfile));
```

---

## 🎯 Learning Goals
This project helps you understand:

✔️ Multi‑layer enterprise architecture  
✔️ Repository + Service patterns  
✔️ AutoMapper best practices  
✔️ DTO‑driven API design  
✔️ EF Core CRUD operations  
✔️ Clean dependency injection  

---


## 📄 License
MIT License — free for learning and personal use.
