using System.Data;
using System.Runtime.CompilerServices;
using Microsoft.Data.SqlClient;
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
                NganhhocDTO nganhhoc = new NganhhocDTO()
                {
                    Manganh = txbManganh.Text.ToString().Trim(),
                    Tennganh = txbTennganh.Text.ToString().Trim(),
                    Khoaquanly = txbKhoa.Text.ToString().Trim()
                };
                DataTable dt = quanlynganhhocBLL.ThemNganhMoi(nganhhoc);
                if (dt.Rows.Count != 0)
                {
                    dgvDanhsachnganhoc.DataSource = dt;
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Lỗi kết nối đến cơ sở dữ liệu khi thêm ngành học.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin ngành học khi thêm.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi khi khi thêm ngành học.\nVui lòng thử lại sau.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string maNganh = txbManganh.Text.Trim();
                DataTable dt = quanlynganhhocBLL.XoaThongTinNganhTheoMaNganh(maNganh);
                if (dt.Rows.Count != 0)
                {
                    dgvDanhsachnganhoc.DataSource = dt;
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Lỗi kết nối đến cơ sở dữ liệu khi xóa ngành học.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Bạn phải nhập mã ngành để xóa ngành khỏi danh sách.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi khi xóa ngành học.\nVui lòng thử lại sau.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                NganhhocDTO nganhhoc = new NganhhocDTO()
                {
                    Manganh = txbManganh.Text.ToString().Trim(),
                    Tennganh = txbTennganh.Text.ToString().Trim(),
                    Khoaquanly = txbKhoa.Text.ToString().Trim()
                };
                DataTable dt = quanlynganhhocBLL.SuaThongTinNganhTheoMaNganh(nganhhoc);
                if (dt.Rows.Count != 0)
                {
                    dgvDanhsachnganhoc.DataSource = dt;
                }
            }
	        catch(SqlException)
            {
                MessageBox.Show("Lỗi kết nối đến cơ sở dữ liệu khi sửa ngành.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
		    catch(ArgumentException)
            {
                MessageBox.Show("Bạn phải nhập mã ngành để sửa thông tin ngành.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
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
