using System.Data;
using StudentManagment.DTO;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Logging;
namespace StudentManagment.DAL.Util
{
    public class DiemDAL
    {
        private readonly ILogger<DiemDAL> logger;
        public DiemDAL(ILoggerFactory loggerFactory)
        {
            logger = loggerFactory.CreateLogger<DiemDAL>();
        }
        public DataTable LayToanBoDiem()
        {
            try
            {
                using (SqlConnection conn = CosodulieuDAL.KetNoiCoSoDuLieu())
                {
                    DataTable dt = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    adapter.SelectCommand = new SqlCommand("SELECT * FROM DIEM", conn);
                    logger.LogInformation("Đang lấy danh sách điểm...");
                    adapter.Fill(dt);
                    return dt;
                }
            }
            catch (SqlException sqlEx)
            {
                logger.LogCritical(sqlEx, "Lỗi kết nối tới cơ sỡ dữ liệu khi lấy danh sách điểm.");
                throw;
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Có lỗi xảy ra khi lấy danh sách điểm.");
                throw;
            }
        }
    }
}
