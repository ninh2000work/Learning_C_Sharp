using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai06_EpKieuTrongCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Chuyển đổi ngầm định (implicit)
            //int a = 2;
            //long b = a;
            //Console.WriteLine("a = {0}, b = {1}", a, b);

            //float c = 5.6f;
            //double d = c;
            //Console.WriteLine("c = {0}, d = {1}", c, d);

            //Console.ReadKey();
            #endregion

            #region Chuyển đổi tường minh (explicit)
            //int a = 100000;
            //short b = (short)a;
            //Console.WriteLine("a = {0}, b = {1}", a, b);

            //double c = 2 / 3;
            //double d = (double)2 / 3;
            //double e = 1.0f * 2 / 3;
            //Console.WriteLine("c = {0}, d = {1}, e = {2}", c, d, e);

            //Console.ReadKey();
            #endregion

            #region Parse()
            //string a = "12";
            //int b = int.Parse(a);
            //Console.WriteLine("a = {0}, b = {1}", a, b);

            //string c = "34.56";
            //float d = float.Parse(c);
            //Console.WriteLine("c = {0}, d = {1}", c, d);

            //Console.ReadKey();
            #endregion

            #region TryParse()
            //int a;
            //bool b;
            //string c = "10", d = "HelloWorld";

            //b = int.TryParse(c, out a);
            //Console.WriteLine((b == true) ? "OK" : "NG");
            //Console.WriteLine("a = " + a);

            //b = int.TryParse(d, out a);
            //Console.WriteLine((b == true) ? "OK" : "NG");
            //Console.WriteLine("a = " + a);

            //Console.ReadKey();
            #endregion

            #region Convert()
            //double a = 10.235;
            //float b = Convert.ToSingle(a);
            //Console.WriteLine("b = " + b);
            //Console.ReadKey();
            #endregion
        }
    }
}
