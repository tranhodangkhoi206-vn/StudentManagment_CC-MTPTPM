using System;
using System.Data;
using System.Drawing;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Logging;
using StudentManagment.BLL;
using StudentManagment.DTO;

namespace StudentManagment.GUI.User_Control
{
    public partial class Quanlisinhvien : UserControl
    {
        private QuanlysinhvienBLL quanlysinhvienBLL;
        public Quanlisinhvien(ILoggerFactory loggerFactory)
        {
            InitializeComponent();
            quanlysinhvienBLL = new QuanlysinhvienBLL(loggerFactory);
        }

        private void Quanlisinhvien_Load(object sender, EventArgs e)
        {
            cbxChuyennganh.DisplayMember = "TENNGANH";
            cbxChuyennganh.ValueMember = "MANGANH";
            cbxChuyennganh.DataSource = quanlysinhvienBLL.HienThiDanhSachNganhHocChoComboBox();
            cbxLop.DisplayMember = "TENLOP";
            cbxLop.ValueMember = "MALOP";
            cbxLop.DataSource = quanlysinhvienBLL.HienThiDanhSachLopChoComboBox();
            drvDanhsachsinhvien.DataSource = quanlysinhvienBLL.HienThiDanhSachSinhVien();
            cbxChuyennganh.SelectedIndex = -1;
            cbxLop.SelectedIndex = -1;
            rbtnNam.Checked = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Kiểm tra không để trống ô nhập
                if (string.IsNullOrWhiteSpace(txbMasinhvien.Text))
                {
                    MessageBox.Show("Vui lòng nhập Mã sinh viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txbMasinhvien.Focus();
                    return;
                }

                SinhvienDTO sv = new SinhvienDTO()
                {
                    MaSinhVien = txbMasinhvien.Text.Trim(),
                    HoVaTen = txbHovaten.Text.Trim(),
                    MaLop = cbxLop.SelectedValue?.ToString() ?? cbxLop.Text,
                    NgaySinh = dtpNgaySinh.Value,
                    GioiTinh = rbtnNam.Checked ? "Nam" : "Nữ",
                    MaNganh = cbxChuyennganh.SelectedValue?.ToString() ?? cbxChuyennganh.Text,
                    TinhTrang = cbxTinhtrang.Text
                };

                quanlysinhvienBLL.ThemsinhvienMoi(sv);

                // Thông báo thành công
                MessageBox.Show("Thêm sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Nạp lại dữ liệu lên DataGridView theo đúng tên biến của nhóm trưởng
                drvDanhsachsinhvien.DataSource = quanlysinhvienBLL.HienThiDanhSachSinhVien();
            }
            catch (Exception ex)
            {
                // Hiển thị trực tiếp câu lỗi chi tiết đã được dịch nghĩa từ DAL
                MessageBox.Show(ex.Message, "Lỗi thêm sinh viên", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Kiểm tra đã chọn mã sinh viên cần xóa chưa
                if (string.IsNullOrWhiteSpace(txbMasinhvien.Text))
                {
                    MessageBox.Show("Vui lòng chọn sinh viên cần xóa từ danh sách!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string maSV = txbMasinhvien.Text.Trim();
                string hoTen = txbHovaten.Text.Trim();

                // 2. Hộp thoại xác nhận trước khi thực hiện thao tác xóa
                DialogResult dialog = MessageBox.Show(
                    $"Bạn có chắc chắn muốn xóa sinh viên '{hoTen}' (Mã: {maSV}) không?\nThao tác này sẽ không thể khôi phục!",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2
                );

                if (dialog == DialogResult.Yes)
                {
                    // 3. Gọi hàm BLL đúng tên trong Quanlysinhvien.BLL.cs
                    quanlysinhvienBLL.XoaSinhVienTheoMaSinhVien(maSV);

                    // 4. Thông báo xóa thành công
                    MessageBox.Show($"Đã xóa sinh viên '{maSV}' thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // 5. Làm trống các trường nhập liệu và nạp lại bảng
                    txbMasinhvien.Clear();
                    txbHovaten.Clear();
                    cbxLop.SelectedIndex = -1;
                    cbxChuyennganh.SelectedIndex = -1;
                    cbxTinhtrang.SelectedIndex = -1;
                    rbtnNam.Checked = true;

                    drvDanhsachsinhvien.DataSource = quanlysinhvienBLL.HienThiDanhSachSinhVien();
                }
            }
            catch (Exception ex)
            {
                // Hiển thị thông báo khi có lỗi ràng buộc khóa ngoại (sinh viên đã có bảng điểm) hoặc lỗi SQL
                MessageBox.Show(ex.Message, "Lỗi xóa sinh viên", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Kiểm tra mã sinh viên không được để trống
                if (string.IsNullOrWhiteSpace(txbMasinhvien.Text))
                {
                    MessageBox.Show("Vui lòng chọn hoặc nhập Mã sinh viên cần sửa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txbMasinhvien.Focus();
                    return;
                }

                // 2. Gom dữ liệu cập nhật vào DTO
                SinhvienDTO sv = new SinhvienDTO()
                {
                    MaSinhVien = txbMasinhvien.Text.Trim(),
                    HoVaTen = txbHovaten.Text.Trim(),
                    MaLop = cbxLop.SelectedValue?.ToString() ?? cbxLop.Text,
                    NgaySinh = dtpNgaySinh.Value,
                    GioiTinh = rbtnNam.Checked ? "Nam" : "Nữ",
                    MaNganh = cbxChuyennganh.SelectedValue?.ToString() ?? cbxChuyennganh.Text,
                    TinhTrang = cbxTinhtrang.Text
                };

                // 3. Gọi hàm BLL qua biến instance quanlysinhvienBLL (tránh lỗi CS0120)
                quanlysinhvienBLL.SuaSinhVienTheoMaSinhVien(sv);

                // 4. Thông báo thành công và làm mới bảng dữ liệu
                MessageBox.Show($"Cập nhật thông tin sinh viên '{sv.MaSinhVien}' thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                drvDanhsachsinhvien.DataSource = quanlysinhvienBLL.HienThiDanhSachSinhVien();
            }
            catch (Exception ex)
            {
                // Hiển thị trực tiếp lỗi đã được DAL/BLL phân tích
                MessageBox.Show(ex.Message, "Lỗi cập nhật sinh viên", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            txbMasinhvien.Text = "";
            txbHovaten.Text = "";
            cbxLop.SelectedIndex = -1;
            dtpNgaySinh.Value = DateTime.Today.Date;
            rbtnNam.Checked = true;
            cbxChuyennganh.SelectedIndex = -1;
            cbxTinhtrang.SelectedIndex = -1;
        }

        private void drvDanhsachsinhvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Bỏ qua nếu người dùng bấm vào hàng tiêu đề (Header row)
            if (e.RowIndex < 0 || e.RowIndex >= drvDanhsachsinhvien.Rows.Count)
            {
                return;
            }

            try
            {
                DataGridViewRow row = drvDanhsachsinhvien.Rows[e.RowIndex];

                // 1. Gán Mã sinh viên và Họ tên
                txbMasinhvien.Text = row.Cells[0].Value?.ToString() ?? "";
                txbHovaten.Text = row.Cells[1].Value?.ToString() ?? "";

                // 2. Gán ComboBox Lớp (tìm theo giá trị hoặc mã hiển thị)
                string maLop = row.Cells[2].Value?.ToString() ?? "";
                if (cbxLop.DataSource != null)
                {
                    cbxLop.SelectedValue = maLop;
                }
                else
                {
                    cbxLop.Text = maLop;
                }

                // 3. Gán Ngày sinh (kiểm tra parse ngày hợp lệ)
                if (DateTime.TryParse(row.Cells[3].Value?.ToString(), out DateTime ngaySinh))
                {
                    dtpNgaySinh.Value = ngaySinh;
                }

                // 4. Gán Giới tính vào RadioButton
                string gioiTinh = row.Cells[4].Value?.ToString() ?? "";
                if (gioiTinh.Trim().Equals("Nam", StringComparison.OrdinalIgnoreCase))
                {
                    rbtnNam.Checked = true;
                }
                else
                {
                    rbtnNam.Checked = false; 
                }

                // 5. Gán ComboBox Chuyên ngành
                string maNganh = row.Cells[5].Value?.ToString() ?? "";
                if (cbxChuyennganh.DataSource != null)
                {
                    cbxChuyennganh.SelectedValue = maNganh;
                }
                else
                {
                    cbxChuyennganh.Text = maNganh;
                }

                // 6. Gán Tình trạng học tập
                cbxTinhtrang.Text = row.Cells[6].Value?.ToString() ?? "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hiển thị chi tiết sinh viên: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
