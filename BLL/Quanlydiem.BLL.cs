using System.Data;
using Microsoft.Extensions.Logging;
using StudentManagment.DTO;
using StudentManagment.DAL;
using StudentManagment.DAL.Util;
using Microsoft.Data.SqlClient;

namespace StudentManagment.BLL
{
    public class QuanlydiemBLL
    {
        private QuanlydiemDAL quanlydiemDAL;
        private DiemDAL diemDAL;
        private readonly ILogger<QuanlydiemBLL> logger;
        public QuanlydiemBLL(ILoggerFactory loggerFactory)
        {
            logger = loggerFactory.CreateLogger<QuanlydiemBLL>();
            quanlydiemDAL = new QuanlydiemDAL(loggerFactory);
            diemDAL = new DiemDAL(loggerFactory);
        }
        public DataTable HienThiToanBoDiem()
        {
            return diemDAL.LayToanBoDiem();
        }
        public DataTable ThemDiemMoi(DiemDTO diem)
        {
            try
            {
                if (string.IsNullOrEmpty(diem.Mamon) ||
                    string.IsNullOrEmpty(diem.Masinhvien) ||
                diem.Diemchuyencan == -1 ||
                diem.Diemgiuaky == -1 ||
                diem.Diemcuoiky == -1
                    )
                {
                    logger.LogWarning("Người dùng chưa nhập đầy đủ thông tin điểm khi thêm.");
                    throw new ArgumentException("Bạn phải nhập đầy đủ thông tin trước khi thêm");
                }
                diem.Diemtong = (diem.Diemchuyencan + diem.Diemgiuaky + diem.Diemcuoiky) / 3;
                DataTable dt = quanlydiemDAL.ThemDiemMoi(diem);
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
                        tinNhanThanThien = "Điểm đã tồn tại."; break;
                }
                throw new DataException(tinNhanThanThien);
            }
        }

        public DataTable SuaThongTinDiemTheoMaSinhVienVaMaMon(DiemDTO diem)
        {
            try
            {
                if (string.IsNullOrEmpty(diem.Mamon) ||
                    string.IsNullOrEmpty(diem.Masinhvien)
                    )
                {
                    logger.LogWarning("Người dùng chưa nhập mã môn và mã sinh viên khi sửa thông tin điểm.");
                    throw new ArgumentException("Bạn phải nhập mã sinh viên và mã môn trước khi sửa");
                }
                diem.Diemtong = (diem.Diemchuyencan + diem.Diemgiuaky + diem.Diemcuoiky) / 3;
                DataTable dt = quanlydiemDAL.SuaThongTinDiemTheoMaSinhVienVaMaMon(diem);
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

        public DataTable XoaThongTinDiemTheoMaSinhVienVaMaMon(string maSinhVien, string maMon)
        {
            try
            {
                if (string.IsNullOrEmpty(maSinhVien) || string.IsNullOrEmpty(maMon))
                {
                    logger.LogWarning("Người dùng chưa nhập mã môn và mã sinh viên khi xóa thông tin điểm.");
                    throw new ArgumentException("Bạn phải nhập mã sinh viên và mã môn trước khi xóa");
                }
                DataTable dt = quanlydiemDAL.XoaThongTinDiemTheoMaSinhVienVaMaMon(maSinhVien, maMon);
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
        public DataTable TimKiemDiemTheoMaSinhVienVaMaMon(string maSinhVien, string maMon)
        {
            try
            {
                if (string.IsNullOrEmpty(maSinhVien) || string.IsNullOrEmpty(maMon))
                {
                    logger.LogWarning("Người dùng chưa nhập mã môn và mã sinh viên khi tìm kiếm.");
                    throw new ArgumentException("Bạn phải nhập mã sinh viên và mã môn trước khi tìm kiếm");
                }
                DataTable dt = quanlydiemDAL.LaySinhVienTheoDieuKienMaSinhVienVaMaMon(maSinhVien, maMon);
                if (dt == null)
                {
                    throw new KeyNotFoundException("Không tìm thấy tài khoản.");
                }
                return dt;
            }
            catch (SqlException)
            {
                throw;
            }
        }
        public double TinhDiemTongVaHienThi(string diemChuyenCan, string diemGiuaKy, string diemCuoiKy)
        {
            if (!string.IsNullOrEmpty(diemChuyenCan) && !string.IsNullOrEmpty(diemGiuaKy) && !string.IsNullOrEmpty(diemCuoiKy))
            {
                double diemTong = (double.Parse(diemChuyenCan) + double.Parse(diemGiuaKy) + double.Parse(diemCuoiKy)) / 3;
                return Math.Round(diemTong, 1);
            }
            return 0;
        }
    }
}
