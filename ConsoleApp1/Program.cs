using System;
using System.Collections.Generic;
using System.Globalization;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main(string[] args)
        {

            TimeSpan t1 = new TimeSpan(); //00:00:00
            TimeSpan t2 = new TimeSpan(900000000); //00:01:30
            TimeSpan t3 = new TimeSpan(2, 11, 10); //02:11:10
            TimeSpan t4 = new TimeSpan(5, 2, 11, 10); //02:11:10



            Console.WriteLine(t4);

        }

    }
}
