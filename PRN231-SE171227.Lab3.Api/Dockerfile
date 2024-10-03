FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER $APP_UID
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["PRN231-SE171227.Lab3.Api/PRN231-SE171227.Lab3.Api.csproj", "PRN231-SE171227.Lab3.Api/"]
COPY ["PRN231-SE171227.Lab3.Services/PRN231-SE171227.Lab3.Services.csproj", "PRN231-SE171227.Lab3.Services/"]
COPY ["Repository/PRN231-SE171227.Lab3.Repository.csproj", "Repository/"]
RUN dotnet restore "PRN231-SE171227.Lab3.Api/PRN231-SE171227.Lab3.Api.csproj"
COPY . .
WORKDIR "/src/PRN231-SE171227.Lab3.Api"
RUN dotnet build "PRN231-SE171227.Lab3.Api.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "PRN231-SE171227.Lab3.Api.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "PRN231-SE171227.Lab3.Api.dll"]
