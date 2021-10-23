FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Univercity/Univercity.csproj", "Univercity/"]
RUN dotnet restore "Univercity/Univercity.csproj"
COPY . .
WORKDIR "/src/Univercity"
RUN dotnet build "Univercity.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Univercity.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Univercity.dll"]
