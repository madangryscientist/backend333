FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["backend333/backend333.csproj", "backend333/"]
RUN dotnet restore "backend333/backend333.csproj"
COPY . .
WORKDIR "/src/backend333"
RUN dotnet build "backend333.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "backend333.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "backend333.dll"]
