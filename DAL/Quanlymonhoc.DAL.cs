using System.Data;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Logging;
using StudentManagment.DTO;
using StudentManagment.DAL.Util;

namespace StudentManagment.DAL
{
    public class QuanlymonhocDAL
    {
        private readonly ILogger<QuanlymonhocDAL> logger;
        private MonhocDAL monhocDAL;
        public QuanlymonhocDAL(ILoggerFactory loggerFactory)
        {
            logger = loggerFactory.CreateLogger<QuanlymonhocDAL>();
            monhocDAL = new MonhocDAL(loggerFactory);
        }
        public DataTable ThemMonHocMoi(MonhocDTO monHoc)
        {
            try
            {
                using (SqlConnection conn = CosodulieuDAL.KetNoiCoSoDuLieu())
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO MONHOC VALUES(@MAMON, @TENMON, @MANGANH, @SOTIETLYTHUYET, @SOTIETTHUCHANH, @GIANGVIEN, @TINHTRANG)", conn);
                    cmd.Parameters.AddWithValue("@MAMON", monHoc.Mamon);
                    cmd.Parameters.AddWithValue("@TENMON", monHoc.Tenmon);
                    cmd.Parameters.AddWithValue("@MANGANH", monHoc.Manganh);
                    cmd.Parameters.AddWithValue("@SOTIETLYTHUYET", monHoc.Sotietlythuyet);
                    cmd.Parameters.AddWithValue("@SOTIETTHUCHANH", monHoc.Sotietthuchanh);
                    cmd.Parameters.AddWithValue("@GIANGVIEN", monHoc.Giangvien);
                    cmd.Parameters.AddWithValue("@TINHTRANG", monHoc.Tinhtrang);
                    logger.LogInformation("Thêm môn học mới vào danh sách môn hoc.\nMã môn: {0},\nTên môn: {1},\nMã môn học: {2},\nSố tiết lý thuyết: {3},\nSố tiết thực hành: {4},\nGiảng viên: {5},\nTình trạng: {6}", monHoc.Mamon, monHoc.Tenmon, monHoc.Manganh, monHoc.Sotietlythuyet, monHoc.Sotietthuchanh, monHoc.Giangvien, monHoc.Tinhtrang);
                    int thucThi = cmd.ExecuteNonQuery();
		            if(thucThi == 0)
                    {
                        logger.LogWarning("Thêm môn học không thành công.");
                        throw new InvalidOperationException();
                    }
                    return monhocDAL.LayToanBoMonHoc();
                }
            }
            catch (SqlException sqlEx)
            {
                logger.LogCritical(sqlEx, "Xảy ra lỗi dữ liệu khi thêm môn học mới.\nMã môn: {0},\nTên môn: {1},\nMã môn học: {2},\nSố tiết lý thuyết: {3},\nSố tiết thực hành: {4},\nGiảng viên: {5},\nTình trạng: {6}", monHoc.Mamon, monHoc.Tenmon, monHoc.Manganh, monHoc.Sotietlythuyet, monHoc.Sotietthuchanh, monHoc.Giangvien, monHoc.Tinhtrang);
                throw;
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Xảy ra lỗi khi thêm môn học mới.\nMã môn: {0},\nTên môn học: {1}, Mã môn học: {2}, Số tiết lý thuyết: {3}, Số tiết thực hành: {4}, Giảng viên: {5}, Tình trạng: {6}", monHoc.Mamon, monHoc.Tenmon, monHoc.Manganh, monHoc.Sotietlythuyet, monHoc.Sotietthuchanh, monHoc.Giangvien, monHoc.Tinhtrang);
                throw;
            }
        }
        public DataTable SuaThongTinMonHocTheoMaMon(MonhocDTO monHoc)
        {
            try
            {
                using (SqlConnection conn = CosodulieuDAL.KetNoiCoSoDuLieu())
                {
                    SqlCommand cmd = new SqlCommand("UPDATE MonHoc SET TENMON = @TENMON, MANGANH = @MANGANH, SOTIETLYTHUYET = @SOTIETLYTHUYET, SOTIETTHUCHANH = @SOTIETTHUCHANH, GIANGVIEN = @GIANGVIEN, TINHTRANG = @TINHTRANG WHERE MAMON = @MAMON", conn);
                    cmd.Parameters.AddWithValue("@MAMON", monHoc.Mamon);
                    cmd.Parameters.AddWithValue("@TENMON", monHoc.Tenmon);
                    cmd.Parameters.AddWithValue("@MANGANH", monHoc.Manganh);
                    cmd.Parameters.AddWithValue("@SOTIETLYTHUYET", monHoc.Sotietlythuyet);
                    cmd.Parameters.AddWithValue("@SOTIETTHUCHANH", monHoc.Sotietthuchanh);
                    cmd.Parameters.AddWithValue("@GIANGVIEN", monHoc.Giangvien);
                    cmd.Parameters.AddWithValue("@TINHTRANG", monHoc.Tinhtrang);
                    logger.LogInformation("Sửa môn học trong danh sách môn học.\nMã môn: {0},\nTên môn: {1},\nMã môn học: {2},\nSố tiết lý thuyết: {3},\nSố tiết thực hành: {4},\nGiảng viên: {5},\nTình trạng: {6}", monHoc.Mamon, monHoc.Tenmon, monHoc.Manganh, monHoc.Sotietlythuyet, monHoc.Sotietthuchanh, monHoc.Giangvien, monHoc.Tinhtrang);
                    int thucThi = cmd.ExecuteNonQuery();
		            if (thucThi == 0)
                    {
                        logger.LogWarning("Mã môn học không tồn tại.\nMã môn học: {0}", monHoc.Mamon);
                        throw new InvalidOperationException();
                    }
                    return monhocDAL.LayToanBoMonHoc();
                }
            }
            catch (SqlException sqlEx)
            {
                logger.LogCritical(sqlEx, "Xảy ra lỗi cơ sở dữ liệu khi sửa môn học.Mã môn học: {0},\nTên môn: {1},\nMã môn học: {2},\nSố tiết lý thuyết: {3},\nSố tiết thực hành: {4},\nGiảng viên: {5},\nTình trạng: {6}", monHoc.Mamon, monHoc.Tenmon, monHoc.Manganh, monHoc.Sotietlythuyet, monHoc.Sotietthuchanh, monHoc.Giangvien, monHoc.Tinhtrang);
                throw;
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Xảy ra lỗi khi sửa môn học.Mã môn học: {0},\nTên môn học: {1}, Mã môn học: {2}, Số tiết lý thuyết: {3}, Số tiết thực hành: {4}, Giảng viên: {5}, Tình trạng: {6}", monHoc.Mamon, monHoc.Tenmon, monHoc.Manganh, monHoc.Sotietlythuyet, monHoc.Sotietthuchanh, monHoc.Giangvien, monHoc.Tinhtrang);
                throw;
            }
        }
        public DataTable XoaThongTinMonHocTheoMaMon(string maMon)
        {
            try
            {
                using (SqlConnection conn = CosodulieuDAL.KetNoiCoSoDuLieu())
                {
                    SqlCommand cmd = new SqlCommand("DELETE FROM MONHOC WHERE MAMON=@MAMON", conn);
                    cmd.Parameters.AddWithValue("@MAMON", maMon);
                    logger.LogInformation("Xóa môn học khỏi dang sách môn học.\nMã môn học: {0}", maMon);
                    int thucThi = cmd.ExecuteNonQuery();
		            if (thucThi == 0)
                    {
                        logger.LogWarning("Mã môn học không tồn tại.\nMã môn học: {0}", maMon);
                        throw new InvalidOperationException();
                    }
                    return monhocDAL.LayToanBoMonHoc();
                }
            }
            catch (SqlException sqlEx)
            {
                logger.LogCritical(sqlEx, "Xảy ra lỗi cơ sở dữ liệu khi xóa môn học.\nMã môn học: {0}", maMon);
                throw;
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Xảy ra lỗi khi xóa môn học.\nMã môn học: {0}", maMon);
                throw;
            }
        }
        public DataTable LayDanhSachMonHocTheoDieuKienMaMon(string maMon)
        {
            try
            {
                using (SqlConnection conn = CosodulieuDAL.KetNoiCoSoDuLieu())
                {
                    SqlDataAdapter adater = new SqlDataAdapter();
                    DataTable dt = new DataTable();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM MONHOC WHERE MAMON=@MAMON", conn);
                    cmd.Parameters.AddWithValue("@MAMON", maMon);
                    adater.SelectCommand = cmd;
                    logger.LogInformation("Lấy danh sách môn học theo điều kiện Mã môn học.\nMã môn học: {0}", maMon);
                    adater.Fill(dt);
		            if (dt.Rows.Count == 0)
                    {
                        logger.LogWarning("Mã môn học không tồn tại.\nMã môn học: {0}", maMon);
                        throw new InvalidOperationException();
                    }
                    return dt;
                }
            }
            catch (SqlException sqlEx)
            {
                logger.LogCritical(sqlEx, "Xảy ra lỗi cơ sở dữ liệu khi lấy danh sách môn học theo điều kiện Mã môn học.\nMã môn học: {0}", maMon);
                throw;
            }
            catch (Exception ex)
            {
                logger.LogWarning(ex, "Xảy ra lỗi khi lấy danh sách môn học theo điều kiện Mã môn học.\nMã môn học: {0}",maMon);
			    throw;
            }
        }
    }
}
