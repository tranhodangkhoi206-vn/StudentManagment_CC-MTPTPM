using Microsoft.Data.SqlClient;

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
