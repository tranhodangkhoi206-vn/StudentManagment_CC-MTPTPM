using System.Data;
using StudentManagment.DTO;
using Microsoft.Extensions.Logging;
using StudentManagment.DAL;
namespace StudentManagment.BLL
{
    public class QuanlydiemBLL
    {
        private DiemDAL diemDAL;
        private readonly ILogger<QuanlydiemBLL> logger;
	    public QuanlydiemBLL(ILoggerFactory loggerFactory)
        {
            logger = loggerFactory.CreateLogger<QuanlydiemBLL>();
            diemDAL = new DiemDAL(loggerFactory);
        }
	    public DataTable HienThiToanBoDiem()
        {
            try
            {
                return diemDAL.LayToanBoDiem();
            } catch (Exception ex)
            {
                logger.LogError(ex, "Có lỗi xảy ra khi lấy danh sách điểm.");
                throw;
            }
        }
        public DataTable ThemDiemMoi(DiemDTO diemMoi)
        {
            try
            {
                return diemDAL.ThemDiemMoi(diemMoi);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Xảy ra lỗi khi thêm điểm của sinh viên có mã sinh viên {0} môn {1} vào danh sách điểm. Với dữ liệu:\nĐiểm chuyên cần: {2},\nĐiểm giữa kỳ: {3},\nĐiểm cuối kỳ: {4},\nĐiểm tổng: {5}", diemMoi.Masinhvien, diemMoi.Mamon, diemMoi.Diemchuyencan, diemMoi.Diemgiuaky, diemMoi.Diemcuoiky, diemMoi.Diemtong);
                throw;
            }
        }

        public DataTable SuaThongTinDiemTheoMaSinhVienVaMaMon(DiemDTO diemSua)
        {
            try
            {
                return diemDAL.SuaThongTinDiemTheoMaSinhVienVaMaMon(diemSua);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Xảy ra lỗi khi sửa điểm của sinh viên có mã sinh viên {0} môn {1} trong danh sách điểm. Với dữ liệu:\nĐiểm chuyên cần: {2},\nĐiểm giữa kỳ: {3},\nĐiểm cuối kỳ: {4},\nĐiểm tổng: {5}", diemSua.Masinhvien, diemSua.Mamon, diemSua.Diemchuyencan, diemSua.Diemgiuaky, diemSua.Diemcuoiky, diemSua.Diemtong);
                throw;
            }
        }

        public DataTable XoaThongTinDiemTheoMaSinhVienVaMaMon(string maSinhVien, string maMon)
        {
            try
            {
                return diemDAL.XoaThongTinDiemTheoMaSinhVienVaMaMon(maSinhVien, maMon);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Lỗi xảy ra khi xóa điểm của sinh viên có mã sinh viên {0} môn {1}", maSinhVien, maMon);
                throw;
            }
        }
    }
}
