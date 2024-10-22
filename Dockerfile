# Stage 1: Build the application
        FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
        WORKDIR /app
        
        # Copy the solution and project files
        COPY ["ConsoleAppHelloWorld/ConsoleAppHelloWorld/ConsoleAppHelloWorld.csproj", "ConsoleAppHelloWorld/ConsoleAppHelloWorld/"]
        
        # Restore dependencies
        RUN dotnet restore "ConsoleAppHelloWorld/ConsoleAppHelloWorld/ConsoleAppHelloWorld.csproj"
        
        # Copy the rest of the application code
        COPY . .
        
        # Navigate to the project directory
        WORKDIR /app/ConsoleAppHelloWorld/ConsoleAppHelloWorld
        
        # Build and publish the application
        RUN dotnet publish "ConsoleAppHelloWorld.csproj" -c Release -o out
        
        # Stage 2: Create the runtime image
        FROM mcr.microsoft.com/dotnet/runtime:8.0 AS runtime
        WORKDIR /app
        
        # Copy the published application from the build stage
        COPY --from=build /app/ConsoleAppHelloWorld/ConsoleAppHelloWorld/out ./
        
        # Define the entry point for the container
        ENTRYPOINT ["dotnet", "ConsoleAppHelloWorld.dll"]
