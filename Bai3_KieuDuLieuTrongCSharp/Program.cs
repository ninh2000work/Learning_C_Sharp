using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3_KieuDuLieuTrongCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Kiểu số nguyên
            byte BienByte = 234;            //1 byte    - Số nguyên dương không dấu có giá trị từ 0 đến 255
            Console.WriteLine(BienByte);
            sbyte BienSbyte = -123;         //1 byte    - Số nguyên có dấu có giá trị từ -128 đến 127
            Console.WriteLine(BienSbyte);
            short BienShort = -1234;        //2 bytes   - Số nguyên có dấu có giá trị từ -32,768 đến 32,767
            Console.WriteLine(BienShort);
            ushort BienUshort = 3456;       //2 bytes   - Số nguyên không dấu có giá trị từ 0 đến 65,535
            Console.WriteLine(BienUshort);
            int BienInt = -12345678;        //4 bytes   - Số nguyên có dấu có giá trị từ -2,147,483,647 đến 2,147,483,647
            Console.WriteLine(BienInt);
            uint BienUint = 23456789;       //4 bytes   - Số nguyên không dấu có giá trị từ 0 đến 4,294,967,295
            Console.WriteLine(BienUint);
            long BienLong = -123456789;     //8 bytes   - Số nguyên có dấu có giá trị từ -9,223,370,036,854,775,808 đến 9,223,370,036,854,775,807
            Console.WriteLine(BienLong);
            ulong BienUlong = 234567890;    //8 bytes   - Số nguyên không dấu có giá trị từ 0 đến 18,446,744,073,709,551,615
            Console.WriteLine(BienUlong);
            #endregion

            #region Kiểu số thực
            float BienFloat = 1.2f;         //4 bytes   - Kiểu số thực dấu chấm động có giá trị dao động từ 3.4E–38 đến 3.4E+38, với 7 chữ số có nghĩa
            Console.WriteLine(BienFloat);
            double BienDouble = 34.56;      //8 bytes   - Kiểu số thực dấu chấm động có giá trị dao động từ 1.7E–308 đến 1.7E+308, với 15, 16 chữ số có nghĩa
            Console.WriteLine(BienDouble);
            decimal BienDecimal = 78.901m;  //8 bytes   - Có độ chính xác đến 28 con số và giá trị thập phân
            Console.WriteLine(BienDecimal);
            #endregion

            #region Kiểu logic
            bool BienLogic = true;          //1 byte    - Chứa 1 trong 2 giá trị logic là true hoặc false
            Console.WriteLine(BienLogic);
            #endregion

            #region Kiểu ký tự
            Char BienChar = 'A';            //2 bytes   - Chứa một ký tự Unicode
            Console.WriteLine(BienChar);
            #endregion

            #region Kiểu chuỗi
            string BienChuoi = null;
            Console.WriteLine(BienChuoi);
            #endregion

            Console.ReadKey();
        }
    }
}
