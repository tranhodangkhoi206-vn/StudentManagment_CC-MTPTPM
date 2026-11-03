using Microsoft.Extensions.Logging;
using StudentManagment.GUI;
using StudentManagment.GUI.User_Control;

namespace StudentManagment
{
    public partial class frmQuanLySinhVien : Form
    {
        private readonly ILogger<frmQuanLySinhVien> logger;
        private readonly ILoggerFactory _loggerFactory;
        private string _tenHienThi;
        public frmQuanLySinhVien(ILoggerFactory loggerFactory, string tenHienThi)
        {
            InitializeComponent();
            logger = loggerFactory.CreateLogger<frmQuanLySinhVien>();
            _loggerFactory = loggerFactory;
            _tenHienThi = tenHienThi;
        }

        private void frmQuanLySinhVien_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void frmQuanLySinhVien_Load(object sender, EventArgs e)
        {
            lbTenhienthi.Text = _tenHienThi;
            pUserControl.Controls.Clear();
            Trangchu trangChu = new Trangchu(_loggerFactory);
            trangChu.Dock = DockStyle.Fill;
            pUserControl.Controls.Add(trangChu);
            trangChu.BringToFront();
            logger.LogInformation("Chuyển sang user control Trang chủ.");
        }
        private void btnTrangchu_Click(object sender, EventArgs e)
        {
            btnTrangchu.BackColor = ColorTranslator.FromHtml("#2471C9");
            pUserControl.Controls.Clear();
            Trangchu trangChu = new Trangchu(_loggerFactory);
            trangChu.Dock = DockStyle.Fill;
            pUserControl.Controls.Add(trangChu);
            trangChu.BringToFront();
            logger.LogInformation("Chuyển sang user control Trang chủ.");
        }

        private void btnTrangchu_Leave(object sender, EventArgs e)
        {
            btnTrangchu.BackColor = ColorTranslator.FromHtml("#1A385A");
        }


        private void btnQuanlysinhvien_Click(object sender, EventArgs e)
        {
            btnQuanlysinhvien.BackColor = ColorTranslator.FromHtml("#2471C9");
            pUserControl.Controls.Clear();
            Quanlysinhvien quanLySinhVien = new Quanlysinhvien(_loggerFactory);
            quanLySinhVien.Dock = DockStyle.Fill;
            pUserControl.Controls.Add(quanLySinhVien);
            quanLySinhVien.BringToFront();
            logger.LogInformation("Chuyển sang user control Quản lý sinh viên.");
        }

        private void btnQuanlysinhvien_Leave(object sender, EventArgs e)
        {
            btnQuanlysinhvien.BackColor = ColorTranslator.FromHtml("#1a385a");
        }

        private void btnQuanlymonhoc_Click(object sender, EventArgs e)
        {
            btnQuanlymonhoc.BackColor = ColorTranslator.FromHtml("#2471C9");
            pUserControl.Controls.Clear();
            Quanlymonhoc quanLyMonHoc = new Quanlymonhoc(_loggerFactory);
            quanLyMonHoc.Dock = DockStyle.Fill;
            pUserControl.Controls.Add(quanLyMonHoc);
            quanLyMonHoc.BringToFront();
            logger.LogInformation("Chuyển sang user control Quản lý môn học.");
        }

        private void btnQuanlymonhoc_Leave(object sender, EventArgs e)
        {
            btnQuanlymonhoc.BackColor = ColorTranslator.FromHtml("#1a385a");
        }

        private void btnQuanlychuyennganh_Click(object sender, EventArgs e)
        {
            btnQuanlychuyennganh.BackColor = ColorTranslator.FromHtml("#2471C9");
            pUserControl.Controls.Clear();
            Quanlynganhhoc quanLyNganhHoc = new Quanlynganhhoc(_loggerFactory);
            quanLyNganhHoc.Dock = DockStyle.Fill;
            pUserControl.Controls.Add(quanLyNganhHoc);
            quanLyNganhHoc.BringToFront();
            logger.LogInformation("Chuyển sang user control Quản lý chuyên ngành.");
        }

        private void btnQuanlychuyennganh_Leave(object sender, EventArgs e)
        {
            btnQuanlychuyennganh.BackColor = ColorTranslator.FromHtml("#1a385a");
        }

        private void btnQuanlydiem_Click(object sender, EventArgs e)
        {
            btnQuanlydiem.BackColor = ColorTranslator.FromHtml("#2471C9");
            pUserControl.Controls.Clear();
            Quanlydiem quanLyDiem = new Quanlydiem(_loggerFactory);
            quanLyDiem.Dock = DockStyle.Fill;
            pUserControl.Controls.Add(quanLyDiem);
            quanLyDiem.BringToFront();
            logger.LogInformation("Chuyển sang user control Quản lý điểm.");
        }

        private void btnQuanlydiem_Leave(object sender, EventArgs e)
        {
            btnQuanlydiem.BackColor = ColorTranslator.FromHtml("#1a385a");
        }

        private void btnQuanlylophoc_Click(object sender, EventArgs e)
        {
            btnQuanlylophoc.BackColor = ColorTranslator.FromHtml("#2471C9");
            pUserControl.Controls.Clear();
            Quanlylophoc quanLyLopHoc = new Quanlylophoc();
            quanLyLopHoc.Dock = DockStyle.Fill;
            pUserControl.Controls.Add(quanLyLopHoc);
            quanLyLopHoc.BringToFront();
            logger.LogInformation("Chuyển sang user control Quản lý lớp học.");
        }

        private void btnQuanlylophoc_Leave(object sender, EventArgs e)
        {
            btnQuanlylophoc.BackColor = ColorTranslator.FromHtml("#1a385a");
        }

        private void btnDangxuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDangnhap frmDangnhap = new frmDangnhap(_loggerFactory);
            frmDangnhap.Show();
            logger.LogInformation("Chuyển sang form Đăng nhập.");
        }
    }
}
