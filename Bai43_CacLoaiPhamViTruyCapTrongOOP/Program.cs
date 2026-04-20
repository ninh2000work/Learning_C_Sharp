using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai43_CacLoaiPhamViTruyCapTrongOOP
{
    class SinhVien
    {
        private string HoTen;
        private int MSSV;

        public string FullName
        {
            get
            {
                return HoTen;
            }

            set
            {
                HoTen = value;
            }
        }

        public string GetFullName()
        {
            return HoTen;
        }

        public void SetID(int ID)
        {
            MSSV = ID;
        }

        public void InfoStudent()
        {
            Console.WriteLine("Fullname is {0}, ID is {1}", HoTen, MSSV);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            SinhVien A = new SinhVien();
            A.FullName = "HelloWorld";
            Console.WriteLine("FullName is " + A.FullName);

            Console.WriteLine("FullName is " + A.GetFullName());
            A.SetID(1234);
            A.InfoStudent();

            Console.ReadKey();
        }
    }
}
