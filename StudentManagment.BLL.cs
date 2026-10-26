using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static StudentManagment.StudentManagment_DAL;

namespace StudentManagment
{
    public class SinhVienBLL
    {
        private readonly SinhVienDAL dal = new SinhVienDAL();
        public bool KiemTraThongTinSinhVien(string mssv, string hoTen, string lop, string khoa, string gpaText, out double gpa)
        {
            gpa = 0.0;
            // Chuẩn hóa: thay thế dấu phẩy ',' thành dấu chấm '.'
            gpaText = gpaText.Trim().Replace(',', '.');

            // 1. Kiểm tra MSSV
            if (string.IsNullOrWhiteSpace(mssv))
                throw new ArgumentException("Mã số sinh viên (MSSV) không được để trống!", nameof(mssv));

            // 2. Kiểm tra Họ và tên
            if (string.IsNullOrWhiteSpace(hoTen))
                throw new ArgumentException("Họ và tên sinh viên không được để trống!", nameof(hoTen));

            // 3. Kiểm tra Lớp: 'DH24CT', 'DH24CT1' hoặc 'DH24CT2'
            if (string.IsNullOrWhiteSpace(lop))
                throw new ArgumentException("Lớp không được để trống!", nameof(lop));

            lop = lop.Trim();
            if (lop != "DH24CT" && lop != "DH24CT1" && lop != "DH24CT2")
                throw new ArgumentException($"Lớp '{lop}' không hợp lệ. Chỉ chấp nhận DH24CT, DH24CT1 hoặc DH24CT2!", nameof(lop));

            // 4. Kiểm tra Khoa: Kỹ thuật phần mềm, An toàn thông tin, Trí tuệ nhân tạo
            if (string.IsNullOrWhiteSpace(khoa))
                throw new ArgumentException("Khoa/Ngành không được để trống!", nameof(khoa));

            khoa = khoa.Trim();
            if (khoa != "Kỹ thuật phần mềm" && khoa != "An toàn thông tin" && khoa != "Trí tuệ nhân tạo")
                throw new ArgumentException($"Ngành '{khoa}' không hợp lệ. Chỉ chấp nhận: Kỹ thuật phần mềm, An toàn thông tin hoặc Trí tuệ nhân tạo!", nameof(khoa));

            // 5. Kiểm tra định dạng điểm GPA (hỗ trợ cả dấu chấm '.' và dấu phẩy ',')
            if (string.IsNullOrWhiteSpace(gpaText))
                throw new ArgumentException("Điểm GPA không được để trống!", nameof(gpaText));

            string normalizedGpaText = gpaText.Trim().Replace(',', '.');
            if (!double.TryParse(normalizedGpaText, NumberStyles.Any, CultureInfo.InvariantCulture, out gpa))
                throw new FormatException($"Điểm GPA '{gpaText}' không đúng định dạng số!");

            // 6. Kiểm tra khoảng giá trị của GPA (0.0 - 4.0)
            if (gpa < 0.0 || gpa > 4.0)
                throw new ArgumentOutOfRangeException(nameof(gpa), "Điểm GPA phải nằm trong khoảng từ 0.0 đến 4.0!");

            // Ép kiểu an toàn với CultureInfo.InvariantCulture
            if (!double.TryParse(gpaText, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out gpa))
            {
                throw new ArgumentException("Điểm GPA phải là một số thực hợp lệ!", nameof(gpaText));
            }
            return true;
        }

        // Nghiệp vụ Sửa sinh viên: Bắt buộc sinh viên phải tồn tại
        public bool SuaSinhVien(SinhVienDTO sv)
        {
            if (!dal.KiemTraTonTai(sv.MSSV))
                throw new KeyNotFoundException($"Không tìm thấy sinh viên có MSSV: {sv.MSSV} để cập nhật!");

            return dal.Sua(sv);
        }

        // Nghiệp vụ Xóa sinh viên: Kiểm tra bỏ trống và kiểm tra tồn tại
        public bool XoaSinhVien(string mssv)
        {
            if (string.IsNullOrWhiteSpace(mssv))
                throw new ArgumentException("Mã số sinh viên (MSSV) cần xóa không được để trống!", nameof(mssv));

            mssv = mssv.Trim();
            if (!dal.KiemTraTonTai(mssv))
                throw new KeyNotFoundException($"Không tìm thấy sinh viên có MSSV: {mssv} để xóa!");

            return dal.Xoa(mssv);
        }

        // Nghiệp vụ Tìm kiếm sinh viên theo MSSV
        public DataTable SearchSinhVienByMSSV(string mssv)
        {
            // 1. Kiểm tra để trống
            if (string.IsNullOrWhiteSpace(mssv))
            {
                throw new ArgumentException("Mã số sinh viên (MSSV) không được để trống!", nameof(mssv));
            }

            mssv = mssv.Trim();

            // 2. Kiểm tra định dạng: 2 chữ 'SV' ở trước và 3 chữ số ở sau (Ví dụ: SV001, SV002, ...)
            if (!Regex.IsMatch(mssv, @"^SV\d{3}$"))
            {
                throw new ArgumentException("Mã số sinh viên (MSSV) không đúng định dạng! MSSV phải bắt đầu bằng 'SV' và theo sau là 3 chữ số (Ví dụ: SV001).", nameof(mssv));
            }

            // 3. Gọi tầng DAL để truy vấn dữ liệu
            return dal.SearchSinhVienByMSSV(mssv);
        }
    }
}
