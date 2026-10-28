using System.Data;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Logging;
using StudentManagment.DTO;
using StudentManagment.DAL.Util;

namespace StudentManagment.DAL
{
    public class TracuusinhvienDAL
    {
        private readonly ILogger logger;
        public TracuusinhvienDAL(ILoggerFactory loggerFactory)
        {
            logger = loggerFactory.CreateLogger<QuanlysinhvienDAL>();
        }
        public DataTable LaySinhVienTheoDieuKienTen(string hovaten)
        {
            try
            {
                using (SqlConnection conn = CosodulieuDAL.KetNoiCoSoDuLieu())
                {
                    DataTable dt = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM SINHVIEN WHERE HOVATEN LIKE @HOVATEN", conn);
                    cmd.Parameters.AddWithValue("@HOVATEN", "%" + hovaten + "%");
                    adapter.SelectCommand = cmd;
                    logger.LogInformation("Đang lấy danh sách sinh viên theo điều kiện tên...");
                    adapter.Fill(dt);
                    return dt;
                }
            }
            catch (SqlException sqlEx)
            {
                logger.LogCritical(sqlEx, "Lỗi kết nối tới cơ sở dữ liệu khi lấy danh sách sinh viên theo điều kiện tên.");
                throw;
            }
        }
        public DataTable LaySinhVienTheoDieuKienLop(string maLop)
        {
            try
            {
                using (SqlConnection conn = CosodulieuDAL.KetNoiCoSoDuLieu())
                {
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM SINHVIEN WHERE MALOP=@MALOP", conn);
                    cmd.Parameters.AddWithValue("@MALOP", maLop);
                    adapter.SelectCommand = cmd;
                    DataTable dt = new DataTable();
                    logger.LogInformation("Đang lấy danh sách sinh viên theo điều kiện lớp...");
                    adapter.Fill(dt);
                    return dt;
                }
            }
            catch (SqlException sqlEx)
            {
                logger.LogCritical(sqlEx, "Lỗi kết nối tới cơ sở dữ liệu khi lấy danh sách sinh viên theo điều kiện lớp.");
                throw;
            }
        }
        public DataTable LaySinhVienTheoDieuKienNganhHoc(string maNganh)
        {
            try
            {
                using (SqlConnection conn = CosodulieuDAL.KetNoiCoSoDuLieu())
                {
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM SINHVIEN WHERE MANGANH=@MANGANH", conn);
                    cmd.Parameters.AddWithValue("@MANGANH", maNganh);
                    adapter.SelectCommand = cmd;
                    DataTable dt = new DataTable();
                    logger.LogInformation("Đang lấy danh sách sinh viên theo điều kiện ngành học...");
                    adapter.Fill(dt);
                    return dt;
                }
            }
            catch (SqlException sqlEx)
            {
                logger.LogCritical(sqlEx, "Lỗi kết nối tới cơ sở dữ liệu khi lấy danh sách sinh viên theo điều kiện ngành học.");
                throw;
            }
        }
    }
}
