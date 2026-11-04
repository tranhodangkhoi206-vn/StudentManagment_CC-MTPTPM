using System.Data;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Logging;
using StudentManagment.BLL;
using StudentManagment.DTO;

namespace StudentManagment.GUI.User_Control
{
    public partial class Quanlydiem : UserControl
    {
        private readonly ILogger<Quanlydiem> logger;
        private QuanlydiemBLL quanlydiemBLL;
        public Quanlydiem(ILoggerFactory loggerFactory)
        {
            InitializeComponent();
            logger = loggerFactory.CreateLogger<Quanlydiem>();
            quanlydiemBLL = new QuanlydiemBLL(loggerFactory);
        }

        private void Quanlydiem_Load(object sender, EventArgs e)
        {
            dgvDiem.DataSource = quanlydiemBLL.HienThiToanBoDiem();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                DiemDTO diemDTO = new DiemDTO()
                {
                    Masinhvien = tbMasinhvien.Text.ToString().Trim().ToUpper(),
                    Mamon = tbMamonhoc.Text.ToString().Trim().ToUpper(),
                    Diemchuyencan = string.IsNullOrEmpty(tbDiemchuyencan.Text) ? -1 : double.Parse(tbDiemchuyencan.Text.ToString().Trim()),
                    Diemgiuaky = string.IsNullOrEmpty(tbDiemgiuaky.Text) ? -1 : double.Parse(tbDiemgiuaky.Text.ToString().Trim()),
                    Diemcuoiky = string.IsNullOrEmpty(tbDiemcuoiky.Text) ? -1 : double.Parse(tbDiemcuoiky.Text.ToString().Trim()),
                };
                DataTable dt = quanlydiemBLL.ThemDiemMoi(diemDTO);
                if (dt.Rows.Count != 0)
                {
                    dgvDiem.DataSource = dt;
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
                    string maSinhVien = tbMasinhvien.Text.ToString().Trim();
                    string maMon = tbMamonhoc.Text.ToString().Trim();
                    DataTable dt = quanlydiemBLL.XoaThongTinDiemTheoMaSinhVienVaMaMon(maSinhVien, maMon);
                    if (dt.Rows.Count != 0)
                    {
                        dgvDiem.DataSource = dt;
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
                DiemDTO diemDTO = new DiemDTO()
                {
                    Masinhvien = tbMasinhvien.Text.ToString().Trim(),
                    Mamon = tbMamonhoc.Text.ToString().Trim(),
                    Diemchuyencan = string.IsNullOrEmpty(tbDiemchuyencan.Text) ? -1 : double.Parse(tbDiemchuyencan.Text.ToString().Trim()),
                    Diemgiuaky = string.IsNullOrEmpty(tbDiemgiuaky.Text) ? -1 : double.Parse(tbDiemgiuaky.Text.ToString().Trim()),
                    Diemcuoiky = string.IsNullOrEmpty(tbDiemcuoiky.Text) ? -1 : double.Parse(tbDiemcuoiky.Text.ToString().Trim()),
                };
                DataTable dt = quanlydiemBLL.SuaThongTinDiemTheoMaSinhVienVaMaMon(diemDTO);
                if (dt.Rows.Count != 0)
                {
                    dgvDiem.DataSource = dt;
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Xảy ra lỗi cơ sở dữ liệu khi xóa điểm mới.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin điểm khi xóa điểm.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Mã sinh viên hoặc mã môn học không tồn tại.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Xảy ra lỗi khi xóa điểm.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDondep_Click(object sender, EventArgs e)
        {
            tbMasinhvien.Text = "";
            tbMamonhoc.Text = "";
            tbDiemchuyencan.Text = "";
            tbDiemgiuaky.Text = "";
            tbDiemcuoiky.Text = "";
            dgvDiem.DataSource = quanlydiemBLL.HienThiToanBoDiem();
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            try
            {
                string maSinhVien = tbMasinhvien.Text.ToString().Trim();
                string maMonHoc = tbMamonhoc.Text.ToString().Trim();
                DataTable dt = quanlydiemBLL.TimKiemDiemTheoMaSinhVienVaMaMon(maSinhVien, maMonHoc);
                if (dt.Rows.Count != 0)
                {
                    dgvDiem.DataSource = dt;
                }
                else
                {
                    dgvDiem.DataSource = quanlydiemBLL.HienThiToanBoDiem();
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

        private void tbDiemchuyencan_TextChanged(object sender, EventArgs e)
        {
            string diemChyenCan = tbDiemchuyencan.Text.ToString().Trim();
            string diemGiuaKy = tbDiemgiuaky.Text.ToString().Trim();
            string diemCuoiKy = tbDiemcuoiky.Text.ToString().Trim();
            lbDiemtong.Text = quanlydiemBLL.TinhDiemTongVaHienThi(diemChyenCan, diemGiuaKy, diemCuoiKy).ToString().Trim();
        }

        private void tbDiemgiuaky_TextChanged(object sender, EventArgs e)
        {
            string diemChyenCan = tbDiemchuyencan.Text.ToString().Trim();
            string diemGiuaKy = tbDiemgiuaky.Text.ToString().Trim();
            string diemCuoiKy = tbDiemcuoiky.Text.ToString().Trim();
            lbDiemtong.Text = quanlydiemBLL.TinhDiemTongVaHienThi(diemChyenCan, diemGiuaKy, diemCuoiKy).ToString().Trim();
        }

        private void tbDiemcuoiky_TextChanged(object sender, EventArgs e)
        {
            string diemChyenCan = tbDiemchuyencan.Text.ToString().Trim();
            string diemGiuaKy = tbDiemgiuaky.Text.ToString().Trim();
            string diemCuoiKy = tbDiemcuoiky.Text.ToString().Trim();
            lbDiemtong.Text = quanlydiemBLL.TinhDiemTongVaHienThi(diemChyenCan, diemGiuaKy, diemCuoiKy).ToString().Trim();
        }
    }
}

