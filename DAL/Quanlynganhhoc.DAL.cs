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

                    logger.LogInformation("Thêm ngành học mới vào danh sách ngành học.\nMã ngành: {0},\nTên ngành: {1},\nKhoa quản lý: {2}", nganhMoi.Manganh, nganhMoi.Tennganh, nganhMoi.Khoaquanly);
                    return nganhhocDAL.LayToanBoNganhHoc();
                }
            }
            catch (SqlException sqlEx)
            {
                logger.LogCritical(sqlEx, "Xảy ra lỗi cơ sở dữ liệu khi thêm ngành học mới.\nMã ngành: {0},\nTên ngành: {1},\nKhoa quản lý: {2}", nganhMoi.Manganh, nganhMoi.Tennganh, nganhMoi.Khoaquanly);
                throw;
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Xảy ra lỗi khi thêm ngành học mới.\nMã ngành: {0},\nTên ngành: {1},\nKhoa quản lý: {2}", nganhMoi.Manganh, nganhMoi.Tennganh, nganhMoi.Khoaquanly);
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

                    logger.LogInformation("Sửa ngành học trong danh sách ngành học.\nMã ngành: {0},\nTên ngành: {1},\nKhoa quản lý: {2}", nganhSua.Manganh, nganhSua.Tennganh, nganhSua.Khoaquanly);

                    return nganhhocDAL.LayToanBoNganhHoc();
                }
            }
            catch (SqlException sqlEx)
            {
                logger.LogCritical(sqlEx, "Xảy ra lỗi cơ sở dữ liệu khi sửa ngành học.\nMã ngành: {0},\nTên ngành: {1},\nKhoa quản lý: {2}", nganhSua.Manganh, nganhSua.Tennganh, nganhSua.Khoaquanly);
                throw;
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Xảy ra lỗi khi sửa ngành học.\nMã ngành: {0},\nTên ngành: {1},\nKhoa quản lý: {2}", nganhSua.Manganh, nganhSua.Tennganh, nganhSua.Khoaquanly);
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

                    logger.LogInformation("Xóa ngành học khỏi danh sách ngành học.\nMã ngành: {0}", maNganh);

                    return nganhhocDAL.LayToanBoNganhHoc();
                }
            }
            catch (SqlException sqlEx)
            {
                logger.LogCritical(sqlEx, "Xảy ra lỗi cơ sở dữ liệu khi xóa ngành học.\nMã ngành: {0}", maNganh);
                throw;
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Xảy ra lỗi khi xóa ngành học.\nMã ngành: {0}", maNganh);
                throw;
            }
        }
        public DataTable LayDanhSachNganhHocTheoDieuKienMaNganh(string maNganh)
        {
            try
            {
                using (SqlConnection conn = CosodulieuDAL.KetNoiCoSoDuLieu())
                {
                    SqlDataAdapter adater = new SqlDataAdapter();
                    DataTable dt = new DataTable();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM NGANHHOC WHERE MANGANH=@MANGANH", conn);
                    cmd.Parameters.AddWithValue("@MANGANH", maNganh);
                    adater.SelectCommand = cmd;
                    logger.LogInformation("Lấy danh sách ngành học theo Mã ngành.\nMã ngành: {0}", maNganh);
                    adater.Fill(dt);
                    return dt;
                }
            }
            catch (SqlException sqlEx)
            {
                logger.LogCritical(sqlEx, "Xảy ra lỗi cơ sở dữ liệu khi lấy danh sách ngành học theo Mã ngành.\nMã ngành: {0}", maNganh);
                throw;
            }
            catch (Exception ex)
            {
                logger.LogWarning(ex, "Xảy ra lỗi khi lấy danh sách ngành hoc theo Mã ngành.\nMã ngành: {0}",maNganh);
			    throw;
            }
        }
    }
}
