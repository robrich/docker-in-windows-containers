Docker for Windows Container Development
========================================

Here's the code we built for [Docker for Windows Container Development](https://dockercon19.smarteventscloud.com/connect/sessionDetail.ww?SESSION_ID=277530) at DockerCon SF 2019.  These samples show how to containerize a .NET Framework app and service and a .NET Core app and service into Windows containers.

Usage
-----

1. Switch to Windows Containers by right-clicking on the whale in the system tray by the clock, and choose "Switch to Windows Containers".  If it says "Switch to Linux Containers", you're in the right place.

2. To build and run the .NET Framework containers:

   ```bash
   cd NetFrameworkApp
   docker build --file WindowsService1/Dockerfile --tag netframework-service  .
   docker container run netframework-service
   docker build -t netframework-site -f WebApplication1/Dockerfile .
   docker container run --detach --publish 5000:80 netframework-site
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
The MIT License

Copyright (c) 2019 Richardson & Sons, LLC. https://www.richardsonandsons.com

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in
all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
THE SOFTWARE.