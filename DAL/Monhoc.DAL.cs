using System.Data;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Logging;

namespace StudentManagment.DAL
{
    public class MonhocDAL
    {
        private readonly ILogger<MonhocDAL> logger;
	    public MonhocDAL(ILoggerFactory loggerFactory)
        {
            logger = loggerFactory.CreateLogger<MonhocDAL>();
        }
	    public DataTable LayToanBoMonHocChoComboBox()
        {
            try
            {
                using(SqlConnection conn = CosodulieuDAL.KetNoiCoSoDuLieu())
                {
			        SqlDataAdapter adapter = new SqlDataAdapter();
                    adapter.SelectCommand = new SqlCommand("SELECT MAMON, TENMON FROM MONHOC", conn);
                    DataTable dt = new DataTable();
                    logger.LogInformation("Đang lấy danh sách môn học cho combo box...");
                    adapter.Fill(dt);
                    return dt;
                }
            } catch (SqlException sqlEx)
            {
                logger.LogCritical(sqlEx, "Lỗi kết nối tới cơ sở dữ liệu khi lấy danh sách môn học cho combo box.");
                throw;
            }
        }
    }
}
