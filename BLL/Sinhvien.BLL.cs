using System.Data;
using Microsoft.Extensions.Logging;
using StudentManagment.DAL;

namespace StudentManagment.BLL
{
    public class SinhvienBLL
    {
        private SinhvienDAL sinhvienDAL;
        private readonly ILogger<SinhvienBLL> logger;
        public SinhvienBLL(ILoggerFactory loggerFactory)
        {
            logger = loggerFactory.CreateLogger<SinhvienBLL>();
            sinhvienDAL = new SinhvienDAL(loggerFactory);
        }
        public DataTable HienThiDanhSachSinhVien()
        {
            try
            {
                return sinhvienDAL.LayToanBoSinhVien();
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Xảy ra lỗi khi hiển thị danh sách sinh viên.");
                throw;
            }
        }
        public DataTable HienThiDanhSachSinhVienTheoDieuKienTen(string hovaten)
        {
            try
            {
                return sinhvienDAL.LaySinhVienTheoDieuKienTen(hovaten);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Xảy ra lỗi khi hiển thị danh sách sinh viên theo điều khiện tên.");
                throw;
            }
        }
    }
}
