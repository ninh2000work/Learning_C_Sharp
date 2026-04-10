using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai23_StructTrongCSharp
{
    internal class Program
    {
        struct NhanVien
        {
            public String FullName;
            public int ID;
            public string PhoneNumber;
            public double Salary;
        }

        static void NhapThongTin(out NhanVien NV)
        {
            Console.Write("Full Name: ");
            NV.FullName = Console.ReadLine();
            Console.Write("ID: ");
            NV.ID = int.Parse(Console.ReadLine());
            Console.Write("Phone Number: ");
            NV.PhoneNumber = Console.ReadLine();
            Console.Write("Salary (milion VND): ");
            NV.Salary = Double.Parse(Console.ReadLine());
        }

        static void XuatThongTin(NhanVien NV)
        {
            Console.WriteLine("Full Name: " + NV.FullName);
            Console.WriteLine("ID: " + NV.ID);
            Console.WriteLine("Phone Number: " + NV.PhoneNumber);
            Console.WriteLine("Salary (milion VND): " + NV.Salary);
        }

        static void Main(string[] args)
        {
            NhanVien A = new NhanVien();
            Console.WriteLine("Nhap Thong Tin Nhan Vien:");
            NhapThongTin(out A);
            Console.WriteLine();
            Console.WriteLine("Xuat Thong Tin Nhan Vien:");
            XuatThongTin(A);
            Console.ReadKey();
        }
    }
}
