using Microsoft.Extensions.Logging;
using StudentManagment.DAL;
using StudentManagment.DTO;

namespace StudentManagment.BLL
{
    public class DangnhapBLL
    {
        private readonly ILogger<DangnhapBLL> logger;
        private DangnhapDAL dangnhapDAL;
        public DangnhapBLL(ILoggerFactory loggerFactory)
        {
            logger = loggerFactory.CreateLogger<DangnhapBLL>();
            dangnhapDAL = new DangnhapDAL(loggerFactory);
        }
        public TaikhoanDTO KiemTraDangNhap(string username, string password, bool admin)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                logger.LogWarning("Người dùng chưa nhập đầy đủ thông tin đăng nhập.");
                throw new ArgumentException();
            }
            TaikhoanDTO taiKhoan = dangnhapDAL.LayTaiKhoanCoDieuKien(username, admin);
            if (taiKhoan == null)
            {
                logger.LogWarning("Người dùng đăng nhập với tài khoản không tồn tại trong hệ thống.");
                throw new InvalidOperationException();
            }
            bool xetMatKhau = BCrypt.Net.BCrypt.Verify(password, taiKhoan.HashedPassword);
            if (!xetMatKhau)
            {
                logger.LogWarning("Người dùng nhập sai mật khẩu.");
                throw new InvalidOperationException();
            }
            logger.LogInformation("Người dùng đã đăng nhập thành công. Username: {username}", username);
            return taiKhoan;
        }
    }
}
