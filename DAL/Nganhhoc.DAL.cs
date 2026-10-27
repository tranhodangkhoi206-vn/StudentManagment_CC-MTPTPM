using System.Data;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Logging;
using StudentManagment.DTO;

namespace StudentManagment.DAL
{
    public class NganhhocDAL
    {
        private readonly ILogger logger;
        public NganhhocDAL(ILoggerFactory loggerFactory)
        {
            logger = loggerFactory.CreateLogger<NganhhocDAL>();
        }
        public DataTable LayToanBoNganhHocChoComboBox()
        {
            try
            {
                using (SqlConnection conn = CosodulieuDAL.KetNoiCoSoDuLieu())
                {
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    adapter.SelectCommand = new SqlCommand("SELECT MANGANH, TENNGANH FROM NGANHHOC", conn);
                    DataTable dt = new DataTable();
                    logger.LogInformation("Đang lấy danh sách ngành học cho combo box...");
                    adapter.Fill(dt);
                    return dt;
                }
            }
            catch (SqlException sqlEx)
            {
                logger.LogCritical(sqlEx, "Lỗi kết nối tới cơ sở dữ liệu khi lấy danh sách ngành học cho combo box.");
                throw;
            }
        }
        public DataTable LayToanBoNganhHoc()
        {
            try
            {
                using (SqlConnection conn = CosodulieuDAL.KetNoiCoSoDuLieu())
                {
                    DataTable dt = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    adapter.SelectCommand = new SqlCommand("SELECT * FROM NGANHHOC", conn);
                    logger.LogInformation("Đang lấy danh sách các ngành học...");
                    adapter.Fill(dt);
                    return dt;
                }
            }
            catch (SqlException sqlEx)
            {
                logger.LogCritical(sqlEx, "Lỗi kết nối tới cơ sỡ dữ liệu khi lấy danh sách ngành học.");
                throw;
            }
        }
        public DataTable ThemNganhMoi(NganhhocDTO nganhMoi)
        {
            try
            {
                using (SqlConnection conn = CosodulieuDAL.KetNoiCoSoDuLieu())
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO NGANHHOC VALUES (@MANGANH, @TENNGANH, @KHOAQUANLY)", conn);
                    cmd.Parameters.AddWithValue("@MANGANH", nganhMoi.Manganh);
                    cmd.Parameters.AddWithValue("@TENNGANH", nganhMoi.Tennganh);
                    cmd.Parameters.AddWithValue("@KHOAQUANLY", nganhMoi.Khoaquanly);
                    cmd.ExecuteNonQuery();

                    logger.LogInformation("Đang thêm ngành mới vào danh sách ngành. Với dữ liệu:\nMã ngành: {0},\nTên ngành: {1},\nKhoa quản lý: {2}", nganhMoi.Manganh, nganhMoi.Tennganh, nganhMoi.Khoaquanly);

                    return LayToanBoNganhHoc();
                }
            }
            catch (SqlException sqlEx)
            {
                logger.LogCritical(sqlEx, "Lỗi kết nối tới cơ sở dữ liệu khi thêm ngành mới. Với thông tin:\nMã ngành: {0},\nTên ngành: {1},\nKhoa quản lý: {2}", nganhMoi.Manganh, nganhMoi.Tennganh, nganhMoi.Khoaquanly);
                throw;
            }
        }

        public DataTable SuaThongTinNganhTheoMaNganh(NganhhocDTO nganhSua)
        {
            try
            {
                using (SqlConnection conn = CosodulieuDAL.KetNoiCoSoDuLieu())
                {
                    SqlCommand cmd = new SqlCommand("UPDATE NGANHHOC SET TENNGANH = @TENNGANH, KHOAQUANLY = @KHOAQUANLY WHERE MANGANH = @MANGANH", conn);
                    cmd.Parameters.AddWithValue("@MANGANH", nganhSua.Manganh);
                    cmd.Parameters.AddWithValue("@TENNGANH", nganhSua.Tennganh);
                    cmd.Parameters.AddWithValue("@KHOAQUANLY", nganhSua.Khoaquanly);
                    cmd.ExecuteNonQuery();

                    logger.LogInformation("Đang sửa ngành có mã ngành {0} trong danh sách ngành. Với dữ liệu:\nTên ngành: {1},\nKhoa quản lý: {2}", nganhSua.Manganh, nganhSua.Tennganh, nganhSua.Khoaquanly);

                    return LayToanBoNganhHoc();
                }
            }
            catch (SqlException sqlEx)
            {
                logger.LogCritical(sqlEx, "Lỗi kết nối tới cơ sở dữ liệu khi sửa ngành có mã ngành {0} trong danh sách ngành. Với dữ liệu:\nTên ngành: {1},\nKhoa quản lý: {2}", nganhSua.Manganh, nganhSua.Tennganh, nganhSua.Khoaquanly);
                throw;
            }
        }

        public DataTable XoaThongTinNganhTheoMaNganh(string maNganh)
        {
            try
            {
                using (SqlConnection conn = CosodulieuDAL.KetNoiCoSoDuLieu())
                {
                    SqlCommand cmd = new SqlCommand("DELETE NGANHHOC WHERE MANGANH = @MANGANH", conn);
                    cmd.Parameters.AddWithValue("@MANGANH", maNganh);
                    cmd.ExecuteNonQuery();

                    logger.LogInformation("Đang xóa ngành với mã ngành {0} khỏi danh sách ngành.", maNganh);

                    return LayToanBoNganhHoc();
                }
            }
            catch (SqlException sqlEx)
            {
                logger.LogCritical(sqlEx, "Lỗi kết nối tới cơ sở dữ liệu khi xóa ngành có mã ngành {0} khỏi danh sách ngành", maNganh);
                throw;
            }
        }
    }
}
