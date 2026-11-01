using System.Data;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Logging;
using StudentManagment.BLL;
using StudentManagment.DTO;

namespace StudentManagment.GUI.User_Control
{
    public partial class Quanlysinhvien : UserControl
    {
        private QuanlysinhvienBLL quanlysinhvienBLL;
        public Quanlysinhvien(ILoggerFactory loggerFactory)
        {
            InitializeComponent();
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
                SinhvienDTO sinhvienMoi = new SinhvienDTO()
                {
                    MaSinhVien = tbMasinhvien.Text.ToString(),
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
                }
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Bạn phải nhập đầy đủ thông tin trước khi thêm.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
	        catch (SqlException)
            {
                MessageBox.Show("Lỗi khi kết nối cơ sở dữ liệu khi thêm sinh viên mới.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi khi thêm sinh viên mới.\nVui lòng thử lại sau.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string maSinhVien = tbMasinhvien.Text.ToString();
                DataTable dt = quanlysinhvienBLL.XoaSinhVienTheoMaSinhVien(maSinhVien);
                dgvSinhvien.DataSource = dt;
            }
	        catch (ArgumentException)
            {
                MessageBox.Show("Bạn phải nhập mã sinh viên trước khi xóa.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
		    catch (SqlException)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu khi xóa sinh viên.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi khi xóa sinh viên.\nVui lòng thử lại sau.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                SinhvienDTO sinhvienSua = new SinhvienDTO()
                {
                    MaSinhVien = tbMasinhvien.Text.ToString(),
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
	        catch(ArgumentException)
            {
                MessageBox.Show("Bạn phải nhập mã sinh viên trước khi sửa.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
		    catch(SqlException)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu khi sửa thông tin sinh viên.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi khi sửa sinh viên.\nVui lòng thử lại sau.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            tbMasinhvien.Text = "";
            tbHovaten.Text = "";
            cbMalop.SelectedIndex = -1;
            dtpNgaysinh.Value = DateTime.Today.Date;
            rbNam.Checked = true;
            cbManganh.SelectedIndex = -1;
            cbTinhtrang.SelectedIndex = -1;
        }
    }
}
