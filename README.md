# PharMedTOGO
The fastest way to receive your medicines!

![.NET 10.0](https://img.shields.io/badge/.NET-10.0-512BD4?logo=dotnet&logoColor=white)
![Docker](https://img.shields.io/badge/Docker-Enabled-2496ED?logo=docker&logoColor=white)
![SQL Server](https://img.shields.io/badge/SQL_Server-LocalDB-CC2927?logo=microsoft-sql-server&logoColor=white)
![Stripe](https://img.shields.io/badge/Stripe-Integrated-635BFF?logo=stripe&logoColor=white)
![GitHub Actions](https://img.shields.io/badge/GitHub_Actions-CI-2088FF?logo=github-actions&logoColor=white)

PharMedTOGO is an online pharmacy web application built on **.NET 10.0** and **ASP.NET Core MVC**. 

---

## Key Tech Stack & Features

* **Framework:** Migrated to **.NET 10.0**.
* **Database:** EF Core 10 with SQL Server (LocalDB for local development, SQL Server container for Docker).
* **Payment Integration:** Stripe payment platform.
* **Authentication:** ASP.NET Core Identity with external Google Login integration.

---

## Getting Started Locally

### 1. Configuration (`.env`)

*The application automatically loads `.env` settings into process environment variables and maps them directly to nested ASP.NET Core configurations (`web:client_id`, `StripeSettings:SecretKey`, etc.) via `builder.Configuration.AddEnvFile()` on startup.*

### 2. Build and Run Local Host
To compile and run the application locally outside of Docker:
```bash
# Build solution
dotnet build PharMedTOGO.slnx

# Run MVC Web Project
dotnet run --project PharMedTOGO.Web/PharMedTOGO.Web.csproj
```

### 3. Run Unit Tests
A suite of **24 unit tests** runs entirely in-memory using SQLite:
```bash
dotnet test PharMedTOGO.slnx
```

---

## Running in Docker Compose

The Docker environment is consolidated into a single, clean `docker-compose.yml` file.

To build and start the containerized database and web app:
```bash
docker compose up -d --build
```

### Accessing the Web App:
* **HTTP Endpoint:** [http://localhost:8001](http://localhost:8001)

---

## Roles and Functionalities

* **Anonymous Users:** Can browse medicines and view their details.
* **Patients:** Can browse medicines, manage their shopping carts (adding prescription medicines requires a validated prescription), and proceed to checkout using the Stripe integration.
* **Administrators:** Have access to the Admin Dashboard (caching enabled) to perform CRUD operations on medicines, manage active sales, see registered users, promote users to admin roles, and validate patient prescriptions.
