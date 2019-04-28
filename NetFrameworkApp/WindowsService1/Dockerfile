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


# production runtime image
FROM mcr.microsoft.com/dotnet/framework/runtime:4.8 as deploy

WORKDIR /app
COPY --from=build /src/WindowsService1/bin/Release .

# start service when container launches
CMD ["WindowsService1.exe"]
