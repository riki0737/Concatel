using System;
using System.Diagnostics;
using System.Threading;
using System.Timers;
using System.Windows;


namespace Tiemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            var d = new DateTime(2019, 11, 11, 20, n, 00);
            for (int i = 0; i < n * 60; ++i) {
                Console.WriteLine(d.ToString("mm:ss"));
                d = d.AddSeconds(-1);
                Thread.Sleep(1000);
                Console.Clear();
            }
        }
    }
}



