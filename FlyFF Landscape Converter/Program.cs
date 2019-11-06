using System;
using System.Windows.Forms;

namespace FlyFF_Landscape_Converter
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmMain());
        }   
    }
}
