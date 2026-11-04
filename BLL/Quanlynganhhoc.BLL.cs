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
                DataTable dt = quanlynganhhocDAL.ThemNganhMoi(nganhMoi);
                if (dt == null)
                {
                    throw new InvalidOperationException("Thêm không thành công.");
                }
                return dt;
            }
            catch (SqlException sqlEx)
            {
                string tinNhanThanThien = "Xảy ra lỗi với cơ sở dữ liệu.";
		        switch (sqlEx.Number)
                {
                    case 2627:
                        tinNhanThanThien = "Ngành học đã tồn tại."; break;
                }
                throw new DataException(tinNhanThanThien);
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
                DataTable dt = quanlynganhhocDAL.SuaThongTinNganhTheoMaNganh(nganhSua);
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

        public DataTable XoaThongTinNganhTheoMaNganh(string maNganh)
        {
            try
            {
                if (string.IsNullOrEmpty(maNganh))
                {
                    logger.LogWarning("Người dùng chưa nhập mã ngành khi xóa ngành học.");
                    throw new ArgumentException("Bạn phải nhập mã ngành trước khi xóa");
                }
                DataTable dt = quanlynganhhocDAL.XoaThongTinNganhTheoMaNganh(maNganh);
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
        public DataTable TimKiemNganhHoc(string maNganh)
        {
            try
            {
                if (string.IsNullOrEmpty(maNganh))
                {
                    logger.LogWarning("Người dùng hưa nhập mã ngành khi tìm kiếm ngành học.");
                    throw new ArgumentException("Bạn phải nhập mã ngành trước khi tìm kiếm");
                }
                DataTable dt = quanlynganhhocDAL.LayDanhSachNganhHocTheoDieuKienMaNganh(maNganh);
                if (dt == null)
                {
                    throw new KeyNotFoundException("Không tìm thấy ngành học.");
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
