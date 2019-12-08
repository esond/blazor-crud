# ethor-test

## Specification

Create an ASP.NET Core web site that can perform the following:

- Authenticate with Facebook or Google using OAuth
- Use Castle Windsor dependency injection container to provide required DI
- Uses Entity Framework and MVC Core or Blazor to CRUD the following item:
  - eThorTestEntity
    - Id : unique identifier
    - Name : text
    - HardProperty : list of text
- The database used does not necessarily need to retain information between runs
  of your application, InMemory is suitable.