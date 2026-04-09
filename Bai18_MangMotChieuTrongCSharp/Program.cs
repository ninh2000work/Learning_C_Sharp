using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai18_MangMotChieuTrongCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] MangInt = new int[10];                                                //Khai báo và cấp phát vùng nhớ cho mảng
            MangInt[0] = 1;
            MangInt[1] = 5;
            MangInt[2] = 10;

            string[] MangChuoi = new string[] { "Hello", "World", "HelloWorld" };       //Khai báo, cấp phát vùng nhớ và khởi tạo giá trị cho mảng

            double[] MangDouble = { 5.6, 1.8, 3.7 };                                    //Khởi tạo giá trị cho mảng

            int a = MangInt.Length;
            Console.WriteLine("MangInt.Length = " + a);

            long b = MangChuoi.LongLength;
            Console.WriteLine("MangChuoi.LongLength = " + b);

            int c = MangInt.GetLength(0);
            Console.WriteLine("MangInt.GetLength(0) = " + c);

            long d = MangChuoi.GetLongLength(0);
            Console.WriteLine("MangChuoi.GetLongLength(0) = " + d);

            Console.ReadKey();
        }
    }
}
