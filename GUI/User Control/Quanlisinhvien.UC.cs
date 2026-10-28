using System.Data;
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
                string maSinhVien = txbMasinhvien.Text.ToString();
                string hoVaTen = txbHovaten.Text.ToString();
                string lop = cbxLop.SelectedValue.ToString().Trim();
                DateTime ngaySinh = dtpNgaySinh.Value.Date;
                string gioiTinh = rbtnNam.Checked ? "Nam" : "Nữ";
                string nganhHoc = cbxChuyennganh.SelectedValue.ToString().Trim();
                string tinhTrang = cbxTinhtrang.Text.Trim();
                SinhvienDTO sinhvienMoi = new SinhvienDTO()
                {
                    MaSinhVien = maSinhVien,
                    HoVaTen = hoVaTen,
                    MaLop = lop,
                    NgaySinh = ngaySinh,
                    GioiTinh = gioiTinh,
                    MaNganh = nganhHoc,
                    TinhTrang = tinhTrang
                };
                DataTable dt = new DataTable();
                dt = quanlysinhvienBLL.ThemsinhvienMoi(sinhvienMoi);
                if (dt != null)
                {
                    drvDanhsachsinhvien.DataSource = dt;
                }
            }
            catch
            {
                MessageBox.Show("Lỗi khi thêm sinh viên mới.\nVui lòng thử lại sau.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string maSinhVien = txbMasinhvien.Text.ToString();
                DataTable dt = new DataTable();
                dt = quanlysinhvienBLL.XoaSinhVienTheoMaSinhVien(maSinhVien);
                drvDanhsachsinhvien.DataSource = dt;
            }
            catch
            {
                MessageBox.Show("Lỗi khi xóa sinh viên.\nVui lòng thử lại sau.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                string maSinhVien = txbMasinhvien.Text.ToString().Trim();
                string hoVaTen = txbHovaten.Text.ToString().Trim();
                string lop = cbxLop.SelectedValue.ToString().Trim();
                DateTime ngaySinh = dtpNgaySinh.Value.Date;
                string gioiTinh = rbtnNam.Checked ? "Nam" : "Nữ";
                string nganhHoc = cbxChuyennganh.SelectedValue.ToString().Trim();
                string tinhTrang = cbxTinhtrang.Text.Trim();
                SinhvienDTO sinhvienSua = new SinhvienDTO()
                {
                    MaSinhVien = maSinhVien,
                    HoVaTen = hoVaTen,
                    MaLop = lop,
                    NgaySinh = ngaySinh,
                    GioiTinh = gioiTinh,
                    MaNganh = nganhHoc,
                    TinhTrang = tinhTrang
                };
                DataTable dt = new DataTable();
                dt = quanlysinhvienBLL.SuaSinhVienTheoMaSinhVien(sinhvienSua);
                if (dt != null)
                {
                    drvDanhsachsinhvien.DataSource = dt;
                }
            }
            catch
            {
                MessageBox.Show("Lỗi khi sửa sinh viên.\nVui lòng thử lại sau.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
