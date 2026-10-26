using Microsoft.Extensions.Logging;

namespace StudentManagment
{
    public partial class frmQuanLySinhVien : Form
    {
        public frmQuanLySinhVien(ILoggerFactory loggerFactory)
        {
            InitializeComponent();
        }
        // Mẫu khi muốn tạo log 
        // private readonly ILogger<LoginForm> _log = AppLogger.For<LoginForm>();
        //
        // private void btnLogin_Click(object sender, EventArgs e)
        // {
        //     _log.LogInformation("Đăng nhập với user {User}", txtUser.Text);
        // }
    }
}
