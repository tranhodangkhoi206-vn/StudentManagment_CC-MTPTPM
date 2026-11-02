using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Logging;
using StudentManagment.BLL;
using StudentManagment.DAL.Util;
using StudentManagment.DTO;

namespace StudentManagment.GUI
{
    public partial class frmTaotaikhoan : Form
    {
        private readonly ILoggerFactory _loggerFactory;
        private readonly ILogger<frmTaotaikhoan> logger;
        private TaotaikhoanBLL taoTaiKhoanBLL;
        private TaikhoanDAL taiKhoanDAL;
        public frmTaotaikhoan(ILoggerFactory loggerFactory, string tenHienThi)
        {
            InitializeComponent();
            logger = loggerFactory.CreateLogger<frmTaotaikhoan>();
            _loggerFactory = loggerFactory;
            taoTaiKhoanBLL = new TaotaikhoanBLL(loggerFactory);
            taiKhoanDAL = new TaikhoanDAL(loggerFactory);
        }

        private void frmTaotaikhoan_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void frmTaotaikhoan_Load(object sender, EventArgs e)
        {
            dgvTaikhoan.DataSource = taiKhoanDAL.LayToanBoTaiKhoan();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                TaikhoanDTO taiKhoan = new TaikhoanDTO()
                {
                    Hovaten = tbHovaten.Text.ToString().Trim(),
                    Username = tbTennguoidung.Text.ToString().Trim(),
                    HashedPassword = tbMatkhau.Text.ToString().Trim(),
                };
                DataTable dt = taoTaiKhoanBLL.ThemTaiKhoanMoi(taiKhoan);
                if (dt.Rows.Count != 0)
                {
                    dgvTaikhoan.DataSource = dt;
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Xảy ra lỗi cơ sở dữ liệu khi thêm tài khoản mới.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Bạn phải nhập đầy đủ thông tin trước khi thêm tài khoản mới.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Xảy ra lỗi khi thêm tài khoản mới.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string username = tbTennguoidung.Text.ToString().Trim();
                DataTable dt = taoTaiKhoanBLL.XoaTaiKhoan(username);
                if (dt.Rows.Count != 0)
                {
                    dgvTaikhoan.DataSource = dt;
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Xảy ra lỗi cơ sở dữ liệu khi thêm tài khoản mới.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Bạn phải nhập đầy đủ thông tin trước khi thêm tài khoản mới.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Xảy ra lỗi khi thêm tài khoản mới.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                TaikhoanDTO taiKhoan = new TaikhoanDTO()
                {
                    Hovaten = tbHovaten.Text.ToString().Trim(),
                    Username = tbTennguoidung.Text.ToString().Trim(),
                    HashedPassword = tbMatkhau.Text.ToString().Trim(),
                };
                DataTable dt = taoTaiKhoanBLL.SuaTaiKhoan(taiKhoan);
                if (dt.Rows.Count != 0)
                {
                    dgvTaikhoan.DataSource = dt;
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Xảy ra lỗi cơ sở dữ liệu khi sửa tài khoản.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Bạn phải nhập đầy đủ username trước khi sửa tài khoản.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Xảy ra lỗi khi sửa tài khoản.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDondep_Click(object sender, EventArgs e)
        {
            tbHovaten.Text = "";
            tbMatkhau.Text = "";
            tbTennguoidung.Text = "";
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            try
            {
                string username = tbTennguoidung.Text.ToString().Trim();
                DataTable dt = taoTaiKhoanBLL.LayDanhSachTaiKhoanTheoDieuKienUsername(username);
                if (dt.Rows.Count != 0)
                {
                    dgvTaikhoan.DataSource = dt;
                }
                else
                {
                    dgvTaikhoan.DataSource = taoTaiKhoanBLL.HienThiDanhSachTaiKhoan();
                    MessageBox.Show("Tài khoản không tồn tại.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Xảy ra lỗi cơ sở dữ liệu khi tìm kiếm tài khoản.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Bạn phải nhập username trước khi tìm kiếm tài khoản.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Xảy ra lỗi khi tìm kiếm tài khoản.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDangxuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDangnhap frmDangnhap = new frmDangnhap(_loggerFactory);
            frmDangnhap.Show();
            logger.LogInformation("Chuyển sang form Đăng nhập chính.");
        }
    }
}
