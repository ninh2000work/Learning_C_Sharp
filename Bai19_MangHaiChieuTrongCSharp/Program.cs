using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai19_MangHaiChieuTrongCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] MangInt = new int[3, 4];         //Khai báo và cấp phát vùng nhớ cho mảng
            MangInt[0,0] = 1;
            MangInt[1,2] = 3;

            string[,] MangString = new string[,]    //Khai báo, cấp phát vùng nhớ và khởi tạo giá trị cho mảng
            {
                { "Hello", "World" },
                { "Demo", "Test" }
            };

            double[,] MangDouble =                  //Khởi tạo giá trị cho mảng
            {
                { 1.3, 4.5, 6.8 },
                { 10.24, 24.51, 5.64 }
            };

            Console.WriteLine("MangInt.Length = " + MangInt.Length);

            Console.WriteLine("MangDouble.GetLength(0) = " + MangDouble.GetLength(0));
            Console.WriteLine("MangDouble.GetLength(1) = " + MangDouble.GetLength(1));

            Console.WriteLine("MangDouble.Rank = " + MangDouble.Rank);

            Console.WriteLine();

            for (int i = 0; i < MangInt.GetLength(0); i++)
            {
                for (int j = 0; j < MangInt.GetLength(1); j++)
                {
                    Console.Write("MangInt[{0},{1}] = {2, -10}", i, j, MangInt[i, j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            for (int i = 0; i < MangDouble.GetLength(0); i++)
            {
                for (int j = 0; j < MangDouble.GetLength(1); j++)
                {
                    Console.Write("MangDouble[{0},{1}] = {2, -10}", i, j, MangDouble[i, j]);
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
