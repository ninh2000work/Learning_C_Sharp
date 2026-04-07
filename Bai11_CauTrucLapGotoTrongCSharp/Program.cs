using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai11_CauTrucLapGotoTrongCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu:
            Console.WriteLine("HelloWorld");
            Console.ReadKey();
            goto Menu;
        }
    }
}
