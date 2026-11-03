using System.Data;
using System.Security.Policy;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Logging;
using Serilog.Sinks.File;
using StudentManagment.DAL;
using StudentManagment.DAL.Util;
using StudentManagment.DTO;

namespace StudentManagment.BLL
{
    public class TaotaikhoanBLL
    {
        private readonly ILogger<TaotaikhoanBLL> logger;
        private TaotaikhoanDAL taoTaiKhoanDAL;
        private TaikhoanDAL taiKhoanDAL;
        public TaotaikhoanBLL(ILoggerFactory loggerFactory)
        {
            logger = loggerFactory.CreateLogger<TaotaikhoanBLL>();
            taiKhoanDAL = new TaikhoanDAL(loggerFactory);
            taoTaiKhoanDAL = new TaotaikhoanDAL(loggerFactory);
        }
        public DataTable HienThiDanhSachTaiKhoan()
        {
            return taiKhoanDAL.LayToanBoTaiKhoan();
        }
        public DataTable ThemTaiKhoanMoi(TaikhoanDTO taiKhoan)
        {
            try
            {
                if (string.IsNullOrEmpty(taiKhoan.Hovaten) || string.IsNullOrEmpty(taiKhoan.Username) || string.IsNullOrEmpty(taiKhoan.HashedPassword))
                {
                    logger.LogWarning("Người dùng chưa nhập đầy đủ thông tin trước khi thêm tài khoản.");
                    throw new ArgumentException("Bạn phải nhập đầy đủ thông tin trước khi thêm");
                }
                DataTable dt = taoTaiKhoanDAL.ThemTaiKhoanMoi(taiKhoan);
                string hashedPassword = BCrypt.Net.BCrypt.HashPassword(taiKhoan.HashedPassword, 12);
                taiKhoan.HashedPassword = hashedPassword;
                taiKhoan.Admin = false;
                if (dt == null)
                {
                    throw new InvalidOperationException("Thêm không thành công.");
                }
                return dt;
            }
            catch (SqlException)
            {
                throw;
            }
        }
        public DataTable SuaTaiKhoan(TaikhoanDTO taiKhoan)
        {
            try
            {
                if (string.IsNullOrEmpty(taiKhoan.Username))
                {
                    logger.LogWarning("Người dùng chưa nhập username trước khi sửa tài khoản.");
                    throw new ArgumentException("Bạn phải nhập username trước khi sửa");
                }
                string hashedPassword = BCrypt.Net.BCrypt.HashPassword(taiKhoan.HashedPassword, 12);
                taiKhoan.HashedPassword = hashedPassword;
                DataTable dt = taoTaiKhoanDAL.ThemTaiKhoanMoi(taiKhoan);
                if (dt == null)
                {
                    throw new InvalidOperationException("Sửa không thành công.");
                }
                return dt;
            }
            catch (SqlException)
            {
                throw;
            }
        }
        public DataTable XoaTaiKhoan(string username)
        {
            try
            {
                if (string.IsNullOrEmpty(username))
                {
                    logger.LogWarning("Người dùng chưa nhập username trước khi xóa tài khoản.");
                    throw new ArgumentException("Bạn phải nhập username trước khi xóa");
                }
                DataTable dt = taoTaiKhoanDAL.XoaTaiKhoanTheoUsername(username);
                if (dt == null)
                {
                    throw new InvalidOperationException("Xóa không thành công.");
                }
                return dt;
            }
            catch (SqlException)
            {
                throw;
            }
        }
        public DataTable LayDanhSachTaiKhoanTheoDieuKienUsername(string username)
        {
            try
            {
                if (string.IsNullOrEmpty(username))
                {
                    logger.LogWarning("Người dùng chưa nhập username trước khi lấy danh sách tài khoản.");
                    throw new ArgumentException("Bạn phải nhập username trước khi tìm kiếm");
                }
                DataTable dt = taoTaiKhoanDAL.LayDanhSachTaiKhoanTheoDieuKienUsername(username);
                if (dt == null)
                {
                    throw new KeyNotFoundException("Không tìm thấy tài khoản.");
                }
                return dt;
            }
            catch (SqlException)
            {
                throw;
            }
        }
    }
}
