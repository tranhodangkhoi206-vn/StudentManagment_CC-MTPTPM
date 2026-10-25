using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; // Add this for Path and Directory
using Microsoft.Extensions.Logging;
using Serilog;

namespace StudentManagment
{
    public static class Logging
    {
        private static readonly ILoggerFactory _factory = LoggerFactory.Create(builder =>
        {
            var serilog = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .WriteTo.File(
                    Path.Combine(AppContext.BaseDirectory, "logs", "app.txt"),
                    rollingInterval: RollingInterval.Day, // mỗi ngày một file: app20261015.txt
                    outputTemplate: "{Timestamp:yyyy-MM-dd HH:mm:ss.fff} [{Level:u}] {SourceContext}: {Message:lj}{NewLine}{Exception}")
                .CreateLogger();

            builder.AddSerilog(serilog, dispose: true);
        });

        public static ILogger<T> For<T>() => _factory.CreateLogger<T>();

        public static void Shutdown() => _factory.Dispose();
    }
}
