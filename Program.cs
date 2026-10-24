using System;
using System.Windows.Forms;

namespace Game3
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Dòng này giúp giữ chương trình chạy và mở Form lên màn hình:
            Application.Run(new frmThanhTich());
        }
    }
}