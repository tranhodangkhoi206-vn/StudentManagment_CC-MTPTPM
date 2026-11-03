using System.Data;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Logging;
using Serilog.Sinks.File;
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
            return sinhvienDAL.LayToanBoSinhVien();
        }
        public DataTable HienThiDanhSachNganhHocChoComboBox()
        {
            return nganhhocDAL.LayToanBoNganhHocChoComboBox();
        }
        public DataTable HienThiDanhSachLopChoComboBox()
        {
            return lopDAL.LayToanBoLopChoComboBox();
        }
        public DataTable ThemsinhvienMoi(SinhvienDTO sinhvienSua)
        {
            try
            {
                if (
                    string.IsNullOrEmpty(sinhvienSua.HoVaTen) ||
                    string.IsNullOrEmpty(sinhvienSua.MaSinhVien) ||
                    string.IsNullOrEmpty(sinhvienSua.MaLop) ||
                    string.IsNullOrEmpty(sinhvienSua.MaNganh) ||
                    string.IsNullOrEmpty(sinhvienSua.GioiTinh) ||
                    string.IsNullOrEmpty(sinhvienSua.TinhTrang)
                )
                {
                    logger.LogWarning("Người dùng chưa nhập đầy đủ thông tin khi thêm sinh viên.");
                    throw new ArgumentException("Bạn phải nhập đầy đủ thông tin trước khi thêm");
                }
                DataTable dt = quanlysinhvienDAL.ThemsinhVienMoi(sinhvienSua);
                if (dt == null)
                {
                    throw new InvalidOperationException("Thêm không thành công.");
                }
                return quanlysinhvienDAL.ThemsinhVienMoi(sinhvienSua);
            }
            catch (SqlException)
            {
                throw;
            }
        }
        public DataTable SuaSinhVienTheoMaSinhVien(SinhvienDTO sinhvienSua)
        {
            try
            {
                if (
                    string.IsNullOrEmpty(sinhvienSua.MaSinhVien)
                )
                {
                    logger.LogWarning("Người dùng chưa nhập mã sinh viên khi sửa thông tin sinh viên.");
                    throw new ArgumentException("Bạn phải nhập mã sinh viên trước khi sửa");
                }
                DataTable dt = quanlysinhvienDAL.SuaThongTinSinhVienTheoMaSinhVien(sinhvienSua);
                if (dt == null)
                {
                    throw new InvalidOperationException("Sửa không thành công.");
                }
                return dt;
            }
            catch (SqlException)
            {
                throw;
            }
        }
        public DataTable XoaSinhVienTheoMaSinhVien(string maSinhVien)
        {
            try
            {
                if (string.IsNullOrEmpty(maSinhVien))
                {
                    logger.LogWarning("Người dùng chưa nhập mã sinh viên khi xóa sinh viên ra khỏi danh sách.");
                    throw new ArgumentException("Bạn phải nhập mã sinh viên trước khi xóa");
                }
                DataTable dt = quanlysinhvienDAL.XoaThongTinSinhVienTheoMaSinhVien(maSinhVien);
                if (dt == null)
                {
                    throw new InvalidOperationException("Xóa không thành công.");
                }
                return dt;
            }
            catch (SqlException)
            {
                throw;
            }
        }
        public DataTable TimKiemSinhVien(string maSinhVien)
        {
            try
            {
                if (string.IsNullOrEmpty(maSinhVien))
                {
                    logger.LogWarning("Người dùng chưa nhập mã sinh viên khi tìm kiếm sinh viên ra khỏi danh sách.");
                    throw new ArgumentException("Bạn phải nhập mã sinh viên trước khi tìm kiếm");
                }
                DataTable dt = quanlysinhvienDAL.LaySinhVienTheoDieuKienMaSinhVien(maSinhVien);
                if (dt == null)
                {
                    throw new KeyNotFoundException("Không tìm thấy sinh viên.");
                }
                return dt;
            }
            catch (SqlException)
            {
                throw;
            }
        }
    }
}
