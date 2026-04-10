using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai24_EnumTrongCSharp
{
    internal class Program
    {
        enum Color1
        {
            Red,
            Green,
            Blue,
            Yellow
        }
        enum Color2
        {
            Red = 10,
            Green = 20,
            Blue = 30
        }

        static void Main(string[] args)
        {
            Console.Write("Nhap So Bat Ky: ");
            int Choose = int.Parse(Console.ReadLine());

            if (Choose == (int)Color1.Red)
            {
                Console.WriteLine("Mau Do 1");
            }
            else if (Choose == (int)Color1.Green)
            {
                Console.WriteLine("Mau Xanh La 1");
            }
            else if (Choose == (int)Color1.Blue)
            {
                Console.WriteLine("Mau Xanh Bien 1");
            }
            else if (Choose == (int)Color1.Yellow)
            {
                Console.WriteLine("Mau Vang 1");
            }
            else if (Choose == (int)Color2.Red)
            {
                Console.WriteLine("Mau Do 2");
            }
            else if (Choose == (int)Color2.Green)
            {
                Console.WriteLine("Mau Xanh La 2");
            }
            else if (Choose == (int)Color2.Blue)
            {
                Console.WriteLine("Mau Xanh Bien 2");
            }
            else
            {
                Console.WriteLine("Khong co mau nao thoa man!");
            }

            Console.ReadKey();
        }
    }
}
