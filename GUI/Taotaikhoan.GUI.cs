using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagment.GUI
{
    public partial class frmTaotaikhoan : Form
    {
        public frmTaotaikhoan()
        {
            InitializeComponent();
        }

        private void frmTaotaikhoan_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
