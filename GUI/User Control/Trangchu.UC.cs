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

namespace StudentManagment.GUI.User_Control
{
    public partial class Trangchu : UserControl
    {
        private readonly ILogger<Trangchu> logger;
        private TrangchuBLL trangChuBLL;
        public Trangchu(ILoggerFactory loggerFactory)
        {
            InitializeComponent();
            logger = loggerFactory.CreateLogger<Trangchu>();
            trangChuBLL = new TrangchuBLL(loggerFactory);
        }

        private void Trangchu_Load(object sender, EventArgs e)
        {
            lbTongsinhvien.Text = trangChuBLL.TinhTongSinhVien().ToString().Trim();
            lbTongmonhoc.Text = trangChuBLL.TinhTongMonHoc().ToString().Trim();
            lbTonglophoc.Text = trangChuBLL.TinhTongLopHoc().ToString().Trim();
        }
    }
}
