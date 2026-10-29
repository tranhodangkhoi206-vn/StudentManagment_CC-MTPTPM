using System.Data;
using Microsoft.Data.SqlClient;
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
                SinhvienDTO sinhvienMoi = new SinhvienDTO()
                {
                    MaSinhVien = txbMasinhvien.Text.ToString(),
                    HoVaTen = txbHovaten.Text.ToString(),
                    MaLop = cbxLop.SelectedValue != null ? cbxLop.SelectedValue.ToString().Trim() : "",
                    NgaySinh = dtpNgaySinh.Value.Date,
                    GioiTinh = rbtnNam.Checked ? "Nam" : "Nữ",
                    MaNganh = cbxChuyennganh.SelectedValue != null ? cbxChuyennganh.SelectedValue.ToString().Trim() : "",
                    TinhTrang = cbxTinhtrang.Text.Trim()
                };
                DataTable dt = quanlysinhvienBLL.ThemsinhvienMoi(sinhvienMoi);
                if (dt.Rows.Count != 0)
                {
                    drvDanhsachsinhvien.DataSource = dt;
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
                string maSinhVien = txbMasinhvien.Text.ToString();
                DataTable dt = quanlysinhvienBLL.XoaSinhVienTheoMaSinhVien(maSinhVien);
                drvDanhsachsinhvien.DataSource = dt;
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
                    MaSinhVien = txbMasinhvien.Text.ToString(),
                    HoVaTen = txbHovaten.Text.ToString(),
                    MaLop = cbxLop.SelectedValue != null ? cbxLop.SelectedValue.ToString().Trim() : "",
                    NgaySinh = dtpNgaySinh.Value.Date,
                    GioiTinh = rbtnNam.Checked ? "Nam" : "Nữ",
                    MaNganh = cbxChuyennganh.SelectedValue != null ? cbxChuyennganh.SelectedValue.ToString().Trim() : "",
                    TinhTrang = cbxTinhtrang.Text.Trim()
                };
                DataTable dt = quanlysinhvienBLL.SuaSinhVienTheoMaSinhVien(sinhvienSua);
                if (dt.Rows.Count != 0)
                {
                    drvDanhsachsinhvien.DataSource = dt;
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
