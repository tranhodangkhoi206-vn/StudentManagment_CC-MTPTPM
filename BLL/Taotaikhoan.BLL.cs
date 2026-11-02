using System.Data;
using System.Security.Policy;
using Microsoft.Extensions.Logging;
using StudentManagment.DAL;
using StudentManagment.DTO;

namespace StudentManagment.BLL
{
    public class TaotaikhoanBLL
    {
        private readonly ILogger<TaotaikhoanBLL> logger;
        private TaotaikhoanDAL taoTaiKhoanDAL;
        public TaotaikhoanBLL(ILoggerFactory loggerFactory)
        {
            logger = loggerFactory.CreateLogger<TaotaikhoanBLL>();
            taoTaiKhoanDAL = new TaotaikhoanDAL(loggerFactory);
        }
        public DataTable ThemTaiKhoanMoi(TaikhoanDTO taiKhoan)
        {
            if (string.IsNullOrEmpty(taiKhoan.Hovaten) || string.IsNullOrEmpty(taiKhoan.Username) || string.IsNullOrEmpty(taiKhoan.HashedPassword))
            {
                logger.LogWarning("Người dùng chưa nhập đầy đủ thông tin trước khi thêm tài khoản.");
                throw new ArgumentException();
            }
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(taiKhoan.HashedPassword, 12);
            taiKhoan.HashedPassword = hashedPassword;
            taiKhoan.Admin = false;
            return taoTaiKhoanDAL.ThemTaiKhoanMoi(taiKhoan);
        }
        public DataTable SuaTaiKhoan(TaikhoanDTO taiKhoan)
        {
            if (string.IsNullOrEmpty(taiKhoan.Username))
            {
                logger.LogWarning("Người dùng chưa nhập username trước khi sửa tài khoản.");
                throw new ArgumentException();
            }
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(taiKhoan.HashedPassword, 12);
            taiKhoan.HashedPassword = hashedPassword;
            return taoTaiKhoanDAL.ThemTaiKhoanMoi(taiKhoan);
        }
	    public DataTable XoaTaiKhoan(string username)
        {
		    if(string.IsNullOrEmpty(username))
            {
                logger.LogWarning("Người dùng chưa nhập username trước khi xóa tài khoản.");
                throw new ArgumentException();
            }
            return taoTaiKhoanDAL.XoaTaiKhoanTheoUsername(username);
        }
	    public DataTable LayDanhSachTaiKhoanTheoDieuKienUsername(string username)
        {
            if(string.IsNullOrEmpty(username))
            {
                logger.LogWarning("Người dùng chưa nhập username trước khi lấy danh sách tài khoản.");
                throw new ArgumentException();
            }
	        return taoTaiKhoanDAL.LayDanhSachTaiKhoanTheoDieuKienUsername(username);
        }
    }
}
