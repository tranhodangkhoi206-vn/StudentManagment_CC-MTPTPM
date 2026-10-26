using Microsoft.Extensions.Logging;
using Serilog;

namespace StudentManagment.Helper
{
    public static class Logging
    {
        public static ILoggerFactory CreateLoggerFactory()
        {
            // Thuc hien luu log vao file
            Log.Logger = new LoggerConfiguration()
                // Tao moi ngay mot file log
                .WriteTo.File("logs/log-.txt", rollingInterval: RollingInterval.Day)
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