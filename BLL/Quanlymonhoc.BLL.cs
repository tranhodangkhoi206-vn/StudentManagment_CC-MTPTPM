
using System.Data;
using Microsoft.Extensions.Logging;
using StudentManagment.DAL.Util;
using StudentManagment.DAL;
using StudentManagment.DTO;
using Microsoft.Data.SqlClient;

namespace StudentManagment.BLL
{
    public class QuanlymonhocBLL
    {
        private QuanlymonhocDAL quanlymonhocDAL;
        private MonhocDAL monhocDAL;
        private NganhhocDAL nganhhocDAL;
        private readonly ILogger<QuanlymonhocBLL> logger;
        public QuanlymonhocBLL(ILoggerFactory loggerFactory)
        {
            logger = loggerFactory.CreateLogger<QuanlymonhocBLL>();
            quanlymonhocDAL = new QuanlymonhocDAL(loggerFactory);
            monhocDAL = new MonhocDAL(loggerFactory);
            nganhhocDAL = new NganhhocDAL(loggerFactory);
        }
        public DataTable HienThiDanhSachMonHoc()
        {
            return monhocDAL.LayToanBoMonHoc();
        }
        public DataTable HienThiDanhSachNganhHocChoComboBox()
        {
            return nganhhocDAL.LayToanBoNganhHocChoComboBox();
        }
        public DataTable ThemmonhocMoi(MonhocDTO monHoc)
        {
            try
            {
                if (
                    string.IsNullOrEmpty(monHoc.Mamon) ||
                    string.IsNullOrEmpty(monHoc.Manganh) ||
                    string.IsNullOrEmpty(monHoc.Tenmon) ||
                    string.IsNullOrEmpty(monHoc.Tinhtrang) ||
                    string.IsNullOrEmpty(monHoc.Giangvien)
                )
                {
                    logger.LogWarning("Người dùng chưa nhập đầy đủ thông tin trước khi thêm.");
                    throw new ArgumentException("Bạn phải nhập đầy đủ thông tin trước khi thêm");
                }
                DataTable dt = quanlymonhocDAL.ThemMonHocMoi(monHoc);
                if (dt == null)
                {
                    throw new InvalidOperationException("Thêm không thành công.");
                }
                return dt;
            }
            catch (SqlException)
            {
                throw;
            }
        }
        public DataTable SuaMonHocTheoMaMonHoc(MonhocDTO monHoc)
        {
            try
            {
                if (string.IsNullOrEmpty(monHoc.Mamon))
                {
                    logger.LogWarning("Người dùng chưa nhập mã môn khi sửa môn học.");
                    throw new ArgumentException("Bạn phải nhập mã môn học trước khi sửa");
                }
                DataTable dt = quanlymonhocDAL.SuaThongTinMonHocTheoMaMon(monHoc);
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
        public DataTable XoaMonHocTheoMaMonHoc(string maMon)
        {
            try
            {
                if (string.IsNullOrEmpty(maMon))
                {
                    logger.LogWarning("Người dùng chua nhập mã môn học khi xóa môn học.");
                    throw new ArgumentException("Bạn phải nhập mã môn học trước khi xóa");
                }
                DataTable dt = quanlymonhocDAL.XoaThongTinMonHocTheoMaMon(maMon);
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
        public DataTable TimKiemMonHocTheoMaMon(string maMon)
        {
            try
            {
                if (string.IsNullOrEmpty(maMon))
                {
                    logger.LogWarning("Người dùng chưa nhập mã môn khi tìm kiếm môn học.");
                    throw new ArgumentException("Bạn phải nhập mã môn học trước khi tìm kiếm");
                }
                DataTable dt = quanlymonhocDAL.LayDanhSachMonHocTheoDieuKienMaMon(maMon);
                if (dt == null)
                {
                    throw new KeyNotFoundException("Không tìm thấy môn học.");
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
