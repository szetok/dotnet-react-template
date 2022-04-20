# dotnet-react-template

Sample React application with .NET Core backend, based on .NET's React project template:

https://docs.microsoft.com/en-us/aspnet/core/client-side/spa/react?view=aspnetcore-6.0&tabs=visual-studio

Uses updated versions and features of .NET, NuGet packages, and npm packages.

## Development

### Non-Containerized

Build and run the .NET backend
```sh
cd src
dotnet build
dotnet run
```

Then in a second terminal, run the React application:
```sh
cd src
cd ClientApp
npm start
```

The React application with backend will be running on https://localhost:44406

### Containerized

```sh
cd src
docker-compose build
docker-compose up
```

or

```sh
cd src
docker build -t dotnet-react-template .
docker run -p 44406:80 dotnet-react-template
```

The React application with backend will be running on http://localhost:44406
