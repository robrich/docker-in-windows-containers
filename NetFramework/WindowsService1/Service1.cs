using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace WindowsService1
{
	public partial class Service1
	{
		private readonly Timer timer;
		public Service1()
		{
			timer = new Timer()
			{
				Interval = 1000,
				Enabled = false
			};
			timer.Elapsed += this.Timer_Elapsed;
		}

		private void Timer_Elapsed(object sender, ElapsedEventArgs e)
		{
			Console.WriteLine($"Service doing work: {DateTime.Now.ToLongTimeString()}");
		}

		public void OnStart(string[] args)
		{
			timer.Enabled = true;
		}

		public void OnStop()
		{
			timer.Enabled = false;
		}
	}
}
