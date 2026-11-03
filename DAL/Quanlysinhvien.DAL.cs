using System.Data;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Logging;
using StudentManagment.DTO;
using StudentManagment.DAL.Util;

namespace StudentManagment.DAL
{
    public class QuanlysinhvienDAL
    {
        private readonly ILogger logger;
        private SinhvienDAL sinhvienDAL;
        public QuanlysinhvienDAL(ILoggerFactory loggerFactory)
        {
            logger = loggerFactory.CreateLogger<QuanlysinhvienDAL>();
            sinhvienDAL = new SinhvienDAL(loggerFactory);
        }
        public DataTable ThemsinhVienMoi(SinhvienDTO sinhVien)
        {
            try
            {
                using (SqlConnection conn = CosodulieuDAL.KetNoiCoSoDuLieu())
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO SinhVien VALUES (@MASV, @HOVATEN, @MALOP, @NGAYSINH, @GIOITINH, @MANGANH, @TINHTRANG)", conn);
                    cmd.Parameters.AddWithValue("@MASV", sinhVien.MaSinhVien);
                    cmd.Parameters.AddWithValue("@HOVATEN", sinhVien.HoVaTen);
                    cmd.Parameters.AddWithValue("@MALOP", sinhVien.MaLop);
                    cmd.Parameters.AddWithValue("@NGAYSINH", sinhVien.NgaySinh);
                    cmd.Parameters.AddWithValue("@GIOITINH", sinhVien.GioiTinh);
                    cmd.Parameters.AddWithValue("@MANGANH", sinhVien.MaNganh);
                    cmd.Parameters.AddWithValue("@TINHTRANG", sinhVien.TinhTrang);
                    logger.LogInformation("Thêm sinh viên mới vào danh sách sinh viên.\nMã sinh viên: {0},\nTên sinh viên: {1},\nMã lớp: {2},\nNgày sinh: {3},\nGiới tính: {4},\nMã ngành: {5},\nTình trạng: {6}", sinhVien.MaSinhVien, sinhVien.HoVaTen, sinhVien.MaLop, sinhVien.NgaySinh, sinhVien.GioiTinh, sinhVien.MaNganh, sinhVien.TinhTrang);
                    int thucThi = cmd.ExecuteNonQuery();
                    if (thucThi == 0)
                    {
                        logger.LogWarning("Thêm sinh viên không thành công.");
                        return null;
                    }

                    return sinhvienDAL.LayToanBoSinhVien();
                }
            }
            catch (SqlException sqlEx)
            {
                logger.LogCritical(sqlEx, "Xảy ra lỗi cơ sở dữ liệu khi thêm sinh viên mới.\nMã sinh viên: {0},\nTên sinh viên: {1},\nMã lớp: {2},\nNgày sinh: {3},\nGiới tính: {4},\nMã ngành: {5},\nTình trạng: {6}", sinhVien.MaSinhVien, sinhVien.HoVaTen, sinhVien.MaLop, sinhVien.NgaySinh, sinhVien.GioiTinh, sinhVien.MaNganh, sinhVien.TinhTrang);
                throw;
            }
        }
        public DataTable SuaThongTinSinhVienTheoMaSinhVien(SinhvienDTO sinhVien)
        {
            try
            {
                using (SqlConnection conn = CosodulieuDAL.KetNoiCoSoDuLieu())
                {
                    SqlCommand cmd = new SqlCommand("UPDATE SinhVien SET HOVATEN   = @HOVATEN, MALOP     = @MALOP, NGAYSINH  = @NGAYSINH, GIOITINH  = @GIOITINH, MANGANH   = @MANGANH, TINHTRANG = @TINHTRANG WHERE MASV = @MASV", conn);
                    cmd.Parameters.AddWithValue("@MASV", sinhVien.MaSinhVien);
                    cmd.Parameters.AddWithValue("@HOVATEN", sinhVien.HoVaTen);
                    cmd.Parameters.AddWithValue("@MALOP", sinhVien.MaLop);
                    cmd.Parameters.AddWithValue("@NGAYSINH", sinhVien.NgaySinh);
                    cmd.Parameters.AddWithValue("@GIOITINH", sinhVien.GioiTinh);
                    cmd.Parameters.AddWithValue("@MANGANH", sinhVien.MaNganh);
                    cmd.Parameters.AddWithValue("@TINHTRANG", sinhVien.TinhTrang);
                    logger.LogInformation("Sửa sinh viên trong danh sách sinh viên.\nMã sinh viên: {0},\nTên sinh viên: {1},\nMã lớp: {2},\nNgày sinh: {3},\nGiới tính: {4},\nMã ngành: {5},\nTình trạng: {6}", sinhVien.MaSinhVien, sinhVien.HoVaTen, sinhVien.MaLop, sinhVien.NgaySinh, sinhVien.GioiTinh, sinhVien.MaNganh, sinhVien.TinhTrang);
                    int thucThi = cmd.ExecuteNonQuery();
                    if (thucThi == 0)
                    {
                        logger.LogWarning("Mã sinh viên không tồn tại.\nMã sinh viên: {0}", sinhVien.MaSinhVien);
                        return null;
                    }
                    return sinhvienDAL.LayToanBoSinhVien();
                }
            }
            catch (SqlException sqlEx)
            {
                logger.LogCritical(sqlEx, "Xảy ra lỗi cơ sở dữ liệu khi sửa sinh viên.\nMã sinh viên: {0},\nTên sinh viên: {1},\nMã lớp: {2},\nNgày sinh: {3},\nGiới tính: {4},\nMã ngành: {5},\nTình trạng: {6}", sinhVien.MaSinhVien, sinhVien.HoVaTen, sinhVien.MaLop, sinhVien.NgaySinh, sinhVien.GioiTinh, sinhVien.MaNganh, sinhVien.TinhTrang);
                throw;
            }
        }
        public DataTable XoaThongTinSinhVienTheoMaSinhVien(string maSinhVien)
        {
            try
            {
                using (SqlConnection conn = CosodulieuDAL.KetNoiCoSoDuLieu())
                {
                    SqlCommand cmd = new SqlCommand("DELETE FROM SINHVIEN WHERE MASV=@MASV", conn);
                    cmd.Parameters.AddWithValue("@MASV", maSinhVien);
                    logger.LogInformation("Xóa sinh viên ra khỏi danh sách sinh viên.\nMã sinh viên: {0}.", maSinhVien);
                    int thucThi = cmd.ExecuteNonQuery();
                    if (thucThi == 0)
                    {
                        logger.LogWarning("Mã sinh viên không tồn tại.\nMã sinh viên: {0}", maSinhVien);
                        return null;
                    }
                    return sinhvienDAL.LayToanBoSinhVien();
                }
            }
            catch (SqlException sqlEx)
            {
                logger.LogCritical(sqlEx, "Xảy ra lỗi cơ sở dữ liệu khi xóa sinh viên.\nMã sinh viên: {0}.", maSinhVien);
                throw;
            }

        }
        public DataTable LaySinhVienTheoDieuKienMaSinhVien(string maSinhVien)
        {
            try
            {
                using (SqlConnection conn = CosodulieuDAL.KetNoiCoSoDuLieu())
                {
                    DataTable dt = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM SINHVIEN WHERE MASV=@MASV", conn);
                    cmd.Parameters.AddWithValue("@MASV", maSinhVien);
                    adapter.SelectCommand = cmd;
                    logger.LogInformation("Lấy danh sách sinh viên theo điều kiện mã sinh viên.\nMã sinh viên: {0}", maSinhVien);
                    adapter.Fill(dt);
                    if (dt.Rows.Count == 0)
                    {
                        logger.LogWarning("Mã sinh viên không tồn tại.\nMã sinh viên: {0}", maSinhVien);
                        return null;
                    }
                    return dt;
                }
            }
            catch (SqlException sqlEx)
            {
                logger.LogCritical(sqlEx, "Xảy ra lỗi cơ sở dữ liệu khi lấy dữ liệu danh sách sinh viên theo Mã sinh viên.\nMã sinh viên: {0}.", maSinhVien);
                throw;
            }
        }
    }
}
