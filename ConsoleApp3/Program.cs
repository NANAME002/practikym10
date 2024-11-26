using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Input("a= ");
            int b = Input("b= ");
            Console.WriteLine($"Максимальная величина={Func(a, b)}");
            Console.ReadLine();

        }
        public static int Input(string message)
        {
            Console.Write(message);
            return int.Parse(Console.ReadLine());
        }
        static int Func(int a, int b)
        {
            return (a>b) ? a : b;
        }

    }
}
