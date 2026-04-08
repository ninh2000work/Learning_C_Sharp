using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai08_SwitchCaseTrongCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Dạng thiếu
            int a = 1;
            switch (a)
            {
                case 1:
                    {
                        Console.WriteLine("a = 1");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("a = 2");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("a = 3");
                        break;
                    }
            }
            Console.ReadKey();
            #endregion

            #region Dạng đủ
            int b = 5;
            switch (b)
            {
                case 1:
                    {
                        Console.WriteLine("b = 1");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("b= 2");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("b = 3");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("b = " + b);
                        break;
                    }
            }
            Console.ReadKey();
            #endregion
        }
    }
}
