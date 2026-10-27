using Microsoft.Extensions.Logging;
using System.Data;
using Microsoft.Data.SqlClient;
namespace StudentManagment.DAL
{
    public class LopDAL
    {
        private readonly ILogger logger;
        public LopDAL(ILoggerFactory loggerFactory)
        {
            logger = loggerFactory.CreateLogger<LopDAL>();
        }
        public DataTable LayToanBoLopChoComboBox()
        {
            try
            {
                using (SqlConnection conn = CosodulieuDAL.KetNoiCoSoDuLieu())
                {
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    adapter.SelectCommand = new SqlCommand("SELECT MALOP, TENLOP FROM LOP", conn);
                    DataTable dt = new DataTable();
                    logger.LogInformation("Đang lấy danh sách lớp cho combo box...");
                    adapter.Fill(dt);
                    return dt;
                }
            }
            catch (SqlException sqlEx)
            {
                logger.LogCritical(sqlEx, "Lỗi kết nối tới cơ sở dữ liệu khi lấy danh sách lớp cho combo box.");
                throw;
            }
        }
    }
}
