using System.Data;
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
                string maSinhVien = txbMasinhvien.Text.ToString().Trim();
                string maMon = txbMamonhoc.Text.ToString().Trim();
                decimal diemChuyenCan = decimal.Parse(txbDiemchuyencan.Text.ToString().Trim());
                decimal diemGiuaKy = decimal.Parse(txbDiemgiuaky.Text.ToString().Trim());
                decimal diemCuoiKy = decimal.Parse(txtDiemcuoiky.Text.ToString().Trim());
                DiemDTO diemDTO = new DiemDTO()
                {
                    Masinhvien = maSinhVien,
                    Mamon = maMon,
                    Diemchuyencan = diemChuyenCan,
                    Diemgiuaky = diemGiuaKy,
                    Diemcuoiky = diemCuoiKy,
                    Diemtong = (diemChuyenCan + diemGiuaKy + diemCuoiKy) / 3

                };
                DataTable dt = new DataTable();
                dt = quanlydiemBLL.ThemDiemMoi(diemDTO);
                dgvDanhsachmonhoc.DataSource = dt;
            }
            catch
            {
                MessageBox.Show("Lỗi khi thêm điểm mới.\nVui lòng thử lại sau.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string maSinhVien = txbMasinhvien.Text.ToString().Trim();
                string maMon = txbMamonhoc.Text.ToString().Trim();
                DataTable dt = new DataTable();
                dt = quanlydiemBLL.XoaThongTinDiemTheoMaSinhVienVaMaMon(maSinhVien, maMon);
                dgvDanhsachmonhoc.DataSource = dt;
            }
            catch
            {
                MessageBox.Show("Lỗi khi xóa điểm.\nVui lòng thử lại sau.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                string maSinhVien = txbMasinhvien.Text.ToString().Trim();
                string maMon = txbMamonhoc.Text.ToString().Trim();
                decimal diemChuyenCan = decimal.Parse(txbDiemchuyencan.Text.ToString().Trim());
                decimal diemGiuaKy = decimal.Parse(txbDiemgiuaky.Text.ToString().Trim());
                decimal diemCuoiKy = decimal.Parse(txtDiemcuoiky.Text.ToString().Trim());
                DiemDTO diemDTO = new DiemDTO()
                {
                    Masinhvien = maSinhVien,
                    Mamon = maMon,
                    Diemchuyencan = diemChuyenCan,
                    Diemgiuaky = diemGiuaKy,
                    Diemcuoiky = diemCuoiKy,
                    Diemtong = (diemChuyenCan + diemGiuaKy + diemCuoiKy) / 3
                };
                DataTable dt = new DataTable();
                dt = quanlydiemBLL.SuaThongTinDiemTheoMaSinhVienVaMaMon(diemDTO);
                dgvDanhsachmonhoc.DataSource = dt;
            }
            catch
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

