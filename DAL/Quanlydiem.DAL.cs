using System.Data;
using StudentManagment.DTO;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Logging;
using StudentManagment.DAL.Util;

namespace StudentManagment.DAL
{
    public class QuanlydiemDAL
    {
        private readonly ILogger<QuanlydiemDAL> logger;
        private DiemDAL diemDAL;
        public QuanlydiemDAL(ILoggerFactory loggerFactory)
        {
            logger = loggerFactory.CreateLogger<QuanlydiemDAL>();
            diemDAL = new DiemDAL(loggerFactory);
        }
        public DataTable ThemDiemMoi(DiemDTO diemMoi)
        {
            try
            {
                using (SqlConnection conn = CosodulieuDAL.KetNoiCoSoDuLieu())
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO DIEM VALUES (@MASV, @MAMON, @DIEMCHUYENCAN, @DIEMGIUAKY, @DIEMCUOIKY, @DIEMTONG)", conn);
                    cmd.Parameters.AddWithValue("@MASV", diemMoi.Masinhvien);
                    cmd.Parameters.AddWithValue("@MAMON", diemMoi.Mamon);
                    cmd.Parameters.AddWithValue("@DIEMCHUYENCAN", diemMoi.Diemchuyencan);
                    cmd.Parameters.AddWithValue("@DIEMGIUAKY", diemMoi.Diemgiuaky);
                    cmd.Parameters.AddWithValue("@DIEMCUOIKY", diemMoi.Diemcuoiky);
                    cmd.Parameters.AddWithValue("@DIEMTONG", diemMoi.Diemtong);
                    cmd.ExecuteNonQuery();

                    logger.LogInformation("Thêm điểm mới vào danh sách điểm.\nMã sinh viên: {0},\nMã môn: {1},\nĐiểm chuyên cần: {2},\nĐiểm giữa kỳ: {3},\nĐiểm cuối kỳ: {4},\nĐiểm tổng: {5}", diemMoi.Masinhvien, diemMoi.Mamon, diemMoi.Diemchuyencan, diemMoi.Diemgiuaky, diemMoi.Diemcuoiky, diemMoi.Diemtong);

                    return diemDAL.LayToanBoDiem();
                }
            }
            catch (SqlException sqlEx)
            {
                logger.LogCritical(sqlEx, "Xảy ra lỗi cơ sở dữ liệu khi thêm điểm.\nMã sinh viên: {0},\nMã môn: {1},\nĐiểm chuyên cần: {2},\nĐiểm giữa kỳ: {3},\nĐiểm cuối kỳ: {4},\nĐiểm tổng: {5}", diemMoi.Masinhvien, diemMoi.Mamon, diemMoi.Diemchuyencan, diemMoi.Diemgiuaky, diemMoi.Diemcuoiky, diemMoi.Diemtong);
                throw;
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Xảy ra lỗi khi thêm điểm.\nMã sinh viên: {0},\nMã môn: {1},\nĐiểm chuyên cần: {2},\nĐiểm giữa kỳ: {3},\nĐiểm cuối kỳ: {4},\nĐiểm tổng: {5}", diemMoi.Masinhvien, diemMoi.Mamon, diemMoi.Diemchuyencan, diemMoi.Diemgiuaky, diemMoi.Diemcuoiky, diemMoi.Diemtong);
                throw;
            }
        }

