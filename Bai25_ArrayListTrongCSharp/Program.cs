using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using Microsoft.SqlServer.Server;
using System.Diagnostics.Eventing.Reader;

namespace Bai25_ArrayListTrongCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Khởi tạo ArrayList
            // Khởi tạo 1 ArrayList rỗng
            ArrayList MyArray1 = new ArrayList();

            // Khởi tạo 1 ArrayList và chỉ định Capacity ban đầu là 5
            ArrayList MyArray2 = new ArrayList(5);

            // Khởi tạo 1 ArrayList có kích thước bằng với MyArray2
            // Sao chép toàn bộ phần từ trong MyArray2 vào MyArray3
            ArrayList MyArray3 = new ArrayList(MyArray2);
            #endregion

            #region Một số thuộc tính và phương thức hỗ trợ sẵn trong ArrayList
            #endregion

            #region Ví dụ sắp xếp 1 danh sách object trong ArrayList
            // Tạo 1 danh sách kiểu ArrayList rỗng
            ArrayList arrPerSons = new ArrayList();

            // Thêm 3 Person vào danh sách
            arrPerSons.Add(new Person("A",18));
            arrPerSons.Add(new Person("B", 10));
            arrPerSons.Add(new Person("C", 50));
            arrPerSons.Add(new Person("D", 37));
            arrPerSons.Add(new Person("E", 25));

            // In danh sách Person ban đầu ra
            Console.WriteLine("Old List Person: ");
            foreach (Person item in arrPerSons)
            {
                Console.WriteLine(item.ToString());
            }

            Console.ReadKey();

            // Sắp xếp danh sách Person theo tiêu chí tuổi tăng dần
            arrPerSons.Sort(new SortPersons());

            // In danh sách Person sau khi sắp xếp
            Console.WriteLine("New List Person: ");
            foreach (Person item in arrPerSons)
            {
                Console.WriteLine(item.ToString());
            }
            #endregion

            Console.ReadKey();
        }
    }
    
    public class Person
    {
        private string name;
        private int age;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        // Tạo 1 constructor có tham số để tiện cho việc khởi tạo nhanh đối tượng Person với các giá trị cho sẵn
        public Person(string Name, int Age)
        {
            this.Name = Name;
            this.Age = Age;
        }

        // Override phương thức ToString để khi cần có thể in thông tin của object ra cho nhanh.
        public override string ToString()
        {
            return "Name: " + name + " || Age: " + age;
        }
    }

    public class SortPersons : IComparer
    {
        public int Compare(object x, object y)
        {
            // Ép kiểu 2 object truyền vào về Person
            Person p1 = x as Person;
            Person p2 = y as Person;

            // Vì có thể 2 object truyền vào không phải Person khi đó ta không thể so sánh được
            if (p1 == null || p2 == null)
            {
                throw new InvalidOperationException();
            }
            else
            {
                if (p1.Age > p2.Age)
                {
                    return 1;
                }
                else if (p1.Age == p2.Age)
                {
                    return 0;
                }
                else
                {
                    return -1;
                }
            }    
        }
    }
}
