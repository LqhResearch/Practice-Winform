using System;

namespace Lab_220622
{
    class KySu : NhanSu
    {
        private string nganh_dt;

        public KySu(string nganh_dt, string hoTen, int tuoi, bool gioiTinh, string diaChi) : base(hoTen, tuoi, gioiTinh, diaChi)
        {
            this.nganh_dt = nganh_dt;
        }

        public int Nganh_DT { get; set; }

        public override void Show()
        {
            base.Show();
            Console.WriteLine("Ngành đào tạo: " + nganh_dt);
        }
    }
}
