using System;
using System.Windows.Forms;

namespace Lab_290622
{
    public partial class Bai01 : Form
    {
        public Bai01()
        {
            InitializeComponent();
        }

        private void btnCriteria_Click(object sender, EventArgs e)
        {
            if (txtCriteria.Text != "")
            {
                lstImportant.Items.Add(txtCriteria.Text);
                txtCriteria.Text = "";
            }
        }

        private void btnMoveRight_Click(object sender, EventArgs e)
        {
            if (lstImportant.SelectedItems.Count > 0)
            {
                int count = lstImportant.SelectedItems.Count;
                for (int i = 0; i < count; i++)
                    lstNoImportant.Items.Add(lstImportant.SelectedItems[i]);

                for (int i = count - 1; i > -1; i--)
                    lstImportant.Items.Remove(lstImportant.SelectedItems[i]);
            }
        }

        private void btnMoveLeft_Click(object sender, EventArgs e)
        {
            if (lstNoImportant.SelectedItems.Count > 0)
            {
                int count = lstNoImportant.SelectedItems.Count;
                for (int i = 0; i < count; i++)
                    lstImportant.Items.Add(lstNoImportant.SelectedItems[i]);

                for (int i = count - 1; i > -1; i--)
                    lstNoImportant.Items.Remove(lstNoImportant.SelectedItems[i]);
            }
        }

        private void btnMoveRightAll_Click(object sender, EventArgs e)
        {
            foreach (object item in lstImportant.Items)
                lstNoImportant.Items.Add(item);
            lstImportant.Items.Clear();
        }

        private void btnMoveLeftAll_Click(object sender, EventArgs e)
        {
            foreach (object item in lstNoImportant.Items)
                lstImportant.Items.Add(item);
            lstNoImportant.Items.Clear();
        }
    }
}
