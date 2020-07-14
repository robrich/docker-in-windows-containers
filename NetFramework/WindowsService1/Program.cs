using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WindowsService1
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		static void Main()
		{
			var service = new Service1();
			service.OnStart(new string[] { });
			while(true)
			{
				Thread.Sleep(1000);
			}
		}
	}
}
