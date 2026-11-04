using Microsoft.Data.SqlClient;
using System.Data;
using Microsoft.Extensions.Logging;
using StudentManagment.DAL;
using StudentManagment.DAL.Util;
using StudentManagment.DTO;

namespace StudentManagment.BLL
{
    public class QuanlylopBLL
    {
        private readonly ILogger logger;
        private readonly QuanlylopDAL quanlylopDAL;
        private readonly LopDAL lopDAL;
        private readonly NganhhocDAL nganhhocDAL;

        public QuanlylopBLL(ILoggerFactory loggerFactory)
        {
            logger = loggerFactory.CreateLogger<QuanlylopBLL>();
            quanlylopDAL = new QuanlylopDAL(loggerFactory);
            lopDAL = new LopDAL(loggerFactory);
            nganhhocDAL = new NganhhocDAL(loggerFactory);
        }

        public DataTable HienThiDanhSachLopHoc()
        {
            return lopDAL.LayToanBoLopHoc();
        }
	    public  DataTable HienThiDanhSachNganhLenCombobox()
        {
            return nganhhocDAL.LayToanBoNganhHocChoComboBox();
        }
        public DataTable TimKiemLopHoc(string maLop)
        {
            if (string.IsNullOrWhiteSpace(maLop))
            {
                logger.LogWarning("Người dùng chưa nhập mã lớp học khi tìm kiếm lớp.");
                throw new ArgumentException("Bạn phải nhập mã lớptrước khi tìm kiếm");
            }
            DataTable dt = quanlylopDAL.TimKiemLopHocTheoMa(maLop);
            if (dt == null)
            {
                throw new KeyNotFoundException("Không tìm thấy lớp học.");
            }
            return dt;
        }

        public DataTable ThemLopHocMoi(LopDTO lop)
        {
            try
            {
                if (
                    string.IsNullOrEmpty(lop.Malop) ||
                    string.IsNullOrEmpty(lop.Manganh) ||
                    string.IsNullOrEmpty(lop.Tenlop) ||
                    string.IsNullOrEmpty(lop.Giangvienphutrach)
                )
                {
                    logger.LogWarning("Người dùng chưa nhập đầy đủ thông tin khi thêm sinh viên.");
                    throw new ArgumentException("Bạn phải nhập đầy đủ thông tin trước khi thêm");
                }
                DataTable dt = quanlylopDAL.ThemDuLieuLopMoi(lop);
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
                        tinNhanThanThien = "Lớp đã tồn tại."; break;
                }
                throw new DataException(tinNhanThanThien);
            }
        }

        public DataTable SuaThongTinLop(LopDTO lop)
        {
            try
            {
                if (
                    string.IsNullOrEmpty(lop.Malop)
                )
                {
                    logger.LogWarning("Người dùng chưa nhập mã lớpkhi sửa thông tin sinh viên.");
                    throw new ArgumentException("Bạn phải nhập mã lớptrước khi sửa");
                }
                DataTable dt = quanlylopDAL.SuaThongTinLopTheoMaLop(lop);
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

        public DataTable XoaThongTinLop(string maLop)
        {
            try
            {
                if (string.IsNullOrEmpty(maLop))
                {
                    logger.LogWarning("Người dùng chưa nhập mã lớpkhi xóa lớpra khỏi danh sách.");
                    throw new ArgumentException("Bạn phải nhập mã lớptrước khi xóa");
                }
                DataTable dt = quanlylopDAL.XoaThongTinLopTheoMaLop(maLop);
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
    }
}