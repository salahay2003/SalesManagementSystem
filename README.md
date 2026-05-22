# SalesManagementSystem

SalesManagementSystem is a simple .NET 9 application that demonstrates a small sales management domain using Entity Framework for data access. It provides data models, EF Core migrations, and a basic UI for managing sales, customers and products.

## Features
- Data access implemented with Entity Framework Core
- Migrations-ready database project
- Simple CRUD operations for sales-related entities

## Requirements
- .NET 9 SDK
- dotnet-ef tools (for migrations)
- Visual Studio 2022/2026 or VS Code (optional)

## Getting started
1. Clone the repository:
   git clone https://github.com/salahay2003/SalesManagementSystem.git

2. Open the solution in Visual Studio or use the dotnet CLI.

3. Update the connection string in your configuration (for example, `appsettings.json` or the project's configuration file) to point to your database server.

4. Install EF tools if you haven't already:
   dotnet tool install --global dotnet-ef

5. Restore and build the solution:
   dotnet restore
   dotnet build

6. Create and apply migrations (run from the data project or specify projects explicitly):
   dotnet ef migrations add InitialCreate
   dotnet ef database update

7. Run the application from Visual Studio or with:
   dotnet run --project <StartupProject>

## Contributing
Contributions are welcome. Please open issues or pull requests on the repository.

## License
MIT
