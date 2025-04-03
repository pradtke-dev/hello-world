# Use the official .NET runtime image as a runtime stage
FROM mcr.microsoft.com/dotnet/aspnet:9.0
WORKDIR /app
COPY ./publish .

# Expose the port the app runs on
ENV ASPNETCORE_URLS=http://+:80/
EXPOSE 80

# Set the entry point for the application
ENTRYPOINT ["dotnet", "Hello.dll"]