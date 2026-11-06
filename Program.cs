using StudentManagment.GUI;
using Microsoft.Extensions.Logging;
using StudentManagment.Helper;

namespace StudentManagment
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Khởi tạo factory logger cho dự án
            using ILoggerFactory loggerFactory = Logging.CreateLoggerFactory();
            ILogger logger = loggerFactory.CreateLogger("Global");
            Application.ThreadException += (_, e) =>
            {
                logger.LogCritical(e.Exception, "Xảy ra lỗi hệ thống.");
                MessageBox.Show("Xảy ra lỗi hệ thống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            };
            AppDomain.CurrentDomain.UnhandledException += (_, e) =>
            {
                logger.LogCritical(e.ExceptionObject as Exception, "Xảy ra lỗi không xác đinh");
                MessageBox.Show("Xảy ra lỗi hệ thống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            };
            Application.SetHighDpiMode(HighDpiMode.PerMonitorV2);
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            // Truyền qua frm đăng nhập để truyền qua các phần khác
            Application.Run(new frmDangnhap(loggerFactory));
            // Application.Run(new frmQuanLySinhVien(loggerFactory, ""))
        }
    }
}