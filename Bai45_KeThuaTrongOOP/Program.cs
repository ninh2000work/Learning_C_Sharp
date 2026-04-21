using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai45_KeThuaTrongOOP
{
    class People
    {
        protected string Name;
        protected int Age;

        public People()
        {
            
        }

        public People(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void Info()
        {
            Console.WriteLine("Name is {0}, Age is {1}", Name, Age);
        }

        public void Info1()
        {
            Console.WriteLine("Name is {0}, Age is {1}", Name, Age);
        }

        public void Info2()
        {
            Console.WriteLine("Name is {0}, Age is {1}", Name, Age);
        }
    }

    class Student : People
    {
        public Student()
        {
            Name = "A";
            Age = 20;
        }

        public Student(string name1, int age1) : base(name1, age1)
        {

        }

        public void Info1()
        {
            Console.WriteLine("Name is {0}, Age is {1}", Name, Age);
        }

        public new void Info2()
        {
            Console.WriteLine("Name is {0}, Age is {1}", Name, Age);
            base.Info2();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Student SV1 = new Student();
            SV1.Info();
            SV1.Info1();

            Student SV2 = new Student("B", 22);
            SV2.Info();
            SV2.Info2();

            Console.ReadKey();
        }
    }
}
