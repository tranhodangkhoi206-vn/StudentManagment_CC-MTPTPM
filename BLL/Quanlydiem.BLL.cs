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
        public DataTable ThemDiemMoi(DiemDTO diemMoi)
        {
            try
            {
                if (string.IsNullOrEmpty(diemMoi.Mamon) ||
                    string.IsNullOrEmpty(diemMoi.Masinhvien) ||
                diemMoi.Diemchuyencan == -1 ||
                diemMoi.Diemgiuaky == -1 ||
                diemMoi.Diemcuoiky == -1
                    )
                {
                    logger.LogWarning("Người dùng chưa nhập đầy đủ thông tin điểm khi thêm.");
                    throw new ArgumentException("Bạn phải nhập đầy đủ thông tin trước khi thêm");
                }
                diemMoi.Diemtong = (diemMoi.Diemchuyencan + diemMoi.Diemgiuaky + diemMoi.Diemcuoiky) / 3;
                return quanlydiemDAL.ThemDiemMoi(diemMoi);
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

        public DataTable SuaThongTinDiemTheoMaSinhVienVaMaMon(DiemDTO diemSua)
        {
            try
            {
                if (string.IsNullOrEmpty(diemSua.Mamon) ||
                    string.IsNullOrEmpty(diemSua.Masinhvien)
                    )
                {
                    logger.LogWarning("Người dùng chưa nhập mã môn và mã sinh viên khi sửa thông tin điểm.");
                    throw new ArgumentException("Bạn phải nhập mã sinh viên và mã môn trước khi sửa");
                }
                diemSua.Diemtong = (diemSua.Diemchuyencan + diemSua.Diemgiuaky + diemSua.Diemcuoiky) / 3;
                return quanlydiemDAL.SuaThongTinDiemTheoMaSinhVienVaMaMon(diemSua);
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

        public DataTable XoaThongTinDiemTheoMaSinhVienVaMaMon(string maSinhVien, string maMon)
        {
            try
            {
                if (string.IsNullOrEmpty(maSinhVien) || string.IsNullOrEmpty(maMon))
                {
                    logger.LogWarning("Người dùng chưa nhập mã môn và mã sinh viên khi xóa thông tin điểm.");
                    throw new ArgumentException("Bạn phải nhập mã sinh viên và mã môn trước khi xóa");
                }
                return quanlydiemDAL.XoaThongTinDiemTheoMaSinhVienVaMaMon(maSinhVien, maMon);
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
        public DataTable TimKiemDiemTheoMaSinhVienVaMaMon(string maSinhVien, string maMonHoc)
        {
            try
            {
                if (string.IsNullOrEmpty(maSinhVien) || string.IsNullOrEmpty(maMonHoc))
                {
                    logger.LogWarning("Người dùng chưa nhập mã môn và mã sinh viên khi tìm kiếm.");
                    throw new ArgumentException("Bạn phải nhập mã sinh viên và mã môn trước khi tìm kiếm");
                }
                return quanlydiemDAL.LaySinhVienTheoDieuKienMaSinhVienVaMaMon(maSinhVien, maMonHoc);
            }
            catch (SqlException)
            {
                throw;
            }
            catch (KeyNotFoundException)
            {
                throw new KeyNotFoundException("Không tìm thấy tài khoản.");
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Xảy ra lỗi không xác định.");
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
