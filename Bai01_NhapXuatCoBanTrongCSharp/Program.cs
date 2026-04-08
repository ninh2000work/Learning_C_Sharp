using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai01_NhapXuatCoBanTrongCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region CauTrucCobanLenhNhapXuat
            Console.Write("HelloWorld\n");
            Console.WriteLine(1);
            Console.Write(2.3f);
            Console.Write(Environment.NewLine);
            Console.WriteLine(Console.ReadLine());
            Console.ReadKey();
            #endregion

            #region Console.Write()
            int a = 1;
            Console.Write("a = ");
            Console.Write(a);
            Console.Write(Environment.NewLine);
            Console.Write("a = " + a);
            Console.Write(Environment.NewLine);
            Console.Write("a = {0}", a);
            Console.Write(Environment.NewLine);
            Console.ReadKey();
            #endregion

            #region Console.WriteLine()
            int b = 2;
            Console.WriteLine("b = " + b);
            Console.WriteLine("b = {0}", b);
            Console.ReadKey();
            #endregion

            #region Console.Read()
            Console.WriteLine(Console.Read());
            Console.ReadKey();
            #endregion

            #region Console.ReadLine()
            Console.WriteLine(Console.ReadLine());
            Console.ReadKey();
            #endregion

            #region Console.ReadKey()
            Console.ReadKey();
            Console.ReadKey(false);
            Console.ReadKey(true);
            #endregion
        }
    }
}
