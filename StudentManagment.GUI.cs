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
        private void drvDanhSachSinhVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

            // Ghi log mức Debug khi bắt đầu thao tác
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
                    // Ghi log mức Information khi thành công
                    _log.LogInformation("Thêm sinh viên thành công: MSSV {MSSV}, Họ tên: {HoTen}, Lớp: {Lop}, Ngành: {Khoa}, GPA: {GPA}",
                                        mssv, hoTen, lop, khoa, gpa);

                    MessageBox.Show("Thêm sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDanhSachSinhVien();
                    btnLamMoi_Click(sender, e);
                }
                else
                {
                    _log.LogWarning("Không thể lưu sinh viên vào cơ sở dữ liệu: MSSV {MSSV}", mssv);
                    MessageBox.Show("Thêm không thành công, vui lòng thử lại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            // 1. Bắt lỗi vi phạm biên khoảng giá trị điểm (GPA < 0 hoặc > 4)
            catch (ArgumentOutOfRangeException ex)
            {
                _log.LogWarning("Dữ liệu điểm vượt biên cho phép: {Message}. Giá trị nhập: '{GPAInput}'", ex.Message, gpaText);
                MessageBox.Show(ex.Message, "Lỗi phạm vi điểm", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbDiem.Focus();
            }
            // 2. Bắt lỗi sai định dạng số
            catch (FormatException ex)
            {
                _log.LogWarning("Sai định dạng số GPA: {Message}. Giá trị nhập: '{GPAInput}'", ex.Message, gpaText);
                MessageBox.Show("Điểm GPA phải là định dạng số hợp lệ (ví dụ: 3.5)!", "Lỗi định dạng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbDiem.Focus();
            }
            // 3. Bắt lỗi dữ liệu rỗng hoặc sai quy định lớp/ngành
            catch (ArgumentException ex)
            {
                _log.LogWarning("Dữ liệu đầu vào không hợp lệ: {Message}", ex.Message);
                MessageBox.Show(ex.Message, "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            // 4. Bắt lỗi vi phạm khóa chính hoặc kết nối từ SQL Server
            catch (SqlException ex)
            {
                if (ex.Number == 2627 || ex.Number == 2601) // Mã lỗi trùng Primary Key
                {
                    _log.LogWarning("Trùng khóa chính MSSV trong CSDL: {MSSV}. Chi tiết SQL: {Message}", mssv, ex.Message);
                    MessageBox.Show($"Mã số sinh viên '{mssv}' đã tồn tại trong hệ thống!", "Trùng khóa chính", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txbMSSV.Focus();
                }
                else
                {
                    _log.LogError(ex, "Lỗi truy vấn SQL Server khi thêm MSSV {MSSV} (Mã lỗi SQL: {SqlCode})", mssv, ex.Number);
                    MessageBox.Show("Lỗi kết nối hoặc thực thi cơ sở dữ liệu: " + ex.Message, "Lỗi SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            // 5. Bắt các ngoại lệ ngoài ý muốn khác
            catch (Exception ex)
            {
                _log.LogError(ex, "Ngoại lệ không xác định xảy ra khi thêm sinh viên MSSV {MSSV}", mssv);
                MessageBox.Show("Đã xảy ra lỗi không xác định: " + ex.Message, "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {

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
