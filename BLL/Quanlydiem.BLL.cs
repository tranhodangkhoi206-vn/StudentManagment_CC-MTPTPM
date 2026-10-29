using System.Data;
using Microsoft.Extensions.Logging;
using StudentManagment.DTO;
using StudentManagment.DAL;
using StudentManagment.DAL.Util;

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
            if (string.IsNullOrEmpty(diemMoi.Mamon) ||
                string.IsNullOrEmpty(diemMoi.Masinhvien) ||
            string.IsNullOrEmpty(diemMoi.Diemchuyencan.ToString()) ||
            string.IsNullOrEmpty(diemMoi.Diemgiuaky.ToString()) ||
            string.IsNullOrEmpty(diemMoi.Diemcuoiky.ToString())
                )
            {
                logger.LogWarning("Người dùng chưa nhập đầy đủ thông tin điểm khi thêm.");
                throw new ArgumentException();
            }
            diemMoi.Diemtong = (diemMoi.Diemchuyencan + diemMoi.Diemgiuaky + diemMoi.Diemcuoiky) / 3;
            return quanlydiemDAL.ThemDiemMoi(diemMoi);
        }

        public DataTable SuaThongTinDiemTheoMaSinhVienVaMaMon(DiemDTO diemSua)
        {
            if (string.IsNullOrEmpty(diemSua.Mamon)|| 
                string.IsNullOrEmpty(diemSua.Masinhvien)
                )
            {
                logger.LogWarning("Người dùng chưa nhập mã môn và mã sinh viên khi sửa thông tin điểm.");
                throw new ArgumentException();
            }
            diemSua.Diemtong = (diemSua.Diemchuyencan + diemSua.Diemgiuaky + diemSua.Diemcuoiky) / 3;
            return quanlydiemDAL.SuaThongTinDiemTheoMaSinhVienVaMaMon(diemSua);
        }

        public DataTable XoaThongTinDiemTheoMaSinhVienVaMaMon(string maSinhVien, string maMon)
        {
            if (string.IsNullOrEmpty(maSinhVien) || string.IsNullOrEmpty(maMon))
            {
                logger.LogWarning("Người dùng chưa nhập mã môn và mã sinh viên khi xóa thông tin điểm.");
                throw new ArgumentException();
            }
            return quanlydiemDAL.XoaThongTinDiemTheoMaSinhVienVaMaMon(maSinhVien, maMon);
        }
    }
}
