using Microsoft.Data.SqlClient;

namespace StudentManagment.DAL
{
    public class CosodulieuDAL
    {
		private const string connectionString = "Data Source=ASUS\\SQLEXPRESS;Initial Catalog=STUDENTMANAGMENT;Integrated Security=True;Trust Server Certificate=True";
        public SqlConnection KetNoiCoSoDuLieu()
        {
            return new SqlConnection(connectionString);
        }
    }
}
