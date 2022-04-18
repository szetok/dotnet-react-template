# dotnet-react-template

ASP.NET Core with React project template (https://docs.microsoft.com/en-us/aspnet/core/client-side/spa/react?view=aspnetcore-6.0&tabs=visual-studio), but better. Uses updated versions of .NET, NuGet packages, and npm packages.

## Development

### Non-Containerized

```
$ dotnet build
$ dotnet run
```

The client SPA will be running on https://localhost:44406

### Containerized

```
$ docker-compose build
$ docker-compose up
```

or

```
$ docker build -t dotnet-react-template .
$ docker run -p 44406:80 dotnet-react-template
```

The client SPA will be running on http://localhost:44406

# dotnet-react-template

ASP.NET Core with React project template (https://docs.microsoft.com/en-us/aspnet/core/client-side/spa/react?view=aspnetcore-6.0&tabs=visual-studio), but better. Uses updated versions of .NET, NuGet packages, and npm packages.

## Development

### Non-Containerized

```
$ dotnet build
$ dotnet run
```

The client SPA will be running on https://localhost:44406

### Containerized

```
$ docker-compose build
$ docker-compose up
```

or

```
$ docker build -t dotnet-react-template .
$ docker run -p 44406:80 dotnet-react-template
```

The client SPA will be running on http://localhost:44406
