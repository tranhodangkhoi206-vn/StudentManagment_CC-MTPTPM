
using System.Data;
using Microsoft.Extensions.Logging;
using StudentManagment.DAL;
using StudentManagment.DTO;

namespace StudentManagment.BLL
{
    public class QuanlymonhocBLL
    {
        private readonly ILogger<QuanlymonhocBLL> logger;
        private MonhocDAL monhocDAL;
        private NganhhocDAL nganhhocDAL;
        public QuanlymonhocBLL(ILoggerFactory loggerFactory)
        {
            logger = loggerFactory.CreateLogger<QuanlymonhocBLL>();
            monhocDAL = new MonhocDAL(loggerFactory);
            nganhhocDAL = new NganhhocDAL(loggerFactory);
        }
	    public DataTable HienThiDanhSachMonHoc()
        {
		    try
            {
                return monhocDAL.LayToanBoMonHoc();
            } catch(Exception ex)
            {
                logger.LogError(ex,"Xảy ra lỗi khi hiển thị danh sách môn học.");
                throw;
            }
        }
        public DataTable HienThiDanhSachNganhHocChoComboBox()
        {
            try
            {
                return nganhhocDAL.LayToanBoNganhHocChoComboBox();
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Xảy ra lỗi khi hiển thị danh sách ngành học cho combo box.");
                throw;
            }
        }
        public DataTable ThemmonhocMoi(MonhocDTO monHocMoi)
        {
            try
            {
                return monhocDAL.ThemMonHocMoi(monHocMoi);
            } catch (Exception ex)
            {
                logger.LogError(ex, "Xảy ra lỗi khi thêm môn học có mã môn học {0} vào danh sách môn học. Với dữ liệu:\nTên môn học: {1}, Mã ngành: {2}, Số tiết lý thuyết: {3}, Số tiết thực hành: {4}, Giảng viên: {5}, Tình trạng: {6}", monHocMoi.Mamon, monHocMoi.Tenmon, monHocMoi.Manganh, monHocMoi.Sotietlythuyet, monHocMoi.Sotietthuchanh, monHocMoi.Giangvien, monHocMoi.Tinhtrang);
                throw;
            }
        }
        public DataTable SuaMonHocTheoMaMonHoc(MonhocDTO monHocMoi)
        {
            try
            {
                return monhocDAL.SuaThongTinMonHocTheoMaMon(monHocMoi);
            } catch (Exception ex)
            {
                logger.LogError(ex, "Xảy ra lỗi khi sửa môn học có mã môn học {0} vào danh sách môn học. Với dữ liệu:\nTên môn học: {1}, Mã ngành: {2}, Số tiết lý thuyết: {3}, Số tiết thực hành: {4}, Giảng viên: {5}, Tình trạng: {6}", monHocMoi.Mamon, monHocMoi.Tenmon, monHocMoi.Manganh, monHocMoi.Sotietlythuyet, monHocMoi.Sotietthuchanh, monHocMoi.Giangvien, monHocMoi.Tinhtrang);
                throw;
            }
        }
	    public DataTable XoaMonHocTheoMaMonHoc(string maMonHoc)
        {
            try
            {
                return monhocDAL.XoaThongTinMonHocTheoMaMon(maMonHoc);
            } catch (Exception ex)
            {
                logger.LogError(ex, "Lỗi xảy ra khi xóa môn học với mã môn học {0}",maMonHoc);
                throw;
            }
        }
    }
}
