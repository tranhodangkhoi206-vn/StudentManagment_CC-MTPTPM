using Microsoft.Data.SqlClient;

namespace StudentManagment.DAL
{
    public class CosodulieuDAL
    {
		private const string connectionString = "Data Source=LAPTOP-A3E91DUB;Initial Catalog=STUDENTMANAGMENT;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
        public static SqlConnection KetNoiCoSoDuLieu()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            return conn;
        }
    }
}
