using StudentManagment.DTO;
using Microsoft.Extensions.Logging;
using StudentManagment.BLL;
using Microsoft.Data.SqlClient;

namespace StudentManagment.GUI
{
    public partial class frmDangnhapadmin : Form
    {
        private readonly ILogger<frmDangnhapadmin> logger;
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
                    frmTaotaikhoan frmTaotaikhoan = new frmTaotaikhoan(_loggerFactory, taiKhoan.Hovaten);
                    frmTaotaikhoan.Show();
                    logger.LogInformation("Chuyển sang form Tạo tài khoản.");
                }
            }
            catch (ArgumentException agEx)
            {
                MessageBox.Show(agEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (KeyNotFoundException knfEx)
            {
                MessageBox.Show(knfEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (UnauthorizedAccessException uaEx)
            {
                MessageBox.Show(uaEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (SqlException)
            {
                MessageBox.Show("Có lỗi xảy ra với cơ sở dữ liệu.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Có lỗi xảy ra.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
