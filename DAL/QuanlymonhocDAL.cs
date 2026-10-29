using System.Data;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Logging;
using StudentManagment.DTO;

namespace StudentManagment.DAL.Util
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
        public DataTable ThemMonHocMoi(MonhocDTO monHocMoi)
        {
            try
            {
                using (SqlConnection conn = CosodulieuDAL.KetNoiCoSoDuLieu())
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO MONHOC VALUES(@MAMON, @TENMON, @MANGANH, @SOTIETLYTHUYET, @SOTIETTHUCHANH, @GIANGVIEN, @TINHTRANG)", conn);
                    cmd.Parameters.AddWithValue("@MAMON", monHocMoi.Mamon);
                    cmd.Parameters.AddWithValue("@TENMON", monHocMoi.Tenmon);
                    cmd.Parameters.AddWithValue("@MANGANH", monHocMoi.Manganh);
                    cmd.Parameters.AddWithValue("@SOTIETLYTHUYET", monHocMoi.Sotietlythuyet);
                    cmd.Parameters.AddWithValue("@SOTIETTHUCHANH", monHocMoi.Sotietthuchanh);
                    cmd.Parameters.AddWithValue("@GIANGVIEN", monHocMoi.Giangvien);
                    cmd.Parameters.AddWithValue("@TINHTRANG", monHocMoi.Tinhtrang);
                    cmd.ExecuteNonQuery();
                    logger.LogInformation("Đang thêm môn học có mã môn {0} vào danh sách môn học. Với dữ liệu:\nTên môn: {1},\nMã ngành: {2},\nSố tiết lý thuyết: {3},\nSố tiết thực hành: {4},\nGiảng viên: {5},\nTình trạng: {6}", monHocMoi.Mamon, monHocMoi.Tenmon, monHocMoi.Manganh, monHocMoi.Sotietlythuyet, monHocMoi.Sotietthuchanh, monHocMoi.Giangvien, monHocMoi.Tinhtrang);
                    return monhocDAL.LayToanBoMonHoc();
                }
            }
            catch (SqlException sqlEx)
            {
                logger.LogCritical(sqlEx, "Lỗi kết nối tới cơ sở dữ liệu khi thêm môn học có mã môn {0} vào danh sách môn học. Với dữ liệu:\nTên môn: {1},\nMã ngành: {2},\nSố tiết lý thuyết: {3},\nSố tiết thực hành: {4},\nGiảng viên: {5},\nTình trạng: {6}", monHocMoi.Mamon, monHocMoi.Tenmon, monHocMoi.Manganh, monHocMoi.Sotietlythuyet, monHocMoi.Sotietthuchanh, monHocMoi.Giangvien, monHocMoi.Tinhtrang);
                throw;
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Xảy ra lỗi khi thêm môn học có mã môn học {0} vào danh sách môn học. Với dữ liệu:\nTên môn học: {1}, Mã ngành: {2}, Số tiết lý thuyết: {3}, Số tiết thực hành: {4}, Giảng viên: {5}, Tình trạng: {6}", monHocMoi.Mamon, monHocMoi.Tenmon, monHocMoi.Manganh, monHocMoi.Sotietlythuyet, monHocMoi.Sotietthuchanh, monHocMoi.Giangvien, monHocMoi.Tinhtrang);
                throw;
            }
        }
        public DataTable SuaThongTinMonHocTheoMaMon(MonhocDTO monHocMoi)
        {
            try
            {
                using (SqlConnection conn = CosodulieuDAL.KetNoiCoSoDuLieu())
                {
                    SqlCommand cmd = new SqlCommand("UPDATE MonHoc SET TENMON = @TENMON, MANGANH = @MANGANH, SOTIETLYTHUYET = @SOTIETLYTHUYET, SOTIETTHUCHANH = @SOTIETTHUCHANH, GIANGVIEN = @GIANGVIEN, TINHTRANG = @TINHTRANG WHERE MAMON = @MAMON", conn);
                    cmd.Parameters.AddWithValue("@MAMON", monHocMoi.Mamon);
                    cmd.Parameters.AddWithValue("@TENMON", monHocMoi.Tenmon);
                    cmd.Parameters.AddWithValue("@MANGANH", monHocMoi.Manganh);
                    cmd.Parameters.AddWithValue("@SOTIETLYTHUYET", monHocMoi.Sotietlythuyet);
                    cmd.Parameters.AddWithValue("@SOTIETTHUCHANH", monHocMoi.Sotietthuchanh);
                    cmd.Parameters.AddWithValue("@GIANGVIEN", monHocMoi.Giangvien);
                    cmd.Parameters.AddWithValue("@TINHTRANG", monHocMoi.Tinhtrang);
                    cmd.ExecuteNonQuery();
                    logger.LogInformation("Đang sửa môn học có mã môn {0} vào danh sách môn học. Với dữ liệu:\nTên môn: {1},\nMã ngành: {2},\nSố tiết lý thuyết: {3},\nSố tiết thực hành: {4},\nGiảng viên: {5},\nTình trạng: {6}", monHocMoi.Mamon, monHocMoi.Tenmon, monHocMoi.Manganh, monHocMoi.Sotietlythuyet, monHocMoi.Sotietthuchanh, monHocMoi.Giangvien, monHocMoi.Tinhtrang);
                    return monhocDAL.LayToanBoMonHoc();
                }
            }
            catch (SqlException sqlEx)
            {
                logger.LogCritical(sqlEx, "Lỗi kết nối tới cơ sở dữ liệu khi sửa môn học có mã môn {0} vào danh sách môn học. Với dữ liệu:\nTên môn: {1},\nMã ngành: {2},\nSố tiết lý thuyết: {3},\nSố tiết thực hành: {4},\nGiảng viên: {5},\nTình trạng: {6}", monHocMoi.Mamon, monHocMoi.Tenmon, monHocMoi.Manganh, monHocMoi.Sotietlythuyet, monHocMoi.Sotietthuchanh, monHocMoi.Giangvien, monHocMoi.Tinhtrang);
                throw;
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Xảy ra lỗi khi sửa môn học có mã môn học {0} vào danh sách môn học. Với dữ liệu:\nTên môn học: {1}, Mã ngành: {2}, Số tiết lý thuyết: {3}, Số tiết thực hành: {4}, Giảng viên: {5}, Tình trạng: {6}", monHocMoi.Mamon, monHocMoi.Tenmon, monHocMoi.Manganh, monHocMoi.Sotietlythuyet, monHocMoi.Sotietthuchanh, monHocMoi.Giangvien, monHocMoi.Tinhtrang);
                throw;
            }
        }
        public DataTable XoaThongTinMonHocTheoMaMon(string maMon)
        {
            try
            {
                using (SqlConnection conn = CosodulieuDAL.KetNoiCoSoDuLieu())
                {
                    SqlCommand cmd = new SqlCommand("DELETE MONHOC WHERE MAMON=@MAMON", conn);
                    cmd.Parameters.AddWithValue("@MAMON", maMon);
                    cmd.ExecuteNonQuery();
                    logger.LogInformation("Đang xóa môn học với mã môn {0} khỏi danh sách môn học.", maMon);
                    return monhocDAL.LayToanBoMonHoc();
                }
            }
            catch (SqlException sqlEx)
            {
                logger.LogCritical(sqlEx, "Lỗi kết nối tới cơ sở dữ liệu khi xóa môn học có mã môn {0} khỏi danh sách môn học", maMon);
                throw;
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Lỗi xảy ra khi xóa môn học với mã môn học {0}", maMon);
                throw;
            }
        }
    }
}
