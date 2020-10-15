using System;
using System.Collections.Generic;
using System.Text;

namespace bài_thực_hành_1_kì_1_năm_2
{
    
        class SoPhuc
        {
            private double thuc, ao;
            public SoPhuc()
            {
                thuc = 0;
                ao = 0;
            }
            public SoPhuc(double thuc, double ao)
            {
                this.thuc = thuc;
                this.ao = ao;
            }
            public SoPhuc(SoPhuc t2)
            {
                this.thuc = t2.thuc;
                this.ao = t2.ao;
            }
            public void Nhap()
            {
                Console.Write("Nhap phan thuc:"); thuc = double.Parse(Console.ReadLine());
                Console.Write("Nhap phan ao:"); ao = double.Parse(Console.ReadLine());
            }
            public void Hien()
            {
                string kq = thuc + (ao > 0 ? "+" : "") + ao + "*i";
                Console.WriteLine(kq);
            }
            public static SoPhuc operator +(SoPhuc t1, SoPhuc t2)
            {
                SoPhuc tmp = new SoPhuc();
                tmp.thuc = t1.thuc + t2.thuc;
                tmp.ao = t1.ao + t2.ao;
                return tmp;
            }
            public SoPhuc Tong(SoPhuc t2)
            {
                SoPhuc tmp = new SoPhuc();
                tmp.thuc = this.thuc + t2.thuc;
                tmp.ao = this.ao + t2.ao;
                return tmp;
            }
        }
        class App2
        {
            static void Main2()
            {
                SoPhuc t1 = new SoPhuc(5, 8);
                SoPhuc t2 = new SoPhuc(t1);
                Console.WriteLine("So phuc thu nhat"); t1.Hien();
                Console.WriteLine("So phuc thu hai"); t2.Hien();
                SoPhuc t3 = t1 + t2;//t1.Tong(t2);
                Console.WriteLine("So phuc tong"); t3.Hien();
                Console.ReadLine();
            }
        }


}
