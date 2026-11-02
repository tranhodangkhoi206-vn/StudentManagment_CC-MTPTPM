using System.Data;
using System.Reflection.Metadata;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Logging;
using StudentManagment.DAL.Util;
using StudentManagment.DTO;

namespace StudentManagment.DAL
{
    public class TaotaikhoanDAL
    {
        private readonly ILogger<TaotaikhoanDAL> logger;
        private TaikhoanDAL taiKhoanDAL;
        public TaotaikhoanDAL(ILoggerFactory loggerFactory)
        {
            logger = loggerFactory.CreateLogger<TaotaikhoanDAL>();
            taiKhoanDAL = new TaikhoanDAL(loggerFactory);
        }
        public DataTable ThemTaiKhoanMoi(TaikhoanDTO taiKhoan)
        {
            try
            {
                using (SqlConnection conn = CosodulieuDAL.KetNoiCoSoDuLieu())
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO TAIKHOAN VALUES(@HOVATEN, @USERNAME, @HASHEDPASSWORD, @ADMIN)", conn);
                    cmd.Parameters.AddWithValue("@HOVATEN", taiKhoan.Hovaten);
                    cmd.Parameters.AddWithValue("@USERNAME", taiKhoan.Username);
                    cmd.Parameters.AddWithValue("@HASHEDPASSWORD", taiKhoan.HashedPassword);
                    cmd.Parameters.AddWithValue("@ADMIN", taiKhoan.Admin);
                    cmd.ExecuteNonQuery();
                    logger.LogInformation("Thêm tài khoản mới vào danh sách tài khoản.\nHọ và tên: {0},\nUsername: {1},\nAdmin: {2}.", taiKhoan.Hovaten, taiKhoan.Username, taiKhoan.Admin);
                    return taiKhoanDAL.LayToanBoTaiKhoan();
                }
            }
            catch (SqlException sqlEx)
            {
                logger.LogCritical(sqlEx, "Xảy ra lỗi cơ sở dữ liệu khi thêm tài khoản mới.\nHọ và tên: {0},\nUsername: {1},\nAdmin: {2}.", taiKhoan.Hovaten, taiKhoan.Username, taiKhoan.Admin);
                throw;
            }
            catch (Exception ex)
            {
                logger.LogCritical(ex, "Xảy ra lỗi khi thêm tài khoản mới.\nHọ và tên: {0},\nUsername: {1},\nAdmin: {2}.", taiKhoan.Hovaten, taiKhoan.Username, taiKhoan.Admin);
                throw;
            }
        }
	    public DataTable SuaThongTinTaiKhoanTheoUsername(TaikhoanDTO taiKhoan)
        {
            try
            {
                using (SqlConnection conn = CosodulieuDAL.KetNoiCoSoDuLieu())
                {
                    SqlCommand cmd = new SqlCommand("UPDATE TAIKHOAN SET HASHEDPASSWORD=@HASEDPASSWORD, HOVATEN=@HOVATEN WHERE USERNAME=@USERNAME", conn);
                    cmd.Parameters.AddWithValue("@HASHEDPASSWORD",taiKhoan.HashedPassword);
                    cmd.Parameters.AddWithValue("@HOVATEN", taiKhoan.Hovaten);
                    cmd.Parameters.AddWithValue("@USERNAME", taiKhoan.Username);
                    cmd.ExecuteNonQuery();

                    logger.LogInformation("Sửa tài khoản trong danh sách tài khoản.\nHọ và tên: {0}", taiKhoan.Hovaten);

                    return taiKhoanDAL.LayToanBoTaiKhoan(); 
                }
            }
            catch (SqlException sqlEx)
            {
                logger.LogCritical(sqlEx, "Xảy ra lỗi cơ sở dữ liệu khi sửa tài khoản.\nHọ và tên: {0}", taiKhoan.Hovaten);
                throw;
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Xảy ra lỗi khi sửa tài khoản.\nHọ và tên: {0}", taiKhoan.Hovaten);
                throw;
            }
        }
    }
}
