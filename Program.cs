using LTQL_QLBHDongHo.Forms;

namespace LTQL_QLBHDongHo
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            // Show login dialog first. If login succeeded, run main form; otherwise exit.
            using (var login = new frmDangNhap())
            {
                var result = login.ShowDialog();
                if (result == DialogResult.OK)
                {
                    Application.Run(new frmTrangChu());
                }
            }
        }
    }
}