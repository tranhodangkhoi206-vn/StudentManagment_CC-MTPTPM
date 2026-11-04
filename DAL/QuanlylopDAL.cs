using System;
using System.ComponentModel.DataAnnotations;
using System.Data;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Logging;
using StudentManagment.DAL.Util;
using StudentManagment.DTO;

namespace StudentManagment.DAL
{
    public class QuanlylopDAL
    {
        private readonly ILogger logger;
        private readonly LopDAL lopDAL;

        public QuanlylopDAL(ILoggerFactory loggerFactory)
        {
            this.logger = loggerFactory.CreateLogger<QuanlylopDAL>();
            this.lopDAL = new LopDAL(loggerFactory);
        }

        // Hàm bóc tách lỗi SQL tiếng Việt chuẩn xác
        private string PhanTichLoiSqlLopHoc(SqlException sqlEx, string maLop)
        {
            string thongBaoGoc = sqlEx.Message.ToLower();

            // 1. Trùng khóa chính MALOP
            if (thongBaoGoc.Contains("primary key") || thongBaoGoc.Contains("duplicate key"))
            {
                return $"Mã lớp '{maLop}' đã tồn tại trong hệ thống. Vui lòng nhập mã lớp khác!";
            }

            // 2. Vi phạm khóa ngoại MANGANH tham chiếu đến bảng NGANHHOC
            if (thongBaoGoc.Contains("fk_lop_nganhhoc") || (thongBaoGoc.Contains("foreign key") && thongBaoGoc.Contains("manganh")))
            {
                return "Mã ngành học không tồn tại trong danh mục ngành học!";
            }

            // 3. Vi phạm ràng buộc khi xóa lớp (lớp đã có sinh viên đăng ký)
            if (thongBaoGoc.Contains("foreign key") || thongBaoGoc.Contains("reference constraint"))
            {
                return $"Không thể xóa lớp '{maLop}' vì lớp này đang có sinh viên theo học!";
            }

            // 4. Dữ liệu nhập quá độ dài trường
            if (thongBaoGoc.Contains("string or binary data would be truncated"))
            {
                return "Dữ liệu nhập vào vượt quá độ dài tối đa cho phép của cột trong cơ sở dữ liệu!";
            }

            // 5. Lỗi kết nối CSDL thực tế
            if (thongBaoGoc.Contains("network-related") || thongBaoGoc.Contains("server was not found") || thongBaoGoc.Contains("cannot open database"))
            {
                return "Không thể kết nối đến máy chủ cơ sở dữ liệu. Vui lòng kiểm tra lại SQL Server!";
            }

            return "Lỗi cơ sở dữ liệu: " + sqlEx.Message;
        }

