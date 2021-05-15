# dotnet-core-web-api
ASP.NET Core 5.0 Web API

Install Nuget Packages
	Microsoft.EntityFrameworkCore.Tools
	Microsoft.EntityFrameworkCore.SqlServer
	Microsoft.EntityFrameworkCore.Design
	AutoMapper.Extensions.Microsoft.DependencyInjection
	Microsoft.AspNetCore.JsonPatch
	Microsoft.AspNetCore.Mvc.NewtonsoftJson

Scaffold-DbContext "Server=(localdb)\mssqllocaldb;Database=Books;Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models

Add-Migration InitialMigration
