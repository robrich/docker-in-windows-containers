Docker for Windows Container Development
========================================

Here's the code we built for Docker for Windows Container Development.  These samples show how to containerize a .NET app and service into Windows and Linux containers.

Usage
-----

1. Use on either Windows or Linux containers.  To switch, right-click on the whale in the system tray by the clock, and choose "Switch to Windows Containers" or "Switch to Linux Containers".

2. To build and run NetApp1 containers:

   ```bash
   cd NetApp1/WorkerService1
   docker build --tag netapp1-svc  .
   docker container run netapp1-svc
   cd ..
   cd WebApplication1
   docker build -t netapp1-web .
   docker container run -d -p 80:80 netapp1-web
   cd ..
   ```
3. To build and run the NetApp2 containers:

   ```bash
   cd NetApp2
   docker-compose build
   docker-compose up
   ```

   or open Visual Studio 2019, and switch from `IIS Express` to `Docker Compose` profile in the top task bar, then push debug.


License
-------
The MIT License

Copyright (c) 2019-2020 Richardson & Sons, LLC. https://www.richardsonandsons.com

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
