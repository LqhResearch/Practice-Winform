using System;
using System.Windows.Forms;

namespace Lab_290622
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Bai03_List());
        }
    }
}
