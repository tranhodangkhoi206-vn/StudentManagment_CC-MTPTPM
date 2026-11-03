using System.Data;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Logging;
using StudentManagment.DAL;
using StudentManagment.DAL.Util;
using StudentManagment.DTO;
namespace StudentManagment.BLL
{
    public class QuanlynganhhocBLL
    {
        private QuanlynganhhocDAL quanlynganhhocDAL;
        private NganhhocDAL nganhhocDAL;
        private readonly ILogger<QuanlynganhhocBLL> logger;
        public QuanlynganhhocBLL(ILoggerFactory loggerFactory)
        {
            logger = loggerFactory.CreateLogger<QuanlynganhhocBLL>();
            quanlynganhhocDAL = new QuanlynganhhocDAL(loggerFactory);
            nganhhocDAL = new NganhhocDAL(loggerFactory);
        }
        public DataTable HienThiToanBoNganhHoc()
        {
            return nganhhocDAL.LayToanBoNganhHoc();
        }
        public DataTable ThemNganhMoi(NganhhocDTO nganhMoi)
        {
            try
            {
                if (
                    string.IsNullOrEmpty(nganhMoi.Manganh) ||
                    string.IsNullOrEmpty(nganhMoi.Tennganh) ||
                    string.IsNullOrEmpty(nganhMoi.Khoaquanly)
                )
                {
                    logger.LogWarning("Người dùng chưa nhập đầy đủ thông tin ngành học khi thêm.");
                    throw new ArgumentException("Bạn phải nhập đầy đủ thông tin trước khi thêm");
                }
                return quanlynganhhocDAL.ThemNganhMoi(nganhMoi);
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

        public DataTable SuaThongTinNganhTheoMaNganh(NganhhocDTO nganhSua)
        {
            try
            {
                if (string.IsNullOrEmpty(nganhSua.Manganh))
                {
                    logger.LogWarning("Người dùng chua nhập mã ngành khi sửa thông tin ngành học.");
                    throw new ArgumentException("Bạn phải nhập mã ngành trước khi sửa");
                }
                return quanlynganhhocDAL.SuaThongTinNganhTheoMaNganh(nganhSua);
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

        public DataTable XoaThongTinNganhTheoMaNganh(string maNganh)
        {
            try
            {
                if (string.IsNullOrEmpty(maNganh))
                {
                    logger.LogWarning("Người dùng chưa nhập mã ngành khi xóa ngành học.");
                    throw new ArgumentException("Bạn phải nhập mã ngành trước khi xóa");
                }
                return quanlynganhhocDAL.XoaThongTinNganhTheoMaNganh(maNganh);
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
        public DataTable TimKiemNganhHoc(string maNganh)
        {
            try
            {
                if (string.IsNullOrEmpty(maNganh))
                {
                    logger.LogWarning("Người dùng hưa nhập mã ngành khi tìm kiếm ngành học.");
                    throw new ArgumentException("Bạn phải nhập mã ngành trước khi tìm kiếm");
                }
                return quanlynganhhocDAL.LayDanhSachNganhHocTheoDieuKienMaNganh(maNganh);
            }
            catch (SqlException)
            {
                throw;
            }
            catch (KeyNotFoundException)
            {
                throw new KeyNotFoundException("Không tìm thấy ngành học.");
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Xảy ra lỗi không xác định.");
                throw;
            }
        }
    }
}
