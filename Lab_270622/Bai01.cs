using System;
using System.Windows.Forms;

namespace Lab_270622
{
    public partial class Bai01 : Form
    {
        public Bai01()
        {
            InitializeComponent();
        }

        private bool IsValid()
        {
            if (txtNumM.Text == "" || txtNumN.Text == "")
            {
                txtAns.Text = "Vui lòng nhập m và n";
                return false;
            }
            return true;
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            if (IsValid())
                txtAns.Text = (Convert.ToDouble(txtNumM.Text) + Convert.ToDouble(txtNumN.Text)).ToString();
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            if (IsValid())
                txtAns.Text = (Convert.ToDouble(txtNumM.Text) - Convert.ToDouble(txtNumN.Text)).ToString();
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            if (IsValid())
                txtAns.Text = (Convert.ToDouble(txtNumM.Text) * Convert.ToDouble(txtNumN.Text)).ToString();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            if (IsValid())
                txtAns.Text = (Convert.ToDouble(txtNumM.Text) / Convert.ToDouble(txtNumN.Text)).ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNumM.Text = txtNumN.Text = txtAns.Text = "";
        }
    }
}
