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
        public TaikhoanDTO LayTaiKhoanCoDieuKien(string username, bool admin)
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
                        logger.LogInformation("Lấy tài khoản theo điều kiện Username và Admin.\nUsername: {0},\nAdmin: {1}.", username, admin);
                        return new TaikhoanDTO
                        {
                            Hovaten = reader["HOVATEN"].ToString().Trim(),
                            Username = reader["USERNAME"].ToString().Trim(),
                            HashedPassword = reader["HASHEDPASSWORD"].ToString().Trim()
                        };
                    }
                    logger.LogWarning("Không tìm thấy tài khoản.\nUsername: {0},\nAdmin: {1}.", username, admin);
                    return null;
                }
            }
            catch (SqlException sqlEx)
            {
                logger.LogCritical(sqlEx, "Xảy ra lỗi cơ sở dữ liệu khi lấy tài khoản theo điều kiện Username và Admin.\nUsername: {0},\nAdmin: {1}", username, admin);
                throw;
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Xảy ra lỗi khi lấy tài khoản theo điều kiện Username và Admin.\nUsername: {0},\nAdmin: {1}", username, admin);
                throw;
            }
        }
    }
}
