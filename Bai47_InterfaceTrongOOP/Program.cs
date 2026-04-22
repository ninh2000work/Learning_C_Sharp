using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai47_InterfaceTrongOOP
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

    internal class Program
    {
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
