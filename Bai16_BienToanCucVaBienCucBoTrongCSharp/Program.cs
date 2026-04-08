using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai16_BienToanCucVaBienCucBoTrongCSharp
{
    internal class Program
    {
        static int a = 5;
        static void Main(string[] args)
        {
            int a = 10;
            Console.WriteLine("a = " + a);
            Demo();
            Console.ReadKey();
        }
        static void Demo()
        {
            Console.WriteLine("a = " + a);
        }
    }
}
