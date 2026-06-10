
FROM mcr.microsoft.com/dotnet/aspnet:10.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["PharMedTOGO/PharMedTOGO.csproj", "PharMedTOGO/"]
COPY ["PharMedTOGO.Core/PharMedTOGO.Core.csproj", "PharMedTOGO.Core/"]
COPY ["PharMedTOGO.Infrastrucure/PharMedTOGO.Infrastrucure.csproj", "PharMedTOGO.Infrastrucure/"]
RUN dotnet restore "./PharMedTOGO/PharMedTOGO.csproj"
COPY . .
WORKDIR "/src/PharMedTOGO"
RUN dotnet build "./PharMedTOGO.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./PharMedTOGO.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "PharMedTOGO.dll"]