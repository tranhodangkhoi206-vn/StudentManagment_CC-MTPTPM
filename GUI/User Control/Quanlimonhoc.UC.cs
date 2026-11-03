using System.Data;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Logging;
using StudentManagment.BLL;
using StudentManagment.DTO;

namespace StudentManagment.GUI.User_Control
{
    public partial class Quanlimonhoc : UserControl
    {
        private QuanlymonhocBLL quanlymonhocBLL;
        public Quanlimonhoc(ILoggerFactory loggerFactory)
        {
            InitializeComponent();
            quanlymonhocBLL = new QuanlymonhocBLL(loggerFactory);
        }

        private void Quanlimonhoc_Load(object sender, EventArgs e)
        {
            // Cài đặt ValueMember và DisplayMember TRƯỚC khi gán DataSource
            cbxChuyennganh.DisplayMember = "TENNGANH";
            cbxChuyennganh.ValueMember = "MANGANH";
            cbxChuyennganh.DataSource = quanlymonhocBLL.HienThiDanhSachNganhHocChoComboBox();
            cbxChuyennganh.SelectedIndex = -1;

            // Load dữ liệu lên DataGridView
            dgvDanhsachmonhoc.DataSource = quanlymonhocBLL.HienThiDanhSachMonHoc();

            nudLythuyet.Value = 1;
            nudThuchanh.Value = 1;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txbMamonhoc.Text) || string.IsNullOrWhiteSpace(txbTenmonhoc.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ Mã môn học và Tên môn học!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txbMamonhoc.Focus();
                    return;
                }
                MonhocDTO monhocDTO = new MonhocDTO()
                {
                    Mamon = txbMamonhoc.Text.Trim(),
                    Tenmon = txbTenmonhoc.Text.Trim(),
                    Manganh = cbxChuyennganh.SelectedValue?.ToString() ?? cbxChuyennganh.Text,
                    Sotietlythuyet = (int)nudLythuyet.Value,
                    Sotietthuchanh = (int)nudThuchanh.Value,
                    Giangvien = txbGiangvien.Text.Trim(),
                    Tinhtrang = cbxTinhtrang.Text.Trim()
                };
                DataTable dt = quanlymonhocBLL.ThemmonhocMoi(monhocDTO);
                if (dt != null && dt.Rows.Count >= 0)
                {
                    dgvDanhsachmonhoc.DataSource = dt;
                }
                MessageBox.Show($"Thêm môn học '{monhocDTO.Tenmon}' thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnLammoi_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi thêm môn học", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txbMamonhoc.Text))
                {
                    MessageBox.Show("Vui lòng chọn môn học cần sửa từ bảng danh sách!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                MonhocDTO monhocDTO = new MonhocDTO()
                {
                    Mamon = txbMamonhoc.Text.Trim(),
                    Tenmon = txbTenmonhoc.Text.Trim(),
                    Manganh = cbxChuyennganh.SelectedValue?.ToString() ?? cbxChuyennganh.Text,
                    Sotietlythuyet = (int)nudLythuyet.Value,
                    Sotietthuchanh = (int)nudThuchanh.Value,
                    Giangvien = txbGiangvien.Text.Trim(),
                    Tinhtrang = cbxTinhtrang.Text.Trim()
                };
                DataTable dt = quanlymonhocBLL.SuaMonHocTheoMaMonHoc(monhocDTO);
                if (dt != null && dt.Rows.Count >= 0)
                {
                    dgvDanhsachmonhoc.DataSource = dt;
                }
                MessageBox.Show($"Cập nhật môn học '{monhocDTO.Mamon}' thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnLammoi_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi sửa môn học", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txbMamonhoc.Text))
                {
                    MessageBox.Show("Vui lòng chọn môn học cần xóa từ bảng danh sách!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string maMon = txbMamonhoc.Text.Trim();
                string tenMon = txbTenmonhoc.Text.Trim();
                DialogResult result = MessageBox.Show(
                    $"Bạn có chắc chắn muốn xóa môn học '{tenMon}' (Mã: {maMon}) không?\nLưu ý: Không thể xóa nếu môn học đã có điểm sinh viên!",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2
                );
                if (result == DialogResult.Yes)
                {
                    DataTable dt = quanlymonhocBLL.XoaMonHocTheoMaMonHoc(maMon);
                    if (dt != null && dt.Rows.Count >= 0)
                    {
                        dgvDanhsachmonhoc.DataSource = dt;
                    }

                    MessageBox.Show($"Đã xóa thành công môn học '{maMon}'!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnLammoi_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi xóa môn học", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            txbMamonhoc.Clear();
            txbTenmonhoc.Clear();
            cbxChuyennganh.SelectedIndex = -1;
            nudLythuyet.Value = 0;
            nudThuchanh.Value = 0;
            txbGiangvien.Clear();
            cbxTinhtrang.SelectedIndex = -1;
            // Mở lại ô Mã môn học để người dùng có thể nhập môn mới
            txbMamonhoc.ReadOnly = false;
            txbMamonhoc.Focus();
        }

        private void dgvDanhsachmonhoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Bỏ qua nếu người dùng bấm vào hàng tiêu đề (header) hoặc ngoài vùng dữ liệu
            if (e.RowIndex < 0 || e.RowIndex >= dgvDanhsachmonhoc.Rows.Count)
            {
                return;
            }

            try
            {
                DataGridViewRow row = dgvDanhsachmonhoc.Rows[e.RowIndex];

                // Lấy DataRowView từ dòng đang chọn để trích xuất dữ liệu chuẩn theo tên cột CSDL
                if (row.DataBoundItem is DataRowView drv)
                {
                    // 1. Mã môn học
                    txbMamonhoc.Text = drv["MAMON"]?.ToString()?.Trim() ?? "";

                    // 2. Tên môn học
                    txbTenmonhoc.Text = drv["TENMON"]?.ToString()?.Trim() ?? "";

                    // 3. Tình trạng (Đang dạy / Ngừng dạy)
                    cbxTinhtrang.Text = drv["TINHTRANG"]?.ToString()?.Trim() ?? "";

                    // 4. Giảng viên
                    txbGiangvien.Text = drv["GIANGVIEN"]?.ToString()?.Trim() ?? "";

                    // 5. Chuyên ngành (gán SelectedValue theo ValueMember là MANGANH)
                    string maNganh = drv["MANGANH"]?.ToString()?.Trim() ?? "";
                    if (!string.IsNullOrEmpty(maNganh))
                    {
                        cbxChuyennganh.SelectedValue = maNganh;
                        // Nếu ComboBox chưa nạp kịp hoặc không tìm thấy Value tương ứng thì gán trực tiếp vào Text
                        if (cbxChuyennganh.SelectedIndex == -1)
                        {
                            cbxChuyennganh.Text = maNganh;
                        }
                    }
                    else
                    {
                        cbxChuyennganh.SelectedIndex = -1;
                    }

                    // 6. Tiết lý thuyết
                    if (decimal.TryParse(drv["SOTIETLYTHUYET"]?.ToString(), out decimal lt))
                    {
                        nudLythuyet.Value = Math.Max(nudLythuyet.Minimum, Math.Min(nudLythuyet.Maximum, lt));
                    }
                    else
                    {
                        nudLythuyet.Value = 0;
                    }

                    // 7. Tiết thực hành
                    if (decimal.TryParse(drv["SOTIETTHUCHANH"]?.ToString(), out decimal th))
                    {
                        nudThuchanh.Value = Math.Max(nudThuchanh.Minimum, Math.Min(nudThuchanh.Maximum, th));
                    }
                    else
                    {
                        nudThuchanh.Value = 0;
                    }
                }
                else
                {
                    // Fallback nếu không bind qua DataTable: đọc qua Name của DataGridViewColumn
                    txbMamonhoc.Text = row.Cells[0].Value?.ToString()?.Trim() ?? "";
                }

                // Khóa ô Mã môn để tránh người dùng sửa nhầm Khóa chính
                txbMamonhoc.ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hiển thị dữ liệu môn học: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
