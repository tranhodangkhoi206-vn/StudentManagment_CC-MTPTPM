using System;
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

        // Lấy toàn bộ danh sách lớp học
        public DataTable LayToanBoLopHoc()
        {
            try
            {
                using (SqlConnection conn = CosodulieuDAL.KetNoiCoSoDuLieu())
                {
                    SqlCommand cmd = new SqlCommand("SELECT MALOP, MANGANH, TENLOP, GIANGVIENPHUTRACH FROM LOP", conn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    logger.LogInformation("Hiển thị toàn bộ danh sách lớp học.");
                    return dt;
                }
            }
            catch (SqlException sqlEx)
            {
                logger.LogCritical(sqlEx, "Lỗi kết nối cơ sở dữ liệu khi tải danh sách lớp học: {0}", sqlEx.Message);
                throw new Exception("Lỗi kết nối tới cơ sở dữ liệu khi lấy danh sách lớp học!");
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Lỗi không xác định khi lấy danh sách lớp học: {0}", ex.Message);
                throw new Exception("Lỗi hệ thống: " + ex.Message);
            }
        }

        // Tìm kiếm lớp học theo Mã lớp
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
                    logger.LogInformation("Tìm kiếm lớp học với từ khóa mã lớp: {0}", maLop);
                    return dt;
                }
            }
            catch (SqlException sqlEx)
            {
                logger.LogCritical(sqlEx, "Lỗi tìm kiếm lớp học: {0}", sqlEx.Message);
                throw new Exception("Lỗi cơ sở dữ liệu khi tìm kiếm lớp học!");
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Lỗi hệ thống khi tìm kiếm lớp học: {0}", ex.Message);
                throw new Exception("Lỗi hệ thống: " + ex.Message);
            }
        }

        // Thêm mới lớp học
        public DataTable ThemDuLieuLopMoi(LopDTO lopDTO)
        {
            try
            {
                using (SqlConnection conn = CosodulieuDAL.KetNoiCoSoDuLieu())
                {
                    string sql = "INSERT INTO LOP (MALOP, MANGANH, TENLOP, GIANGVIENPHUTRACH) VALUES (@MALOP, @MANGANH, @TENLOP, @GIANGVIENPHUTRACH)";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@MALOP", lopDTO.Malop.Trim());
                    cmd.Parameters.AddWithValue("@MANGANH", lopDTO.Manganh.Trim());
                    cmd.Parameters.AddWithValue("@TENLOP", lopDTO.Tenlop.Trim());
                    cmd.Parameters.AddWithValue("@GIANGVIENPHUTRACH", lopDTO.Giangvienphutrach.Trim());

                    cmd.ExecuteNonQuery();

                    logger.LogInformation("Thêm lớp học thành công với mã lớp: {0}", lopDTO.Malop);
                    return LayToanBoLopHoc();
                }
            }
            catch (SqlException sqlEx)
            {
                string thongBaoLoi = PhanTichLoiSqlLopHoc(sqlEx, lopDTO.Malop);
                logger.LogCritical(sqlEx, "Lỗi thêm lớp học: {0}", thongBaoLoi);
                throw new Exception(thongBaoLoi);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Lỗi khi thêm lớp học {0}: {1}", lopDTO.Malop, ex.Message);
                throw new Exception("Lỗi hệ thống khi thêm lớp học: " + ex.Message);
            }
        }

        // Sửa thông tin lớp học
        public DataTable SuaThongTinLopTheoMaLop(LopDTO lopDTO)
        {
            try
            {
                using (SqlConnection conn = CosodulieuDAL.KetNoiCoSoDuLieu())
                {
                    string sql = "UPDATE LOP SET MANGANH = @MANGANH, TENLOP = @TENLOP, GIANGVIENPHUTRACH = @GIANGVIENPHUTRACH WHERE MALOP = @MALOP";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@MALOP", lopDTO.Malop.Trim());
                    cmd.Parameters.AddWithValue("@MANGANH", lopDTO.Manganh.Trim());
                    cmd.Parameters.AddWithValue("@TENLOP", lopDTO.Tenlop.Trim());
                    cmd.Parameters.AddWithValue("@GIANGVIENPHUTRACH", lopDTO.Giangvienphutrach.Trim());

                    cmd.ExecuteNonQuery();

                    logger.LogInformation("Cập nhật lớp học có mã lớp: {0}", lopDTO.Malop);
                    return LayToanBoLopHoc();
                }
            }
            catch (SqlException sqlEx)
            {
                string thongBaoLoi = PhanTichLoiSqlLopHoc(sqlEx, lopDTO.Malop);
                logger.LogCritical(sqlEx, "Lỗi sửa lớp học: {0}", thongBaoLoi);
                throw new Exception(thongBaoLoi);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Lỗi khi cập nhật lớp học {0}: {1}", lopDTO.Malop, ex.Message);
                throw new Exception("Lỗi hệ thống khi cập nhật lớp học: " + ex.Message);
            }
        }

        // Xóa thông tin lớp học
        public DataTable XoaThongTinLopTheoMaLop(string maLop)
        {
            try
            {
                using (SqlConnection conn = CosodulieuDAL.KetNoiCoSoDuLieu())
                {
                    SqlCommand cmd = new SqlCommand("DELETE FROM LOP WHERE MALOP = @MALOP", conn);
                    cmd.Parameters.AddWithValue("@MALOP", maLop.Trim());

                    cmd.ExecuteNonQuery();

                    logger.LogInformation("Xóa thành công lớp học có mã: {0}", maLop);
                    return LayToanBoLopHoc();
                }
            }
            catch (SqlException sqlEx)
            {
                string thongBaoLoi = PhanTichLoiSqlLopHoc(sqlEx, maLop);
                logger.LogCritical(sqlEx, "Lỗi xóa lớp học: {0}", thongBaoLoi);
                throw new Exception(thongBaoLoi);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Lỗi khi xóa lớp học {0}: {1}", maLop, ex.Message);
                throw new Exception("Lỗi hệ thống khi xóa lớp học: " + ex.Message);
            }
        }
    }
}