using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai46_DaHinhTrongOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            People A = new Men();
            A.Info1();

            People B = new Women();
            B.Info2();

            University C = new School();
            C.Info();

            Console.ReadKey();
        }
    }

    class People
    {
        public void Info1()
        {
            Console.WriteLine("People1");
        }

        public virtual void Info2()
        {
            Console.WriteLine("People2");
        }
    }

    class Men : People
    {
        public void Info1()
        {
            // Lớp cha đã có phương thức này => Warning
            Console.WriteLine("Men");
        }
    }

    class Women : People
    {
        public override void Info2()
        {
            Console.WriteLine("Women");
        }
    }

    abstract class University
    {
        public abstract void Info();
        // Phương thức này phải là trống rỗng, không cho phép code tại đây
    }

    class School : University
    {
        public override void Info()
        {
            Console.WriteLine("School");
        }
    }
}
