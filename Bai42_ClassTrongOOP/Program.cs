using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai42_ClassTrongOOP
{
    class Animal
    {
        public double Weight;
        public double Height;

        public void Info()
        {
            Console.WriteLine("Weight: " + Weight);
            Console.WriteLine("Height: " + Height);
        }
    }
    class Student
    {
        public String School;
        public String Class;

        public Student()
        {
            School = "EE";
            Class = "EE2-10-K64";
        }

        public Student(string s, string c)
        {
            School = s;
            Class = c;
        }

        ~Student()
        {
            Console.WriteLine("Destructor");
        }

        public void InfoStudent()
        {
            Console.WriteLine("School of Student is: " + School);
            Console.WriteLine("Class of Student is: " + Class);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Khai báo, khởi tạo và sử dụng Class
            Animal Lion = new Animal();
            Lion.Weight = 250.0;
            Lion.Height = 1.2;
            Lion.Info();

            Console.WriteLine();
            #endregion

            #region Phương thức khởi tạo (Constructor) + Phương thức hủy bỏ (Destructor)
            Student A = new Student();
            A.InfoStudent();

            Student B = new Student("IT", "IT2-01-K63");
            B.InfoStudent();

            Console.WriteLine();
            #endregion

            Console.ReadKey();
        }
    }
}
