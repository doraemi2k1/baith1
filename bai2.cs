using System;
using System.Collections.Generic;
using System.Text;

namespace bài_thực_hành_1_kì_1_năm_2
{
    class Employee
    {
        private int id;
        private string name;
        private int yearOfBirth;
        private double salaryLever;
        private double basicSalary;
        public int  getld()
        {
            return id;
        }
        public string getname()
        {
            return name;
        }
        public int getyearOBirth()
        {
            return yearOfBirth;
        }
        public double getIncome()
        {
            return salaryLever * basicSalary;
        }
        public void display()
        {
            Console.WriteLine("Thong tin ve nguoi lao dong:");
            Console.Write("Dinh danh", id, "Ten", name, "Nam sinh", yearOfBirth, "Luong co ban", basicSalary, "Thu nhap", getIncome);
        }
    }
}
