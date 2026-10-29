using System.Data;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Logging;
using StudentManagment.DAL.Util;
using StudentManagment.DTO;

namespace StudentManagment.DAL
{
    public class QuanlynganhhocDAL
    {
        private readonly ILogger logger;
        private NganhhocDAL nganhhocDAL;
        public QuanlynganhhocDAL(ILoggerFactory loggerFactory)
        {
            logger = loggerFactory.CreateLogger<QuanlynganhhocDAL>();
            nganhhocDAL = new NganhhocDAL(loggerFactory);
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
                    return nganhhocDAL.LayToanBoNganhHoc();
                }
            }
            catch (SqlException sqlEx)
            {
                logger.LogCritical(sqlEx, "Lỗi kết nối tới cơ sở dữ liệu khi thêm ngành mới. Với thông tin:\nMã ngành: {0},\nTên ngành: {1},\nKhoa quản lý: {2}", nganhMoi.Manganh, nganhMoi.Tennganh, nganhMoi.Khoaquanly);
                throw;
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Xảy ra lỗi khi thêm ngành có mã ngành {0} vào danh sách ngành. Với dữ liệu:\nTên ngành: {1},\nKhoa quản lý: {2}", nganhMoi.Manganh, nganhMoi.Tennganh, nganhMoi.Khoaquanly);
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

                    return nganhhocDAL.LayToanBoNganhHoc();
                }
            }
            catch (SqlException sqlEx)
            {
                logger.LogCritical(sqlEx, "Lỗi kết nối tới cơ sở dữ liệu khi sửa ngành có mã ngành {0} trong danh sách ngành. Với dữ liệu:\nTên ngành: {1},\nKhoa quản lý: {2}", nganhSua.Manganh, nganhSua.Tennganh, nganhSua.Khoaquanly);
                throw;
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Xảy ra lỗi khi sửa ngành có mã ngành {0} trong danh sách ngành. Với dữ liệu:\nTên ngành: {1},\nKhoa quản lý: {2}", nganhSua.Manganh, nganhSua.Tennganh, nganhSua.Khoaquanly);
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

                    return nganhhocDAL.LayToanBoNganhHoc();
                }
            }
            catch (SqlException sqlEx)
            {
                logger.LogCritical(sqlEx, "Lỗi kết nối tới cơ sở dữ liệu khi xóa ngành có mã ngành {0} khỏi danh sách ngành", maNganh);
                throw;
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Lỗi xảy ra khi xóa ngành với mã ngành {0}", maNganh);
                throw;
            }
        }
    }
}
