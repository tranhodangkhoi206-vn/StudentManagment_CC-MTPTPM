using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using StudentManagment.Helper;

namespace StudentManagment.DAL
{
    public class CosodulieuDAL
    {
        private const string connectionString = "Data Source=ASUS\\SQLEXPRESS;Initial Catalog=STUDENTMANAGMENT;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
        public static SqlConnection KetNoiCoSoDuLieu()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            return conn;

        }
    }
}
