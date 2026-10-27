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

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                string tenSinhVienTimKiem = txbTimkiem.Text.Trim();
                drvDanhsachsinhvien.DataSource = sinhvienBLL.HienThiDanhSachSinhVienTheoDieuKienTen(tenSinhVienTimKiem);
            }
            catch
            {
                // logger.LogError(ex, "Lỗi xảy ra khi thực hiện tìm kiếm trên form tra cứu sinh viên.");
                MessageBox.Show("Có lỗi xảy ra khi tìm kiếm.\nVui lòng thử lại sau.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txbTimkiem_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string tenSinhVienTimKiem = txbTimkiem.Text.Trim();
                if (tenSinhVienTimKiem == "")
                {
                    drvDanhsachsinhvien.DataSource = sinhvienBLL.HienThiDanhSachSinhVien();
                }
            }
            catch
            {
                MessageBox.Show("Có lỗi xảy ra khi tìm kiếm.\nVui lòng thử lại sau.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
