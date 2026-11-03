using System.Data;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Logging;
using StudentManagment.BLL;
using StudentManagment.DTO;

namespace StudentManagment.GUI.User_Control
{
    public partial class Quanlynganhhoc : UserControl
    {
        private readonly ILogger<Quanlynganhhoc> logger;
        private QuanlynganhhocBLL quanlynganhhocBLL;
        public Quanlynganhhoc(ILoggerFactory loggerFactory)
        {
            InitializeComponent();
            logger = loggerFactory.CreateLogger<Quanlynganhhoc>();
            quanlynganhhocBLL = new QuanlynganhhocBLL(loggerFactory);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                NganhhocDTO nganhhoc = new NganhhocDTO()
                {
                    Manganh = tbManganh.Text.ToString().Trim(),
                    Tennganh = tbTennganh.Text.ToString().Trim(),
                    Khoaquanly = cbKhoaquanly.Text.ToString().Trim()
                };
                DataTable dt = quanlynganhhocBLL.ThemNganhMoi(nganhhoc);
                if (dt.Rows.Count != 0)
                {
                    dgvNganh.DataSource = dt;
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Xảy ra lỗi cơ sở dữ liệu khi thêm ngành học mới.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin ngành học khi thêm ngành học.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Thêm không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Xảy ra lỗi khi thêm ngành học.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Bạn chắc chắn muốn xóa chứ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    string maNganh = tbManganh.Text.Trim();
                    DataTable dt = quanlynganhhocBLL.XoaThongTinNganhTheoMaNganh(maNganh);
                    if (dt.Rows.Count != 0)
                    {
                        dgvNganh.DataSource = dt;
                    }
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Xảy ra lỗi cơ sở dữ liệu khi xóa ngành học.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Bạn chưa nhập mã ngành trước khi xóa ngành học.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Mã ngành không tồn tại.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Xảy ra lỗi khi xóa ngành học", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                NganhhocDTO nganhhoc = new NganhhocDTO()
                {
                    Manganh = tbManganh.Text.ToString().Trim(),
                    Tennganh = tbTennganh.Text.ToString().Trim(),
                    Khoaquanly = cbKhoaquanly.Text.ToString().Trim()
                };
                DataTable dt = quanlynganhhocBLL.SuaThongTinNganhTheoMaNganh(nganhhoc);
                if (dt.Rows.Count != 0)
                {
                    dgvNganh.DataSource = dt;
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Xảy ra lỗi cơ sở dữ liệu khi sửa ngành học.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Bạn chưa nhập mã ngành trước khi sửa ngành học.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Mã ngành không tồn tại.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Xảy ra lôi khi sửa ngành học.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void Quanlynganhhoc_Load(object sender, EventArgs e)
        {
            dgvNganh.DataSource = quanlynganhhocBLL.HienThiToanBoNganhHoc();
        }

        private void btnDondep_Click(object sender, EventArgs e)
        {
            tbManganh.Text = "";
            tbTennganh.Text = "";
            cbKhoaquanly.SelectedIndex = -1;
            dgvNganh.DataSource = quanlynganhhocBLL.HienThiToanBoNganhHoc();
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            try
            {
                string maNganh = tbManganh.Text.ToString().Trim();
                DataTable dt = quanlynganhhocBLL.TimKiemNganhHoc(maNganh);
                if (dt.Rows.Count != 0)
                {
                    dgvNganh.DataSource = dt;
                }
                else
                {
                    dgvNganh.DataSource = quanlynganhhocBLL.HienThiToanBoNganhHoc();
                    MessageBox.Show("Ngành học không tồn tại.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Xảy ra lỗi cơ sở dữ liệu khi tìm kiếm ngành học.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Bạn phải nhập mã ngành trước khi tìm kiếm ngành học.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Mã ngành không tồn tại.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Xảy ra lỗi khi tìm kiếm ngành học.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
