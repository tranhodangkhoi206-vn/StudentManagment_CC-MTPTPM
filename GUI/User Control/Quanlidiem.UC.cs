using System.Data;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Logging;
using StudentManagment.BLL;
using StudentManagment.DTO;

namespace StudentManagment.GUI.User_Control
{
    public partial class Quanlidiem : UserControl
    {
        private readonly ILogger<Quanlidiem> logger;
        private QuanlydiemBLL quanlydiemBLL;
        public Quanlidiem(ILoggerFactory loggerFactory)
        {
            InitializeComponent();
            logger = loggerFactory.CreateLogger<Quanlidiem>();
            quanlydiemBLL = new QuanlydiemBLL(loggerFactory);
        }

        private void Quanlidiem_Load(object sender, EventArgs e)
        {
            dgvDanhsachmonhoc.DataSource = quanlydiemBLL.HienThiToanBoDiem();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                DiemDTO diemDTO = new DiemDTO()
                {
                    Masinhvien = txbMasinhvien.Text.ToString().Trim(),
                    Mamon = txbMamonhoc.Text.ToString().Trim(),
                    Diemchuyencan = string.IsNullOrEmpty(txbDiemchuyencan.Text) ? -1 : float.Parse(txbDiemchuyencan.Text.ToString().Trim()),
                    Diemgiuaky = string.IsNullOrEmpty(txbDiemgiuaky.Text) ? -1 : float.Parse(txbDiemgiuaky.Text.ToString().Trim()),
                    Diemcuoiky = string.IsNullOrEmpty(txtDiemcuoiky.Text) ? -1 : float.Parse(txtDiemcuoiky.Text.ToString().Trim()),
                };
                DataTable dt = quanlydiemBLL.ThemDiemMoi(diemDTO);
                if (dt.Rows.Count != 0)
                {
                    dgvDanhsachmonhoc.DataSource = dt;
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu khi thêm điểm mợi.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Bạn phải nhập đầy đủ thông tin trước khi thêm.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
                MessageBox.Show("Lỗi khi thêm điểm mới.\nVui lòng thử lại sau.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string maSinhVien = txbMasinhvien.Text.ToString().Trim();
                string maMon = txbMamonhoc.Text.ToString().Trim();
                DataTable dt = quanlydiemBLL.XoaThongTinDiemTheoMaSinhVienVaMaMon(maSinhVien, maMon);
                if (dt.Rows.Count != 0)
                {
                    dgvDanhsachmonhoc.DataSource = dt;
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Lỗi kết nối đến cơ sở dữ liệu khi xóa thông tin điểm.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Bạn phải nhập mã môn và mã sinh viên trước khi xóa.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi khi xóa điểm.\nVui lòng thử lại sau.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                DiemDTO diemDTO = new DiemDTO()
                {
                    Masinhvien = txbMasinhvien.Text.ToString().Trim(),
                    Mamon = txbMamonhoc.Text.ToString().Trim(),
                    Diemchuyencan = string.IsNullOrEmpty(txbDiemchuyencan.Text) ? -1 : float.Parse(txbDiemchuyencan.Text.ToString().Trim()),
                    Diemgiuaky = string.IsNullOrEmpty(txbDiemgiuaky.Text) ? -1 : float.Parse(txbDiemgiuaky.Text.ToString().Trim()),
                    Diemcuoiky = string.IsNullOrEmpty(txtDiemcuoiky.Text) ? -1 : float.Parse(txtDiemcuoiky.Text.ToString().Trim()),
                };
                DataTable dt = quanlydiemBLL.SuaThongTinDiemTheoMaSinhVienVaMaMon(diemDTO);
                if (dt.Rows.Count != 0)
                {
                    dgvDanhsachmonhoc.DataSource = dt;
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Lỗi kết nối đến cơ sở dữ liệu khi mà sửa thông tin điểm.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Bạn phải nhập mã điểm và mã sinh viên trước khi sửa thông tin điểm.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi khi sửa điểm.\nVui lòng thử lại sau.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            txbMasinhvien.Text = "";
            txbMamonhoc.Text = "";
            txbDiemchuyencan.Text = "";
            txbDiemgiuaky.Text = "";
            txtDiemcuoiky.Text = "";
        }
    }
}

