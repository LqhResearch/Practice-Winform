using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Lab_290622
{
    public partial class Bai03_List : Form
    {
        List<Student> lists = new List<Student>();

        public Bai03_List()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Student s = new Student();
            Bai03 frm = new Bai03();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                s.Name = frm.txtName.Text;
                s.Gender = frm.rdMale.Checked;
                s.Birthday = Convert.ToInt32(frm.txtBirthday.Text);
                s.Phone = frm.txtPhone.Text;
                s.Address = frm.txtAddress.Text;
                s.Course = frm.cboCourse.SelectedText;
                lists.Add(s);
                lsvList.Items.Add(s.Name);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Student s = lsvList.SelectedItem as Student;
            Bai03 frm = new Bai03();

            if (frm.ShowDialog() == DialogResult.OK)
            {
                s.Name = frm.txtName.Text;
                s.Gender = frm.rdMale.Checked;
                s.Birthday = Convert.ToInt32(frm.txtBirthday.Text);
                s.Phone = frm.txtPhone.Text;
                s.Address = frm.txtAddress.Text;
                s.Course = frm.cboCourse.SelectedText;
                lists.Add(s);
                lsvList.Items.Add(s.Name);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(lsvList.SelectedItems.Count > 0)
                lsvList.Items.Remove(lsvList.SelectedItems[0]);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
