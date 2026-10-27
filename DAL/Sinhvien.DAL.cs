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
        public DataTable ThemSinhVienMoi(SinhvienDTO sinhVienMoi)
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
    }
}
