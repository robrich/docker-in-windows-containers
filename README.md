Docker for Windows Container Development
========================================

Here's the code we built for [Docker for Windows Container Development](https://dockercon19.smarteventscloud.com/connect/sessionDetail.ww?SESSION_ID=277530) at DockerCon SF 2019.  These samples show how to containerize a .NET Framework app and service and a .NET Core app and service into Windows containers.

Usage
-----

1. Switch to Windows Containers by right-clicking on the whale in the system tray by the clock, and choose "Switch to Windows Containers".  If it says "Switch to Linux Containers", you're in the right place.

2. To build and run the .NET Framework containers:

   ```bash
   cd NetFrameworkApp
   docker build -t netframework-service -f WindowsService1\Dockerfile .
   docker container run -d netframework-service
   docker build -t netframework-site -f WebApplication1\Dockerfile .
   docker container run -d -p 3000:80 netframework-site
   ```
3. To build and run the .NET Core containers:

   ```bash
   cd NetCoreApp
   docker-compose build
   docker-compose up
   ```

   or open Visual Studio 2019, and switch the Debug profile in the top task bar from `IIS Express` to `Docker`, then push debug.


License
-------
MIT
