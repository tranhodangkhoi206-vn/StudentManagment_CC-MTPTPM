
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
        public DataTable ThemmonhocMoi(MonhocDTO monHocMoi)
        {
            try
            {
                if (
                    string.IsNullOrEmpty(monHocMoi.Mamon) ||
                    string.IsNullOrEmpty(monHocMoi.Manganh) ||
                    string.IsNullOrEmpty(monHocMoi.Tenmon) ||
                    string.IsNullOrEmpty(monHocMoi.Tinhtrang) ||
                    string.IsNullOrEmpty(monHocMoi.Giangvien)
                )
                {
                    logger.LogWarning("Người dùng chưa nhập đầy đủ thông tin trước khi thêm.");
                    throw new ArgumentException("Bạn phải nhập đầy đủ thông tin trước khi thêm");
                }
                return quanlymonhocDAL.ThemMonHocMoi(monHocMoi);
            }
            catch (SqlException)
            {
                throw;
            }
            catch (InvalidOperationException)
            {
                throw new InvalidOperationException("Thêm không thành công.");
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Xảy ra lỗi không xác định.");
                throw;
            }
        }
        public DataTable SuaMonHocTheoMaMonHoc(MonhocDTO monHocMoi)
        {
            try
            {
                if (string.IsNullOrEmpty(monHocMoi.Mamon))
                {
                    logger.LogWarning("Người dùng chưa nhập mã môn khi sửa môn học.");
                    throw new ArgumentException("Bạn phải nhập mã môn học trước khi sửa");
                }
                return quanlymonhocDAL.SuaThongTinMonHocTheoMaMon(monHocMoi);
            }
            catch (SqlException)
            {
                throw;
            }
            catch (InvalidOperationException)
            {
                throw new InvalidOperationException("Sửa không thành công.");
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Xảy ra lỗi không xác định.");
                throw;
            }
        }
        public DataTable XoaMonHocTheoMaMonHoc(string maMonHoc)
        {
            try
            {
                if (string.IsNullOrEmpty(maMonHoc))
                {
                    logger.LogWarning("Người dùng chua nhập mã môn học khi xóa môn học.");
                    throw new ArgumentException("Bạn phải nhập mã môn học trước khi xóa");
                }
                return quanlymonhocDAL.XoaThongTinMonHocTheoMaMon(maMonHoc);
            }
            catch (SqlException)
            {
                throw;
            }
            catch (InvalidOperationException)
            {
                throw new InvalidOperationException("Xóa không thành công.");
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Xảy ra lỗi không xác định.");
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
                return quanlymonhocDAL.LayDanhSachMonHocTheoDieuKienMaMon(maMon);
            }
            catch (SqlException)
            {
                throw;
            }
            catch (KeyNotFoundException)
            {
                throw new KeyNotFoundException("Không tìm thấy môn học.");
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Xảy ra lỗi không xác định.");
                throw;
            }
        }
    }
}
