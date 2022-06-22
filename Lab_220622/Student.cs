using System;

namespace Lab_220622
{
    class Student
    {
        private int sID;
        private string tenSV;
        private string khoa;
        private double diemTB;

        public Student()
        {
        }

        public Student(int sID, string tenSV, string khoa, double diemTB)
        {
            this.sID = sID;
            this.tenSV = tenSV;
            this.khoa = khoa;
            this.diemTB = diemTB;
        }

        public Student(Student st)
        {
            this.sID = st.sID;
            this.tenSV = st.tenSV;
            this.khoa = st.khoa;
            this.diemTB = st.diemTB;
        }

        public int SID { get; set; }
        public int TenSV { get; set; }
        public int Khoa { get; set; }
        public int DiemTB { get; set; }

        public Student Nhap()
        {
            Student st = new Student();
            Console.Write("- Mã số sinh viên: ");
            st.sID = Convert.ToInt32(Console.ReadLine());
            Console.Write("- Họ tên: ");
            st.tenSV = Console.ReadLine();
            Console.Write("- Tên khoa: ");
            st.khoa = Console.ReadLine();
            Console.Write("- Điểm trung bình: ");
            st.diemTB = Convert.ToDouble(Console.ReadLine());
            return st;
        }

        public void Show()
        {
            Console.WriteLine("Mã số sinh viên: " + sID);
            Console.WriteLine("Họ tên: " + tenSV);
            Console.WriteLine("Tên khoa: " + khoa);
            Console.WriteLine("Điểm trung bình: " + diemTB);
        }
    }
}
