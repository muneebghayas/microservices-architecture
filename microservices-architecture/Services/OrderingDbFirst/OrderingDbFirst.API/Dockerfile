#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["Services/OrderingDbFirst/OrderingDbFirst.API/OrderingDbFirst.API.csproj", "Services/OrderingDbFirst/OrderingDbFirst.API/"]
COPY ["Services/OrderingDbFirst/OrderingDbFirst.Models/OrderingDbFirst.Models.csproj", "Services/OrderingDbFirst/OrderingDbFirst.Models/"]
COPY ["Services/OrderingDbFirst/OrderingDbFirst.Services/OrderingDbFirst.Services.csproj", "Services/OrderingDbFirst/OrderingDbFirst.Services/"]
COPY ["Services/OrderingDbFirst/OrderingDbFirst.Repository/OrderingDbFirst.Repository.csproj", "Services/OrderingDbFirst/OrderingDbFirst.Repository/"]
COPY ["Services/OrderingDbFirst/OrderingDbFirst.Utilities/OrderingDbFirst.Utilities.csproj", "Services/OrderingDbFirst/OrderingDbFirst.Utilities/"]
RUN dotnet restore "./Services/OrderingDbFirst/OrderingDbFirst.API/./OrderingDbFirst.API.csproj"
COPY . .
WORKDIR "/src/Services/OrderingDbFirst/OrderingDbFirst.API"
RUN dotnet build "./OrderingDbFirst.API.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./OrderingDbFirst.API.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "OrderingDbFirst.API.dll"]