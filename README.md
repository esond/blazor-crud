# ethor-test

## Specification

Create an ASP.NET Core web site that can perform the following:

- Authenticate with Facebook or Google using OAuth
- Use Castle Windsor dependency injection container to provide required DI
- Uses Entity Framework and MVC Core or Blazor to CRUD the following item:
  - eThorTestEntity
    - `Id` : unique identifier
    - `Name` : text
    - `HardProperty` : list of text
- The database used does not necessarily need to retain information between runs
  of your application, InMemory is suitable.
- **Bonus** if you use Blazor (server-side or client-side)
- **Bonus** if your web site leverages Docker containers.

## Dependencies

- .NET Core 3.1
- Visual Studio 16.4.0 or higher
- An active Google account
- Docker Desktop using Windows containers

## Instructions

- To run the app, the value of the `ApplicationClientSecret` configuration
  setting (`src/eThorTest/appsettings.json`) must be replaced with the value
  found in the `credentials.json` file sent alongside this project.
- Set the default startup project in Visual studio to `docker-compose` (*right
  click in Solution Explorer > Set As Startup Project*)

## Notes


- The requirement to use Castle Windsor is not achievable if developing the app
  with Blazor. Blazor requires .NET Core 3.0 or higher, and Castle windsor [does
  not yet support .NET Core 3.0.](https://github.com/castleproject/Windsor/issues/418)
  - See also: [.NET docs - Default service container replacement](https://docs.microsoft.com/en-us/aspnet/core/fundamentals/dependency-injection?view=aspnetcore-3.1#default-service-container-replacement)