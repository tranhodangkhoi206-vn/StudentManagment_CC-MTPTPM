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
            logger = _loggerFactory.CreateLogger<frmDangnhap>();
            dangnhapBLL = new DangnhapBLL(loggerFactory);
        }
        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            try
            {
                string username = txbTennguoidung.Text.Trim();
                string password = txbMatkhau.Text.Trim();
                bool taiKhoanHopLe = dangnhapBLL.KiemTraDangNhap(username, password);
                if (taiKhoanHopLe)
                {
                    this.Hide();
                    frmQuanLySinhVien quanLySinhVienGUI = new frmQuanLySinhVien(_loggerFactory);
                    quanLySinhVienGUI.Show();
                    logger.LogInformation("Đăng nhập thành công, hiển thị form chính.");
                }
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Lỗi xảy ra ở form đăng nhập.");
                MessageBox.Show("Có lỗi xảy ra khi bạn đăng nhập, hãy thử lại.");
            }
        }
    }
}
