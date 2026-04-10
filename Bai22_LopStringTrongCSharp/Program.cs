using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai22_LopStringTrongCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Lớp String trong C#
            string a = " Hello World ! ";

            //Tính độ dài chuỗi
            Console.WriteLine("a = \"{0}\", a.Length = {1}", a, a.Length);

            //So sánh chuỗi
            Console.WriteLine("a = \"{0}\", a.CompareTo(\" Hello Z\") = {1}", a, a.CompareTo(" Hello Z"));
            Console.WriteLine("a = \"{0}\", String.Compare(a,\" HellO\") = {1}", a, String.Compare(a, " HellO"));

            //Trả về vị trí xuất hiện đầu tiên của ký tự
            Console.WriteLine("a = \"{0}\", a.IndexOf('o') = {1}", a, a.IndexOf('o'));

            //Trả về vị trí xuất hiện cuối cùng của ký tự
            Console.WriteLine("a = \"{0}\", a.LastIndexOf('o') = {1}", a, a.LastIndexOf('o'));

            //Loại bỏ ký tự khoảng trắng ở đầu và cuối chuỗi
            Console.WriteLine("a = \"{0}\", a.Trim() = \"{1}\"", a, a.Trim());

            //Chèn chuỗi mới vào vị trí xác định
            Console.WriteLine("a = \"{0}\", a.Insert(6,\"And \") = \"{1}\"", a, a.Insert(6, " And"));

            //Xóa một chuỗi ký tự từ vị trí xác định
            Console.WriteLine("a = \"{0}\", a.Remove(1,5) = \"{1}\"", a, a.Remove(1, 5));

            //Thay thế ký tự trong chuỗi
            Console.WriteLine("a = \"{0}\", a.Replace('o','a') = \"{1}\"", a, a.Replace('o', 'a'));

            //Cắt chuỗi từ vị trí xác định
            Console.WriteLine("a = \"{0}\", a.Substring(7,5) = \"{1}\"", a, a.Substring(7, 5));
            Console.WriteLine("a = \"{0}\", a.Substring(6) = \"{1}\"", a, a.Substring(6));

            //Tách chuỗi tại vị trí ký tự xác định
            string[] aSplit = a.Split(' ');
            for (int i = 0; i < aSplit.Length; i++)
            {
                Console.WriteLine("a = \"{0}\", aSplit[{1}] = \"{2}\"", a, i, aSplit[i]);
            }

            //Nối chuỗi
            Console.WriteLine("a = \"{0}\", String.Concat(a,\"Hi!\") = \"{1}\"", a, String.Concat(a,"Hi!"));

            //Kiểm tra chuỗi có phải là chuỗi rỗng
            Console.WriteLine("a = \"{0}\", String.IsNullOrEmpty(a) = {1}", a, String.IsNullOrEmpty(a));

            Console.WriteLine();

            Console.ReadKey();
            #endregion

            #region Ứng dụng lớp String vào xử lý chuỗi
            string b = "        hI,    HoW          ARe       YoU?   ";
            string b1 = null;
            string b2 = null;
            Console.WriteLine("b = \"{0}\"", b);

            string c = b.Trim();
            Console.WriteLine("c = \"{0}\"", c);

            string d = c;
            while (d.IndexOf("  ") != -1)
            {
                d = d.Replace("  ", " ");
                Console.WriteLine("d = \"{0}\"", d);
            }

            string[] e = d.Split(' ');
            for(int i = 0;i < e.Length;i++)
            {
                Console.Write("e[{0}] = \"{1}\"\t||\t", i, e[i]);
                string f = e[i].Substring(0, 1);
                string g = e[i].Substring(1);
                e[i] = f.ToUpper() + g.ToLower();
                Console.WriteLine("e[{0}] = \"{1}\"", i, e[i]);
                b1 += e[i] + " ";
            }

            Console.WriteLine("b = \"{0}\"", b);
            Console.WriteLine("b1 = \"{0}\"", b1);
            b2 = b1.Trim();
            Console.WriteLine("b2 = \"{0}\"", b2);

            Console.WriteLine();

            Console.ReadKey();
            #endregion

            #region StringBuilder
            StringBuilder sb1 = new StringBuilder("Hello");
            StringBuilder sb2 = new StringBuilder();
            sb2.Append("World");

            Console.WriteLine("sb1 = \"{0}\"", sb1);
            Console.WriteLine("sb2 = \"{0}\"", sb2);

            //Nối chuỗi
            Console.WriteLine("sb1.Append(sb2) = \"{0}\", sb1 = \"{1}\"", sb1.Append(sb2), sb1);

            //Xóa nội dung chuỗi
            Console.WriteLine("sb1.Clear() = \"{0}\", sb1 = \"{1}\"", sb1.Clear(), sb1);

            //Chuyển đối tượng kiểu StringBuilder sang kiểu String
            string sb3 = sb2.ToString();
            Console.WriteLine("sb2 = \"{0}\", sb3 = \"{1}\"", sb2, sb3);

            Console.ReadKey();
            #endregion
        }
    }
}
