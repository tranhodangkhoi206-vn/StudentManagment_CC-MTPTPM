using Microsoft.Extensions.Logging;
using StudentManagment.GUI.User_Control;
using StudentManagment.GUI.User_Control;

namespace StudentManagment
{
    public partial class frmQuanLySinhVien : Form
    {
        public frmQuanLySinhVien(ILoggerFactory loggerFactory)
        {
            InitializeComponent();
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
    }
}
