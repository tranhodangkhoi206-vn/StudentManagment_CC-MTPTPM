using System.Data;
using System.Runtime.CompilerServices;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Logging;
using StudentManagment.DTO;

namespace StudentManagment.DAL
{
    public class SinhvienDAL
    {
        private readonly ILogger logger
            ;
        public SinhvienDAL(ILoggerFactory loggerFactory)
        {
            logger = loggerFactory.CreateLogger<SinhvienDAL>();
        }
        public DataTable LayToanBoSinhVien()
        {
            try
            {
                using (SqlConnection conn = CosodulieuDAL.KetNoiCoSoDuLieu())
                {
                    DataTable dt = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    adapter.SelectCommand = new SqlCommand("SELECT * FROM SINHVIEN", conn);
                    logger.LogInformation("Đang lấy danh sách các sinh viên...");
                    adapter.Fill(dt);
                    return dt;
                }
            }
            catch (SqlException sqlEx)
            {
                logger.LogCritical(sqlEx, "Lỗi kết nối tới cơ sỡ dữ liệu khi lấy danh sách sinh viên.");
                throw;
            }
        }
        public DataTable LaySinhVienTheoDieuKienTen(string hovaten)
        {
            try
            {
                using (SqlConnection conn = CosodulieuDAL.KetNoiCoSoDuLieu())
                {
                    DataTable dt = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM SINHVIEN WHERE HOVATEN LIKE @HOVATEN", conn);
                    cmd.Parameters.AddWithValue("@HOVATEN", "%" + hovaten + "%");
                    adapter.SelectCommand = cmd;
                    logger.LogInformation("Đang lấy danh sách sinh viên theo điều kiện tên...");
                    adapter.Fill(dt);
                    return dt;
                }
            }
            catch (SqlException sqlEx)
            {
                logger.LogCritical(sqlEx, "Lỗi kết nối tới cơ sở dữ liệu khi lấy danh sách sinh viên theo điều kiện tên.");
                throw;
            }
        }
        public DataTable LaySinhVienTheoDieuKienLop(string maLop)
        {
            try
            {
                using (SqlConnection conn = CosodulieuDAL.KetNoiCoSoDuLieu())
                {
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM SINHVIEN WHERE MALOP=@MALOP", conn);
                    cmd.Parameters.AddWithValue("@MALOP", maLop);
                    adapter.SelectCommand = cmd;
                    DataTable dt = new DataTable();
                    logger.LogInformation("Đang lấy danh sách sinh viên theo điều kiện lớp...");
                    adapter.Fill(dt);
                    return dt;
                }
            }
            catch (SqlException sqlEx)
            {
                logger.LogCritical(sqlEx, "Lỗi kết nối tới cơ sở dữ liệu khi lấy danh sách sinh viên theo điều kiện lớp.");
                throw;
            }
        }
        public DataTable LaySinhVienTheoDieuKienNganhHoc(string maNganh)
        {
            try
            {
                using (SqlConnection conn = CosodulieuDAL.KetNoiCoSoDuLieu())
                {
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM SINHVIEN WHERE MANGANH=@MANGANH", conn);
                    cmd.Parameters.AddWithValue("@MANGANH", maNganh);
                    adapter.SelectCommand = cmd;
                    DataTable dt = new DataTable();
                    logger.LogInformation("Đang lấy danh sách sinh viên theo điều kiện ngành học...");
                    adapter.Fill(dt);
                    return dt;
                }
            }
            catch (SqlException sqlEx)
            {
                logger.LogCritical(sqlEx, "Lỗi kết nối tới cơ sở dữ liệu khi lấy danh sách sinh viên theo điều kiện ngành học.");
                throw;
            }
        }
        public DataTable ThemsinhVienMoi(SinhvienDTO sinhVienMoi)
        {
            try
            {
                using (SqlConnection conn = CosodulieuDAL.KetNoiCoSoDuLieu())
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO SinhVien VALUES (@MASV, @HOVATEN, @MALOP, @NGAYSINH, @GIOITINH, @MANGANH, @TINHTRANG)", conn);
                    cmd.Parameters.AddWithValue("@MASV", sinhVienMoi.MaSinhVien);
                    cmd.Parameters.AddWithValue("@HOVATEN", sinhVienMoi.HoVaTen);
                    cmd.Parameters.AddWithValue("@MALOP", sinhVienMoi.MaLop);
                    cmd.Parameters.AddWithValue("@NGAYSINH", sinhVienMoi.NgaySinh);
                    cmd.Parameters.AddWithValue("@GIOITINH", sinhVienMoi.GioiTinh);
                    cmd.Parameters.AddWithValue("@MANGANH", sinhVienMoi.MaNganh);
                    cmd.Parameters.AddWithValue("@TINHTRANG", sinhVienMoi.TinhTrang);
                    cmd.ExecuteNonQuery();

                    logger.LogInformation("Đang thêm sinh viên mới vào danh sách sinh viên. Với dữ liệu:\nMã sinh viên: {0},\nTên sinh viên: {1},\nMã lớp: {2},\nNgày sinh: {3},\nGiới tính: {4},\nMã ngành: {5},\nTình trạng: {6}", sinhVienMoi.MaSinhVien, sinhVienMoi.HoVaTen, sinhVienMoi.MaLop, sinhVienMoi.NgaySinh, sinhVienMoi.GioiTinh, sinhVienMoi.MaNganh, sinhVienMoi.TinhTrang);

                    return LayToanBoSinhVien();
                }
            }
            catch (SqlException sqlEx)
            {
                logger.LogCritical(sqlEx, "Lỗi kết nối tới cơ sở dữ liệu khi thêm sinh viên mới. Với thông tin:\nMã sinh viên: {0},\nTên sinh viên: {1},\nMã lớp: {2},\nNgày sinh: {3},\nGiới tính: {4},\nMã ngành: {5},\nTình trạng: {6}", sinhVienMoi.MaSinhVien, sinhVienMoi.HoVaTen, sinhVienMoi.MaLop, sinhVienMoi.NgaySinh, sinhVienMoi.GioiTinh, sinhVienMoi.MaNganh, sinhVienMoi.TinhTrang);
                throw;
            }
        }
        public DataTable SuaThongTinSinhVienTheoMaSinhVien(SinhvienDTO sinhVienSua)
        {
            try
            {
                using (SqlConnection conn = CosodulieuDAL.KetNoiCoSoDuLieu())
                {
                    SqlCommand cmd = new SqlCommand("UPDATE SinhVien SET HOVATEN   = @HOVATEN, MALOP     = @MALOP, NGAYSINH  = @NGAYSINH, GIOITINH  = @GIOITINH, MANGANH   = @MANGANH, TINHTRANG = @TINHTRANG WHERE MASV = @MASV");
                    cmd.Parameters.AddWithValue("@MASV", sinhVienSua.MaSinhVien);
                    cmd.Parameters.AddWithValue("@HOVATEN", sinhVienSua.HoVaTen);
                    cmd.Parameters.AddWithValue("@MALOP", sinhVienSua.MaLop);
                    cmd.Parameters.AddWithValue("@NGAYSINH", sinhVienSua.NgaySinh);
                    cmd.Parameters.AddWithValue("@GIOITINH", sinhVienSua.GioiTinh);
                    cmd.Parameters.AddWithValue("@MANGANH", sinhVienSua.MaNganh);
                    cmd.Parameters.AddWithValue("@TINHTRANG", sinhVienSua.TinhTrang);
                    cmd.ExecuteNonQuery();
                    logger.LogInformation("Đang sửa sinh viên có mã sinh viên {0} vào danh sách sinh viên. Với dữ liệu:\nTên sinh viên: {1},\nMã lớp: {2},\nNgày sinh: {3},\nGiới tính: {4},\nMã ngành: {5},\nTình trạng: {6}", sinhVienSua.MaSinhVien, sinhVienSua.HoVaTen, sinhVienSua.MaLop, sinhVienSua.NgaySinh, sinhVienSua.GioiTinh, sinhVienSua.MaNganh, sinhVienSua.TinhTrang);
                    return LayToanBoSinhVien();
                }
            }
            catch (SqlException sqlEx)
            {
                logger.LogCritical(sqlEx, "Lỗi kết nối tới cơ sở dữ liệu khi sửa sinh viên có mã sinh viên {0} vào danh sách sinh viên. Với dữ liệu:\nTên sinh viên: {1},\nMã lớp: {2},\nNgày sinh: {3},\nGiới tính: {4},\nMã ngành: {5},\nTình trạng: {6}", sinhVienSua.MaSinhVien, sinhVienSua.HoVaTen, sinhVienSua.MaLop, sinhVienSua.NgaySinh, sinhVienSua.GioiTinh, sinhVienSua.MaNganh, sinhVienSua.TinhTrang);
                throw;
            }
        }
        public DataTable XoaThongTinSinhVienTheoMaSinhVien(string maSinhVien)
        {
            try
            {
                using (SqlConnection conn = CosodulieuDAL.KetNoiCoSoDuLieu())
                {
                    SqlCommand cmd = new SqlCommand("DELETE SINHVIEN WHERE MASV=@MASV", conn);
                    cmd.Parameters.AddWithValue("@MASV", maSinhVien);
                    cmd.ExecuteNonQuery();
                    logger.LogInformation("Đang xóa sinh viên với mã sinh viên {0} khỏi danh sách sinh viên.", maSinhVien);
                    return LayToanBoSinhVien();
                }
            }
            catch (SqlException sqlEx)
            {
                logger.LogCritical(sqlEx, "Lỗi kết nối tới cơ sở dữ liệu khi xóa sinh viên có mã sinh viên {0} khỏi danh sách sinh viên", maSinhVien);
                throw;
            }
        }
    }
}
