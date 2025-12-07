```markdown
# Employee Admin Portal API

A simple ASP.NET Core Web API for managing employee data using MySQL and Entity Framework Core.

---

## 📦 Getting Started

### 📥 Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/download)
- [MySQL Server](https://dev.mysql.com/downloads/mysql/)
- [MySQL Workbench](https://dev.mysql.com/downloads/workbench/)
- [Visual Studio](https://visualstudio.microsoft.com/) (or any other C# IDE)

---

## 🛠️ Installation

1. Clone the repository:
   ```bash
   git clone https://github.com/yourusername/employee-admin-portal.git
   ```

2. Open the project in Visual Studio.

3. Update the connection string in `appsettings.json` with your MySQL credentials:
   ```json
   "ConnectionStrings": {
     "DefaultConnection": "Server=localhost;Port=3306;Database=employeesdb;User=root;Password=yourpassword;"
   }
   ```

4. Install required NuGet packages:
   ```bash
   Install-Package Pomelo.EntityFrameworkCore.MySql
   Install-Package Microsoft.EntityFrameworkCore.Tools
   ```

5. Run migrations:
   ```bash
   Add-Migration InitialMigration
   Update-Database
   ```

---

## 🧱 Project Structure

- `Controllers/` - Contains the API controllers
- `Models/Entities/` - Contains the entity classes (e.g., `Employee`)
- `Models/DTOs/` - Contains the Data Transfer Objects (e.g., `AddEmployeeDto`, `UpdateEmployeeDto`)
- `Data/` - Contains the `ApplicationDbContext` class
- `Program.cs` - The entry point of the application
- `appsettings.json` - Contains the connection string and other configurations

---

## 🚀 Running the API

1. Start the application:
   ```bash
   dotnet run
   ```

2. Open your browser and navigate to:
   ```
   https://localhost:xxxx/swagger
   ```

3. Use Swagger UI to test the API endpoints.

---

## 📦 Endpoints

### 🧾 GET /api/employees
- Returns a list of all employees.

### 🧾 GET /api/employees/{id}
- Returns a single employee by ID.

### 🧾 POST /api/employees
- Creates a new employee.

### 🧾 PUT /api/employees/{id}
- Updates an existing employee.

### 🧾 DELETE /api/employees/{id}
- Deletes an employee by ID.

---

## 🧪 Testing the API

You can use **Postman**, **Insomnia**, or the built-in **Swagger UI** to test the API endpoints.
