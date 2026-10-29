
using System.Data;
using Microsoft.Extensions.Logging;
using StudentManagment.DAL.Util;
using StudentManagment.DTO;

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
            if (
                string.IsNullOrEmpty(monHocMoi.Mamon) ||
                string.IsNullOrEmpty(monHocMoi.Manganh) ||
                string.IsNullOrEmpty(monHocMoi.Tenmon) ||
                string.IsNullOrEmpty(monHocMoi.Tinhtrang) ||
                string.IsNullOrEmpty(monHocMoi.Giangvien)
            )
            {
                logger.LogWarning("Người dùng chưa nhập đầy đủ thông tin trước khi thêm.");
                throw new ArgumentException();
            }
            return quanlymonhocDAL.ThemMonHocMoi(monHocMoi);
        }
        public DataTable SuaMonHocTheoMaMonHoc(MonhocDTO monHocMoi)
        {
            if (string.IsNullOrEmpty(monHocMoi.Mamon))
            {
                logger.LogWarning("Người dùng chưa nhập mã môn khi sửa môn học.");
                throw new ArgumentException();
            }
            return quanlymonhocDAL.SuaThongTinMonHocTheoMaMon(monHocMoi);
        }
        public DataTable XoaMonHocTheoMaMonHoc(string maMonHoc)
        {
            if (string.IsNullOrEmpty(maMonHoc))
            {
                logger.LogWarning("Người dùng chua nhập mã môn học khi xóa môn học.");
                throw new ArgumentException();
            }
            return quanlymonhocDAL.XoaThongTinMonHocTheoMaMon(maMonHoc);
        }
    }
}
