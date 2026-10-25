using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace StudentManagment
{
    public class StudentManagment_DAL
    {
        public class SinhVienDAL
        {
            public DataTable LayDanhSachSinhVien()
            {
                DataTable dt = new DataTable();
                using (SqlConnection conn = KetNoiCSDL.Connection())
                {
                    string sql = "SELECT MSSV, HoTen, Khoa, Lop, GPA FROM SinhVien";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            da.Fill(dt);
                        }
                    }
                }
                return dt;
            }
            public bool ThemSinhVien(SinhVienDTO sv)
            {
                using (SqlConnection conn = KetNoiCSDL.Connection())
                {
                    conn.Open();
                    string sql = "INSERT INTO SinhVien (MSSV, HoTen, Khoa, Lop, GPA) VALUES (@MSSV, @HoTen, @Khoa, @Lop, @GPA)";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@MSSV", sv.MSSV);
                        cmd.Parameters.AddWithValue("@HoTen", sv.HoTen);
                        cmd.Parameters.AddWithValue("@Khoa", sv.Khoa);
                        cmd.Parameters.AddWithValue("@Lop", sv.Lop);
                        cmd.Parameters.AddWithValue("@GPA", sv.DiemGPA.ToString("0.00"));

                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
        }
    }
}
