using System.Data;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Logging;
using StudentManagment.BLL;
using StudentManagment.DTO;

namespace StudentManagment.GUI.User_Control
{
    public partial class Quanlidiem : UserControl
    {
        private readonly ILogger<Quanlidiem> logger;
        private QuanlydiemBLL quanlydiemBLL;
        public Quanlidiem(ILoggerFactory loggerFactory)
        {
            InitializeComponent();
            logger = loggerFactory.CreateLogger<Quanlidiem>();
            quanlydiemBLL = new QuanlydiemBLL(loggerFactory);
        }

        private double ParseDiem(string diemStr)
        {
            if (string.IsNullOrWhiteSpace(diemStr))
            {
                return -1; // Chưa nhập điểm
            }

            string str = diemStr.Trim().Replace(',', '.');
            if (double.TryParse(str, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out double diem))
            {
                if (diem < 0 || diem > 10)
                {
                    throw new ArgumentOutOfRangeException(nameof(diemStr), "Điểm số phải nằm trong khoảng từ 0 đến 10!");
                }
                return diem;
            }

            throw new FormatException("Điểm số phải là giá trị số hợp lệ!");
        }

        private void Quanlidiem_Load(object sender, EventArgs e)
        {
            dgvDanhsachmonhoc.DataSource = quanlydiemBLL.HienThiToanBoDiem();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string maSV = txbMasinhvien.Text.Trim();
                string maMon = txbMamonhoc.Text.Trim();

                if (string.IsNullOrWhiteSpace(maSV) || string.IsNullOrWhiteSpace(maMon))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ Mã sinh viên và Mã môn học!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DiemDTO diemDTO = new DiemDTO()
                {
                    Masinhvien = maSV,
                    Mamon = maMon,
                    Diemchuyencan = ParseDiem(txbDiemchuyencan.Text),
                    Diemgiuaky = ParseDiem(txbDiemgiuaky.Text),
                    Diemcuoiky = ParseDiem(txtDiemcuoiky.Text)
                };

                DataTable dt = quanlydiemBLL.ThemDiemMoi(diemDTO);
                if (dt != null)
                {
                    dgvDanhsachmonhoc.DataSource = dt;
                }

                MessageBox.Show($"Thêm điểm cho sinh viên '{maSV}' môn '{maMon}' thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnLammoi_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi thêm điểm", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string maSV = txbMasinhvien.Text.Trim();
                string maMon = txbMamonhoc.Text.Trim();

                if (string.IsNullOrWhiteSpace(maSV) || string.IsNullOrWhiteSpace(maMon))
                {
                    MessageBox.Show("Vui lòng chọn dữ liệu điểm cần xóa từ danh sách!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult result = MessageBox.Show(
                    $"Bạn có chắc chắn muốn xóa điểm môn '{maMon}' của sinh viên '{maSV}'?",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2
                );

                if (result == DialogResult.Yes)
                {
                    DataTable dt = quanlydiemBLL.XoaThongTinDiemTheoMaSinhVienVaMaMon(maSV, maMon);
                    if (dt != null)
                    {
                        dgvDanhsachmonhoc.DataSource = dt;
                    }

                    MessageBox.Show("Đã xóa bản ghi điểm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnLammoi_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi xóa điểm", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                string maSV = txbMasinhvien.Text.Trim();
                string maMon = txbMamonhoc.Text.Trim();

                if (string.IsNullOrWhiteSpace(maSV) || string.IsNullOrWhiteSpace(maMon))
                {
                    MessageBox.Show("Vui lòng chọn dòng điểm cần sửa từ danh sách!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DiemDTO diemDTO = new DiemDTO()
                {
                    Masinhvien = maSV,
                    Mamon = maMon,
                    Diemchuyencan = ParseDiem(txbDiemchuyencan.Text),
                    Diemgiuaky = ParseDiem(txbDiemgiuaky.Text),
                    Diemcuoiky = ParseDiem(txtDiemcuoiky.Text)
                };

                DataTable dt = quanlydiemBLL.SuaThongTinDiemTheoMaSinhVienVaMaMon(diemDTO);
                if (dt != null)
                {
                    dgvDanhsachmonhoc.DataSource = dt;
                }

                MessageBox.Show($"Cập nhật điểm thành công cho sinh viên '{maSV}'!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnLammoi_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi sửa điểm", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            txbMasinhvien.Clear();
            txbMamonhoc.Clear();
            txbDiemchuyencan.Clear();
            txbDiemgiuaky.Clear();
            txtDiemcuoiky.Clear();

            // Mở khóa lại 2 ô mã để người dùng có thể nhập mới
            txbMasinhvien.ReadOnly = false;
            txbMamonhoc.ReadOnly = false;
            txbMasinhvien.Focus();
        }

        private void dgvDanhsachmonhoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Bỏ qua nếu bấm vào tiêu đề cột hoặc ngoài vùng dữ liệu
            if (e.RowIndex < 0 || e.RowIndex >= dgvDanhsachmonhoc.Rows.Count)
            {
                return;
            }

            try
            {
                DataGridViewRow row = dgvDanhsachmonhoc.Rows[e.RowIndex];

                // Ép kiểu DataBoundItem để đọc an toàn qua tên cột dữ liệu hoặc chỉ số cột
                if (row.DataBoundItem is DataRowView drv)
                {
                    txbMasinhvien.Text = drv["MASV"]?.ToString()?.Trim() ?? drv[0]?.ToString()?.Trim() ?? "";
                    txbMamonhoc.Text = drv["MAMON"]?.ToString()?.Trim() ?? drv[1]?.ToString()?.Trim() ?? "";

                    // Xử lý điểm chuyên cần (-1 hoặc null thì để trống)
                    string cc = drv["DIEMCHUYENCAN"]?.ToString()?.Trim() ?? drv[2]?.ToString()?.Trim() ?? "";
                    txbDiemchuyencan.Text = (cc == "-1") ? "" : cc;

                    // Xử lý điểm giữa kỳ
                    string gk = drv["DIEMGIUAKY"]?.ToString()?.Trim() ?? drv[3]?.ToString()?.Trim() ?? "";
                    txbDiemgiuaky.Text = (gk == "-1") ? "" : gk;

                    // Xử lý điểm cuối kỳ
                    string ck = drv["DIEMCUOIKY"]?.ToString()?.Trim() ?? drv[4]?.ToString()?.Trim() ?? "";
                    txtDiemcuoiky.Text = (ck == "-1") ? "" : ck;
                }
                else
                {
                    // Dự phòng nếu không bind trực tiếp qua DataRowView
                    txbMasinhvien.Text = row.Cells[0].Value?.ToString()?.Trim() ?? "";
                    txbMamonhoc.Text = row.Cells[1].Value?.ToString()?.Trim() ?? "";

                    string cc = row.Cells[2].Value?.ToString()?.Trim() ?? "";
                    txbDiemchuyencan.Text = (cc == "-1") ? "" : cc;

                    string gk = row.Cells[3].Value?.ToString()?.Trim() ?? "";
                    txbDiemgiuaky.Text = (gk == "-1") ? "" : gk;

                    string ck = row.Cells[4].Value?.ToString()?.Trim() ?? "";
                    txtDiemcuoiky.Text = (ck == "-1") ? "" : ck;
                }

                // Khóa mã sinh viên và mã môn khi đang xem/sửa, tránh sửa nhầm khóa chính kép
                txbMasinhvien.ReadOnly = true;
                txbMamonhoc.ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hiển thị dữ liệu điểm: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


    }
}

