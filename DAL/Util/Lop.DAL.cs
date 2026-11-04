using Microsoft.Extensions.Logging;
using System.Data;
using Microsoft.Data.SqlClient;
namespace StudentManagment.DAL.Util
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
                logger.LogError(sqlEx, "Lỗi kết nối tới cơ sở dữ liệu khi lấy danh sách lớp cho combo box.");
                throw;
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Xảy ra lỗi khi lấy danh sách lớp cho combo boxo");
                throw;
            }
        }
	    public DataTable LayToanBoLopHoc()
        {
            try
            {
                using(SqlConnection conn = CosodulieuDAL.KetNoiCoSoDuLieu())
                {
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    adapter.SelectCommand = new SqlCommand("SELECT * FROM LOP",conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    logger.LogInformation("Lấy toàn bộ lớp học.");
                    return dt;
                }			
            } catch(SqlException sqlEx)
            {
                logger.LogError(sqlEx,"Xảy ra lỗi cơ sở dữ liệu khi lấy toàn bộ lớp học.");
                throw;
            } catch(Exception ex)
            {
                logger.LogWarning(ex,"Xảy ra lỗi khi lấy toàn bộ ngành học.");
                throw;
            }
        }
    }
}
