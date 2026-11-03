using Microsoft.Extensions.Logging;
using StudentManagment.BLL;
using StudentManagment.DTO;

namespace StudentManagment.GUI.User_Control
{
    public partial class Quanlinganhhoc : UserControl
    {
        private readonly ILogger<Quanlinganhhoc> logger;
        private readonly QuanlynganhhocBLL quanlynganhhocBLL;

        public Quanlinganhhoc(ILoggerFactory loggerFactory)
        {
            InitializeComponent();
            logger = loggerFactory.CreateLogger<Quanlinganhhoc>();
            quanlynganhhocBLL = new QuanlynganhhocBLL(loggerFactory);
        }

        // Tải danh sách khi mở giao diện
        private void Quanlinganhhoc_Load(object sender, EventArgs e)
        {
            LoadDanhSachNganh();
        }

        private void LoadDanhSachNganh()
        {
            try
            {
                dgvDanhsachnganhoc.DataSource = quanlynganhhocBLL.HienThiToanBoNganhHoc();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể tải danh sách ngành học: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 1. CHỨC NĂNG THÊM NGÀNH HỌC
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra dữ liệu đầu vào cơ bản
                if (string.IsNullOrWhiteSpace(txbManganh.Text) ||
                    string.IsNullOrWhiteSpace(txbTennganh.Text) ||
                    string.IsNullOrWhiteSpace(txbKhoa.Text))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ Mã ngành, Tên ngành và Khoa quản lý!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                NganhhocDTO nganhhoc = new NganhhocDTO()
                {
                    Manganh = txbManganh.Text.Trim(),
                    Tennganh = txbTennganh.Text.Trim(),
                    Khoaquanly = txbKhoa.Text.Trim()
                };

                // Gọi BLL thêm mới
                quanlynganhhocBLL.ThemNganhMoi(nganhhoc);

                // Thông báo thành công và nạp lại bảng
                MessageBox.Show($"Thêm ngành học '{nganhhoc.Tennganh}' thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDanhSachNganh();
                LamMoiForm();
            }
            catch (Exception ex)
            {
                // Hiển thị nội dung lỗi thực tế thay vì gán cứng
                MessageBox.Show(ex.Message, "Lỗi thêm ngành học", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 2. CHỨC NĂNG SỬA NGÀNH HỌC
        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txbManganh.Text))
                {
                    MessageBox.Show("Vui lòng chọn ngành học cần sửa từ danh sách!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txbTennganh.Text) || string.IsNullOrWhiteSpace(txbKhoa.Text))
                {
                    MessageBox.Show("Tên ngành và Khoa quản lý không được để trống!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                NganhhocDTO nganhhoc = new NganhhocDTO()
                {
                    Manganh = txbManganh.Text.Trim(),
                    Tennganh = txbTennganh.Text.Trim(),
                    Khoaquanly = txbKhoa.Text.Trim()
                };

                quanlynganhhocBLL.SuaThongTinNganhTheoMaNganh(nganhhoc);

                MessageBox.Show($"Cập nhật ngành học '{nganhhoc.Manganh}' thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDanhSachNganh();
                LamMoiForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi cập nhật ngành học", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 3. CHỨC NĂNG XÓA NGÀNH HỌC
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txbManganh.Text))
                {
                    MessageBox.Show("Vui lòng chọn ngành học cần xóa từ danh sách!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string maNganh = txbManganh.Text.Trim();
                string tenNganh = txbTennganh.Text.Trim();

                DialogResult result = MessageBox.Show(
                    $"Bạn có chắc chắn muốn xóa ngành '{tenNganh}' (Mã: {maNganh}) không?\nLưu ý: Không thể xóa nếu ngành đã có sinh viên đang theo học!",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2
                );

                if (result == DialogResult.Yes)
                {
                    quanlynganhhocBLL.XoaThongTinNganhTheoMaNganh(maNganh);

                    MessageBox.Show($"Đã xóa thành công ngành học '{maNganh}'!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDanhSachNganh();
                    LamMoiForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi xóa ngành học", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 4. CHỨC NĂNG LÀM MỚI
        private void LamMoiForm()
        {
            txbManganh.Clear();
            txbTennganh.Clear();
            txbKhoa.Clear();
            txbManganh.ReadOnly = false;
            txbManganh.Focus();
        }

        // Sự kiện click nút Làm mới trên giao diện (ví dụ tên nút là btnLamMoi)
        private void btnLammoi_Click(object sender, EventArgs e)
        {
            LamMoiForm();
            LoadDanhSachNganh();
        }

        // 5. ĐỔ DỮ LIỆU TỪ BẢNG LÊN CÁC Ô NHẬP LIỆU KHI CLICK DÒNG
        private void dgvDanhsachnganhoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dgvDanhsachnganhoc.Rows.Count) return;

            try
            {
                DataGridViewRow row = dgvDanhsachnganhoc.Rows[e.RowIndex];
                txbManganh.Text = row.Cells[0].Value?.ToString() ?? "";
                txbTennganh.Text = row.Cells[1].Value?.ToString() ?? "";
                txbKhoa.Text = row.Cells[2].Value?.ToString() ?? "";

                // Khóa ô mã ngành khi đang chọn dòng để sửa, tránh sửa nhầm khóa chính
                txbManganh.ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hiển thị dữ liệu: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvDanhsachnganhoc_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            // Bỏ qua nếu người dùng click vào hàng tiêu đề (header) hoặc click ra ngoài vùng dữ liệu
            if (e.RowIndex < 0 || e.RowIndex >= dgvDanhsachnganhoc.Rows.Count)
            {
                return;
            }

            try
            {
                // Lấy hàng hiện tại được chọn
                DataGridViewRow row = dgvDanhsachnganhoc.Rows[e.RowIndex];

                // Lấy giá trị theo chỉ số cột (0: Mã ngành, 1: Tên ngành, 2: Khoa quản lý)
                txbManganh.Text = row.Cells[0].Value?.ToString() ?? "";
                txbTennganh.Text = row.Cells[1].Value?.ToString() ?? "";
                txbKhoa.Text = row.Cells[2].Value?.ToString() ?? "";

                // Khóa không cho sửa Mã ngành vì đây là Khóa chính (Primary Key)
                txbManganh.ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hiển thị chi tiết ngành học: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}