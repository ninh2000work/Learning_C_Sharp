using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai10_TuKhoaDynamicTrongCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Dynamic
            dynamic a = 10;
            Console.WriteLine(a);
            Console.ReadKey();

            string b = "HelloWorld";
            dynamic c = b;
            Console.WriteLine(c);
            Console.ReadKey();
            #endregion
        }
    }
}
