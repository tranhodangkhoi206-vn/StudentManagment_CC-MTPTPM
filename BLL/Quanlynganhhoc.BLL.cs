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
            return nganhhocDAL.LayToanBoNganhHoc();
        }
        public DataTable ThemNganhMoi(NganhhocDTO nganhMoi)
        {
            if (
                string.IsNullOrEmpty(nganhMoi.Manganh) ||
                string.IsNullOrEmpty(nganhMoi.Tennganh) ||
                string.IsNullOrEmpty(nganhMoi.Khoaquanly)
            )
            {
                logger.LogWarning("Người dùng chưa nhập đầy đủ thông tin ngành học khi thêm.");
                throw new ArgumentException();
            }
            return quanlynganhhocDAL.ThemNganhMoi(nganhMoi);
        }

        public DataTable SuaThongTinNganhTheoMaNganh(NganhhocDTO nganhSua)
        {
            if (string.IsNullOrEmpty(nganhSua.Manganh))
            {
                logger.LogWarning("Người dùng chua nhập mã ngành khi sửa thông tin ngành học.");
                throw new ArgumentException();
            }
            return quanlynganhhocDAL.SuaThongTinNganhTheoMaNganh(nganhSua);
        }

        public DataTable XoaThongTinNganhTheoMaNganh(string maNganh)
        {
            if (string.IsNullOrEmpty(maNganh))
            {
                logger.LogWarning("Người dùng chưa nhập mã ngành khi xóa ngành học.");
                throw new ArgumentException();
            }
            return quanlynganhhocDAL.XoaThongTinNganhTheoMaNganh(maNganh);
        }
    }
}
