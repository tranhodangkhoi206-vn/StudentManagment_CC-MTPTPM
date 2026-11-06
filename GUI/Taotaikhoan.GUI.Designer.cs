namespace StudentManagment.GUI
{
    partial class frmTaotaikhoan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            tableLayoutPanel4 = new TableLayoutPanel();
            label2 = new Label();
            tbHovaten = new TextBox();
            dgvTaikhoan = new DataGridView();
            HOVATEN = new DataGridViewTextBoxColumn();
            USERNAME = new DataGridViewTextBoxColumn();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel14 = new TableLayoutPanel();
            btnTimkiem = new Button();
            label9 = new Label();
            tableLayoutPanel13 = new TableLayoutPanel();
            btnDondep = new Button();
            btnSua = new Button();
            tableLayoutPanel12 = new TableLayoutPanel();
            btnXoa = new Button();
            btnThem = new Button();
            tableLayoutPanel5 = new TableLayoutPanel();
            label3 = new Label();
            tbTennguoidung = new TextBox();
            tableLayoutPanel6 = new TableLayoutPanel();
            label4 = new Label();
            tbMatkhau = new TextBox();
            tableLayoutPanel7 = new TableLayoutPanel();
            btnDangxuat = new Button();
            lbTenhienthi = new Label();
            tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTaikhoan).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel14.SuspendLayout();
            tableLayoutPanel13.SuspendLayout();
            tableLayoutPanel12.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.76435F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 62.23565F));
            tableLayoutPanel4.Controls.Add(label2, 0, 0);
            tableLayoutPanel4.Controls.Add(tbHovaten, 1, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(0, 0);
            tableLayoutPanel4.Margin = new Padding(0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(405, 62);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Roboto Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(4, 0);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(144, 62);
            label2.TabIndex = 0;
            label2.Text = "Họ và tên:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tbHovaten
            // 
            tbHovaten.Anchor = AnchorStyles.Left;
            tbHovaten.BorderStyle = BorderStyle.FixedSingle;
            tbHovaten.Font = new Font("Roboto Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbHovaten.Location = new Point(156, 12);
            tbHovaten.Margin = new Padding(4);
            tbHovaten.Name = "tbHovaten";
            tbHovaten.Size = new Size(244, 38);
            tbHovaten.TabIndex = 0;
            // 
            // dgvTaikhoan
            // 
            dgvTaikhoan.AllowUserToAddRows = false;
            dgvTaikhoan.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvTaikhoan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvTaikhoan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTaikhoan.Columns.AddRange(new DataGridViewColumn[] { HOVATEN, USERNAME });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvTaikhoan.DefaultCellStyle = dataGridViewCellStyle2;
            dgvTaikhoan.Dock = DockStyle.Fill;
            dgvTaikhoan.Location = new Point(413, 8);
            dgvTaikhoan.Margin = new Padding(0);
            dgvTaikhoan.Name = "dgvTaikhoan";
            dgvTaikhoan.ReadOnly = true;
            dgvTaikhoan.RowHeadersWidth = 51;
            dgvTaikhoan.Size = new Size(547, 617);
            dgvTaikhoan.TabIndex = 0;
            // 
            // HOVATEN
            // 
            HOVATEN.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            HOVATEN.DataPropertyName = "HOVATEN";
            HOVATEN.HeaderText = "Họ và tên";
            HOVATEN.MinimumWidth = 6;
            HOVATEN.Name = "HOVATEN";
            HOVATEN.ReadOnly = true;
            // 
            // USERNAME
            // 
            USERNAME.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            USERNAME.DataPropertyName = "USERNAME";
            USERNAME.HeaderText = "Tên người dùng";
            USERNAME.MinimumWidth = 6;
            USERNAME.Name = "USERNAME";
            USERNAME.ReadOnly = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 82F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(968, 715);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(26, 56, 90);
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Roboto Condensed", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(968, 82);
            label1.TabIndex = 0;
            label1.Text = "TẠO TÀI KHOẢN";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 42.5449867F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 57.4550133F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel2.Controls.Add(dgvTaikhoan, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 82);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.Padding = new Padding(8);
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(968, 633);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(tableLayoutPanel14, 0, 5);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel13, 0, 4);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel12, 0, 3);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel5, 0, 1);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel6, 0, 2);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel4, 0, 0);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel7, 0, 7);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(8, 8);
            tableLayoutPanel3.Margin = new Padding(0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 8;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 62F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 62F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 62F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 62F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 62F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 62F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 172F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanel3.Size = new Size(405, 617);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // tableLayoutPanel14
            // 
            tableLayoutPanel14.ColumnCount = 2;
            tableLayoutPanel14.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.4622345F));
            tableLayoutPanel14.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 62.5377655F));
            tableLayoutPanel14.Controls.Add(btnTimkiem, 0, 0);
            tableLayoutPanel14.Controls.Add(label9, 1, 0);
            tableLayoutPanel14.Dock = DockStyle.Fill;
            tableLayoutPanel14.Location = new Point(0, 310);
            tableLayoutPanel14.Margin = new Padding(0);
            tableLayoutPanel14.Name = "tableLayoutPanel14";
            tableLayoutPanel14.RowCount = 1;
            tableLayoutPanel14.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel14.RowStyles.Add(new RowStyle(SizeType.Absolute, 62F));
            tableLayoutPanel14.Size = new Size(405, 62);
            tableLayoutPanel14.TabIndex = 16;
            // 
            // btnTimkiem
            // 
            btnTimkiem.Dock = DockStyle.Left;
            btnTimkiem.Font = new Font("Roboto Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTimkiem.Location = new Point(4, 4);
            btnTimkiem.Margin = new Padding(4);
            btnTimkiem.Name = "btnTimkiem";
            btnTimkiem.Size = new Size(142, 54);
            btnTimkiem.TabIndex = 7;
            btnTimkiem.Text = "Tìm kiếm";
            btnTimkiem.UseVisualStyleBackColor = true;
            btnTimkiem.Click += btnTimkiem_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Dock = DockStyle.Fill;
            label9.Font = new Font("Roboto Condensed", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(155, 0);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(246, 62);
            label9.TabIndex = 2;
            label9.Text = "(Nhập tên tài khoản để tìm kiếm)";
            label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel13
            // 
            tableLayoutPanel13.ColumnCount = 2;
            tableLayoutPanel13.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel13.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel13.Controls.Add(btnDondep, 1, 0);
            tableLayoutPanel13.Controls.Add(btnSua, 0, 0);
            tableLayoutPanel13.Dock = DockStyle.Fill;
            tableLayoutPanel13.Location = new Point(0, 248);
            tableLayoutPanel13.Margin = new Padding(0);
            tableLayoutPanel13.Name = "tableLayoutPanel13";
            tableLayoutPanel13.RowCount = 1;
            tableLayoutPanel13.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel13.Size = new Size(405, 62);
            tableLayoutPanel13.TabIndex = 15;
            // 
            // btnDondep
            // 
            btnDondep.Dock = DockStyle.Left;
            btnDondep.Font = new Font("Roboto Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDondep.Location = new Point(206, 4);
            btnDondep.Margin = new Padding(4);
            btnDondep.Name = "btnDondep";
            btnDondep.Size = new Size(142, 54);
            btnDondep.TabIndex = 6;
            btnDondep.Text = "Dọn dẹp";
            btnDondep.UseVisualStyleBackColor = true;
            btnDondep.Click += btnDondep_Click;
            // 
            // btnSua
            // 
            btnSua.Dock = DockStyle.Left;
            btnSua.Font = new Font("Roboto Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSua.Location = new Point(4, 4);
            btnSua.Margin = new Padding(4);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(142, 54);
            btnSua.TabIndex = 5;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // tableLayoutPanel12
            // 
            tableLayoutPanel12.ColumnCount = 2;
            tableLayoutPanel12.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel12.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel12.Controls.Add(btnXoa, 1, 0);
            tableLayoutPanel12.Controls.Add(btnThem, 0, 0);
            tableLayoutPanel12.Dock = DockStyle.Fill;
            tableLayoutPanel12.Location = new Point(0, 186);
            tableLayoutPanel12.Margin = new Padding(0);
            tableLayoutPanel12.Name = "tableLayoutPanel12";
            tableLayoutPanel12.RowCount = 1;
            tableLayoutPanel12.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel12.Size = new Size(405, 62);
            tableLayoutPanel12.TabIndex = 14;
            // 
            // btnXoa
            // 
            btnXoa.Dock = DockStyle.Left;
            btnXoa.Font = new Font("Roboto Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnXoa.Location = new Point(206, 4);
            btnXoa.Margin = new Padding(4);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(142, 54);
            btnXoa.TabIndex = 4;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThem
            // 
            btnThem.Dock = DockStyle.Left;
            btnThem.Font = new Font("Roboto Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnThem.Location = new Point(4, 4);
            btnThem.Margin = new Padding(4);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(142, 54);
            btnThem.TabIndex = 3;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.76435F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 62.23565F));
            tableLayoutPanel5.Controls.Add(label3, 0, 0);
            tableLayoutPanel5.Controls.Add(tbTennguoidung, 1, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(0, 62);
            tableLayoutPanel5.Margin = new Padding(0);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Size = new Size(405, 62);
            tableLayoutPanel5.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Roboto Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(4, 0);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(144, 62);
            label3.TabIndex = 0;
            label3.Text = "Tên người dùng:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tbTennguoidung
            // 
            tbTennguoidung.Anchor = AnchorStyles.Left;
            tbTennguoidung.BorderStyle = BorderStyle.FixedSingle;
            tbTennguoidung.Font = new Font("Roboto Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbTennguoidung.Location = new Point(156, 12);
            tbTennguoidung.Margin = new Padding(4);
            tbTennguoidung.Name = "tbTennguoidung";
            tbTennguoidung.Size = new Size(244, 38);
            tbTennguoidung.TabIndex = 1;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 2;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.76435F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 62.23565F));
            tableLayoutPanel6.Controls.Add(label4, 0, 0);
            tableLayoutPanel6.Controls.Add(tbMatkhau, 1, 0);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(0, 124);
            tableLayoutPanel6.Margin = new Padding(0);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Size = new Size(405, 62);
            tableLayoutPanel6.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Roboto Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(4, 0);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(144, 62);
            label4.TabIndex = 0;
            label4.Text = "Mật khẩu:";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tbMatkhau
            // 
            tbMatkhau.Anchor = AnchorStyles.Left;
            tbMatkhau.BorderStyle = BorderStyle.FixedSingle;
            tbMatkhau.Font = new Font("Roboto Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbMatkhau.Location = new Point(156, 12);
            tbMatkhau.Margin = new Padding(4);
            tbMatkhau.Name = "tbMatkhau";
            tbMatkhau.Size = new Size(244, 38);
            tbMatkhau.TabIndex = 2;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 2;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 63.2716064F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 36.7283936F));
            tableLayoutPanel7.Controls.Add(btnDangxuat, 1, 0);
            tableLayoutPanel7.Controls.Add(lbTenhienthi, 0, 0);
            tableLayoutPanel7.Dock = DockStyle.Fill;
            tableLayoutPanel7.Location = new Point(0, 544);
            tableLayoutPanel7.Margin = new Padding(0);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 1;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.Size = new Size(405, 73);
            tableLayoutPanel7.TabIndex = 17;
            // 
            // btnDangxuat
            // 
            btnDangxuat.Dock = DockStyle.Left;
            btnDangxuat.Font = new Font("Roboto Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDangxuat.Location = new Point(260, 4);
            btnDangxuat.Margin = new Padding(4);
            btnDangxuat.Name = "btnDangxuat";
            btnDangxuat.Size = new Size(141, 65);
            btnDangxuat.TabIndex = 8;
            btnDangxuat.Text = "Đăng xuất";
            btnDangxuat.UseVisualStyleBackColor = true;
            btnDangxuat.Click += btnDangxuat_Click;
            // 
            // lbTenhienthi
            // 
            lbTenhienthi.AutoSize = true;
            lbTenhienthi.Dock = DockStyle.Fill;
            lbTenhienthi.Font = new Font("Roboto Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbTenhienthi.Location = new Point(4, 0);
            lbTenhienthi.Margin = new Padding(4, 0, 4, 0);
            lbTenhienthi.Name = "lbTenhienthi";
            lbTenhienthi.Size = new Size(248, 73);
            lbTenhienthi.TabIndex = 0;
            lbTenhienthi.Text = "Nguyễn Văn A";
            lbTenhienthi.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // frmTaotaikhoan
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(968, 715);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(4);
            Name = "frmTaotaikhoan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tạo tài khoản";
            FormClosed += frmTaotaikhoan_FormClosed;
            Load += frmTaotaikhoan_Load;
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTaikhoan).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel14.ResumeLayout(false);
            tableLayoutPanel14.PerformLayout();
            tableLayoutPanel13.ResumeLayout(false);
            tableLayoutPanel12.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel7.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel4;
        private Label label2;
        private TextBox tbHovaten;
        private DataGridView dgvTaikhoan;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel6;
        private Label label4;
        private TextBox tbMatkhau;
        private TableLayoutPanel tableLayoutPanel5;
        private Label label3;
        private TextBox tbTennguoidung;
        private TableLayoutPanel tableLayoutPanel14;
        private Button btnTimkiem;
        private Label label9;
        private TableLayoutPanel tableLayoutPanel13;
        private Button btnDondep;
        private Button btnSua;
        private TableLayoutPanel tableLayoutPanel12;
        private Button btnXoa;
        private Button btnThem;
        private TableLayoutPanel tableLayoutPanel7;
        private Label lbTenhienthi;
        private Button btnDangxuat;
        private DataGridViewTextBoxColumn HOVATEN;
        private DataGridViewTextBoxColumn USERNAME;
    }
}