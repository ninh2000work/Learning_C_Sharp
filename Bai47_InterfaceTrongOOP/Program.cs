using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai47_InterfaceTrongOOP
{
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

    interface IPeople
    {
        void Info();
        // Phương thức này phải là trống rỗng, không cho phép code tại đây
    }

    class Men : IPeople
    {
        public void Info()
        {
            Console.WriteLine("Men");
        }
    }
}
