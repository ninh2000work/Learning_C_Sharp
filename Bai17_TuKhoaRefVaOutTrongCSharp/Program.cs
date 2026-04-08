using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai17_TuKhoaRefVaOutTrongCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5, b = 20;
            int c, d;
            Console.WriteLine("a = {0}, b = {1}", a, b);
            Demo1(a,b);   //a,b chưa thay đổi giá trị sau khi chạy hàm Demo1(a,b)
            Console.WriteLine("a = {0}, b = {1}", a, b);
            Demo2(ref a,ref b);   //a,b thay đổi giá trị sau khi chạy hàm Demo2(ref a,ref b)
            Console.WriteLine("a = {0}, b = {1}", a, b);
            Demo3(out c, out d);   //a,b thay đổi giá trị sau khi chạy hàm Demo3(out c, out d)
            Console.WriteLine("c = {0}, d = {1}", c, d);
            Console.ReadKey();
        }
        static void Demo1(int a, int b)
        {
            a += 10;
            b *= 2;
        }
        static void Demo2(ref int a, ref int b)
        {
            a += 10;
            b *= 2;
        }
        static void Demo3(out int e, out int f)
        {
            e = 2;
            e++;
            f = 1;
            f--;
        }
    }
}
