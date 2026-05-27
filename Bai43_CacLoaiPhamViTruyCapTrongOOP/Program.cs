using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai43_CacLoaiPhamViTruyCapTrongOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SinhVien A = new SinhVien();
            A.InfoStudent();

            A.FullName = "B";
            A.ID = 2222;
            A.InfoStudent();

            A.FullName = "C";
            Console.WriteLine("FullName is " + A.GetFullName());
            A.SetID(1234);
            A.InfoStudent();

            Console.ReadKey();
        }
    }

    class SinhVien
    {
        private string HoTen = "A";
        private int MSSV = 1111;

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

        public int ID
        {
            get
            {
                return MSSV;
            }

            set
            {
                MSSV = value;
            }
        }

        public string GetFullName()
        {
            return HoTen;
        }

        public void SetID(int id)
        {
            MSSV = id;
        }

        public void InfoStudent()
        {
            Console.WriteLine("Fullname is {0}, ID is {1}\n", HoTen, MSSV);
        }
    }
}
