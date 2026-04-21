using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Bai44_TuKhoaStaticTrongOOP
{
    internal class Program
    {
        class SinhVien
        {
            private string hoten;
            private int mssv;

            public string Hoten
            {
                get { return hoten; }

                set { hoten = value; }
            }

            public int Mssv
            {
                get { return mssv; }  
                
                set { mssv = value; }
            }

            public static int Count;

            public SinhVien()
            {
                hoten = "A";
                mssv = 1234;
                Count++;
            }

            public SinhVien(string ten, int ms)
            {
                hoten = ten;
                mssv = ms;
                Count++;
            }

            public void ThongTin()
            {
                Console.WriteLine("TenSV: {0}, MSSV: {1}\n", hoten, mssv);
            }

            public static void ThongTinSV(string ten1, int ms1)
            {
                Console.WriteLine("TenSV: {0}, MSSV: {1}", ten1, ms1);
                Count++;
            }
        }

        static class NhanVien
        {
            public static int MaNV = 456;

            public static void TenNhanVien(string TenNV)
            {
                Console.WriteLine("TenNV: {0}, MaNV: {1}", TenNV, MaNV);
            }
        }

        class HocSinh
        {
            public static string TenHS;
            static HocSinh()
            {
                TenHS = "E";
            }
        }

        static void Main(string[] args)
        {
            #region Biến tĩnh
            Console.WriteLine("So luong sinh vien: {0}\n", SinhVien.Count);

            SinhVien SV1 = new SinhVien();
            Console.WriteLine("So luong sinh vien: " + SinhVien.Count);
            Console.WriteLine("TenSV: {0}, MSSV: {1}", SV1.Hoten, SV1.Mssv);
            SV1.ThongTin();

            SinhVien SV2 = new SinhVien("B", 5678);
            Console.WriteLine("So luong sinh vien: " + SinhVien.Count);
            Console.WriteLine("TenSV: {0}, MSSV: {1}", SV2.Hoten, SV2.Mssv);
            SV2.ThongTin();
            #endregion

            #region Phương thức tĩnh
            SinhVien.ThongTinSV("C", 2468);
            Console.WriteLine("So luong sinh vien: " + SinhVien.Count);
            #endregion

            #region Lớp tĩnh
            Console.WriteLine();
            NhanVien.TenNhanVien("D");
            #endregion

            #region Phương thức khởi tạo tĩnh (Constructor tĩnh)
            Console.WriteLine();
            Console.WriteLine("TenHS: " + HocSinh.TenHS);
            #endregion

            Console.ReadKey();
        }
    }
}
