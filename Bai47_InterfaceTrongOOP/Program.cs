using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai47_InterfaceTrongOOP
{
    internal class Program
    {
        interface IPeople
        {
            void Info();
        }

        class Men : IPeople
        {
            public void Info()
            {
                Console.WriteLine("Men");
            }
        }

        static void Main(string[] args)
        {
            Men A = new Men();
            A.Info();

            IPeople B = new Men();
            B.Info();

            Console.ReadKey();
        }
    }
}
