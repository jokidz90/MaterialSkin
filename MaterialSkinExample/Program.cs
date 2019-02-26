using System;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace MaterialSkinExample
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new MaterialDateRangePickerForm());
            //Application.Run(new MDIMain());
            Application.Run(new MainForm());
        }
    }
}
