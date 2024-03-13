#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS swagger
WORKDIR /app
COPY --from=build /app ./
RUN dotnet tool install --version 6.5.0 Swashbuckle.AspNetCore.Cli --tool-path /dotnet-global-tools
LABEL swagger=true
RUN /dotnet-global-tools/swagger tofile --output swagger.json /app/snglrtycrvtureofspce.Animal.dll v1

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS swaggershort
WORKDIR /app
COPY --from=build /app ./
RUN dotnet tool install --version 6.5.0 Swashbuckle.AspNetCore.Cli --tool-path /dotnet-global-tools
LABEL swagger=true
ENV DISABLE_RABBITMQ true
ENV Swagger__Path ""
RUN /dotnet-global-tools/swagger tofile --output swagger.json /app/snglrtycrvtureofspce.Animal.dll v1

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["snglrtycrvtureofspce.Animal/snglrtycrvtureofspce.Animal.csproj", "snglrtycrvtureofspce.Animal/"]
RUN dotnet restore "./snglrtycrvtureofspce.Animal/snglrtycrvtureofspce.Animal.csproj"
COPY . .
WORKDIR "/src/snglrtycrvtureofspce.Animal"
RUN dotnet build "./snglrtycrvtureofspce.Animal.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./snglrtycrvtureofspce.Animal.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "snglrtycrvtureofspce.Animal.dll"]