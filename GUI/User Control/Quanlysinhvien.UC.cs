using System.Data;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Logging;
using StudentManagment.BLL;
using StudentManagment.DTO;

namespace StudentManagment.GUI.User_Control
{
    public partial class Quanlysinhvien : UserControl
    {
        private readonly ILogger<Quanlysinhvien> logger;
        private QuanlysinhvienBLL quanlysinhvienBLL;
        public Quanlysinhvien(ILoggerFactory loggerFactory)
        {
            InitializeComponent();
            logger = loggerFactory.CreateLogger<Quanlysinhvien>();
            quanlysinhvienBLL = new QuanlysinhvienBLL(loggerFactory);
        }

        private void Quanlysinhvien_Load(object sender, EventArgs e)
        {
            cbManganh.DisplayMember = "TENNGANH";
            cbManganh.ValueMember = "MANGANH";
            cbManganh.DataSource = quanlysinhvienBLL.HienThiDanhSachNganhHocChoComboBox();
            cbMalop.DisplayMember = "TENLOP";
            cbMalop.ValueMember = "MALOP";
            cbMalop.DataSource = quanlysinhvienBLL.HienThiDanhSachLopChoComboBox();
            dgvSinhvien.DataSource = quanlysinhvienBLL.HienThiDanhSachSinhVien();
            cbManganh.SelectedIndex = -1;
            cbMalop.SelectedIndex = -1;
            rbNam.Checked = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                logger.LogInformation("Người dùng thêm sinh viên mới");
                SinhvienDTO sinhvienMoi = new SinhvienDTO()
                {
                    MaSinhVien = tbMasinhvien.Text.ToString().ToUpper(),
                    HoVaTen = tbHovaten.Text.ToString(),
                    MaLop = cbMalop.SelectedValue != null ? cbMalop.SelectedValue.ToString().Trim() : "",
                    NgaySinh = dtpNgaysinh.Value.Date,
                    GioiTinh = rbNam.Checked ? "Nam" : "Nữ",
                    MaNganh = cbManganh.SelectedValue != null ? cbManganh.SelectedValue.ToString().Trim() : "",
                    TinhTrang = cbTinhtrang.Text.Trim()
                };
                DataTable dt = quanlysinhvienBLL.ThemsinhvienMoi(sinhvienMoi);
                if (dt.Rows.Count != 0)
                {
                    dgvSinhvien.DataSource = dt;
                    MessageBox.Show("Thêm sinh viên thành công.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                DialogResult result = MessageBox.Show("Bạn chắc chắn muốn xóa chứ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                logger.LogInformation("Người dùng xóa sinh viên");
                    string maSinhVien = tbMasinhvien.Text.ToString().ToUpper();
                    DataTable dt = quanlysinhvienBLL.XoaSinhVienTheoMaSinhVien(maSinhVien);
                    if (dt.Rows.Count != 0)
                    {
                        dgvSinhvien.DataSource = dt;
                        MessageBox.Show("Xóa sinh viên thành công.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {  
                logger.LogInformation("Người dùng sửa sinh viên");
                SinhvienDTO sinhvienSua = new SinhvienDTO()
                {
                    MaSinhVien = tbMasinhvien.Text.ToString().ToUpper(),
                    HoVaTen = tbHovaten.Text.ToString(),
                    MaLop = cbMalop.SelectedValue != null ? cbMalop.SelectedValue.ToString().Trim() : "",
                    NgaySinh = dtpNgaysinh.Value.Date,
                    GioiTinh = rbNam.Checked ? "Nam" : "Nữ",
                    MaNganh = cbManganh.SelectedValue != null ? cbManganh.SelectedValue.ToString().Trim() : "",
                    TinhTrang = cbTinhtrang.Text.Trim()
                };
                DataTable dt = quanlysinhvienBLL.SuaSinhVienTheoMaSinhVien(sinhvienSua);
                if (dt.Rows.Count != 0)
                {
                    dgvSinhvien.DataSource = dt;
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
            tbMasinhvien.Text = "";
            tbHovaten.Text = "";
            cbMalop.SelectedIndex = -1;
            dtpNgaysinh.Value = DateTime.Today.Date;
            rbNam.Checked = true;
            cbManganh.SelectedIndex = -1;
            cbTinhtrang.SelectedIndex = -1;
            dgvSinhvien.DataSource = quanlysinhvienBLL.HienThiDanhSachSinhVien();
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            try
            {
                logger.LogInformation("Người dùng tìm kiếm sinh viên");
                string maSinhVien = tbMasinhvien.Text.ToString().Trim();
                DataTable dt = quanlysinhvienBLL.TimKiemSinhVien(maSinhVien);
                if (dt.Rows.Count != 0)
                {
                    dgvSinhvien.DataSource = dt;
                }
                else
                {
                    dgvSinhvien.DataSource = quanlysinhvienBLL.HienThiDanhSachSinhVien();
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
