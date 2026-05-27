using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Bai44_TuKhoaStaticTrongOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Biến tĩnh
            Console.WriteLine("So luong sinh vien: {0}\n", SinhVien.count);

            SinhVien SV1 = new SinhVien();
            Console.WriteLine("Ten SV: {0}, MSSV: {1}", SV1.Name, SV1.ID);
            Console.WriteLine("So luong sinh vien: {0}\n", SinhVien.count);

            SinhVien SV2 = new SinhVien("B", 2222);
            Console.WriteLine("Ten SV: {0}, MSSV: {1}", SV2.Name, SV2.ID);
            Console.WriteLine("So luong sinh vien: {0}\n", SinhVien.count);
            #endregion

            #region Phương thức tĩnh
            SinhVien.InfoSV("C", 3333);
            Console.WriteLine("So luong sinh vien: {0}\n", SinhVien.count);
            #endregion

            #region Lớp tĩnh
            Console.WriteLine("Truong sinh vien: " + SinhVien.School.SchoolSV());
            #endregion

            #region Phương thức khởi tạo tĩnh (Constructor tĩnh)
            #endregion

            Console.ReadKey();
        }
    }

    class SinhVien
    {
        private string name = "";
        private int id = 1;

        public string Name
        {
            get { return name; }

            set { name = value; }
        }

        public int ID
        {
            get { return id; }

            set { id = value; }
        }

        public SinhVien()
        {
            name = "A";
            id = 1111;
            count++;
        }

        public SinhVien(string name1, int id1)
        {
            name = name1;
            id = id1;
            count++;
        }

        // Biến tĩnh
        public static int count;


        // Phương thức tĩnh
        public static void InfoSV(string name, int id)
        {
            Console.WriteLine("Ten SV: {0}, MSSV: {1}", name, id);
            count++;
        }

        // Lớp tĩnh
        public static class School
        {
            private static string school = "EE";

            public static string SchoolSV()
            {
                return school;
            }
        }

        // Phương thức khởi tạo tĩnh (Constructor tĩnh)
        static SinhVien()
        {
            Console.WriteLine("Static Constructor");
        }
    }
}
