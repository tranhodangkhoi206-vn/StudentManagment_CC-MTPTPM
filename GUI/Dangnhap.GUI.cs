using Microsoft.Extensions.Logging;
using StudentManagment.BLL;
using StudentManagment.DTO;

namespace StudentManagment.GUI
{
    public partial class frmDangnhap : Form
    {
        private readonly ILoggerFactory _loggerFactory;
        private readonly ILogger<frmDangnhap> logger;
        private DangnhapBLL dangnhapBLL;
        public frmDangnhap(ILoggerFactory loggerFactory)
        {
            InitializeComponent();
            _loggerFactory = loggerFactory;
            logger = loggerFactory.CreateLogger<frmDangnhap>();
            dangnhapBLL = new DangnhapBLL(loggerFactory);
        }
        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            try
            {
                string username = txbTennguoidung.Text.Trim();
                string password = txbMatkhau.Text.Trim();
                TaikhoanDTO taiKhoan = dangnhapBLL.KiemTraDangNhap(username, password, false);
                if (taiKhoan != null)
                {
                    this.Hide();
                    frmQuanLySinhVien quanLySinhVienGUI = new frmQuanLySinhVien(_loggerFactory, taiKhoan.Hovaten);
                    quanLySinhVienGUI.Show();
                    logger.LogInformation("Chuyển sang form Quản lý sinh viên.");
                }
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Bạn phải nhập đầy đủ thông tin trước khi đăng nhập.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Tên tài khoản hoặc mật khẩu chưa chính xác.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Có lỗi xảy ra khi bạn đăng nhập.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmDangnhap_Load(object sender, EventArgs e)
        {
            txbMatkhau.PasswordChar = '*';
        }

        private void btnTaotaikhoan_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDangnhapadmin frmDangnhapadmin = new frmDangnhapadmin(_loggerFactory);
            frmDangnhapadmin.Show();
            logger.LogInformation("Chuyển sang form Đăng nhập quyền Admin.");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDangnhap_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
