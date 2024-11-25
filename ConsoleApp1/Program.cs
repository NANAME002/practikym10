using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"x={Func(5) + Func(12) + Func(19):F2}");
            Console.ReadLine();
        }
        public static double Func(double x)
        {
            return (Math.Sqrt(x) + x) / 2;
        }
    }
}
