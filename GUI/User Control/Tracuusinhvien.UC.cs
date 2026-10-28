using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.Logging;
using StudentManagment.BLL;
using StudentManagment.DTO;

namespace StudentManagment.GUI.User_Control
{
    public partial class Tracuusinhvien : UserControl
    {
        private readonly ILogger logger;
        private TracuusinhvienBLL tracuusinhvienBLL;
        public Tracuusinhvien(ILoggerFactory loggerFactory)
        {
            InitializeComponent();
            logger = loggerFactory.CreateLogger<Tracuusinhvien>();
            tracuusinhvienBLL = new TracuusinhvienBLL(loggerFactory);

        }
        private void Tracuusinhvien_Load(object sender, EventArgs e)
        {
            DataTable danhSachLopChoComboBox = tracuusinhvienBLL.HienThiDanhSachLopChoComboBox();
            DataTable danhSachNganhHocChoComboBox = tracuusinhvienBLL.HienThiDanhSachNganhHocChoComboBox();

            DataRow rowLop = danhSachLopChoComboBox.NewRow();
            rowLop["MALOP"] = "";
            rowLop["TENLOP"] = "Tất cả";
            danhSachLopChoComboBox.Rows.InsertAt(rowLop, 0);

            DataRow rowNganh = danhSachNganhHocChoComboBox.NewRow();
            rowNganh["MANGANH"] = "";
            rowNganh["TENNGANH"] = "Tất cả";
            danhSachNganhHocChoComboBox.Rows.InsertAt(rowNganh, 0);

            cbxNhomlop.DisplayMember = "TENLOP";
            cbxNhomlop.ValueMember = "MALOP";
            cbxNhomlop.DataSource = danhSachLopChoComboBox;

            cbxNhomchuyennganh.DisplayMember = "TENNGANH";
            cbxNhomchuyennganh.ValueMember = "MANGANH";
            cbxNhomchuyennganh.DataSource = danhSachNganhHocChoComboBox;

            drvDanhsachsinhvien.DataSource = tracuusinhvienBLL.HienThiDanhSachSinhVien();
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                string tenSinhVienTimKiem = txbTimkiem.Text.Trim();
                drvDanhsachsinhvien.DataSource = tracuusinhvienBLL.HienThiDanhSachSinhVienTheoDieuKienTen(tenSinhVienTimKiem);
            }
            catch
            {
                MessageBox.Show("Có lỗi xảy ra khi tìm kiếm.\nVui lòng thử lại sau.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txbTimkiem_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string tenSinhVienTimKiem = txbTimkiem.Text.Trim();
                if (tenSinhVienTimKiem == "")
                {
                    drvDanhsachsinhvien.DataSource = tracuusinhvienBLL.HienThiDanhSachSinhVien();
                }
            }
            catch
            {
                MessageBox.Show("Có lỗi xảy ra khi tìm kiếm.\nVui lòng thử lại sau.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbxNhomlop_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string giaTriDuocChon = cbxNhomlop.SelectedValue.ToString();
                if (giaTriDuocChon == "")
                {
                    drvDanhsachsinhvien.DataSource = tracuusinhvienBLL.HienThiDanhSachSinhVien();
                }
                else
                {
                    drvDanhsachsinhvien.DataSource = tracuusinhvienBLL.HienThiDanhSachSinhVienTheoDieuKienLop(giaTriDuocChon);
                }
            }
            catch
            {
                MessageBox.Show("Có lỗi xảy ra khi lọc theo nhóm lớp.\nVui lòng thử lại sau.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbxNhomchuyennganh_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string giaTriDuocChon = cbxNhomchuyennganh.SelectedValue.ToString();
                if (giaTriDuocChon == "")
                {
                    drvDanhsachsinhvien.DataSource = tracuusinhvienBLL.HienThiDanhSachSinhVien();
                }
                else
                {
                    drvDanhsachsinhvien.DataSource = tracuusinhvienBLL.HienThiDanhSachSinhVienTheoDieuKienNganhHoc(giaTriDuocChon);
                }
            }
            catch
            {
                MessageBox.Show("Có lỗi xảy ra khi lọc theo nhóm lớp.\nVui lòng thử lại sau.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
