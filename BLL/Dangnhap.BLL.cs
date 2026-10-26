using Microsoft.Extensions.Logging;
using StudentManagment.DAL;
using StudentManagment.DTO;

namespace StudentManagment.BLL
{
    public class DangnhapBLL
    {
        private readonly ILogger<DangnhapBLL> logger;
        private DangnhapDAL dangnhapDAL;
        // Khởi tạo constructor để lấy logger factory từ form
        public DangnhapBLL(ILoggerFactory loggerFactory)
        {
            logger = loggerFactory.CreateLogger<DangnhapBLL>();
            dangnhapDAL = new DangnhapDAL(loggerFactory);
        }
        public bool KiemTraDangNhap(string username, string password)
        {
            try
            {
                bool kiemTraUsername = string.IsNullOrEmpty(username);
                bool kiemTraPassword = string.IsNullOrEmpty(password);
                if (kiemTraUsername || kiemTraPassword)
                {
                    MessageBox.Show("Bạn phải nhập đầy đủ thông tin trước khi đăng nhập.");
                    logger.LogInformation("Người dùng chưa nhập đầy đủ thông tin.");
                    return false;
                }
                TaikhoanDTO taikhoan = dangnhapDAL.LayTaiKhoanCoDieuKien(username, password);
                // Tài khoản == null khi có lỗi ở lớp DAL xảy ra
                if (taikhoan == null) { throw new Exception(); }
                if (username == taikhoan.Username && password == taikhoan.Matkhau)
                {
                    logger.LogInformation("Người dùng đã đăng nhập thành công vào hệ thống. Với username: {username}", username);
                    return true;
                }
                else
                {
                    MessageBox.Show("Tên tài khoản hoặc mật khẩu đã sai. Vui lòng thử lại.");
                    logger.LogInformation("Người dùng nhập sai tài khoản hoặc mật khẩu đăng nhập.");
                    return false;
                }
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Có lỗi xảy ra khi người dùng cố gắng đăng nhập vào hệ thống. Với Username: {username}", username);
                return false;
            }
        }
    }
}
