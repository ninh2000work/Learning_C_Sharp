using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai14_VongLapDoWhileTrongCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            do
            {
                Console.WriteLine("a = " + a);
                a++;
            } while (a < 10);
            Console.ReadKey();
        }
    }
}
