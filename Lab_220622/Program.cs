using System;

namespace Lab_220622
{
    class Program
    {
        private static void Lab1()
        {
            Student st = new Student();
            st = st.Nhap();
            st.Show();
            Console.ReadLine();
        }

        private static void Lab2()
        {
            PhanSo ps1 = new PhanSo();
            PhanSo ps2 = new PhanSo();
            ps1 = ps1.Nhap();
            ps2 = ps2.Nhap();
            Console.WriteLine("Tổng: ");
            ps1.Add(ps2).Show();
            Console.ReadLine();
        }

        private static void Lab3()
        {
            CongNhan cn = new CongNhan(7, "Hồng Hạnh", 35, false, "Châu Thành - Trà Vinh");
            CongNhan cn2 = new CongNhan(7, "Hồng Hạnh", 35, false, "Châu Thành - Trà Vinh");
            Console.WriteLine(cn.Equals(cn2));
            Console.WriteLine(cn.ToString());
            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Lab3();
        }
    }
}
