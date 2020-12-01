# build server
FROM mcr.microsoft.com/dotnet/sdk:5.0 as build

WORKDIR /src

COPY WebApplication1.csproj .
RUN dotnet restore

COPY . .
RUN dotnet build -c Release
RUN dotnet test
RUN dotnet publish -c Release -o /dist


# production server
FROM mcr.microsoft.com/dotnet/aspnet:5.0

WORKDIR /app

ENV ASPNETCORE_ENVIRONMENT Production
ENV ASPNETCORE_URLS http://+:80
EXPOSE 80

COPY --from=build /dist .

CMD ["dotnet", "WebApplication1.dll"]
