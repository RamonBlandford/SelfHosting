# Build
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY *.csproj ./
RUN dotnet restore
COPY . .
RUN dotnet publish -c Release -o /out /p:UseAppHost=false

# Runtime
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build /out .

# Bind to 0.0.0.0:5003 in the container
ENV ASPNETCORE_URLS=http://0.0.0.0:5003
EXPOSE 5003

ENTRYPOINT ["dotnet", "MyEmailApiService.dll"]