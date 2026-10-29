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
                throw new ArgumentException();
            }
            return quanlysinhvienDAL.ThemsinhVienMoi(sinhvienSua);
        }
        public DataTable SuaSinhVienTheoMaSinhVien(SinhvienDTO sinhvienSua)
        {
            if (
                string.IsNullOrEmpty(sinhvienSua.MaSinhVien)
            )
            {
                logger.LogWarning("Người dùng chưa nhập mã sinh viên khi sửa thông tin sinh viên.");
                throw new ArgumentException();
            }
            return quanlysinhvienDAL.SuaThongTinSinhVienTheoMaSinhVien(sinhvienSua);
        }
        public DataTable XoaSinhVienTheoMaSinhVien(string maSinhVien)
        {
            if (string.IsNullOrEmpty(maSinhVien))
            {
                logger.LogWarning("Người dùng chưa nhập mã sinh viên khi xóa sinh viên ra khỏi danh sách.");
                throw new ArgumentException();
            }
            return quanlysinhvienDAL.XoaThongTinSinhVienTheoMaSinhVien(maSinhVien);
        }
    }
}
