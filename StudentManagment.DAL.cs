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

            // Kiểm tra xem MSSV có tồn tại trong CSDL hay không
            public bool KiemTraTonTai(string mssv)
            {
                using (SqlConnection conn = KetNoiCSDL.Connection())
                {
                    string query = "SELECT COUNT(*) FROM SinhVien WHERE MSSV = @MSSV";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MSSV", mssv);
                        conn.Open();
                        int count = (int)cmd.ExecuteScalar();
                        return count > 0;
                    }
                }
            }

            // Sửa sinh viên
            public bool Sua(SinhVienDTO sv)
            {
                using (SqlConnection conn = KetNoiCSDL.Connection())
                {
                    // Đổi DiemGPA = @GPA thành GPA = @GPA
                    string query = @"UPDATE SinhVien 
                         SET HoTen = @HoTen, 
                             Lop = @Lop, 
                             Khoa = @Khoa, 
                             GPA = @GPA 
                         WHERE MSSV = @MSSV";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MSSV", sv.MSSV);
                        cmd.Parameters.AddWithValue("@HoTen", sv.HoTen);
                        cmd.Parameters.AddWithValue("@Lop", sv.Lop);
                        cmd.Parameters.AddWithValue("@Khoa", sv.Khoa);
                        cmd.Parameters.AddWithValue("@GPA", sv.DiemGPA);

                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }

            public bool Xoa(string mssv)
            {
                using (SqlConnection conn = KetNoiCSDL.Connection())
                {
                    string query = "DELETE FROM SinhVien WHERE MSSV = @MSSV";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MSSV", mssv);

                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
        }
    }
}
