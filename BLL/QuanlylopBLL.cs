using System;
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

        public QuanlylopBLL(ILoggerFactory loggerFactory)
        {
            logger = loggerFactory.CreateLogger<QuanlylopBLL>();
            quanlylopDAL = new QuanlylopDAL(loggerFactory);
            lopDAL = new LopDAL(loggerFactory);
        }


        // 1. Hiển thị toàn bộ danh sách lớp
        public DataTable HienThiToanBoDanhSachLop()
        {
            return lopDAL.LayToanBoLopHoc();
        }

        // 2. Tìm kiếm lớp học theo Mã lớp
        public DataTable TimKiemLopHoc(string maLop)
        {
            if (string.IsNullOrWhiteSpace(maLop))
            {
                // Nếu ô tìm kiếm để trống thì hiển thị toàn bộ
                return quanlylopDAL.LayToanBoLopHoc();
            }

            return quanlylopDAL.TimKiemLopHocTheoMa(maLop.Trim());
        }

        // 3. Thêm lớp học mới (Validate dữ liệu đầu vào)
        public DataTable ThemLopHocMoi(LopDTO lopDTO)
        {
            if (lopDTO == null)
            {
                throw new ArgumentNullException(nameof(lopDTO), "Dữ liệu lớp học không được để trống!");
            }

            if (string.IsNullOrWhiteSpace(lopDTO.Malop))
            {
                logger?.LogWarning("Người dùng bỏ trống mã lớp khi thực hiện thêm.");
                throw new ArgumentException("Mã lớp không được để trống!");
            }

            if (string.IsNullOrWhiteSpace(lopDTO.Manganh))
            {
                logger?.LogWarning("Người dùng bỏ trống mã ngành khi thực hiện thêm lớp.");
                throw new ArgumentException("Mã ngành không được để trống!");
            }

            if (string.IsNullOrWhiteSpace(lopDTO.Tenlop))
            {
                logger?.LogWarning("Người dùng bỏ trống tên lớp khi thực hiện thêm lớp.");
                throw new ArgumentException("Tên lớp không được để trống!");
            }

            if (string.IsNullOrWhiteSpace(lopDTO.Giangvienphutrach))
            {
                logger?.LogWarning("Người dùng bỏ trống giảng viên phụ trách khi thực hiện thêm lớp.");
                throw new ArgumentException("Giảng viên phụ trách không được để trống!");
            }

            return quanlylopDAL.ThemDuLieuLopMoi(lopDTO);
        }

        // 4. Sửa thông tin lớp học
        public DataTable SuaThongTinLop(LopDTO lopDTO)
        {
            if (lopDTO == null)
            {
                throw new ArgumentNullException(nameof(lopDTO), "Dữ liệu lớp học không được để trống!");
            }

            if (string.IsNullOrWhiteSpace(lopDTO.Malop))
            {
                logger?.LogWarning("Người dùng chưa chọn hoặc chưa nhập mã lớp cần sửa.");
                throw new ArgumentException("Mã lớp không được để trống khi sửa thông tin!");
            }

            if (string.IsNullOrWhiteSpace(lopDTO.Manganh) ||
                string.IsNullOrWhiteSpace(lopDTO.Tenlop) ||
                string.IsNullOrWhiteSpace(lopDTO.Giangvienphutrach))
            {
                logger?.LogWarning("Thông tin cập nhật của lớp học còn thiếu trường bắt buộc.");
                throw new ArgumentException("Vui lòng điền đầy đủ Mã ngành, Tên lớp và Giảng viên phụ trách!");
            }

            return quanlylopDAL.SuaThongTinLopTheoMaLop(lopDTO);
        }

        // 5. Xóa lớp học
        public DataTable XoaThongTinLop(string maLop)
        {
            if (string.IsNullOrWhiteSpace(maLop))
            {
                logger?.LogWarning("Người dùng chưa chọn hoặc chưa nhập mã lớp để xóa.");
                throw new ArgumentException("Mã lớp không được để trống khi thực hiện xóa!");
            }

            return quanlylopDAL.XoaThongTinLopTheoMaLop(maLop.Trim());
        }
    }
}