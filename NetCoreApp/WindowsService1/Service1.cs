using System;
using System.Timers;

namespace WindowsService1
{
    public class Service1
    {
        private readonly Timer timer1;

        public Service1()
        {
            timer1 = new Timer
            {
                Interval = 500, // ms
                Enabled = true
            };
            timer1.Elapsed += Timer1_Elapsed;
        }

        private void Timer1_Elapsed(object sender, ElapsedEventArgs e)
        {
            Console.WriteLine($"Elapsed: {DateTime.Now.ToLongTimeString()}");
        }

    }
}
