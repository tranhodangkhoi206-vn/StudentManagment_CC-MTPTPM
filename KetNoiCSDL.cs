using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace StudentManagment
{
    public static class KetNoiCSDL
    {
        private static readonly string strConn = @"Data Source=LAPTOP-A3E91DUB;Initial Catalog=STUDENTMANAGMENT;Integrated Security=True";

        public static SqlConnection Connection()
        {
            return new SqlConnection(strConn);
        }
    }
}
