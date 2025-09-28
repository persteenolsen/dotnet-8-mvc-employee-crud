# mvcwebapp

ASP.NET Core MVC Web Application by .NET 8 serving CRUD of Employees towards a MS SQL Database

Last updated

- 28-09-2025

# Create a global json

dotnet new globaljson --sdk-version 8.0.203 --force

# Create the remote MS SQL DB

- If the folder "Migrations" do not exist or is empty run: 

dotnet ef migrations add FirstCreate --output-dir Migrations/SqlServerMigrations

- If the folder "Migrations" exist or have migration files run: dotnet ef database update

# Functionality of the Web App

- CRUD functionality
- Display a list of Employees

# Tech used for creating the Web App

- A .NET 8 MVC Web App
- A traditional Webhotel for hosting
- VS Code

# Development

dotnet run

# Production

Create a self contained build for production at the remote server / traditionel web hotel

dotnet publish mvcwebapp.csproj --configuration Release --runtime win-x86 --self-contained

Upload the build to remote server

At my remote servers the web.config needs to be without the folowing:

hostingModel="inprocess"

# Test the Web App - The Employees

- yourhost/employee