        public DataTable TimKiemLopHocTheoMa(string maLop)
        {
            try
            {
                using (SqlConnection conn = CosodulieuDAL.KetNoiCoSoDuLieu())
                {
                    SqlCommand cmd = new SqlCommand("SELECT MALOP, MANGANH, TENLOP, GIANGVIENPHUTRACH FROM LOP WHERE MALOP LIKE @MALOP", conn);
                    cmd.Parameters.AddWithValue("@MALOP", "%" + maLop.Trim() + "%");
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    logger.LogInformation("Lấy danh sách lớp học theo điều kiện mã mã lớp.\nMã lớp học: {0}", maLop);
                    return dt;
                }
            }
            catch (SqlException sqlEx)
            {
                logger.LogError("Xảy ra lỗi cơ sở dữ liệu khi tìm kiếm lớp.\nMã lớp: {0}", maLop);
                throw;
            }
        }
        public DataTable ThemDuLieuLopMoi(LopDTO lopHoc)
        {
            try
            {
                using (SqlConnection conn = CosodulieuDAL.KetNoiCoSoDuLieu())
                {
                    string sql = "INSERT INTO LOP VALUES (@MALOP, @MANGANH, @TENLOP, @GIANGVIENPHUTRACH)";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@MALOP", lopHoc.Malop.Trim());
                    cmd.Parameters.AddWithValue("@MANGANH", lopHoc.Manganh.Trim());
                    cmd.Parameters.AddWithValue("@TENLOP", lopHoc.Tenlop.Trim());
                    cmd.Parameters.AddWithValue("@GIANGVIENPHUTRACH", lopHoc.Giangvienphutrach.Trim());
                    logger.LogInformation("Thêm lớp  mới vào danh sách lớp học.\nMã lớp: {0},\nMã ngành: {1},\nTên lớp: {2},\nGiảng viên phụ trách: {3}", lopHoc.Malop, lopHoc.Manganh, lopHoc.Tenlop, lopHoc.Giangvienphutrach);
                    int thucThi = cmd.ExecuteNonQuery();
                    if (thucThi == 0)
                    {
                        logger.LogWarning("Thêm lớp không thành công.");
                        return null;
                    }
                    return lopDAL.LayToanBoLopHoc();
                }
            }
            catch (SqlException sqlEx)
            {
                logger.LogError(sqlEx, "Xảy ra lỗi cơ sở dữ liệu khi thêm lớp học mới.\nMã lớp: {0},\nMã ngành: {1},\nTên lớp: {2},\nGiảng viên phụ trách: {3}", lopHoc.Malop, lopHoc.Manganh, lopHoc.Tenlop, lopHoc.Giangvienphutrach);
                throw;
            }
        }
        public DataTable SuaThongTinLopTheoMaLop(LopDTO lopHoc)
        {
            try
            {
                using (SqlConnection conn = CosodulieuDAL.KetNoiCoSoDuLieu())
                {
                    string sql = "UPDATE LOP SET MANGANH = @MANGANH, TENLOP = @TENLOP, GIANGVIENPHUTRACH = @GIANGVIENPHUTRACH WHERE MALOP = @MALOP";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@MALOP", lopHoc.Malop.Trim());
                    cmd.Parameters.AddWithValue("@MANGANH", lopHoc.Manganh.Trim());
                    cmd.Parameters.AddWithValue("@TENLOP", lopHoc.Tenlop.Trim());
                    cmd.Parameters.AddWithValue("@GIANGVIENPHUTRACH", lopHoc.Giangvienphutrach.Trim());
                    logger.LogInformation("Sửa lớp học trong danh sách lớp học.\nMã lớp: {0},\nMã ngành: {1},\nTên lớp: {2},\nGiảng viên phụ trách: {3}", lopHoc.Malop, lopHoc.Manganh, lopHoc.Tenlop, lopHoc.Giangvienphutrach);
                    int thucThi = cmd.ExecuteNonQuery();
                    if (thucThi == 0)
                    {
                        logger.LogWarning("Sửa lớp không thành công.");
                        return null;
                    }
                    return lopDAL.LayToanBoLopHoc();
                }
            }
            catch (SqlException sqlEx)
            {
                logger.LogError(sqlEx, "Xảy ra lỗi cơ sở dữ liệu khi sửa lớp học.\nMã lớp: {0},\nMã ngành: {1},\nTên lớp: {2},\nGiảng viên phụ trách: {3}", lopHoc.Malop, lopHoc.Manganh, lopHoc.Tenlop, lopHoc.Giangvienphutrach);
                throw;
            }
        }

        public DataTable XoaThongTinLopTheoMaLop(string maLop)
        {
            try
            {
                using (SqlConnection conn = CosodulieuDAL.KetNoiCoSoDuLieu())
                {
                    SqlCommand cmd = new SqlCommand("DELETE FROM LOP WHERE MALOP = @MALOP", conn);
                    cmd.Parameters.AddWithValue("@MALOP", maLop.Trim());
                    logger.LogInformation("Xóa lớp học khỏi danh sách lớp học.\nMã lớp: {0}", maLop);
                    int thucThi = cmd.ExecuteNonQuery();
                    if (thucThi == 0)
                    {
                        logger.LogWarning("Xóa lớp không thành công.");
                        return null;
                    }
                    return lopDAL.LayToanBoLopHoc();
                }
            }
            catch (SqlException sqlEx)
            {
                logger.LogError(sqlEx, "Xảy ra lỗi cơ sở dữ liệu khi xóa lớp học.\nMã lớp học: {0}", maLop);
                throw;
            }
        }
    }
}