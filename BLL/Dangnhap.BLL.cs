using Microsoft.Data.SqlClient;
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
            try
            {
                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                {
                    logger.LogWarning("Người dùng chưa nhập đầy đủ thông tin đăng nhập.");
                    throw new ArgumentException("Bạn phải nhập đầy đủ thông tin trước khi đăng nhập.");
                }
                TaikhoanDTO taiKhoan = dangnhapDAL.LayTaiKhoanCoDieuKien(username, admin);
                if (taiKhoan != null)
                {
                    bool xetMatKhau = BCrypt.Net.BCrypt.Verify(password, taiKhoan.HashedPassword);
                    if (!xetMatKhau)
                    {
                        logger.LogWarning("Người dùng nhập sai mật khẩu.");
                        throw new UnauthorizedAccessException("Bạn nhập mật khẩu chưa chính xác.");
                    }
                    logger.LogInformation("Người dùng đã đăng nhập thành công. Username: {username}", username);
                    return taiKhoan;
                }
                return null;
            }
            catch (SqlException)
            {
                throw;
            }
            catch (KeyNotFoundException)
            {
                throw new KeyNotFoundException("Tên tài khoản hoặc mật khẩu chưa chính xác.");
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Xảy ra lỗi không xác định.");
                throw;
            }
        }
    }
}
