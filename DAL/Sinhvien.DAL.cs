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
                    DataTable dt = LayToanBoSinhVien();
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                    DataRow row = dt.NewRow();
                    row["MASV"] = sinhVienMoi.MaSinhVien;
                    row["HOVATEN"] = sinhVienMoi.HoVaTen;
                    row["MALOP"] = sinhVienMoi.MaLop;
                    row["NGAYSINH"] = sinhVienMoi.NgaySinh;
                    row["GIOITINH"] = sinhVienMoi.GioiTinh;
                    row["MANGANH"] = sinhVienMoi.MaNganh;
                    row["TINHTRANG"] = sinhVienMoi.TinhTrang;
                    dt.Rows.Add(row);
                    logger.LogInformation("Đang thêm sinh viên mới vào danh sách sinh viên. Với dữ liệu:\nMã sinh viên: {0},\nTên sinh viên: {1},\nMã lớp: {2},\nNgày sinh: {3},\nGiới tính: {4},\nMã ngành: {5},\nTình trạng: {6}", sinhVienMoi.MaSinhVien, sinhVienMoi.HoVaTen, sinhVienMoi.MaLop, sinhVienMoi.NgaySinh, sinhVienMoi.GioiTinh, sinhVienMoi.MaNganh, sinhVienMoi.TinhTrang);
                    adapter.Update(dt);
                    return dt;
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
                    DataTable dt = LayToanBoSinhVien();
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                    DataRow[] rows = dt.Select("MASV={0}", sinhVienSua.MaSinhVien);
		            if (rows.Length == 0)
                    {
                        logger.LogInformation("Thông tin sinh viên cần sửa không tồn tại. Với mã sinh viên: {masinhvien}", sinhVienSua.MaSinhVien);
                    }
                    DataRow row = rows[0];
                    row["HOVATEN"] = sinhVienSua.HoVaTen;
                    row["MALOP"] = sinhVienSua.MaLop;
                    row["NGAYSINH"] = sinhVienSua.NgaySinh;
                    row["GIOITINH"] = sinhVienSua.GioiTinh;
                    row["MANGANH"] = sinhVienSua.MaNganh;
                    row["TINHTRANG"] = sinhVienSua.TinhTrang;
                    logger.LogInformation("Đang sửa sinh viên có mã sinh viên {0} vào danh sách sinh viên. Với dữ liệu:\nTên sinh viên: {1},\nMã lớp: {2},\nNgày sinh: {3},\nGiới tính: {4},\nMã ngành: {5},\nTình trạng: {6}", sinhVienSua.MaSinhVien, sinhVienSua.HoVaTen, sinhVienSua.MaLop, sinhVienSua.NgaySinh, sinhVienSua.GioiTinh, sinhVienSua.MaNganh, sinhVienSua.TinhTrang);
                    adapter.Update(dt);
                    return dt;
                }
            } catch (SqlException sqlEx)
            {
                logger.LogCritical(sqlEx, "Lỗi kết nối tới cơ sở dữ liệu khi sửa sinh viên có mã sinh viên {0} vào danh sách sinh viên. Với dữ liệu:\nTên sinh viên: {1},\nMã lớp: {2},\nNgày sinh: {3},\nGiới tính: {4},\nMã ngành: {5},\nTình trạng: {6}", sinhVienSua.MaSinhVien, sinhVienSua.HoVaTen, sinhVienSua.MaLop, sinhVienSua.NgaySinh, sinhVienSua.GioiTinh, sinhVienSua.MaNganh, sinhVienSua.TinhTrang);
                throw;
            }
        }
	    public DataTable XoaThongTinSinhVienTheoMaSinhVien(string maSinhVien)
        {
            try
            {
                using(SqlConnection conn = CosodulieuDAL.KetNoiCoSoDuLieu())
                {
                    DataTable dt = LayToanBoSinhVien();
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                    DataRow[] rows = dt.Select("MASV={masv}", maSinhVien);
		            if (rows.Length == 0)
                    {
                        logger.LogInformation("Thông tin sinh viên cần xóa không tồn tại. Với mã sinh viên: {masinhvien}", maSinhVien);
                    }
                    rows[0].Delete();
                    logger.LogInformation("Đang xóa sinh viên với mã sinh viên {0} khỏi danh sách sinh viên.", maSinhVien);
                    adapter.Update(dt);
                    return dt;
                }
            } catch (SqlException sqlEx)
            {
                logger.LogCritical(sqlEx, "Lỗi kết nối tới cơ sở dữ liệu khi xóa sinh viên có mã sinh viên {0} khỏi danh sách sinh viên", maSinhVien);
                throw;
            }
        }
    }
}
