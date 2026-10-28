using System.Data;
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
            try
            {
                return nganhhocDAL.LayToanBoNganhHoc();
            } catch (Exception ex)
            {
                logger.LogError(ex, "Lỗi xảy ra khi lấy danh sách ngành học.");
                throw;
            }
        }
        public DataTable ThemNganhMoi(NganhhocDTO nganhMoi)
        {
            try
            {
                return quanlynganhhocDAL.ThemNganhMoi(nganhMoi);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Xảy ra lỗi khi thêm ngành có mã ngành {0} vào danh sách ngành. Với dữ liệu:\nTên ngành: {1},\nKhoa quản lý: {2}", nganhMoi.Manganh, nganhMoi.Tennganh, nganhMoi.Khoaquanly);
                throw;
            }
        }

        public DataTable SuaThongTinNganhTheoMaNganh(NganhhocDTO nganhSua)
        {
            try
            {
                return quanlynganhhocDAL.SuaThongTinNganhTheoMaNganh(nganhSua);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Xảy ra lỗi khi sửa ngành có mã ngành {0} trong danh sách ngành. Với dữ liệu:\nTên ngành: {1},\nKhoa quản lý: {2}", nganhSua.Manganh, nganhSua.Tennganh, nganhSua.Khoaquanly);
                throw;
            }
        }

        public DataTable XoaThongTinNganhTheoMaNganh(string maNganh)
        {
            try
            {
                return quanlynganhhocDAL.XoaThongTinNganhTheoMaNganh(maNganh);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Lỗi xảy ra khi xóa ngành với mã ngành {0}", maNganh);
                throw;
            }
        }
    }
}
