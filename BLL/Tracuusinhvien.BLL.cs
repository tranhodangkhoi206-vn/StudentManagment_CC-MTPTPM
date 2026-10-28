using System.Data;
using Microsoft.Extensions.Logging;
using StudentManagment.DAL;
using StudentManagment.DAL.Util;

namespace StudentManagment.BLL
{
    public class TracuusinhvienBLL
    {
        private SinhvienDAL sinhvienDAL;
        private TracuusinhvienDAL tracuusinhvienDAL;
        private LopDAL lopDAL;
        private NganhhocDAL nganhhocDAL;
        private readonly ILogger<TracuusinhvienBLL> logger;
        public TracuusinhvienBLL(ILoggerFactory loggerFactory)
        {
            logger = loggerFactory.CreateLogger<TracuusinhvienBLL>();
            sinhvienDAL = new SinhvienDAL(loggerFactory);
            tracuusinhvienDAL = new TracuusinhvienDAL(loggerFactory);
            lopDAL = new LopDAL(loggerFactory);
            nganhhocDAL = new NganhhocDAL(loggerFactory);
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
                return tracuusinhvienDAL.LaySinhVienTheoDieuKienTen(hovaten);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Xảy ra lỗi khi hiển thị danh sách sinh viên theo điều khiện tên.");
                throw;
            }
        }
        public DataTable HienThiDanhSachSinhVienTheoDieuKienLop(string malop)
        {
            try
            {
                return tracuusinhvienDAL.LaySinhVienTheoDieuKienLop(malop);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Xảy ra lỗi khi hiển thị danh sách sinh viên theo điều khiện lớp.");
                throw;
            }
        }
        public DataTable HienThiDanhSachSinhVienTheoDieuKienNganhHoc(string manganh)
        {
            try
            {
                return tracuusinhvienDAL.LaySinhVienTheoDieuKienNganhHoc(manganh);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Xảy ra lỗi khi hiển thị danh sách sinh viên theo điều khiện ngành học.");
                throw;
            }
        }


        public DataTable HienThiDanhSachLopChoComboBox()
        {
            try
            {
                return lopDAL.LayToanBoLopChoComboBox();
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Xảy ra lỗi khi hiển thị danh sách môn học cho combo box.");
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
    }
}
