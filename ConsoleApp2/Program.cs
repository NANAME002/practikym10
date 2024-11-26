using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"x={Func(5, 7) + Func(12, 8) + Func(19, 2):F2}");
            Console.ReadLine();
        }
        public static double Func(double x, double y)
        {
            return (Math.Sqrt(x) + x) / Math.Sqrt(y) + y;
        }
    }
    
}
