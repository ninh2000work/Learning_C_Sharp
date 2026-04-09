using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Bai20_MangNhieuChieuTrongCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Mảng 3 chiều
            int[,,] MangInt = new int[2, 3, 4];     //Khai báo và cấp phát vùng nhớ cho mảng
            MangInt[0,1,2] = 2;

            double[,,] MangDouble = new double[ , , ]  //Khai báo, cấp phát vùng nhớ và khởi tạo giá trị cho mảng
            {
                {
                    { 1, 2, 3, 4 },
                    { 5, 6, 7, 8},
                    { 9, 10, 11, 12 }
                },
                {
                    { 11, 22, 33, 44 },
                    { 55, 66, 77, 88 },
                    { 99, 100, 111, 112 }
                }
            };

            string[,,] MangString =                 //Khởi tạo giá trị cho mảng
            {
                {
                    { "Hello", "Hi" },
                    { "Demo", "Test"}
                },
                {
                    { "Bye", "Again"},
                    { "How", "What"}
                },
            };

            Console.WriteLine("MangInt.Length = " + MangInt.Length);

            Console.WriteLine("MangDouble.GetLength(0) = " + MangDouble.GetLength(0));
            Console.WriteLine("MangDouble.GetLength(1) = " + MangDouble.GetLength(1));
            Console.WriteLine("MangDouble.GetLength(2) = " + MangDouble.GetLength(2));

            Console.WriteLine("MangDouble.Rank = " + MangDouble.Rank);

            Console.WriteLine();

            for (int i = 0; i < MangDouble.GetLength(0); i++)
            {
                for (int j = 0; j < MangDouble.GetLength(1); j++)
                {
                    for (int k = 0; k < MangDouble.GetLength(2); k++)
                    {
                        Console.Write("MangDouble[{0},{1},{2}] = {3,-10}", i, j, k, MangDouble[i,j,k]);
                    }
                    Console.WriteLine();
                }
            }
            Console.WriteLine();

            Console.ReadKey();
            #endregion

            #region Mảng Jegged
            int[][] IntJegged = new int[3][];
            IntJegged[0] = new int[2];
            IntJegged[1] = new int[5];
            IntJegged[2] = new int[3];
            IntJegged[0][1] = 5;

            double[][] DoubleJegged =
            {
                new double[] { 1, 2, 3 },
                new double[] { 4, 5, 6, 7, 8 },
                new double[] { 9, 10 }
            };
            for (int i = 0; i < DoubleJegged.Length; i++)
            {
                for (int j = 0; j < DoubleJegged[i].Length; j++)
                {
                    Console.Write("DoubleJegged[{0}][{1}] = {2, -3}", i, j, DoubleJegged[i][j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.ReadKey();
            #endregion

            #region Array
            int[] IntArray = { 6, 3, 2, 4, 5, 1 };
            for (int i = 0; i < IntArray.Length; i++)
            {
                Console.Write("IntArray[{0}] = {1, -4}", i, IntArray[i]);
            }
            Console.WriteLine();

            int a;
            Console.WriteLine("IntArray.GetValue({0}) = {1}", a = 1, IntArray.GetValue(a));

            int b;
            Console.WriteLine("Array.IndexOf(IntArray, {0}) = {1}", b = 1, Array.IndexOf(IntArray, b));

            Array.Reverse(IntArray);
            for (int i = 0; i < IntArray.Length; i++)
            {
                Console.Write("IntArray[{0}] = {1, -4}", i, IntArray[i]);
            }
            Console.WriteLine();

            Array.Sort(IntArray);
            for (int i = 0; i < IntArray.Length; i++)
            {
                Console.Write("IntArray[{0}] = {1, -4}", i, IntArray[i]);
            }
            Console.WriteLine();

            Array.Clear(IntArray, 1, 4);
            for (int i = 0; i < IntArray.Length; i++)
            {
                Console.Write("IntArray[{0}] = {1, -4}", i, IntArray[i]);
            }

            Console.ReadKey();
            #endregion
        }
    }
}
