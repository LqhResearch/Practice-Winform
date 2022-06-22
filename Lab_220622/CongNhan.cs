using System;

namespace Lab_220622
{
    class CongNhan : NhanSu
    {
        private int bac;

        public CongNhan(int bac, string hoTen, int tuoi, bool gioiTinh, string diaChi) : base(hoTen, tuoi, gioiTinh, diaChi)
        {
            this.bac = bac;
        }

        public int Bac { get; set; }

        public override void Show()
        {
            base.Show();
            Console.WriteLine("Bậc: " + bac);
        }
    }
}
