using System;

namespace Lab_220622
{
    class PhanSo
    {
        private int tuSo;
        private int mauSo;

        public PhanSo()
        {
            tuSo = 0;
            mauSo = 1;
        }

        public PhanSo(int tuSo, int mauSo)
        {
            this.tuSo = tuSo;
            this.mauSo = mauSo;
        }

        public PhanSo(PhanSo ps)
        {
            this.tuSo = ps.tuSo;
            this.mauSo = ps.mauSo;
        }

        public int TuSo { get; set; }
        public int MauSo { get; set; }

        public PhanSo Nhap()
        {
            PhanSo ps = new PhanSo();
            Console.Write("- Tử số: ");
            ps.tuSo = Convert.ToInt32(Console.ReadLine());
            Console.Write("- Mẫu số: ");
            ps.mauSo = Convert.ToInt32(Console.ReadLine());
            return ps;
        }

        public void Show()
        {
            Console.Write("Phân số: " + tuSo + "/" + mauSo);
        }

        public PhanSo Add(PhanSo ps)
        {
            PhanSo p = new PhanSo();
            p.tuSo = tuSo * ps.mauSo + mauSo * ps.tuSo;
            p.mauSo = mauSo * ps.mauSo;
            return p;
        }

        public PhanSo Sub(PhanSo ps)
        {
            PhanSo p = new PhanSo();
            p.tuSo = tuSo * ps.mauSo - mauSo * ps.tuSo;
            p.mauSo = mauSo * ps.mauSo;
            return p;
        }

        public PhanSo Mul(PhanSo ps)
        {
            PhanSo p = new PhanSo();
            p.tuSo = tuSo * ps.tuSo;
            p.mauSo = mauSo * ps.mauSo;
            return p;
        }

        public PhanSo Div(PhanSo ps)
        {
            PhanSo p = new PhanSo();
            p.tuSo = tuSo * ps.mauSo;
            p.mauSo = mauSo * ps.tuSo;
            return p;
        }
    }
}
