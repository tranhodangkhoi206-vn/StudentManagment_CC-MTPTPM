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
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            // Khởi tạo factory logger cho dự án 
            using ILoggerFactory loggerFactory = Logging.CreateLoggerFactory();
            // Truyền qua frm đăng nhập để truyền qua các phần khác
            // Application.Run(new frmDangnhap(loggerFactory));
            Application.Run(new frmQuanLySinhVien(loggerFactory, ""));
        }
    }
}