# Dependency Injection Microproject (ASP.NET Core)

This microproject demonstrates the core concept of **Dependency Injection (DI)** in ASP.NET Core.  
It shows how to use interfaces and services to build clean, scalable, and maintainable applications.

---

## 🚀 What This Project Teaches

- How Dependency Injection works in ASP.NET Core
- Registering services using:
  - `AddScoped()`
  - `AddTransient()`
  - `AddSingleton()`
- Injecting services into controllers
- Interface-based architecture
- Loose coupling and testability
- Cleaner, more maintainable code structure

---

## 🧱 Project Structure

/Services
- IUserServices.cs
- UserServices.cs

/Controllers
- UserServicesController.cs

/Views
- Home / Index.cshtml
- (MVC pages for demo)

  
---

## 🛠️ Tech Stack Used

- **C#**
- **ASP.NET Core MVC**
- **Dependency Injection (built-in DI container)**
- **Razor Views**

---

## 🧠 Key Learnings

- Why controllers should *not* create objects directly (`new`)
- How DI improves flexibility in real-world enterprise applications
- How to decouple logic using interfaces (`IUserServices`)
- How .NET automatically resolves dependencies through constructor injection

---

## ▶️ How to Run This Project

1. Clone the repository:
git clone https://github.com/hrishikeshkulat-cmd/dependency-injection-microproject.git

2. Open the solution in **Visual Studio**  
3. Restore NuGet packages  
4. Run the project using:

---



## 📚 Additional Notes

This microproject is part of my **.NET Microproject Series**, where each module focuses on one core backend concept:

✔ Dependency Injection  
⬜ EF Core CRUD  
⬜ Repository Pattern  
⬜ Middleware  
⬜ Logging  
⬜ Authentication  
⬜ APIs  

More incoming soon 🚀

---

## 👤 Author

**Hrishikesh Kulat**  
.NET Developer (Learning Path)  
