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
                    Mamon = tbMamonhoc.Text.Trim().ToUpper(),
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
            catch (ArgumentException agEx)
            {
                MessageBox.Show(agEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (InvalidOperationException ioEx)
            {
                MessageBox.Show(ioEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (SqlException)
            {
                MessageBox.Show("Có lỗi xảy ra với cơ sở dữ liệu.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (DataException dEx)
            {
                MessageBox.Show(dEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Bạn chắc chắn muốn xóa chứ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
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
            }
            catch (ArgumentException agEx)
            {
                MessageBox.Show(agEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (InvalidOperationException ioEx)
            {
                MessageBox.Show(ioEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (SqlException)
            {
                MessageBox.Show("Có lỗi xảy ra với cơ sở dữ liệu.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Có lỗi xảy ra.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            catch (ArgumentException agEx)
            {
                MessageBox.Show(agEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (InvalidOperationException ioEx)
            {
                MessageBox.Show(ioEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (SqlException)
            {
                MessageBox.Show("Có lỗi xảy ra với cơ sở dữ liệu.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Có lỗi xảy ra.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            catch (ArgumentException agEx)
            {
                MessageBox.Show(agEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (KeyNotFoundException knfEx)
            {
                MessageBox.Show(knfEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (SqlException)
            {
                MessageBox.Show("Có lỗi xảy ra với cơ sở dữ liệu.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Có lỗi xảy ra.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
