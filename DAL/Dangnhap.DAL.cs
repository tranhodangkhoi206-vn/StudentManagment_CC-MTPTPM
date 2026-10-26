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
        private CosodulieuDAL csdl = new CosodulieuDAL();
        public DangnhapDAL(ILoggerFactory loggerFactory)
        {
            logger = loggerFactory.CreateLogger<DangnhapDAL>();
        }
        public TaikhoanDTO LayTaiKhoanCoDieuKien(string username, string password)
        {
            try
            {
                using (SqlConnection conn = csdl.KetNoiCoSoDuLieu())
                {
                    SqlCommand cmd = new SqlCommand("SELECT * FROM TAIKHOAN WHERE USERNAME=@USERNAME AND PASSWORD=@PASSWORD", conn);
                    cmd.Parameters.AddWithValue("@USERNAME", username);
                    cmd.Parameters.AddWithValue("@PASSWORD", password);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        logger.LogInformation("Đang lấy tài khoản từ cơ sở dữ liệu.");
                        return new TaikhoanDTO
                        {
                            Hovaten = reader["HOVATEN"].ToString().Trim(),
                            Username = reader["USERNAME"].ToString().Trim(),
                            Matkhau = reader["PASSWORD"].ToString().Trim()
                        };
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                logger.LogCritical(sqlEx, "Lỗi kết nối tới cơ sỡ dữ liệu.");
                MessageBox.Show("Lỗi xảy ra khi đăng nhập. Hãy thử lại sau.");
                return null;
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Lỗi xảy ra khi đăng nhập");
                MessageBox.Show("Lỗi xảy ra khi đăng nhập. Hãy thử lại sau.");
                return null;
            }
            logger.LogInformation("Người dùng đăng nhập với tài khoản không tồn tại trong hệ thống.");
            return new TaikhoanDTO { Hovaten = "1", Username = "1", Matkhau = "1" };
        }
    }
}
