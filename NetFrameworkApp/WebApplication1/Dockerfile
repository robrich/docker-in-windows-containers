# build image
FROM mcr.microsoft.com/dotnet/framework/sdk:4.8 as build

WORKDIR /src

# copy in manifests
COPY NetFrameworkApp.sln .
COPY WebApplication1/WebApplication1.csproj WebApplication1/WebApplication1.csproj
COPY WebApplication1/packages.config WebApplication1/packages.config
COPY WindowsService1/WindowsService1.csproj WindowsService1/WindowsService1.csproj
RUN nuget restore

# build
COPY . .
RUN msbuild NetFrameworkApp.sln /p:Configuration=Release /m

# test
# RUN nunit.exe ...

# publish website
RUN msbuild WebApplication1/WebApplication1.csproj /p:Configuration=Release /m /p:DeployOnBuild=true /p:PublishProfile=FolderProfile


# production runtime image
FROM mcr.microsoft.com/dotnet/framework/aspnet:4.8 as deploy

WORKDIR /inetpub/wwwroot
COPY --from=build /src/WebApplication1/bin/Release/Publish .

# base image starts IIS
