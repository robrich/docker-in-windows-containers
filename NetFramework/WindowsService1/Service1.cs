using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Timers;

namespace WindowsService1
{
	public partial class Service1
	{
		private readonly Timer timer1;

		public Service1()
		{
			this.timer1 = new Timer()
			{
				Enabled = false,
				Interval = 1000
			};
			this.timer1.Elapsed += this.timer1_elapsed;
		}

		private void timer1_elapsed(object sender, ElapsedEventArgs e)
		{
			Console.WriteLine($"Service prcessed: {DateTime.Now.ToLongTimeString()}");
		}

		public void OnStart(string[] args)
		{
			this.timer1.Enabled = true;
		}

		public void OnStop()
		{
			this.timer1.Enabled = false;
		}
	}
}
