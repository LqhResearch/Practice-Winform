using System;
using System.Windows.Forms;

namespace Lab_270622
{
    public partial class Bai03 : Form
    {
        public Bai03()
        {
            InitializeComponent();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            int money = 0;
            if (ckbFood1.Checked)
                money += 20000;
            if (ckbFood2.Checked)
                money += 25000;
            if (ckbFood3.Checked)
                money += 20000;
            money += Convert.ToInt32(nudFood4.Value) * 25000;
            txtPay.Text = money.ToString() + " đ";
        }
    }
}