        public DataTable SuaThongTinDiemTheoMaSinhVienVaMaMon(DiemDTO diemSua)
        {
            try
            {
                using (SqlConnection conn = CosodulieuDAL.KetNoiCoSoDuLieu())
                {
                    SqlCommand cmd = new SqlCommand("UPDATE DIEM SET DIEMCHUYENCAN = @DIEMCHUYENCAN, DIEMGIUAKY = @DIEMGIUAKY, DIEMCUOIKY = @DIEMCUOIKY, DIEMTONG = @DIEMTONG WHERE MASV = @MASV AND MAMON = @MAMON", conn);
                    cmd.Parameters.AddWithValue("@MASV", diemSua.Masinhvien);
                    cmd.Parameters.AddWithValue("@MAMON", diemSua.Mamon);
                    cmd.Parameters.AddWithValue("@DIEMCHUYENCAN", diemSua.Diemchuyencan);
                    cmd.Parameters.AddWithValue("@DIEMGIUAKY", diemSua.Diemgiuaky);
                    cmd.Parameters.AddWithValue("@DIEMCUOIKY", diemSua.Diemcuoiky);
                    cmd.Parameters.AddWithValue("@DIEMTONG", diemSua.Diemtong);
                    cmd.ExecuteNonQuery();

                    logger.LogInformation("Sửa điểm trong danh sách điểm.\nMã sinh viên: {0},\nMã môn: {1},\nĐiểm chuyên cần: {2},\nĐiểm giữa kỳ: {3},\nĐiểm cuối kỳ: {4},\nĐiểm tổng: {5}", diemSua.Masinhvien, diemSua.Mamon, diemSua.Diemchuyencan, diemSua.Diemgiuaky, diemSua.Diemcuoiky, diemSua.Diemtong);

                    return diemDAL.LayToanBoDiem();
                }
            }
            catch (SqlException sqlEx)
            {
                logger.LogCritical(sqlEx, "Xảy ra lỗi cơ sở dữ liệu khi sửa điểm.\nMã sinh viên: {0},\nMã môn: {1},\nĐiểm chuyên cần: {2},\nĐiểm giữa kỳ: {3},\nĐiểm cuối kỳ: {4},\nĐiểm tổng: {5}", diemSua.Masinhvien, diemSua.Mamon, diemSua.Diemchuyencan, diemSua.Diemgiuaky, diemSua.Diemcuoiky, diemSua.Diemtong);
                throw;
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Xảy ra lỗi khi sửa điểm.\nMã sinh viên: {0},\nMã môn: {1},\nĐiểm chuyên cần: {2},\nĐiểm giữa kỳ: {3},\nĐiểm cuối kỳ: {4},\nĐiểm tổng: {5}", diemSua.Masinhvien, diemSua.Mamon, diemSua.Diemchuyencan, diemSua.Diemgiuaky, diemSua.Diemcuoiky, diemSua.Diemtong);
                throw;
            }
        }

        public DataTable XoaThongTinDiemTheoMaSinhVienVaMaMon(string maSinhVien, string maMon)
        {
            try
            {
                using (SqlConnection conn = CosodulieuDAL.KetNoiCoSoDuLieu())
                {
                    SqlCommand cmd = new SqlCommand("DELETE DIEM WHERE MASV = @MASV AND MAMON = @MAMON", conn);
                    cmd.Parameters.AddWithValue("@MASV", maSinhVien);
                    cmd.Parameters.AddWithValue("@MAMON", maMon);
                    cmd.ExecuteNonQuery();

                    logger.LogInformation("Xóa điểm khỏi danh sách điểm.\nMã sinh viên: {0},\nMã môn: {1}", maSinhVien, maMon);

                    return diemDAL.LayToanBoDiem();
                }
            }
            catch (SqlException sqlEx)
            {
                logger.LogCritical(sqlEx, "Xảy ra lỗi cơ sở dữ liệu khi xóa điểm.\nMã sinh viên: {0},\nMã môn: {1},", maSinhVien, maMon);
                throw;
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Xảy ra lỗi khi xóa điểm.\nMã sinh viên: {0},\nMã môn: {1}", maSinhVien, maMon);
                throw;
            }
        }
        public DataTable LaySinhVienTheoDieuKienMaSinhVienVaMaMon(string maSinhVien, string maMon)
        {

            try
            {
                using (SqlConnection conn = CosodulieuDAL.KetNoiCoSoDuLieu())
                {
                    DataTable dt = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM DIEM WHERE MASINHVIEN=@MASINHVIEN AND MAMON=@MAMON", conn);
                    cmd.Parameters.AddWithValue("@MASINHVIEN", maSinhVien);
                    cmd.Parameters.AddWithValue("@MAMON", maMon);
                    adapter.SelectCommand = cmd;
                    logger.LogInformation("Lấy sinh viên theo điều kiện Mã sinh viên và Mã môn học.\nMã sinh viên: {0},\nMã môn học: {1}", maSinhVien, maMon);
                    adapter.Fill(dt);
                    return dt;
                }
            }
            catch (SqlException sqlEx)
            {
                logger.LogCritical(sqlEx, "Xảy ra lỗi cơ sở dữ liệu khi lấy sinh viên theo điều khiên Mã sin viên và Mã môn học.\nMã sinh viên: {0},\nMã môn học: {1}", maSinhVien, maMon);
                throw;
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Xảy ra lỗi khi lấy sinh viên theo điều kiện Mã sinh viên và Mã môn học.\nMã sinh viên: {0},\nMã môn học: {1}", maSinhVien, maMon);
                throw;
            }
        }
    }
}
