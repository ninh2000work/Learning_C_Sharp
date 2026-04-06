using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4_ToanTuTrongCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Toán tử toán học
            int a, b, c;
            Console.WriteLine("a = {0}, b = {1}, a + b = {2}", a = 5, b = 3, a + b);
            Console.WriteLine("a = {0}, b = {1}, a - b = {2}", a = 5, b = 3, a - b);
            Console.WriteLine("a = {0}, b = {1}, a * b = {2}", a = 5, b = 3, a * b);
            Console.WriteLine("a = {0}, b = {1}, a / b = {2}", a = 5, b = 3, a / b);
            Console.WriteLine("a = {0}, b = {1}, a % b = {2}", a = 5, b = 3, a % b);
            Console.WriteLine("c = {0}, c++ = {1}, c = {2}", c = 10, c++, c);
            Console.WriteLine("c = {0}, ++c = {1}, c = {2}", c = 10, ++c, c);
            Console.WriteLine("c = {0}, c-- = {1}, c = {2}", c = 10, c--, c);
            Console.WriteLine("c = {0}, --c = {1}, c = {2}", c = 10, --c, c);
            Console.ReadKey();
            #endregion

            #region Toán tử quan hệ
            int a = 2, b = 3;
            Console.WriteLine("a = {0}, b = {1}", a, b);
            //So sánh 2 toán hạng có bằng nhau không
            if (a == b)
            {
                Console.WriteLine("a = b is true");
            }
            else
            {
                Console.WriteLine("a = b is false");
            }
            //So sánh 2 toán hạng có khác nhau không
            if (a != b)
            {
                Console.WriteLine("a != b is true");
            }
            else
            {
                Console.WriteLine("a != b is false");
            }
            //So sánh toán hạng bên trái có lớn hơn toán hạng bên phải không
            if (a > b)
            {
                Console.WriteLine("a > b is true");
            }
            else
            {
                Console.WriteLine("a > b is false");
            }
            //So sánh toán hạng bên trái có bé hơn toán hạng bên phải không
            if (a < b)
            {
                Console.WriteLine("a < b is true");
            }
            else
            {
                Console.WriteLine("a < b is false");
            }
            //So sánh toán hạng bên trái có lớn hơn hoặc bằng toán hạng bên phải không
            if (a >= b)
            {
                Console.WriteLine("a >= b is true");
            }
            else
            {
                Console.WriteLine("a >= b is false");
            }
            //So sánh toán hạng bên trái có bé hơn hoặc bằng toán hạng bên phải không
            if (a <= b)
            {
                Console.WriteLine("a <= b is true");
            }
            else
            {
                Console.WriteLine("a <= b is false");
            }
            Console.ReadKey();
            #endregion

            #region Toán tử logic
            int a = 1, b = 2, c = 3, d = 4;
            Console.WriteLine("a = {0}, b = {1}, c = {2}, d = {3}", a, b, c, d);
            //Toán tử logic AND
            if ((a < b) && (c < d))
            {
                Console.WriteLine("(a < b) && (c < d) is true");
            }
            else
            {
                Console.WriteLine("(a < b) && (c < d) is false");
            }
            //Toán tử logic OR
            if ((a < b) || (c == d))
            {
                Console.WriteLine("(a < b) || (c = d) is true");
            }
            else
            {
                Console.WriteLine("(a < b) || (c = d) is false");
            }
            //Toán tử logic NOT
            if (!(a < b))
            {
                Console.WriteLine("!(a < b) is true");
            }
            else
            {
                Console.WriteLine("!(a < b) is false");
            }
            Console.ReadKey();
            #endregion

            #region Toán tử khởi tạo và gán
            int a, b;
            Console.WriteLine("a = {0}, b = {1}, a += b is {2}", a = 5, b = 3, a += b);
            Console.WriteLine("a = {0}, b = {1}, a -= b is {2}", a = 5, b = 3, a -= b);
            Console.WriteLine("a = {0}, b = {1}, a *= b is {2}", a = 5, b = 3, a *= b);
            Console.WriteLine("a = {0}, b = {1}, a /= b is {2}", a = 5, b = 3, a /= b);
            Console.WriteLine("a = {0}, b = {1}, a %= b is {2}", a = 5, b = 3, a %= b);
            Console.ReadKey();
            #endregion

            #region Toán tử so sánh trên bit
            int a, b, c;
            Console.WriteLine("a = {0}, b = {1}, c = a&b is {2}", a = 2, b = 3, a &= b);    //a = 2 = 0b0010, b = 3 = 0b0011, a &= b = 0b0010 = 2
            Console.WriteLine("a = {0}, b = {1}, c = a|b is {2}", a = 2, b = 3, a |= b);    //a = 2 = 0b0010, b = 3 = 0b0011, a |= b = 0b0011 = 3
            Console.WriteLine("a = {0}, b = {1}, c = a^b is {2}", a = 2, b = 3, a ^= b);    //a = 2 = 0b0010, b = 3 = 0b0011, a ^= b = 0b0001 = 1
            Console.WriteLine("a = {0}, c = ~a is {1}", a = 2, ~a);                         //a = 2 = 0b0010, c = 0b1101 = -3
            Console.WriteLine("a = {0}, c = a<<2 is {1}", a = 2, a << 2);                   //a = 2 = 0b0010, c = 0b1000 = 8
            Console.WriteLine("a = {0}, c = a>>2 is {1}", a = 2, a >> 2);                   //a = 2 = 0b0010, c = 0b0000 = 0
            Console.ReadKey();
            #endregion

            #region Toán tử khác
            int a = 10;
            string b;
            b = (a == 10) ? ("a = 10") : ("a != 10");   //Toán tử ba ngôi
            Console.WriteLine(b);
            Console.ReadKey();
            #endregion
        }
    }
}
