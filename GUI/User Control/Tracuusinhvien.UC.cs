using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.Logging;
using StudentManagment.BLL;

namespace StudentManagment.GUI.User_Control
{
    public partial class Tracuusinhvien : UserControl
    {
        private readonly ILogger logger;
        private SinhvienBLL sinhvienBLL;
        public Tracuusinhvien(ILoggerFactory loggerFactory)
        {
            InitializeComponent();
            logger = loggerFactory.CreateLogger<Tracuusinhvien>();
            sinhvienBLL = new SinhvienBLL(loggerFactory);
            drvDanhsachsinhvien.DataSource = sinhvienBLL.HienThiDanhSachSinhVien();
        }

    }
}
