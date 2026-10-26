using Microsoft.Extensions.Logging;
using StudentManagment.GUI.User_Control;

namespace StudentManagment
{
    public partial class frmQuanLySinhVien : Form
    {
        public frmQuanLySinhVien(ILoggerFactory loggerFactory, string tenHienThi)
        {
            InitializeComponent();
            lbTen.Text = tenHienThi;
        }

        private void frmQuanLySinhVien_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnTracuusinhvien_Click(object sender, EventArgs e)
        {
            btnTracuusinhvien.BackColor = ColorTranslator.FromHtml("#0094ff");
            btnTracuusinhvien.ForeColor = Color.White;

            pUserControl.Controls.Clear();
            Tracuusinhvien ucTracuusinhvien = new Tracuusinhvien();
            ucTracuusinhvien.Dock = DockStyle.Fill;
            pUserControl.Controls.Add(ucTracuusinhvien);
            ucTracuusinhvien.BringToFront();
        }

        private void btnTracuusinhvien_Leave(object sender, EventArgs e)
        {
            btnTracuusinhvien.BackColor = SystemColors.Highlight;
            btnTracuusinhvien.ForeColor = Color.White;
        }

        private void btnQuanlisinhvien_Click(object sender, EventArgs e)
        {
            btnQuanlisinhvien.BackColor = ColorTranslator.FromHtml("#0094ff");
            btnQuanlisinhvien.ForeColor = Color.White;

            pUserControl.Controls.Clear();
            Quanlisinhvien ucQuanlisinhvien = new Quanlisinhvien();
            ucQuanlisinhvien.Dock = DockStyle.Fill;
            pUserControl.Controls.Add(ucQuanlisinhvien);
            ucQuanlisinhvien.BringToFront();
        }

        private void btnQuanlisinhvien_Leave(object sender, EventArgs e)
        {
            btnQuanlisinhvien.BackColor = SystemColors.Highlight;
            btnQuanlisinhvien.ForeColor = Color.White;
        }

        private void btnQuanlimonhoc_Click(object sender, EventArgs e)
        {
            btnQuanlimonhoc.BackColor = ColorTranslator.FromHtml("#0094ff");
            btnQuanlimonhoc.ForeColor = Color.White;

            pUserControl.Controls.Clear();
            Quanlimonhoc ucQuanlimonhoc = new Quanlimonhoc();
            ucQuanlimonhoc.Dock = DockStyle.Fill;
            pUserControl.Controls.Add(ucQuanlimonhoc);
            ucQuanlimonhoc.BringToFront();
        }

        private void btnQuanlimonhoc_Leave(object sender, EventArgs e)
        {
            btnQuanlimonhoc.BackColor = SystemColors.Highlight;
            btnQuanlimonhoc.ForeColor = Color.White;
        }

        private void btnQuanlichuyennganh_Click(object sender, EventArgs e)
        {
            btnQuanlichuyennganh.BackColor = ColorTranslator.FromHtml("#0094ff");
            btnQuanlichuyennganh.ForeColor = Color.White;

            pUserControl.Controls.Clear();
            Quanlinganhhoc ucQuanlinganhhoc = new Quanlinganhhoc();
            ucQuanlinganhhoc.Dock = DockStyle.Fill;
            pUserControl.Controls.Add(ucQuanlinganhhoc);
            ucQuanlinganhhoc.BringToFront();
        }

        private void btnQuanlichuyennganh_Leave(object sender, EventArgs e)
        {
            btnQuanlichuyennganh.BackColor = SystemColors.Highlight;
            btnQuanlichuyennganh.ForeColor = Color.White;
        }

        private void btnQuanlidiem_Click(object sender, EventArgs e)
        {

            btnQuanlidiem.BackColor = ColorTranslator.FromHtml("#0094ff");
            btnQuanlidiem.ForeColor = Color.White;

            pUserControl.Controls.Clear();
            Quanlidiem ucQuanlidiem = new Quanlidiem();
            ucQuanlidiem.Dock = DockStyle.Fill;
            pUserControl.Controls.Add(ucQuanlidiem);
            ucQuanlidiem.BringToFront();
        }

        private void btnQuanlidiem_Leave(object sender, EventArgs e)
        {
            btnQuanlidiem.BackColor = SystemColors.Highlight;
            btnQuanlidiem.ForeColor = Color.White;
        }
    }
}
