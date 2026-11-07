using System.Data;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Logging;
using StudentManagment.DTO;

namespace StudentManagment.DAL.Util
{
    public class TaikhoanDAL
    {
        private readonly ILogger<TaikhoanDAL> logger;
	    public TaikhoanDAL(ILoggerFactory loggerFactory)
        {
            logger = loggerFactory.CreateLogger<TaikhoanDAL>();
        }
	    public DataTable LayToanBoTaiKhoan()
        {
            try
            {
                using(SqlConnection conn = CosodulieuDAL.KetNoiCoSoDuLieu())
                {
                    SqlCommand cmd = new SqlCommand("SELECT HOVATEN, USERNAME FROM TAIKHOAN WHERE ADMIN=@ADMIN", conn);
                    cmd.Parameters.Add("@ADMIN", SqlDbType.Bit).Value = false;
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    DataTable dt = new DataTable();
                    adapter.SelectCommand = cmd;
                    adapter.Fill(dt);
                    logger.LogInformation("Lấy toàn bộ tài khoản.");
                    return dt;
                }
            }
	        catch (SqlException sqlEx)
            {
                logger.LogCritical(sqlEx,"Xảy ra lỗi cơ sở dữ liệu khi lấy toàn bộ tài khoản.");
                throw;
            }
            catch(Exception ex)
            {
                logger.LogWarning(ex, "Xảy ra lỗi khi lấy toàn bộ tài khoản");
                throw;
            }
        }
    }
}
