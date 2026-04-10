using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai21_VongLapForeachTrongCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[][] DoubleJegged =
            {
                new double[] { 1, 2, 3 },
                new double[] { 4, 5, 6, 7, 8 },
                new double[] { 9, 10 }
            };

            int i = 0;
            foreach (double[] item1 in DoubleJegged)
            {
                int j = 0;
                foreach (double item2 in item1)
                {
                    Console.Write("DoubleJegged[{0}][{1}] = {2, -5}", i, j, item2);
                    j++;
                }
                i++;
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
