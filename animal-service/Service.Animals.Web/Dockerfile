FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY Service.Animals.Web/ ./Service.Animals.Web
WORKDIR /src/Service.Animals.Web
RUN dotnet restore
RUN dotnet build -c Release -o /app -p:TargetFramework=net8.0
RUN dotnet build -c Release -o /swagger -p:TargetFramework=net8.0

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS swagger
WORKDIR /app
COPY --from=build /swagger ./
RUN dotnet tool install --version 6.5.0 Swashbuckle.AspNetCore.Cli --tool-path /dotnet-global-tools
LABEL swagger=true
RUN /dotnet-global-tools/swagger tofile --output swagger.json /app/Service.Animals.Web.dll v1

FROM build AS publish
RUN dotnet publish -c Release -o /app  -p:TargetFramework=net8.0

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Service.Animals.Web.dll"]