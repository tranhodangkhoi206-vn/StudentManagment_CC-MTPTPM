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
        public DataTable ThemDiemMoi(DiemDTO diem)
        {
            try
            {
                using (SqlConnection conn = CosodulieuDAL.KetNoiCoSoDuLieu())
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO DIEM VALUES (@MASV, @MAMON, @DIEMCHUYENCAN, @DIEMGIUAKY, @DIEMCUOIKY, @DIEMTONG)", conn);
                    cmd.Parameters.AddWithValue("@MASV", diem.Masinhvien);
                    cmd.Parameters.AddWithValue("@MAMON", diem.Mamon);
                    cmd.Parameters.AddWithValue("@DIEMCHUYENCAN", diem.Diemchuyencan);
                    cmd.Parameters.AddWithValue("@DIEMGIUAKY", diem.Diemgiuaky);
                    cmd.Parameters.AddWithValue("@DIEMCUOIKY", diem.Diemcuoiky);
                    cmd.Parameters.AddWithValue("@DIEMTONG", diem.Diemtong);
                    logger.LogInformation("Thêm điểm mới vào danh sách điểm.\nMã sinh viên: {0},\nMã môn: {1},\nĐiểm chuyên cần: {2},\nĐiểm giữa kỳ: {3},\nĐiểm cuối kỳ: {4},\nĐiểm tổng: {5}", diem.Masinhvien, diem.Mamon, diem.Diemchuyencan, diem.Diemgiuaky, diem.Diemcuoiky, diem.Diemtong);
                    int thucThi = cmd.ExecuteNonQuery();
                    if (thucThi == 0)
                    {
                        logger.LogWarning("Thêm điểm không thành công.");
                        throw new InvalidOperationException();
                    }
                    return diemDAL.LayToanBoDiem();
                }
            }
            catch (SqlException sqlEx)
            {
                logger.LogCritical(sqlEx, "Xảy ra lỗi cơ sở dữ liệu khi thêm điểm.\nMã sinh viên: {0},\nMã môn: {1},\nĐiểm chuyên cần: {2},\nĐiểm giữa kỳ: {3},\nĐiểm cuối kỳ: {4},\nĐiểm tổng: {5}", diem.Masinhvien, diem.Mamon, diem.Diemchuyencan, diem.Diemgiuaky, diem.Diemcuoiky, diem.Diemtong);
                throw;
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Xảy ra lỗi khi thêm điểm.\nMã sinh viên: {0},\nMã môn: {1},\nĐiểm chuyên cần: {2},\nĐiểm giữa kỳ: {3},\nĐiểm cuối kỳ: {4},\nĐiểm tổng: {5}", diem.Masinhvien, diem.Mamon, diem.Diemchuyencan, diem.Diemgiuaky, diem.Diemcuoiky, diem.Diemtong);
                throw;
            }
        }

        public DataTable SuaThongTinDiemTheoMaSinhVienVaMaMon(DiemDTO diem)
        {
            try
            {
                using (SqlConnection conn = CosodulieuDAL.KetNoiCoSoDuLieu())
                {
                    SqlCommand cmd = new SqlCommand("UPDATE DIEM SET DIEMCHUYENCAN = @DIEMCHUYENCAN, DIEMGIUAKY = @DIEMGIUAKY, DIEMCUOIKY = @DIEMCUOIKY, DIEMTONG = @DIEMTONG WHERE MASV = @MASV AND MAMON = @MAMON", conn);
                    cmd.Parameters.AddWithValue("@MASV", diem.Masinhvien);
                    cmd.Parameters.AddWithValue("@MAMON", diem.Mamon);
                    cmd.Parameters.AddWithValue("@DIEMCHUYENCAN", diem.Diemchuyencan);
                    cmd.Parameters.AddWithValue("@DIEMGIUAKY", diem.Diemgiuaky);
                    cmd.Parameters.AddWithValue("@DIEMCUOIKY", diem.Diemcuoiky);
                    cmd.Parameters.AddWithValue("@DIEMTONG", diem.Diemtong);
                    logger.LogInformation("Sửa điểm trong danh sách điểm.\nMã sinh viên: {0},\nMã môn: {1},\nĐiểm chuyên cần: {2},\nĐiểm giữa kỳ: {3},\nĐiểm cuối kỳ: {4},\nĐiểm tổng: {5}", diem.Masinhvien, diem.Mamon, diem.Diemchuyencan, diem.Diemgiuaky, diem.Diemcuoiky, diem.Diemtong);
                    int thucThi = cmd.ExecuteNonQuery();
                    if (thucThi == 0)
                    {
                        logger.LogWarning("Mã sinh viên hoặc mã môn học không tồn tại.\nMã sinh viên: {0},\nMã môn học: {0}",diem.Masinhvien,diem.Mamon);
                        throw new InvalidOperationException();
                    }

                    return diemDAL.LayToanBoDiem();
                }
            }
            catch (SqlException sqlEx)
            {
                logger.LogCritical(sqlEx, "Xảy ra lỗi cơ sở dữ liệu khi sửa điểm.\nMã sinh viên: {0},\nMã môn: {1},\nĐiểm chuyên cần: {2},\nĐiểm giữa kỳ: {3},\nĐiểm cuối kỳ: {4},\nĐiểm tổng: {5}", diem.Masinhvien, diem.Mamon, diem.Diemchuyencan, diem.Diemgiuaky, diem.Diemcuoiky, diem.Diemtong);
                throw;
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Xảy ra lỗi khi sửa điểm.\nMã sinh viên: {0},\nMã môn: {1},\nĐiểm chuyên cần: {2},\nĐiểm giữa kỳ: {3},\nĐiểm cuối kỳ: {4},\nĐiểm tổng: {5}", diem.Masinhvien, diem.Mamon, diem.Diemchuyencan, diem.Diemgiuaky, diem.Diemcuoiky, diem.Diemtong);
                throw;
            }
        }

        public DataTable XoaThongTinDiemTheoMaSinhVienVaMaMon(string maSinhVien, string maMon)
        {
            try
            {
                using (SqlConnection conn = CosodulieuDAL.KetNoiCoSoDuLieu())
                {
                    SqlCommand cmd = new SqlCommand("DELETE FROM DIEM WHERE MASV = @MASV AND MAMON = @MAMON", conn);
                    cmd.Parameters.AddWithValue("@MASV", maSinhVien);
                    cmd.Parameters.AddWithValue("@MAMON", maMon);
                    logger.LogInformation("Xóa điểm khỏi danh sách điểm.\nMã sinh viên: {0},\nMã môn: {1}", maSinhVien, maMon);
                    int thucThi = cmd.ExecuteNonQuery();
                    if (thucThi == 0)
                    {
                        logger.LogWarning("Mã sinh viên hoặc mã môn học không tồn tại.\nMã sinh viên: {0},\nMã môn học: {0}",maSinhVien,maMon);
                        throw new InvalidOperationException();
                    }

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
                    SqlCommand cmd = new SqlCommand("SELECT * FROM DIEM WHERE MASV=@MASV AND MAMON=@MAMON", conn);
                    cmd.Parameters.AddWithValue("@MASV", maSinhVien);
                    cmd.Parameters.AddWithValue("@MAMON", maMon);
                    adapter.SelectCommand = cmd;
                    logger.LogInformation("Lấy danh sách điểm theo điều kiện Mã sinh viên và Mã điểm.\nMã sinh viên: {0},\nMã điểm: {1}", maSinhVien, maMon);
                    adapter.Fill(dt);
                    if (dt.Rows.Count == 0)
                    {
                        logger.LogWarning("Mã sinh viên hoặc mã môn học không tồn tại.\nMã sinh viên: {0},\nMã môn học: {0}",maSinhVien,maMon);
                        throw new InvalidOperationException();
                    }
                    return dt;
                }
            }
            catch (SqlException sqlEx)
            {
                logger.LogCritical(sqlEx, "Xảy ra lỗi cơ sở dữ liệu khi lấy danh sách điểm theo điều khiên Mã sin viên và Mã điểm.\nMã sinh viên: {0},\nMã điểm: {1}", maSinhVien, maMon);
                throw;
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Xảy ra lỗi khi danh sách lấy điểm theo điều kiện Mã sinh viên và Mã điểm.\nMã sinh viên: {0},\nMã điểm: {1}", maSinhVien, maMon);
                throw;
            }
        }
    }
}
