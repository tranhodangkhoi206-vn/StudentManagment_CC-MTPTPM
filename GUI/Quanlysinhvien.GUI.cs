using Microsoft.Extensions.Logging;
using StudentManagment.GUI.User_Control;

namespace StudentManagment
{
    public partial class frmQuanLySinhVien : Form
    {
        private readonly ILoggerFactory _loggerFactory;
        public frmQuanLySinhVien(ILoggerFactory loggerFactory, string tenHienThi)
        {
            InitializeComponent();
            _loggerFactory = loggerFactory;
        }

        private void frmQuanLySinhVien_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void btnTrangchu_Click(object sender, EventArgs e)
        {
            btnTrangchu.BackColor = ColorTranslator.FromHtml("#2471C9");
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
        }

        private void btnQuanlysinhvien_Leave(object sender, EventArgs e)
        {
            btnQuanlysinhvien.BackColor = ColorTranslator.FromHtml("#1a385a");
        }

        private void btnQuanlymonhoc_Click(object sender, EventArgs e)
        {
            btnQuanlymonhoc.BackColor = ColorTranslator.FromHtml("#2471C9");
            pUserControl.Controls.Clear();
            Quanlymonhoc quanlymonhoc = new Quanlymonhoc(_loggerFactory);
            quanlymonhoc.Dock = DockStyle.Fill;
            pUserControl.Controls.Add(quanlymonhoc);
            quanlymonhoc.BringToFront();
        }

        private void btnQuanlymonhoc_Leave(object sender, EventArgs e)
        {
            btnQuanlymonhoc.BackColor = ColorTranslator.FromHtml("#1a385a");
        }

        private void btnQuanlychuyennganh_Click(object sender, EventArgs e)
        {
            btnQuanlychuyennganh.BackColor = ColorTranslator.FromHtml("#2471C9");
        }

        private void btnQuanlychuyennganh_Leave(object sender, EventArgs e)
        {
            btnQuanlychuyennganh.BackColor = ColorTranslator.FromHtml("#1a385a");
        }

        private void btnQuanlydiem_Click(object sender, EventArgs e)
        {
            btnQuanlydiem.BackColor = ColorTranslator.FromHtml("#2471C9");
        }

        private void btnQuanlydiem_Leave(object sender, EventArgs e)
        {
            btnQuanlydiem.BackColor = ColorTranslator.FromHtml("#1a385a");
        }

        private void btnQuanlylophoc_Click(object sender, EventArgs e)
        {
            btnQuanlylophoc.BackColor = ColorTranslator.FromHtml("#2471C9");
        }

        private void btnQuanlylophoc_Leave(object sender, EventArgs e)
        {
            btnQuanlylophoc.BackColor = ColorTranslator.FromHtml("#1a385a");
        }
    }
}
