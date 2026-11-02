using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Logging;
using StudentManagment.DTO;

namespace StudentManagment.DAL
{
    public class DangnhapDAL
    {
        private readonly ILogger<DangnhapDAL> logger;
        public DangnhapDAL(ILoggerFactory loggerFactory)
        {
            logger = loggerFactory.CreateLogger<DangnhapDAL>();
        }
        public TaikhoanDTO LayTaiKhoanCoDieuKien(string username, string password, bool admin)
        {
            try
            {
                using (SqlConnection conn = CosodulieuDAL.KetNoiCoSoDuLieu())
                {
                    SqlCommand cmd = new SqlCommand("SELECT * FROM TAIKHOAN WHERE USERNAME=@USERNAME AND ADMIN=@ADMIN", conn);
                    cmd.Parameters.AddWithValue("@USERNAME", username);
                    cmd.Parameters.Add("@ADMIN", System.Data.SqlDbType.Bit).Value = admin;
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        logger.LogInformation("Lấy thông tin tài khoản từ cơ sở dữ liệu. Username: {0}.", username);
                        return new TaikhoanDTO
                        {
                            Hovaten = reader["HOVATEN"].ToString().Trim(),
                            Username = reader["USERNAME"].ToString().Trim(),
                            HashedPassword = reader["HASHEDPASSWORD"].ToString().Trim()
                        };
                    }
                    logger.LogWarning("Không tìm thấy thông tin tài khoản từ cơ sở dữ liệu. Username: {0}.", username);
                    return null;
                }
            }
            catch (SqlException sqlEx)
            {
                logger.LogCritical(sqlEx, "Lỗi kết nối cơ sỡ dữ liệu khi đang lấy thông tin tài khoản. Username: {0}.", username);
                throw;
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Lỗi xảy ra khi lấy thông tin khoản. Username: {0}", username);
                throw;
            }
        }
    }
}
