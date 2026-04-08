using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai15_CauTrucCuaHamCoBanTrongCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            VoidDemo();

            int a, b;
            Console.WriteLine("a = {0}, b = {1}, a * b = {2}", a = 2, b = 3, DoubleDemo(a, b));

            Console.ReadKey();
        }

        static void VoidDemo()
        {
            Console.WriteLine("HelloWorld");
            IntDemo(10);
        }

        static int IntDemo(int a)
        {
            Console.Write("a = {0}, ", a);
            a += 5;
            Console.WriteLine("a + 5 = " + a);
            return a;
        }

        static double DoubleDemo(double a, double b)
        {
            return (a * b);
        }
    }
}
