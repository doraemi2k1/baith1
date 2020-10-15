using System;
using System.Collections.Generic;
using System.Text;

namespace bài_thực_hành_1_kì_1_năm_2
{
    class Diem
    {
        private double x, y;
        public Diem()
        {
            x = y = 0;
        }
        public Diem(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public void Nhap()
        {
            Console.Write("Nhap x:");
            x = double.Parse(Console.ReadLine());
            Console.Write("Nhap y:");
            y = double.Parse(Console.ReadLine());
        }
        public void Hien()
        {
            Console.WriteLine("Toa do (x,y)=({0},{1})");
        }
        public double TinhDT(Diem B)
        {
            return Math.Sqrt(Math.Pow(B.x - this.x, 2) + Math.Pow(B.y - this.y, 2));
        }
    }
}
