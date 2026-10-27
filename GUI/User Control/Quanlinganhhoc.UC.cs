using System.Data;
using Microsoft.Extensions.Logging;
using StudentManagment.BLL;
using StudentManagment.DTO;

namespace StudentManagment.GUI.User_Control
{
    public partial class Quanlinganhhoc : UserControl
    {
        private readonly ILogger<Quanlinganhhoc> logger;
        private QuanlynganhhocBLL quanlynganhhocBLL;
        public Quanlinganhhoc(ILoggerFactory loggerFactory)
        {
            InitializeComponent();
            logger = loggerFactory.CreateLogger<Quanlinganhhoc>();
            quanlynganhhocBLL = new QuanlynganhhocBLL(loggerFactory);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string maNganh = txbManganh.Text.ToString().Trim();
                string tenNganh = txbTennganh.Text.ToString().Trim();
                string khoa = txbKhoa.Text.ToString().Trim();
                NganhhocDTO nganhhoc = new NganhhocDTO()
                {
                    Manganh = maNganh,
                    Tennganh = tenNganh,
                    Khoaquanly = khoa
                };
                DataTable dt = new DataTable();
                dt = quanlynganhhocBLL.ThemNganhMoi(nganhhoc);
                dgvDanhsachnganhoc.DataSource = dt;

            }
            catch
            {
                MessageBox.Show("Lỗi khi khi thêm ngành học.\nVui lòng thử lại sau.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string maNganh = txbManganh.Text.Trim();
                DataTable dt = new DataTable();
                dt = quanlynganhhocBLL.XoaThongTinNganhTheoMaNganh(maNganh);
                dgvDanhsachnganhoc.DataSource = dt;
            }
            catch
            {
                MessageBox.Show("Lỗi khi xóa ngành học.\nVui lòng thử lại sau.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                string maNganh = txbManganh.Text.ToString().Trim();
                string tenNganh = txbTennganh.Text.ToString().Trim();
                string khoa = txbKhoa.Text.ToString().Trim();
                NganhhocDTO nganhhoc = new NganhhocDTO()
                {
                    Manganh = maNganh,
                    Tennganh = tenNganh,
                    Khoaquanly = khoa
                };
                DataTable dt = new DataTable();
                dt = quanlynganhhocBLL.SuaThongTinNganhTheoMaNganh(nganhhoc);
                dgvDanhsachnganhoc.DataSource = dt;
            }
            catch
            {
                MessageBox.Show("Lỗi khi sửa ngành học.\nVui lòng thử lại sau.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void Quanlinganhhoc_Load(object sender, EventArgs e)
        {
            dgvDanhsachnganhoc.DataSource = quanlynganhhocBLL.HienThiToanBoNganhHoc();
        }
    }
}
