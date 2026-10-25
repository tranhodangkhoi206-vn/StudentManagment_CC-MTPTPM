using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Microsoft.Extensions.Logging;
using static StudentManagment.StudentManagment_DAL;

namespace StudentManagment
{
    public partial class frmQuanLySinhVien : Form
    {
        private readonly ILogger<frmQuanLySinhVien> _log = Logging.For<frmQuanLySinhVien>();
        private readonly SinhVienDAL _dal = new SinhVienDAL();
        private readonly SinhVienBLL _bll = new SinhVienBLL();
        public frmQuanLySinhVien()
        {
            InitializeComponent();
            LoadDanhSachSinhVien();
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
        }
        private void LoadDanhSachSinhVien()
        {
            try
            {
                dataGridView1.DataSource = _dal.LayDanhSachSinhVien();
            }
            catch (Exception ex)
            {
                _log.LogError(ex, "Lỗi khi tải danh sách sinh viên lên DataGridView");
                MessageBox.Show("Không thể tải danh sách sinh viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Bỏ qua nếu click vào tiêu đề cột hoặc ngoài phạm vi dòng dữ liệu
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Bỏ qua dòng trống mới thêm (dòng dấu * cuối bảng)
                if (row.IsNewRow) return;

                // Đổ dữ liệu từ bảng lên các ô nhập liệu phía trên
                txbMSSV.Text = row.Cells["MSSV"].Value?.ToString() ?? "";
                txbHovaten.Text = row.Cells["HoTen"].Value?.ToString() ?? "";
                txbKhoa.Text = row.Cells["Khoa"].Value?.ToString() ?? "";
                txbLop.Text = row.Cells["Lop"].Value?.ToString() ?? "";
                txbDiem.Text = row.Cells["GPA"].Value?.ToString() ?? "";

                // Khóa ô MSSV không cho chỉnh sửa trực tiếp mã khóa chính
                txbMSSV.ReadOnly = true;
            }
        }
        

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string mssv = txbMSSV.Text.Trim();
            string hoTen = txbHovaten.Text.Trim();
            string lop = txbLop.Text.Trim();
            string khoa = txbKhoa.Text.Trim();
            string gpaText = txbDiem.Text.Trim();

            // 1. Ghi log mức DEBUG khi bắt đầu luồng xử lý
            _log.LogDebug("Bắt đầu xử lý thêm sinh viên với MSSV: {MSSV}", mssv);

            try
            {
                // Kiểm tra hợp lệ dữ liệu qua BLL
                _bll.KiemTraThongTinSinhVien(mssv, hoTen, lop, khoa, gpaText, out double gpa);

                // Khởi tạo DTO và gọi tầng DAL thực thi chèn CSDL
                SinhVienDTO sv = new SinhVienDTO(mssv, hoTen, khoa, lop, gpa);
                bool ketQua = _dal.ThemSinhVien(sv);

                if (ketQua)
                {
                    // 2. Ghi log mức INFORMATION khi thao tác lưu thành công
                    _log.LogInformation("Thêm sinh viên thành công: MSSV {MSSV}, Họ tên: {HoTen}, Lớp: {Lop}, Ngành: {Khoa}, GPA: {GPA}",
                        mssv, hoTen, lop, khoa, gpa);

                    MessageBox.Show("Thêm sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDanhSachSinhVien();
                    btnLamMoi_Click(sender, e);
                }
                else
                {
                    // Ghi log mức WARNING khi câu lệnh không tác động dòng nào
                    _log.LogWarning("Không thể lưu sinh viên vào cơ sở dữ liệu: MSSV {MSSV}", mssv);
                    MessageBox.Show("Thêm không thành công, vui lòng thử lại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            // 3. Bắt các lỗi nhập liệu đầu vào (Mức WARNING)
            catch (ArgumentOutOfRangeException ex)
            {
                _log.LogWarning("Dữ liệu điểm vượt biên cho phép: {Message}. Giá trị nhập: '{GPAInput}'", ex.Message, gpaText);
                MessageBox.Show(ex.Message, "Lỗi phạm vi điểm", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbDiem.Focus();
            }
            catch (FormatException ex)
            {
                _log.LogWarning("Sai định dạng số GPA: {Message}. Giá trị nhập: '{GPAInput}'", ex.Message, gpaText);
                MessageBox.Show("Điểm GPA phải là định dạng số hợp lệ (ví dụ: 3.5)!", "Lỗi định dạng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbDiem.Focus();
            }
            catch (ArgumentException ex)
            {
                _log.LogWarning("Dữ liệu đầu vào không hợp lệ: {Message}", ex.Message);
                MessageBox.Show(ex.Message, "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            // 4. Bắt lỗi SQL Server (Phân tách giữa lỗi trùng dữ liệu ERROR và sự cố máy chủ CRITICAL)
            catch (SqlException ex)
            {
                if (ex.Number == 2627 || ex.Number == 2601) // Mã lỗi trùng Primary Key
                {
                    // Mức ERROR: Lỗi vi phạm toàn vẹn dữ liệu
                    _log.LogError("Trùng khóa chính MSSV trong CSDL: {MSSV}. Chi tiết SQL: {Message}", mssv, ex.Message);
                    MessageBox.Show($"Mã số sinh viên '{mssv}' đã tồn tại trong hệ thống!", "Trùng khóa chính", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txbMSSV.Focus();
                }
                else
                {
                    // Mức CRITICAL: Lỗi mất kết nối, server chết hoặc timeout
                    _log.LogCritical(ex, "SỰ CỐ CƠ SỞ DỮ LIỆU NGHIÊM TRỌNG khi thêm MSSV {MSSV} (Mã lỗi SQL: {SqlCode}): {Message}", mssv, ex.Number, ex.Message);
                    MessageBox.Show("Lỗi kết nối hoặc thực thi cơ sở dữ liệu nghiêm trọng: " + ex.Message, "Lỗi kết nối CSDL", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            // 5. Bắt các ngoại lệ ngoài ý muốn khác (Mức CRITICAL cao nhất)
            catch (Exception ex)
            {
                _log.LogCritical(ex, "SỰ CỐ HỆ THỐNG KHÔNG XÁC ĐỊNH xảy ra khi thêm sinh viên MSSV {MSSV}", mssv);
                MessageBox.Show("Đã xảy ra sự cố nghiêm trọng không xác định: " + ex.Message, "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            string mssv = txbMSSV.Text.Trim();
            _log.LogDebug("Bắt đầu xử lý xóa sinh viên có MSSV: {MSSV}", mssv);

            if (string.IsNullOrWhiteSpace(mssv))
            {
                _log.LogWarning("Yêu cầu xóa không hợp lệ: Chưa chọn hoặc chưa nhập MSSV.");
                MessageBox.Show("Vui lòng chọn hoặc nhập MSSV của sinh viên cần xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dialogResult = MessageBox.Show($"Bạn có chắc chắn muốn xóa sinh viên MSSV: {mssv}?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult != DialogResult.Yes)
            {
                _log.LogInformation("Người dùng đã hủy thao tác xóa sinh viên MSSV: {MSSV}", mssv);
                return;
            }

            try
            {
                if (_bll.XoaSinhVien(mssv))
                {
                    _log.LogInformation("Đã xóa thành công sinh viên MSSV: {MSSV}", mssv);
                    MessageBox.Show("Xóa sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnLamMoi_Click(sender, e);
                    LoadDanhSachSinhVien();
                }
            }
            catch (KeyNotFoundException ex)
            {
                _log.LogError("Không tìm thấy sinh viên để xóa: {Message}", ex.Message);
                MessageBox.Show(ex.Message, "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentException ex)
            {
                _log.LogWarning("Lỗi tham số đầu vào khi xóa sinh viên: {Message}", ex.Message);
                MessageBox.Show(ex.Message, "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (SqlException ex)
            {
                _log.LogCritical(ex, "SỰ CỐ CSDL NGHIÊM TRỌNG khi xóa sinh viên MSSV {MSSV} (Mã lỗi: {SqlCode})", mssv, ex.Number);
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu nghiêm trọng!", "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            catch (Exception ex)
            {
                _log.LogCritical(ex, "SỰ CỐ HỆ THỐNG KHÔNG XÁC ĐỊNH khi xóa sinh viên MSSV {MSSV}", mssv);
                MessageBox.Show("Đã xảy ra sự cố nghiêm trọng không xác định trong ứng dụng!", "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string mssv = txbMSSV.Text.Trim();
            string hoTen = txbHovaten.Text.Trim();
            string lop = txbLop.Text.Trim();
            string khoa = txbKhoa.Text.Trim();
            string gpaText = txbDiem.Text.Trim();

            _log.LogDebug("Bắt đầu xử lý cập nhật thông tin sinh viên MSSV: {MSSV}", mssv);

            try
            {
                // ĐỐI CHIẾU CHÍNH XÁC THỨ TỰ: mssv -> hoTen -> lop -> khoa -> gpaText
                _bll.KiemTraThongTinSinhVien(mssv, hoTen, lop, khoa, gpaText, out double gpa);

                SinhVienDTO sv = new SinhVienDTO(mssv, hoTen, khoa, lop, gpa);

                if (_bll.SuaSinhVien(sv))
                {
                    _log.LogInformation("Cập nhật thành công sinh viên: MSSV {MSSV}, Họ tên: {HoTen}, Lớp: {Lop}, Ngành: {Khoa}, GPA: {GPA}",
                        mssv, hoTen, lop, khoa, gpa);

                    MessageBox.Show("Cập nhật thông tin sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDanhSachSinhVien();
                }
            }
            catch (KeyNotFoundException ex)
            {
                // Mức ERROR: Lỗi không tìm thấy đối tượng trong CSDL để sửa
                _log.LogError("Không tìm thấy sinh viên để cập nhật: {Message}", ex.Message);
                MessageBox.Show(ex.Message, "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentException ex)
            {
                _log.LogWarning("Dữ liệu nhập không hợp lệ khi sửa sinh viên: {Message}", ex.Message);
                MessageBox.Show(ex.Message, "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (FormatException ex)
            {
                _log.LogWarning("Sai định dạng số GPA khi sửa sinh viên: {Message}", ex.Message);
                MessageBox.Show("Điểm GPA phải là định dạng số hợp lệ!", "Lỗi định dạng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbDiem.Focus();
            }
            catch (SqlException ex)
            {
                _log.LogCritical(ex, "SỰ CỐ CSDL NGHIÊM TRỌNG khi cập nhật MSSV {MSSV} (Mã lỗi: {SqlCode})", mssv, ex.Number);
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu nghiêm trọng!", "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            catch (Exception ex)
            {
                _log.LogCritical(ex, "SỰ CỐ HỆ THỐNG KHÔNG XÁC ĐỊNH khi sửa sinh viên MSSV {MSSV}", mssv);
                MessageBox.Show("Đã xảy ra sự cố nghiêm trọng không xác định trong ứng dụng!", "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        // Mẫu khi muốn tạo log 
        // private readonly ILogger<LoginForm> _log = AppLogger.For<LoginForm>();
        //
        // private void btnLogin_Click(object sender, EventArgs e)
        // {
        //     _log.LogInformation("Đăng nhập với user {User}", txtUser.Text);
        // }
    }
}
