using Microsoft.Extensions.Logging;
using StudentManagment.DAL;
using StudentManagment.DTO;

namespace StudentManagment.BLL
{
    public class Dangnhap
    {
        private readonly ILogger<Dangnhap> _logger;
        private DangnhapDAL dangnhapDAL = new DangnhapDAL();
        // Khởi tạo constructor để lấy logger từ form
        public Dangnhap(ILogger<Dangnhap> logger)
        {
            _logger = logger;
        }
        public bool KiemTraDangNhap(string username, string password)
        {
            try
            {
                bool kiemTraUsername = string.IsNullOrEmpty(username);
                bool kiemTraPassword = string.IsNullOrEmpty(password);
                if (kiemTraUsername || kiemTraPassword)
                {
                    _logger.LogInformation("Người dùng chưa nhập đầy đủ thông tin.");
                    return false;
                }
                TaikhoanDTO taikhoan = dangnhapDAL.Laytaikhoancuthe(username, password);
                if (taikhoan == null)
                {
                    _logger.LogInformation("Người dùng nhập sai tài khoản hoặc mật khẩu đăng nhập.");
                    return false;
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Có lỗi xảy ra khi người dùng cố gắng đăng nhập vào hệ thống. Với Username: {username}", username);
                return false;
            }
            _logger.LogInformation("Người dùng đã đăng nhập thành công vào hệ thống. Với username: {username}", username);
            return true;
        }
    }
}
