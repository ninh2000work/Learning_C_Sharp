using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai13_VongLapWhileTrongCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            while (a < 10)
            {
                Console.WriteLine("a = " + a);
                a++;
            }
            Console.ReadKey();
        }
    }
}
