using StudentManagment.DTO;
using Microsoft.Extensions.Logging;
using StudentManagment.BLL;

namespace StudentManagment.GUI
{
    public partial class frmDangnhapadmin : Form
    {
        private readonly ILogger logger;
        private readonly ILoggerFactory _loggerFactory;
        private DangnhapBLL dangnhapBLL;
        public frmDangnhapadmin(ILoggerFactory loggerFactory)
        {
            InitializeComponent();
            logger = loggerFactory.CreateLogger<frmDangnhapadmin>();
            dangnhapBLL = new DangnhapBLL(loggerFactory);
            _loggerFactory = loggerFactory;
        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            try
            {
                string username = txbTennguoidung.Text.Trim();
                string password = txbMatkhau.Text.Trim();
                TaikhoanDTO taiKhoan = dangnhapBLL.KiemTraDangNhap(username, password, true);
                if (taiKhoan != null)
                {
                    this.Hide();
                    frmTaotaikhoan frmTaotaikhoan = new frmTaotaikhoan();
                    frmTaotaikhoan.Show();
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

        private void btnQuaylai_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDangnhap frmDangnhap = new frmDangnhap(_loggerFactory);
            frmDangnhap.Show();
            logger.LogWarning("Chuyển sang form đăng nhập chính.");
        }

        private void frmDangnhapadmin_Load(object sender, EventArgs e)
        {
            txbMatkhau.PasswordChar = '*';
        }

        private void frmDangnhapadmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
