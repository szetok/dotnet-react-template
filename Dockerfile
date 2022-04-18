# Pull down an image from Docker Hub that includes the .NET core SDK.
# This is so we have all the tools necessary to compile the app.
FROM mcr.microsoft.com/dotnet/sdk:6.0-alpine3.14 AS build

# Install dependencies.
RUN apk add --no-cache libc6-compat curl tzdata icu-libs nodejs npm

# Copy the source from your machine onto the container.
WORKDIR /app
COPY src .

# Compile, then pack the compiled app and dependencies into a deployable unit.
RUN dotnet publish dotnet-react-template.csproj --output /app/publish --configuration Release --runtime linux-musl-x64

# Pull down an image from Docker Hub that includes only the ASP.NET core runtime.
# We don't need the SDK anymore, so this will produce a lighter-weight image
# that can still run the app.
FROM mcr.microsoft.com/dotnet/runtime-deps:6.0-alpine3.14 AS run
WORKDIR /app

# Install dependencies.
RUN apk add --no-cache libc6-compat curl tzdata icu-libs nodejs npm

# Expose port 80 to your local machine so you can access the app.
EXPOSE 80

# Copy the published app to this new runtime-only container.
COPY --from=build /app/publish .

# Run the published app.
CMD ["sh", "-c", "./dotnet-react-template"]