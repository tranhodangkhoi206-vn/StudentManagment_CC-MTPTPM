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
                MonhocDTO monhocDTO = new MonhocDTO()
                {
                    Mamon = txbMamonhoc.Text.Trim(),
                    Tenmon = txbTenmonhoc.Text.Trim(),
                    Manganh = cbxChuyennganh.SelectedValue != null ? cbxChuyennganh.SelectedValue.ToString().Trim() : "",
                    Sotietlythuyet = (int)nudLythuyet.Value,
                    Sotietthuchanh = (int)nudThuchanh.Value,
                    Giangvien = txbGiangvien.Text.Trim(),
                    Tinhtrang = cbxTinhtrang.Text.Trim()
                };
                DataTable dt = quanlymonhocBLL.ThemmonhocMoi(monhocDTO);
                if (dt.Rows.Count != 0)
                {
                    dgvDanhsachmonhoc.DataSource = dt;
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Lỗi kết nối đến cơ sở dữ liệu khi thêm môn học.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Bạn phải nhập đầy đủ thông tin môn học trước khi thêm.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MonhocDTO monhocDTO = new MonhocDTO()
                {
                    Mamon = txbMamonhoc.Text.Trim(),
                    Tenmon = txbTenmonhoc.Text.Trim(),
                    Manganh = cbxChuyennganh.SelectedValue != null ? cbxChuyennganh.SelectedValue.ToString().Trim() : "",
                    Sotietlythuyet = (int)nudLythuyet.Value,
                    Sotietthuchanh = (int)nudThuchanh.Value,
                    Giangvien = txbGiangvien.Text.Trim(),
                    Tinhtrang = cbxTinhtrang.Text.Trim()
                };
                DataTable dt = quanlymonhocBLL.SuaMonHocTheoMaMonHoc(monhocDTO);
                if (dt.Rows.Count != 0)
                {
                    dgvDanhsachmonhoc.DataSource = dt;
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Lỗi kết nối đến cơ sở dữ liệu khi sửa thông tin môn học.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Bạn phải nhập mã môn học trước khi sửa thông tin môn học.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi khi sửa môn học mới.\nVui lòng thử lại sau.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string maMon = txbMamonhoc.Text.ToString().Trim();
                DataTable dt = quanlymonhocBLL.XoaMonHocTheoMaMonHoc(maMon);
                if (dt.Rows.Count != 0)
                {
                    dgvDanhsachmonhoc.DataSource = dt;
                }
            }
	        catch (SqlException)
            {
                MessageBox.Show("Lỗi kết nối đến cơ sở dữ liệu khi xóa thông tin môn học.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
		    catch (ArgumentException)
            {
                MessageBox.Show("Bạn phải nhập mã môn học trước khi xóa môn học khỏi danh sách.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
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
            nudThuchanh.Value = 1;
            txbGiangvien.Text = "";
            cbxTinhtrang.SelectedIndex = -1;
        }
    }
}
