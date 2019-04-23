using System;
using System.Threading;

namespace WindowsService1
{
    class Program
    {
        static void Main(string[] args)
        {
            var svc = new Service1();

            while(true)
            {
                Thread.Sleep(500);
            }
        }

    }
}
