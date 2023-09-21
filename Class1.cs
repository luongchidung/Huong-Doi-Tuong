
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace HuongDoiTuong
{
    internal class HocSinh
    {
        //Khai bao thuoc tinh
        private int MaHS;
        string TenHS;
        int namSinh;
        string DiaChi;
        double diemToan, diemVan, diemAnh, DTB;
        // Xay dung ham khoi tao doi tuong Constructor 1
        public HocSinh()
        {
        }
        //Xay dung ham Constructor 2
        public HocSinh(int ma, string ten, int ns, string diaChi)
        {
            MaHS = ma;
            TenHS = ten;
            namSinh = ns;
            DiaChi = diaChi;
        }
        public void NhapHS()
        {
            Console.Write("Nhap ma HS: ");
            MaHS = Convert.ToInt16(Console.ReadLine());
            Console.Write("Nhap ten hoc sinh: ");
            TenHS = Console.ReadLine();
            Console.Write("Nhap nam sinh: ");
            namSinh = Convert.ToInt16(Console.ReadLine());
            Console.Write("Nhap dia chi: ");
            DiaChi = Console.ReadLine();
            Console.Write("Nhap diem toan: ");
            diemToan = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap diem van: ");
            diemVan = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap diem anh: ");
            diemAnh = Convert.ToDouble(Console.ReadLine());

          
        }
        
       
        public Double TinhDTB()
        {
            DTB = Math.Round((diemAnh + diemToan + diemVan) / 3, 1);
            return DTB;
        }
        public void XuatHS()
        {

            Console.WriteLine("Thong tin sinh vien la ");
            Console.WriteLine("Ma hoc sinh: " + MaHS );
            Console.WriteLine("Ten hoc sinh: " + TenHS );
            Console.WriteLine("Nam sinh: " + namSinh );
            Console.WriteLine("Dia chi: " + DiaChi);
            Console.WriteLine("Diem trung binh: " + TinhDTB());

            Console.ReadKey();

        }
       

    }
}