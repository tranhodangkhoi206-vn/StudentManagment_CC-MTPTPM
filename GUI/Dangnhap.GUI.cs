using Microsoft.Extensions.Logging;
using StudentManagment.BLL;

namespace StudentManagment.GUI
{
    public partial class frmDangnhap : Form
    {
        private readonly ILoggerFactory _loggerFactory;
        // Khởi tạo một logger cho form đăng nhập
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
                bool kiemTraRong = dangnhapBLL.KiemTraDangNhapRong(username, password);
                if (kiemTraRong)
                {
                    MessageBox.Show("Bạn phải nhập đầy đủ thông tin trước khi đăng nhập.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    bool taiKhoanHopLe = dangnhapBLL.KiemTraDangNhap(username, password);
                    if (taiKhoanHopLe)
                    {
                        this.Hide();
                        frmQuanLySinhVien quanLySinhVienGUI = new frmQuanLySinhVien(_loggerFactory, dangnhapBLL.LayTenHienThi());
                        quanLySinhVienGUI.Show();
                        logger.LogInformation("Đăng nhập thành công, hiển thị form chính.");
                    }
                    else
                    {
                        MessageBox.Show("Tên người dung hoặc mật khẩu chưa chính xác.\nVui lòng thử lại sau.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Lỗi xảy ra khi với form đăng nhập.");
                MessageBox.Show("Có lỗi xảy ra khi bạn đăng nhập.\nVui lòng thử lại sau.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDangnhap_Load(object sender, EventArgs e)
        {
            txbMatkhau.PasswordChar = '*';
        }
    }
}
