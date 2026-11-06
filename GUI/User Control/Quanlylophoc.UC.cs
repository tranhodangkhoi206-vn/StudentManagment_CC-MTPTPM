using System.Data;
using Microsoft.Extensions.Logging;
using StudentManagment.BLL;
using StudentManagment.DTO;
using Microsoft.Data.SqlClient;

namespace StudentManagment.GUI.User_Control
{
    public partial class Quanlylophoc : UserControl
    {
        private readonly ILogger<QuanlylopBLL> logger;
        private readonly QuanlylopBLL quanlylopBLL;
        public Quanlylophoc(ILoggerFactory loggerFactory)
        {
            InitializeComponent();
            logger = loggerFactory.CreateLogger<QuanlylopBLL>();
            quanlylopBLL = new QuanlylopBLL(loggerFactory);
        }
        private void Quanlylophoc_Load(object sender, EventArgs e)
        {
            dgvLop.DataSource = quanlylopBLL.HienThiDanhSachLopHoc();
            cbManganh.DisplayMember = "TENNGANH";
            cbManganh.ValueMember = "MANGANH";
            cbManganh.DataSource = quanlylopBLL.HienThiDanhSachNganhLenCombobox();
            cbManganh.SelectedIndex = -1;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                logger.LogInformation("Người dùng thêm lớp học mới");
                LopDTO lop = new LopDTO()
                {
                    Malop = tbMalop.Text.ToString().Trim(),
                    Manganh = cbManganh.SelectedValue.ToString().Trim(),
                    Tenlop = tbTenlop.Text.ToString().Trim(),
                    Giangvienphutrach = tbGiangvien.Text.ToString().Trim(),
                };
                DataTable dt = quanlylopBLL.ThemLopHocMoi(lop);
                if (dt.Rows.Count != 0)
                {
                    dgvLop.DataSource = dt;
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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                logger.LogInformation("Người dùng xóa lớp học");
                string maLop = tbMalop.Text.ToString().Trim();
                DataTable dt = quanlylopBLL.XoaThongTinLop(maLop);
                if (dt.Rows.Count != 0)
                {
                    dgvLop.DataSource = dt;
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

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                logger.LogInformation("Người dùng sửa lớp học");
                DialogResult result = MessageBox.Show("Bạn chắc chắn muốn xóa chứ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    LopDTO lop = new LopDTO()
                    {
                        Malop = tbMalop.Text.ToString().Trim(),
                        Manganh = cbManganh.SelectedValue.ToString().Trim(),
                        Tenlop = tbTenlop.Text.ToString().Trim(),
                        Giangvienphutrach = tbGiangvien.Text.ToString().Trim(),
                    };
                    DataTable dt = quanlylopBLL.SuaThongTinLop(lop);
                    if (dt.Rows.Count != 0)
                    {
                        dgvLop.DataSource = dt;
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

        private void btnDondep_Click(object sender, EventArgs e)
        {
            logger.LogInformation("Người dùng dọn dẹp");
            tbMalop.Text = "";
            cbManganh.SelectedIndex = -1;
            tbTenlop.Text = "";
            tbGiangvien.Text = "";
            dgvLop.DataSource = quanlylopBLL.HienThiDanhSachLopHoc();
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            try
            {
                logger.LogInformation("Người dùng tìm kiếm lớp học");
                string maLop = tbMalop.Text.ToString().Trim();
                DataTable dt = quanlylopBLL.TimKiemLopHoc(maLop);
                if (dt.Rows.Count != 0)
                {
                    dgvLop.DataSource = dt;
                }
                else
                {
                    dgvLop.DataSource = quanlylopBLL.HienThiDanhSachLopHoc();
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
