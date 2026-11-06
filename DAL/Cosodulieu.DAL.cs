using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using StudentManagment.Helper;

namespace StudentManagment.DAL
{
    public class CosodulieuDAL
    {
        private const string connectionString = "Data Source=ASUS\\SQLEXPRESS;Initial Catalog=STUDENTMANAGMENT;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
        private static readonly ILogger<CosodulieuDAL> logger = Logging.CreateLoggerFactory().CreateLogger<CosodulieuDAL>();
        public static SqlConnection KetNoiCoSoDuLieu()
        {
            try
            {
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                return conn;
            }
            catch (SqlException sqlEx)
            {
                logger.LogCritical(sqlEx, "Lỗi kết nối cơ sở dữ liệu.");
                throw;
            }

        }
    }
}
