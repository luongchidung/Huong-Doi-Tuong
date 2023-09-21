using HuongDoiTuong;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuongDoiTuong
{

    internal class Class1
    {
        static void Main(string[] args)
        {
            //Khoi tao doi tuong lop Hoc sinh theo Constructor 1
            HocSinh hs = new HocSinh();
            //Khoi tao doi tuong lop Hoc sinh theo Constructor 2
            HocSinh hs2 = new HocSinh(10, "trang", 2005, "thai nguyen");
            //Nhap thong tin sv
            Console.WriteLine("Nhap thong tin hoc sinh: ");
            hs.NhapHS();
            // hocsinh2.NhapHS();
            //Hien thi theo doi tuong hocsinh
            Console.WriteLine("Hien thi thong tin sv theo contructor 1");
            hs.XuatHS();
            Console.WriteLine("Hien thi thong tin sv theo Contructor 2, co doi so truyen vao");

            hs.XuatHS();

            //Dung cho xem man hinh
            Console.Read();
        }
    }
}