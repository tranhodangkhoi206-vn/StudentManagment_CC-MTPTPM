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
        private readonly SinhvienDAL sinhvienDAL;

        public QuanlysinhvienDAL(ILoggerFactory loggerFactory)
        {
            logger = loggerFactory.CreateLogger<QuanlysinhvienDAL>();
            sinhvienDAL = new SinhvienDAL(loggerFactory);
        }

        // Hàm phân tích thông báo lỗi SQL Server 
        private string PhanTichLoiSql(SqlException sqlEx, string maSinhVien)
        {
            string thongBaoGoc = sqlEx.Message.ToLower();

            // 1. Lỗi trùng khóa chính (Mã sinh viên đã có sẵn trong bảng)
            if (thongBaoGoc.Contains("primary key") || thongBaoGoc.Contains("duplicate key"))
            {
                return $"Mã sinh viên '{maSinhVien}' đã tồn tại trong hệ thống. Vui lòng nhập mã sinh viên khác!";
            }

            // 2. Lỗi khóa ngoại (Mã lớp hoặc Mã ngành không tồn tại trong danh mục)
            if (thongBaoGoc.Contains("foreign key") || thongBaoGoc.Contains("the conflict occurred"))
            {
                return "Mã lớp hoặc Mã ngành học không hợp lệ (không tồn tại trong danh mục hệ thống)!";
            }

            // 3. Lỗi dữ liệu nhập vượt quá độ dài cột trong database
            if (thongBaoGoc.Contains("string or binary data would be truncated"))
            {
                return "Dữ liệu nhập vào vượt quá độ dài cho phép của hệ thống!";
            }

            // 4. Lỗi sai định dạng dữ liệu (ví dụ định dạng ngày tháng)
            if (thongBaoGoc.Contains("conversion failed"))
            {
                return "Định dạng ngày sinh hoặc kiểu dữ liệu nhập vào không hợp lệ!";
            }

            // 5. Lỗi mất kết nối CSDL hoặc máy chủ SQL tắt
            if (thongBaoGoc.Contains("network-related") || thongBaoGoc.Contains("server was not found") || thongBaoGoc.Contains("cannot open database"))
            {
                return "Không thể kết nối đến máy chủ cơ sở dữ liệu. Vui lòng kiểm tra lại dịch vụ SQL Server!";
            }

            // Trường hợp lỗi khác: lấy nguyên văn thông báo từ SQL Server
            return "Lỗi cơ sở dữ liệu: " + sqlEx.Message;
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