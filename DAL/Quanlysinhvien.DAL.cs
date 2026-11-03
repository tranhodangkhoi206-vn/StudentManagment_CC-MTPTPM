using System;
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

        // 1. CHỨC NĂNG THÊM SINH VIÊN MỚI
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

                    logger.LogInformation("Đang thêm sinh viên mới vào danh sách sinh viên. Với dữ liệu:\nMã sinh viên: {0},\nHọ tên: {1}",
                        sinhVienMoi.MaSinhVien, sinhVienMoi.HoVaTen);

                    return sinhvienDAL.LayToanBoSinhVien();
                }
            }
            catch (SqlException sqlEx)
            {
                string loiCuThe = PhanTichLoiSql(sqlEx, sinhVienMoi.MaSinhVien);
                logger.LogCritical(sqlEx, "Lỗi thêm sinh viên: {0}", loiCuThe);
                throw new Exception(loiCuThe);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Xảy ra lỗi khi thêm sinh viên {0}: {1}", sinhVienMoi.MaSinhVien, ex.Message);
                throw new Exception("Lỗi hệ thống khi thêm sinh viên: " + ex.Message);
            }
        }

        // 2. CHỨC NĂNG SỬA THÔNG TIN SINH VIÊN
        public DataTable SuaThongTinSinhVienTheoMaSinhVien(SinhvienDTO sinhVienSua)
        {
            try
            {
                using (SqlConnection conn = CosodulieuDAL.KetNoiCoSoDuLieu())
                {
                    SqlCommand cmd = new SqlCommand("UPDATE SinhVien SET HOVATEN = @HOVATEN, MALOP = @MALOP, NGAYSINH = @NGAYSINH, GIOITINH = @GIOITINH, MANGANH = @MANGANH, TINHTRANG = @TINHTRANG WHERE MASV = @MASV", conn);
                    cmd.Parameters.AddWithValue("@MASV", sinhVienSua.MaSinhVien);
                    cmd.Parameters.AddWithValue("@HOVATEN", sinhVienSua.HoVaTen);
                    cmd.Parameters.AddWithValue("@MALOP", sinhVienSua.MaLop);
                    cmd.Parameters.AddWithValue("@NGAYSINH", sinhVienSua.NgaySinh);
                    cmd.Parameters.AddWithValue("@GIOITINH", sinhVienSua.GioiTinh);
                    cmd.Parameters.AddWithValue("@MANGANH", sinhVienSua.MaNganh);
                    cmd.Parameters.AddWithValue("@TINHTRANG", sinhVienSua.TinhTrang);

                    cmd.ExecuteNonQuery();

                    logger.LogInformation("Đang sửa thông tin sinh viên có mã sinh viên {0}", sinhVienSua.MaSinhVien);

                    return sinhvienDAL.LayToanBoSinhVien();
                }
            }
            catch (SqlException sqlEx)
            {
                string loiCuThe = PhanTichLoiSql(sqlEx, sinhVienSua.MaSinhVien);
                logger.LogCritical(sqlEx, "Lỗi cập nhật sinh viên: {0}", loiCuThe);
                throw new Exception(loiCuThe);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Xảy ra lỗi khi sửa sinh viên {0}: {1}", sinhVienSua.MaSinhVien, ex.Message);
                throw new Exception("Lỗi hệ thống khi cập nhật sinh viên: " + ex.Message);
            }
        }

        // 3. CHỨC NĂNG XÓA SINH VIÊN
        public DataTable XoaThongTinSinhVienTheoMaSinhVien(string maSinhVien)
        {
            try
            {
                using (SqlConnection conn = CosodulieuDAL.KetNoiCoSoDuLieu())
                {
                    SqlCommand cmd = new SqlCommand("DELETE SinhVien WHERE MASV = @MASV", conn);
                    cmd.Parameters.AddWithValue("@MASV", maSinhVien);

                    cmd.ExecuteNonQuery();

                    logger.LogInformation("Đang xóa sinh viên có mã sinh viên {0}", maSinhVien);

                    return sinhvienDAL.LayToanBoSinhVien();
                }
            }
            catch (SqlException sqlEx)
            {
                string thongBaoGoc = sqlEx.Message.ToLower();
                string loiCuThe;

                // Khi xóa, nếu sinh viên đã có bảng điểm thì SQL sẽ chặn theo ràng buộc khóa ngoại
                if (thongBaoGoc.Contains("foreign key") || thongBaoGoc.Contains("reference constraint"))
                {
                    loiCuThe = $"Không thể xóa sinh viên '{maSinhVien}' vì sinh viên này đã có dữ liệu điểm học tập!";
                }
                else
                {
                    loiCuThe = PhanTichLoiSql(sqlEx, maSinhVien);
                }

                logger.LogCritical(sqlEx, "Lỗi xóa sinh viên: {0}", loiCuThe);
                throw new Exception(loiCuThe);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Xảy ra lỗi khi xóa sinh viên {0}: {1}", maSinhVien, ex.Message);
                throw new Exception("Lỗi hệ thống khi xóa sinh viên: " + ex.Message);
            }
        }
    }
}