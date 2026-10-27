using System.Data;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Logging;
using StudentManagment.DTO;

namespace StudentManagment.DAL
{
    public class SinhvienDAL
    {
        private CosodulieuDAL csdl = new CosodulieuDAL();
        private readonly ILogger logger;
        public SinhvienDAL(ILoggerFactory loggerFactory)
        {
            logger = loggerFactory.CreateLogger<SinhvienDAL>();
        }
        public DataTable LayToanBoSinhVien()
        {
            try
            {
                using (SqlConnection conn = csdl.KetNoiCoSoDuLieu())
                {
                    DataTable dt = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    adapter.SelectCommand = new SqlCommand("SELECT * FROM SINHVIEN", conn);
                    logger.LogInformation("Đang lấy danh sách các sinh viên...");
                    adapter.Fill(dt);
                    return dt;
                }
            }
            catch (SqlException sqlEx)
            {
                logger.LogCritical(sqlEx, "Lỗi kết nối tới cơ sỡ dữ liệu khi lấy danh sách sinh viên.");
                throw;
            }
        }
    }
}
