using System;

namespace Lab_220622
{
    class NhanSu
    {
        private string hoTen;
        private int tuoi;
        private bool gioiTinh;
        private string diaChi;

        public NhanSu()
        {
            hoTen = "";
            tuoi = 0;
            gioiTinh = true;
            diaChi = "";
        }

        public NhanSu(string hoTen, int tuoi, bool gioiTinh, string diaChi)
        {
            this.hoTen = hoTen;
            this.tuoi = tuoi;
            this.gioiTinh = gioiTinh;
            this.diaChi = diaChi;
        }

        public string Hoten { get; set; }
        public int Tuoi { get; set; }
        public bool GioiTinh { get; set; }
        public string DiaChi { get; set; }

        public virtual void Show()
        {
            Console.WriteLine("Họ tên: " + hoTen);
            Console.WriteLine("Tuổi: " + tuoi);
            Console.WriteLine("Giới tính: " + gioiTinh);
            Console.WriteLine("Địa chỉ: " + diaChi);
        }

        public override bool Equals(object obj)
        {
            return obj is NhanSu ns && hoTen == ns.hoTen && tuoi == ns.tuoi && gioiTinh == ns.GioiTinh && diaChi == ns.diaChi;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
