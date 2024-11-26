using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Input("a= ");
            int b = Input("b= ");
            int c = Input("c= ");
            int d = Input("d= ");
            Console.WriteLine($"s={Max(a,b)+ Max(c,d)}");
            Console.ReadLine();
        }
        public static int Input(string message)
        {
            Console.Write(message);
            return int.Parse(Console.ReadLine());
        }
        public static int Max(int a, int b)
        {
            return a>b ? a : b;
        }

    }
}
