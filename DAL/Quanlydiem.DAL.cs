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

                    logger.LogInformation("Đang thêm điểm mới vào danh sách điểm. Với dữ liệu:\nMã sinh viên: {0},\nMã môn: {1},\nĐiểm chuyên cần: {2},\nĐiểm giữa kỳ: {3},\nĐiểm cuối kỳ: {4},\nĐiểm tổng: {5}", diemMoi.Masinhvien, diemMoi.Mamon, diemMoi.Diemchuyencan, diemMoi.Diemgiuaky, diemMoi.Diemcuoiky, diemMoi.Diemtong);

                    return diemDAL.LayToanBoDiem();
                }
            }
            catch (SqlException sqlEx)
            {
                logger.LogCritical(sqlEx, "Lỗi kết nối tới cơ sở dữ liệu khi thêm điểm mới. Với thông tin:\nMã sinh viên: {0},\nMã môn: {1},\nĐiểm chuyên cần: {2},\nĐiểm giữa kỳ: {3},\nĐiểm cuối kỳ: {4},\nĐiểm tổng: {5}", diemMoi.Masinhvien, diemMoi.Mamon, diemMoi.Diemchuyencan, diemMoi.Diemgiuaky, diemMoi.Diemcuoiky, diemMoi.Diemtong);
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

                    logger.LogInformation("Đang sửa điểm của sinh viên có mã sinh viên {0} môn {1} trong danh sách điểm. Với dữ liệu:\nĐiểm chuyên cần: {2},\nĐiểm giữa kỳ: {3},\nĐiểm cuối kỳ: {4},\nĐiểm tổng: {5}", diemSua.Masinhvien, diemSua.Mamon, diemSua.Diemchuyencan, diemSua.Diemgiuaky, diemSua.Diemcuoiky, diemSua.Diemtong);

                    return diemDAL.LayToanBoDiem();
                }
            }
            catch (SqlException sqlEx)
            {
                logger.LogCritical(sqlEx, "Lỗi kết nối tới cơ sở dữ liệu khi sửa điểm của sinh viên có mã sinh viên {0} môn {1} trong danh sách điểm. Với dữ liệu:\nĐiểm chuyên cần: {2},\nĐiểm giữa kỳ: {3},\nĐiểm cuối kỳ: {4},\nĐiểm tổng: {5}", diemSua.Masinhvien, diemSua.Mamon, diemSua.Diemchuyencan, diemSua.Diemgiuaky, diemSua.Diemcuoiky, diemSua.Diemtong);
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

                    logger.LogInformation("Đang xóa điểm của sinh viên có mã sinh viên {0} môn {1} khỏi danh sách điểm.", maSinhVien, maMon);

                    return diemDAL.LayToanBoDiem();
                }
            }
            catch (SqlException sqlEx)
            {
                logger.LogCritical(sqlEx, "Lỗi kết nối tới cơ sở dữ liệu khi xóa điểm của sinh viên có mã sinh viên {0} môn {1} khỏi danh sách điểm", maSinhVien, maMon);
                throw;
            }
        }
    }
}
