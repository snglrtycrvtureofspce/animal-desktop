using System;
using System.Windows.Forms;
using Service.Animals.Desktop.Form;

namespace Service.Animals.Desktop
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ProgresBar());
        }
    }
}
