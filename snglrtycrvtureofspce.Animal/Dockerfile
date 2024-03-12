FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

RUN sudo apt-get install nodejs

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY snglrtycrvtureofspce.Animal/ ./snglrtycrvtureofspce.Animal
WORKDIR /src/snglrtycrvtureofspce.Animal
RUN dotnet restore
RUN dotnet build -c $BUILD_CONFIGURATION -o /app

FROM build AS npmpublisher
WORKDIR /app
COPY snglrtycrvtureofspce/ ./snglrtycrvtureofspce
WORKDIR /app/snglrtycrvtureofspce
RUN npm config set fetch-timeout 600000
RUN npm install
COPY --from=swagger /app/swagger.json ./swagger.json
RUN ./node_modules/.bin/swagger-angular-generator -s ./swagger.json -d ./projects/snglrtycrvtureofspce/animal-api/src/lib --no-store
RUN ./node_modules/.bin/public-api-generator -d ./projects/snglrtycrvtureofspce/animal-api/src -s ./projects/snglrtycrvtureofspce/animal-api/src/lib
WORKDIR /app/solidex/projects/snglrtycrvtureofspce/animal-api
RUN npm version 1.0.$PACKAGE_VERSION
WORKDIR /app/snglrtycrvtureofspce
RUN npm run build
WORKDIR /app/snglrtycrvtureofspce/dist/snglrtycrvtureofspce/animal-api
RUN echo "//registry.npmjs.org/:_authToken=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" > ~/.npmrc
RUN npm publish --access public

FROM base AS final
WORKDIR /app
COPY --from=npmpublisher /app .
ENTRYPOINT ["dotnet", "snglrtycrvtureofspce.Animal.dll"]