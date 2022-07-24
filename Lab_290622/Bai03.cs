using System.Windows.Forms;

namespace Lab_290622
{
    public partial class Bai03 : Form
    {
        public Bai03()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, System.EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
