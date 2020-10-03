# build container
FROM mcr.microsoft.com/dotnet/framework/sdk:4.8 as build

WORKDIR /src

COPY NetFramework.sln .
COPY WebApplication1/WebApplication1.csproj WebApplication1/WebApplication1.csproj
COPY WebApplication1/packages.config WebApplication1/packages.config
COPY WindowsService1/WindowsService1.csproj WindowsService1/WindowsService1.csproj
RUN nuget restore

COPY . .
RUN msbuild NetFramework.sln /p:Configuration=Release /m

# RUN nunit.exe ...


# production runtime container
FROM mcr.microsoft.com/dotnet/framework/runtime:4.8

WORKDIR /app

COPY --from=build /src/WindowsService1/bin/Release .

CMD ["WindowsService1.exe"]
