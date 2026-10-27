using System.Data;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Logging;

namespace StudentManagment.DAL
{
    public class NganhhocDAL
    {
        private readonly ILogger logger;
	    public NganhhocDAL(ILoggerFactory loggerFactory)
        {
            logger = loggerFactory.CreateLogger<NganhhocDAL>();
        }
	    public DataTable LayToanBoNganhHocChoComboBox()
        {
            try
            {
                using(SqlConnection conn = CosodulieuDAL.KetNoiCoSoDuLieu())
                {
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    adapter.SelectCommand = new SqlCommand("SELECT MANGANH, TENNGANH FROM NGANHHOC", conn);
                    DataTable dt = new DataTable();
                    logger.LogInformation("Đang lấy danh sách ngành học cho combo box...");
                    adapter.Fill(dt);
                    return dt;
                }
            } catch (SqlException sqlEx)
            {
                logger.LogCritical(sqlEx, "Lỗi kết nối tới cơ sở dữ liệu khi lấy danh sách ngành học cho combo box.");
                throw;
            }
        }
	    public DataTable LayToanBoNganhHoc()
        {
            try
            {
                using (SqlConnection conn = CosodulieuDAL.KetNoiCoSoDuLieu())
                {
                    DataTable dt = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    adapter.SelectCommand = new SqlCommand("SELECT * FROM NGANHHOC", conn);
                    logger.LogInformation("Đang lấy danh sách các ngành học...");
                    adapter.Fill(dt);
                    return dt;
                }
            }
            catch (SqlException sqlEx)
            {
                logger.LogCritical(sqlEx, "Lỗi kết nối tới cơ sỡ dữ liệu khi lấy danh sách ngành học.");
                throw;
            }
        }
    }
}
