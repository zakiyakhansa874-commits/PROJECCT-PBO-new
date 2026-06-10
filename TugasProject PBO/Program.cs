using System;
using System.Windows.Forms;
using TugasProject_PBO.Views;

namespace TugasProject_PBO.Views
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new LoginSIMIHAN());
        }
    }
}