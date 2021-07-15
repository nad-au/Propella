FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Propella.Api/Propella.Api.csproj", "Propella.Api/"]
RUN dotnet restore "Propella.Api/Propella.Api.csproj"
COPY . .
WORKDIR "/src/Propella.Api"
RUN dotnet build "Propella.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Propella.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Propella.Api.dll"]
