using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai07_IfElseTrongCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If
            int a = 1;
            if (a == 1)
            {
                Console.WriteLine("a = 1");
            }
            Console.ReadKey();
            #endregion

            #region If Else
            int b = 3;
            if (b == 2)
                Console.WriteLine("b = 2");
            else
            {
                Console.WriteLine("b != 2");
                Console.WriteLine("b = " + b);
            }
            Console.ReadKey();
            #endregion

            #region If Elseif Else
            int c = 4;
            if (c == 3)
                Console.WriteLine("c = 3");
            else if (c < 3)
            {
                Console.WriteLine("c < 3");
                Console.WriteLine("c = " + c);
            }
            else
            {
                Console.WriteLine("c > 3");
                Console.WriteLine("c = " + c);
            }
            Console.ReadKey();
            #endregion
        }
    }
}
