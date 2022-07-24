using System;
using System.Windows.Forms;

namespace Lab_270622
{
    public partial class Bai02 : Form
    {
        string numA = "";
        string numB = "";
        string oper = "";

        public Bai02()
        {
            InitializeComponent();
        }

        private void btnNum_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            txtAns.Text += btn.Text;

            if (oper == "")
                numA += btn.Text;
            else
                numB += btn.Text;
        }

        private void btnOperator_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            txtAns.Text += btn.Text;
            oper = btn.Text;
        }

        private void btnAns_Click(object sender, EventArgs e)
        {
            double value = 0;
            if (oper == "+")
                value = Convert.ToDouble(numA) + Convert.ToDouble(numB);
            else if (oper == "-")
                value = Convert.ToDouble(numA) - Convert.ToDouble(numB);
            else if (oper == "*")
                value = Convert.ToDouble(numA) * Convert.ToDouble(numB);
            else if (oper == "/")
                value = Convert.ToDouble(numA) / Convert.ToDouble(numB);
            txtAns.Text = value.ToString();
            numA = txtAns.Text;
            numB = oper = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAns.Text = numA = numB = oper = "";
        }
    }
}
