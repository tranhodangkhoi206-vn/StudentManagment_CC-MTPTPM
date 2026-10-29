using System.Data;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Logging;
using StudentManagment.DTO;

namespace StudentManagment.DAL.Util
{
    public class MonhocDAL
    {
        private readonly ILogger<MonhocDAL> logger;
        public MonhocDAL(ILoggerFactory loggerFactory)
        {
            logger = loggerFactory.CreateLogger<MonhocDAL>();
        }
        public DataTable LayToanBoMonHoc()
        {
            try
            {
                using (SqlConnection conn = CosodulieuDAL.KetNoiCoSoDuLieu())
                {
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    adapter.SelectCommand = new SqlCommand("SELECT * FROM MONHOC", conn);
                    DataTable dt = new DataTable();
                    logger.LogInformation("Đang lấy toàn bộ môn học...");
                    adapter.Fill(dt);
                    return dt;
                }
            }
            catch (SqlException sqlEx)
            {
                logger.LogCritical(sqlEx, "Lỗi kết nối tới cơ sở dữ liệu khi lấy danh sách môn học.");
                throw;
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Xảy ra lỗi khi hiển thị danh sách môn học.");
                throw;
            }
        }
    }
}
