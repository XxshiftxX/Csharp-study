//Rextester.Program.Main is the entry point for your code. Don't change it.
//Compiler version 4.0.30319.17929 for Microsoft (R) .NET Framework 4.5

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Rextester
{
    public class Program
    {
        public static void Main(string[] args)
        {
            DateTime before = DateTime.Now;
            Sum();
            DateTime after = DateTime.Now;
            
            long gap = after.Ticks - before.Ticks;
            Console.WriteLine("Total Ticks: " + gap);
            Console.WriteLine("Millisecond: " + (gap / 10000));
            Console.WriteLine("Second: " + (gap / 10000 / 1000));
        }
        
        private static long Sum()
        {
            long sum = 0;
            
            for(int i = 0; i < 2000000000; i++)
            {
                sum += i;
            }
            
            return sum;
        }
    }
}