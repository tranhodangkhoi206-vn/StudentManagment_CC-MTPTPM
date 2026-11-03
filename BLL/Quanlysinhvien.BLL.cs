using System.Data;
using System.Globalization;
using System.Text.RegularExpressions;
using Microsoft.Extensions.Logging;
using StudentManagment.DAL;
using StudentManagment.DAL.Util;
using StudentManagment.DTO;


namespace StudentManagment.BLL
{
    public class QuanlysinhvienBLL
    {
        private readonly ILogger<QuanlysinhvienBLL> logger;
        private SinhvienDAL sinhvienDAL;
        private QuanlysinhvienDAL quanlysinhvienDAL;
        private NganhhocDAL nganhhocDAL;
        private LopDAL lopDAL;
        public QuanlysinhvienBLL(ILoggerFactory loggerFactory)
        {
            logger = loggerFactory.CreateLogger<QuanlysinhvienBLL>();
            sinhvienDAL = new SinhvienDAL(loggerFactory);
            quanlysinhvienDAL = new QuanlysinhvienDAL(loggerFactory);
            nganhhocDAL = new NganhhocDAL(loggerFactory);
            lopDAL = new LopDAL(loggerFactory);
        }

        // Constructor rỗng phục vụ Unit Test và gọi nội bộ
        public QuanlysinhvienBLL()
        {

        }
        public DataTable HienThiDanhSachSinhVien()
        {
            return sinhvienDAL.LayToanBoSinhVien();
        }
        public DataTable HienThiDanhSachNganhHocChoComboBox()
        {
            return nganhhocDAL.LayToanBoNganhHocChoComboBox();
        }
        public DataTable HienThiDanhSachLopChoComboBox()
        {
            return lopDAL.LayToanBoLopChoComboBox();
        }
        public DataTable ThemsinhvienMoi(SinhvienDTO sinhvienSua)
        {
            if (
                string.IsNullOrEmpty(sinhvienSua.HoVaTen) ||
                string.IsNullOrEmpty(sinhvienSua.MaSinhVien) ||
                string.IsNullOrEmpty(sinhvienSua.MaLop) ||
                string.IsNullOrEmpty(sinhvienSua.MaNganh) ||
                string.IsNullOrEmpty(sinhvienSua.GioiTinh) ||
                string.IsNullOrEmpty(sinhvienSua.TinhTrang)
            )
            {
                logger.LogWarning("Người dùng chưa nhập đầy đủ thông tin khi thêm sinh viên.");
                throw new ArgumentException("Vui lòng điền đầy đủ tất cả các trường thông tin của sinh viên!");
            }
            return quanlysinhvienDAL.ThemsinhVienMoi(sinhvienSua);
        }
        public DataTable SuaSinhVienTheoMaSinhVien(SinhvienDTO sinhvienSua)
        {
            if (
                string.IsNullOrEmpty(sinhvienSua.MaSinhVien)
            )
            {
                logger.LogWarning("Người dùng chưa nhập mã sinh viên khi sửa thông tin sinh viên.");
                throw new ArgumentException();
            }
            return quanlysinhvienDAL.SuaThongTinSinhVienTheoMaSinhVien(sinhvienSua);
        }
        public DataTable XoaSinhVienTheoMaSinhVien(string maSinhVien)
        {
            if (string.IsNullOrEmpty(maSinhVien))
            {
                logger.LogWarning("Người dùng chưa nhập mã sinh viên khi xóa sinh viên ra khỏi danh sách.");
                throw new ArgumentException();
            }
            return quanlysinhvienDAL.XoaThongTinSinhVienTheoMaSinhVien(maSinhVien);
        }

        // Phương thức kiểm tra hợp lệ thông tin sinh viên cho Unit Test và GUI
        public bool KiemTraThongTinSinhVien(string maSV, string hoTen, string lop, string nganh, string gpaStr, out double gpa)
        {
            gpa = 0.0;

            // 1. Kiểm tra Mã sinh viên
            if (string.IsNullOrWhiteSpace(maSV))
            {
                throw new ArgumentException("Mã số sinh viên không được để trống!");
            }
            if (!Regex.IsMatch(maSV.Trim(), @"^SV\d{3}$"))
            {
                throw new ArgumentException("Mã số sinh viên không đúng định dạng (phải bắt đầu bằng SV và 3 chữ số)!");
            }

            // 2. Kiểm tra Họ tên
            if (string.IsNullOrWhiteSpace(hoTen))
            {
                throw new ArgumentException("Họ và tên sinh viên không được để trống!");
            }

            // 3. Kiểm tra Lớp (DH24CT, DH24CT1, DH24CT2)
            string lopChuanHoa = lop?.Trim() ?? "";
            if (lopChuanHoa != "DH24CT" && lopChuanHoa != "DH24CT1" && lopChuanHoa != "DH24CT2")
            {
                throw new ArgumentException("Lớp không hợp lệ theo quy định!");
            }

            // 4. Kiểm tra Ngành
            string nganhChuanHoa = nganh?.Trim().ToLower() ?? "";
            if (nganhChuanHoa != "kỹ thuật phần mềm" &&
                nganhChuanHoa != "an toàn thông tin" &&
                nganhChuanHoa != "trí tuệ nhân tạo")
            {
                throw new ArgumentException("Chuyên ngành không thuộc danh mục hợp lệ!");
            }

            // 5. Kiểm tra GPA để trống
            if (string.IsNullOrWhiteSpace(gpaStr))
            {
                throw new ArgumentException("Điểm GPA không được để trống!");
            }

            // 6. Xử lý chuẩn hóa số thực (chấp nhận cả dấu phẩy và chấm)
            string gpaFormatted = gpaStr.Trim().Replace(',', '.');
            if (!double.TryParse(gpaFormatted, NumberStyles.Any, CultureInfo.InvariantCulture, out double parsedGpa))
            {
                throw new FormatException("Điểm GPA phải là định dạng số hợp lệ!");
            }

            // 7. Kiểm tra thang điểm [0.0 - 4.0]
            if (parsedGpa < 0.0 || parsedGpa > 4.0)
            {
                throw new ArgumentOutOfRangeException(nameof(gpaStr), "Điểm GPA phải nằm trong khoảng từ 0.0 đến 4.0!");
            }

            gpa = parsedGpa;
            return true;
        }
    }
}
