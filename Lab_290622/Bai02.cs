using System;
using System.Windows.Forms;

namespace Lab_290622
{
    public partial class Bai02 : Form
    {
        public Bai02()
        {
            InitializeComponent();
        }

        private void Bai02_Load(object sender, System.EventArgs e)
        {
            lsvList.Items.Add(new ListViewItem(new string[] { "Nguyễn Anh Tài", "16/06/1996", "0982266366", "Cầu Ngang - Trà Vinh" }));
            lsvList.Items.Add(new ListViewItem(new string[] { "Nguyễn Thị Xinh", "13/03/1993", "0977127721", "Tiểu Cần - Trà Vinh" }));
            lsvList.Items.Add(new ListViewItem(new string[] { "Nguyễn Văn Chuyên", "16/06/1996", "0825563365", "Càng Long - Trà Vinh" }));
        }

        private void lsvList_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (lsvList.SelectedItems.Count > 0)
            {
                ListViewItem item = lsvList.SelectedItems[0];
                txtName.Text = item.SubItems[0].Text;
                dtpBirthday.Value = DateTime.ParseExact(item.SubItems[1].Text, "dd/MM/yyyy", null);
                txtPhone.Text = item.SubItems[2].Text;
                txtAddress.Text = item.SubItems[3].Text;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lsvList.Items.Add(new ListViewItem(new string[] { txtName.Text, dtpBirthday.Value.ToString("dd/MM/yyyy"), txtPhone.Text, txtAddress.Text }));
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            lsvList.SelectedItems[0].SubItems[0].Text = txtName.Text;
            lsvList.SelectedItems[0].SubItems[1].Text = dtpBirthday.Value.ToString("dd/MM/yyyy");
            lsvList.SelectedItems[0].SubItems[2].Text = txtPhone.Text;
            lsvList.SelectedItems[0].SubItems[3].Text = txtAddress.Text;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            lsvList.Items.Remove(lsvList.SelectedItems[0]);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
