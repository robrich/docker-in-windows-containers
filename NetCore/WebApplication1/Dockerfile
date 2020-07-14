FROM mcr.microsoft.com/dotnet/core/aspnet:3.1 AS base


FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /src

COPY NetCore.sln .
COPY WebApplication1/WebApplication1.csproj WebApplication1/
COPY WorkerService1/WorkerService1.csproj WorkerService1/
RUN dotnet restore

COPY . .
RUN dotnet build NetCore.sln -c Release

# RUN dotnet test

RUN dotnet publish WebApplication1/WebApplication1.csproj -c Release -o /dist


FROM base AS final
EXPOSE 80
EXPOSE 443
WORKDIR /app
COPY --from=build /dist .
ENTRYPOINT ["dotnet", "WebApplication1.dll"]
