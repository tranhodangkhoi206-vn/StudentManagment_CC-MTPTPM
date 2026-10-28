using System.Data;
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
            cbxChuyennganh.DisplayMember = "TENNGANH";
            cbxChuyennganh.ValueMember = "MANGANH";
            cbxChuyennganh.DataSource = quanlymonhocBLL.HienThiDanhSachNganhHocChoComboBox();
            dgvDanhsachmonhoc.DataSource = quanlymonhocBLL.HienThiDanhSachMonHoc();
            nudLythuyet.Value = 1;
            nudThuchanh.Value = 1;
            cbxChuyennganh.SelectedIndex = -1;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string maMon = txbMamonhoc.Text.Trim();
                string tenMon = txbTenmonhoc.Text.Trim();
                string nganhHoc = cbxChuyennganh.SelectedValue.ToString().Trim();
                int tietLyThuyet = ((int)nudLythuyet.Value);
                int tietThucHanh = ((int)nudThuchanh.Value);
                string giangVien = txbGiangvien.Text.Trim();
                string tinhTrang = cbxTinhtrang.Text.Trim();
                MonhocDTO monhocDTO = new MonhocDTO()
                {
                    Mamon = maMon,
                    Tenmon = tenMon,
                    Manganh = nganhHoc,
                    Sotietlythuyet = tietLyThuyet,
                    Sotietthuchanh = tietThucHanh,
                    Giangvien = giangVien,
                    Tinhtrang = tinhTrang
                };
                DataTable dt = new DataTable();
                dt = quanlymonhocBLL.ThemmonhocMoi(monhocDTO);
                dgvDanhsachmonhoc.DataSource = dt;
            }
            catch
            {
                MessageBox.Show("Lỗi khi thêm môn học mới.\nVui lòng thử lại sau.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                string maMon = txbMamonhoc.Text.Trim();
                string tenMon = txbTenmonhoc.Text.Trim();
                string nganhHoc = cbxChuyennganh.SelectedValue.ToString().Trim();
                int tietLyThuyet = ((int)nudLythuyet.Value);
                int tietThucHanh = ((int)nudThuchanh.Value);
                string giangVien = txbGiangvien.Text.Trim();
                string tinhTrang = cbxTinhtrang.Text.Trim();
                MonhocDTO monhocDTO = new MonhocDTO()
                {
                    Mamon = maMon,
                    Tenmon = tenMon,
                    Manganh = nganhHoc,
                    Sotietlythuyet = tietLyThuyet,
                    Sotietthuchanh = tietThucHanh,
                    Giangvien = giangVien,
                    Tinhtrang = tinhTrang
                };
                DataTable dt = new DataTable();
                dt = quanlymonhocBLL.SuaMonHocTheoMaMonHoc(monhocDTO);
                dgvDanhsachmonhoc.DataSource = dt;
            }
            catch
            {
                MessageBox.Show("Lỗi khi sửa môn học mới.\nVui lòng thử lại sau.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string maMon = txbMamonhoc.Text.ToString().Trim();
                DataTable dt = new DataTable();
                dt = quanlymonhocBLL.XoaMonHocTheoMaMonHoc(maMon);
                dgvDanhsachmonhoc.DataSource = dt;
            }
            catch
            {
                MessageBox.Show("Lỗi khi xóa môn học.\nVui lòng thử lại sau.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            txbMamonhoc.Text = "";
            txbTenmonhoc.Text = "";
            cbxChuyennganh.SelectedIndex = -1;
            nudLythuyet.Value = 1;
            nudThuchanh.Value =1;
            txbGiangvien.Text = "";
            cbxTinhtrang.SelectedIndex = -1;
        }
    }
}
