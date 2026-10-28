using System.Data;
using Microsoft.Extensions.Logging;
using StudentManagment.DAL;
using StudentManagment.DAL.Util;
using StudentManagment.DTO;

namespace StudentManagment.BLL
{
    public class QuanlysinhvienBLL
    {
        private readonly ILogger<QuanlysinhvienBLL> logger;
        private SinhvienDAL sinhvienDAL;
        private QuanlysinhvienDAL quanlysinhvienDAL; 
        private NganhhocDAL nganhhocDAL;
        private LopDAL lopDAL;
        public QuanlysinhvienBLL(ILoggerFactory loggerFactory)
        {
            logger = loggerFactory.CreateLogger<QuanlysinhvienBLL>();
            sinhvienDAL = new SinhvienDAL(loggerFactory);
            quanlysinhvienDAL = new QuanlysinhvienDAL(loggerFactory); 
            nganhhocDAL = new NganhhocDAL(loggerFactory);
            lopDAL = new LopDAL(loggerFactory);
        }
        public DataTable HienThiDanhSachSinhVien()
        {
            try
            {
                return sinhvienDAL.LayToanBoSinhVien();
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Lỗi xảy ra khi hiển thị danh sách sinh viên.");
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
	    public DataTable HienThiDanhSachLopChoComboBox()
        {
            try
            {
                return lopDAL.LayToanBoLopChoComboBox();
            } catch (Exception ex)
            {
                logger.LogError(ex, "Xảy ra lỗi khi hiển thị danh sách lớp cho combo box.");
                throw;
            }
        }
        public DataTable ThemsinhvienMoi(SinhvienDTO sinhvienMoi)
        {
            try
            {
                return quanlysinhvienDAL.ThemsinhVienMoi(sinhvienMoi);
            } catch (Exception ex)
            {
                logger.LogError(ex, "Xảy ra lỗi khi thêm sinh viên có mã sinh viên {0} vào danh sách sinh viên. Với dữ liệu:\nTên sinh viên: {1},\nMã lớp: {2},\nNgày sinh: {3},\nGiới tính: {4},\nMã ngành: {5},\nTình trạng: {6}", sinhvienMoi.MaSinhVien, sinhvienMoi.HoVaTen, sinhvienMoi.MaLop, sinhvienMoi.NgaySinh, sinhvienMoi.GioiTinh, sinhvienMoi.MaNganh, sinhvienMoi.TinhTrang);
                throw;
            }
        }
        public DataTable SuaSinhVienTheoMaSinhVien(SinhvienDTO sinhvienMoi)
        {
            try
            {
                return quanlysinhvienDAL.SuaThongTinSinhVienTheoMaSinhVien(sinhvienMoi);
            } catch (Exception ex)
            {
                logger.LogError(ex, "Xảy ra lỗi khi sửa sinh viên có mã sinh viên {0} vào danh sách sinh viên. Với dữ liệu:\nTên sinh viên: {1},\nMã lớp: {2},\nNgày sinh: {3},\nGiới tính: {4},\nMã ngành: {5},\nTình trạng: {6}", sinhvienMoi.MaSinhVien, sinhvienMoi.HoVaTen, sinhvienMoi.MaLop, sinhvienMoi.NgaySinh, sinhvienMoi.GioiTinh, sinhvienMoi.MaNganh, sinhvienMoi.TinhTrang);
                throw;
            }
        }
	    public DataTable XoaSinhVienTheoMaSinhVien(string maSinhVien)
        {
            try
            {
                return quanlysinhvienDAL.XoaThongTinSinhVienTheoMaSinhVien(maSinhVien);
            } catch (Exception ex)
            {
                logger.LogError(ex, "Lỗi xảy ra khi xóa sinh viên với mã sinh viên {masinhvien}", maSinhVien);
                throw;
            }
        }
    }
}
