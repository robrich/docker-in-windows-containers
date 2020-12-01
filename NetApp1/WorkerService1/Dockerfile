# build server
FROM mcr.microsoft.com/dotnet/sdk:5.0 as build

WORKDIR /src

COPY WorkerService1.csproj .
RUN dotnet restore

COPY . .
RUN dotnet build -c Release
RUN dotnet test
RUN dotnet publish -c Release -o /dist


# production server
FROM mcr.microsoft.com/dotnet/runtime:5.0

WORKDIR /app

ENV ASPNETCORE_ENVIRONMENT Production

COPY --from=build /dist .

CMD ["dotnet", "WorkerService1.dll"]
