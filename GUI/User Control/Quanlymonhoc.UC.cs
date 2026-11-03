using System.Data;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Logging;
using StudentManagment.BLL;
using StudentManagment.DTO;

namespace StudentManagment.GUI.User_Control
{
    public partial class Quanlymonhoc : UserControl
    {
        private QuanlymonhocBLL quanlymonhocBLL;
        public Quanlymonhoc(ILoggerFactory loggerFactory)
        {
            InitializeComponent();
            quanlymonhocBLL = new QuanlymonhocBLL(loggerFactory);
        }

        private void Quanlymonhoc_Load(object sender, EventArgs e)
        {
            cbManganh.DisplayMember = "TENNGANH";
            cbManganh.ValueMember = "MANGANH";
            cbManganh.DataSource = quanlymonhocBLL.HienThiDanhSachNganhHocChoComboBox();
            dgvMonhoc.DataSource = quanlymonhocBLL.HienThiDanhSachMonHoc();
            nudLythuyet.Value = 1;
            nudThuchanh.Value = 1;
            cbManganh.SelectedIndex = -1;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                MonhocDTO monhocDTO = new MonhocDTO()
                {
                    Mamon = tbMamonhoc.Text.Trim(),
                    Tenmon = tbTenmonhoc.Text.Trim(),
                    Manganh = cbManganh.SelectedValue != null ? cbManganh.SelectedValue.ToString().Trim() : "",
                    Sotietlythuyet = (int)nudLythuyet.Value,
                    Sotietthuchanh = (int)nudThuchanh.Value,
                    Giangvien = tbGiangvien.Text.Trim(),
                    Tinhtrang = cbTinhtrang.Text.Trim()
                };
                DataTable dt = quanlymonhocBLL.ThemmonhocMoi(monhocDTO);
                if (dt.Rows.Count != 0)
                {
                    dgvMonhoc.DataSource = dt;
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Xảy ra lỗi cơ sở dữ liệu khi thêm môn học mới.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin môn học khi thêm môn học.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Thêm không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Xảy ra lỗi khi thêm môn học.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                MonhocDTO monhocDTO = new MonhocDTO()
                {
                    Mamon = tbMamonhoc.Text.Trim(),
                    Tenmon = tbTenmonhoc.Text.Trim(),
                    Manganh = cbManganh.SelectedValue != null ? cbManganh.SelectedValue.ToString().Trim() : "",
                    Sotietlythuyet = (int)nudLythuyet.Value,
                    Sotietthuchanh = (int)nudThuchanh.Value,
                    Giangvien = tbGiangvien.Text.Trim(),
                    Tinhtrang = cbTinhtrang.Text.Trim()
                };
                DataTable dt = quanlymonhocBLL.SuaMonHocTheoMaMonHoc(monhocDTO);
                if (dt.Rows.Count != 0)
                {
                    dgvMonhoc.DataSource = dt;
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Xảy ra lỗi cơ sở dữ liệu khi sửa môn học mới.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin môn học khi sửa môn học.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Mã môn học không tồn tại.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Xảy ra lỗi khi sửa môn học.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string maMon = tbMamonhoc.Text.ToString().Trim();
                DataTable dt = quanlymonhocBLL.XoaMonHocTheoMaMonHoc(maMon);
                if (dt.Rows.Count != 0)
                {
                    dgvMonhoc.DataSource = dt;
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Xảy ra lỗi cơ sở dữ liệu khi xóa môn học mới.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin môn học khi xóa môn học.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Mã môn học không tồn tại.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Xảy ra lỗi khi xóa môn học.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDondep_Click(object sender, EventArgs e)
        {
            tbMamonhoc.Text = "";
            tbTenmonhoc.Text = "";
            cbManganh.SelectedIndex = -1;
            nudLythuyet.Value = 1;
            nudThuchanh.Value = 1;
            tbGiangvien.Text = "";
            cbTinhtrang.SelectedIndex = -1;
            dgvMonhoc.DataSource = quanlymonhocBLL.HienThiDanhSachMonHoc();
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            try
            {
                string maMon = tbMamonhoc.Text.ToString().Trim();
                DataTable dt = quanlymonhocBLL.TimKiemMonHocTheoMaMon(maMon);
                if (dt.Rows.Count != 0)
                {
                    dgvMonhoc.DataSource = dt;
                }
                else
                {
                    dgvMonhoc.DataSource = quanlymonhocBLL.HienThiDanhSachMonHoc();
                    MessageBox.Show("Môn học không tồn tại.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Xảy ra lỗi cơ sở dữ liệu khi tìm kiếm môn học.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Bạn phải nhập mã môn học trước khi tìm kiếm môn học.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Mã môn học không tồn tại.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Xảy ra lỗi khi tìm kiếm môn học.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
