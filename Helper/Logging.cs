using Microsoft.Extensions.Logging;
using Serilog;

namespace StudentManagment.Helper
{
    public static class Logging
    {
        public static ILoggerFactory CreateLoggerFactory()
        {
            // Lấy đường dẫn thư mục chứa ứng dụng
            string appDirectory = AppContext.BaseDirectory;

            // Di chuyển từ bin/Debug/net9.0-windows về thư mục gốc StudentManagment
            string projectDirectory = Path.GetFullPath(
                Path.Combine(appDirectory, @"..\..\..")
            );

            // Tạo đường dẫn thư mục logs
            string logDirectory = Path.Combine(projectDirectory, "logs");

            // Tạo thư mục logs nếu chưa tồn tại
            Directory.CreateDirectory(logDirectory);

            // Thuc hien luu log vao file
            Log.Logger = new LoggerConfiguration()
                // Tao moi ngay mot file log
                .WriteTo.File(Path.Combine(logDirectory, "log-.txt"), rollingInterval: RollingInterval.Day)
                .CreateLogger();

            return LoggerFactory.Create(builder =>
            {
                // Xoa cac provider duoc thiet lap truoc do
                builder.ClearProviders();
                builder.SetMinimumLevel(LogLevel.Information);
                builder.AddSerilog();
            });
        }
    }
}