using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Input("a= ");
            int b = Input("b= ");
            int z = Input("z= ");
            Console.WriteLine($"Максимальная величина={Max(Max(a, b),z)}");
            Console.ReadLine();

        }
        public static int Input(string message)
        {
            Console.Write(message);
            return int.Parse(Console.ReadLine());
        }
        static int Max(int a, int b)
        {
            return (a > b) ? a : b;
        }
    }

}
