using System;

namespace Lab_220622
{
    class NhanVien : NhanSu
    {
        private string congViec;

        public NhanVien(string congViec, string hoTen, int tuoi, bool gioiTinh, string diaChi) : base(hoTen, tuoi, gioiTinh, diaChi)
        {
            this.congViec = congViec;
        }

        public int CongViec { get; set; }

        public override void Show()
        {
            base.Show();
            Console.WriteLine("Công việc: " + congViec);
        }
    }
}
