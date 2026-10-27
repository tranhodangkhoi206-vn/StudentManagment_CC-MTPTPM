namespace StudentManagment.GUI.User_Control
{
    partial class Quanlimonhoc
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel10 = new TableLayoutPanel();
            cbxTinhtrang = new ComboBox();
            label8 = new Label();
            tableLayoutPanel9 = new TableLayoutPanel();
            txbGiangvien = new TextBox();
            label7 = new Label();
            tableLayoutPanel5 = new TableLayoutPanel();
            label4 = new Label();
            cbxChuyennganh = new ComboBox();
            tableLayoutPanel4 = new TableLayoutPanel();
            label3 = new Label();
            txbTenmonhoc = new TextBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            label2 = new Label();
            txbMamonhoc = new TextBox();
            tableLayoutPanel6 = new TableLayoutPanel();
            tableLayoutPanel8 = new TableLayoutPanel();
            label6 = new Label();
            nudThuchanh = new NumericUpDown();
            tableLayoutPanel7 = new TableLayoutPanel();
            label5 = new Label();
            nudLythuyet = new NumericUpDown();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnThem = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnLammoi = new Button();
            dgvDanhsachmonhoc = new DataGridView();
            MAMON = new DataGridViewTextBoxColumn();
            TINHTRANG = new DataGridViewTextBoxColumn();
            TENMON = new DataGridViewTextBoxColumn();
            MANGANH = new DataGridViewTextBoxColumn();
            SOTIETLYTHUYET = new DataGridViewTextBoxColumn();
            SOTIETTHUCHANH = new DataGridViewTextBoxColumn();
            GIANGVIEN = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel10.SuspendLayout();
            tableLayoutPanel9.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            tableLayoutPanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudThuchanh).BeginInit();
            tableLayoutPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudLythuyet).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDanhsachmonhoc).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1060, 85);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Roboto Condensed", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(18, 8);
            label1.Name = "label1";
            label1.Size = new Size(392, 58);
            label1.TabIndex = 0;
            label1.Text = "QUẢN LÝ MÔN HỌC";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 399F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 510F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(dgvDanhsachmonhoc, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 85);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1060, 636);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel10, 0, 5);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel9, 0, 4);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel5, 0, 2);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel4, 0, 1);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel6, 0, 3);
            tableLayoutPanel2.Controls.Add(flowLayoutPanel1, 0, 6);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 8;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(399, 636);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel10
            // 
            tableLayoutPanel10.ColumnCount = 2;
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.2673264F));
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66.73267F));
            tableLayoutPanel10.Controls.Add(cbxTinhtrang, 1, 0);
            tableLayoutPanel10.Controls.Add(label8, 0, 0);
            tableLayoutPanel10.Dock = DockStyle.Fill;
            tableLayoutPanel10.Location = new Point(0, 300);
            tableLayoutPanel10.Margin = new Padding(0);
            tableLayoutPanel10.Name = "tableLayoutPanel10";
            tableLayoutPanel10.RowCount = 1;
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel10.Size = new Size(399, 60);
            tableLayoutPanel10.TabIndex = 5;
            // 
            // cbxTinhtrang
            // 
            cbxTinhtrang.Anchor = AnchorStyles.Left;
            cbxTinhtrang.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxTinhtrang.Font = new Font("Roboto Condensed", 14F);
            cbxTinhtrang.FormattingEnabled = true;
            cbxTinhtrang.Items.AddRange(new object[] { "Đang dạy", "Ngưng dạy" });
            cbxTinhtrang.Location = new Point(135, 14);
            cbxTinhtrang.Name = "cbxTinhtrang";
            cbxTinhtrang.Size = new Size(261, 31);
            cbxTinhtrang.TabIndex = 2;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Dock = DockStyle.Fill;
            label8.Font = new Font("Roboto Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(3, 0);
            label8.Name = "label8";
            label8.Size = new Size(126, 60);
            label8.TabIndex = 0;
            label8.Text = "Tình trạng:";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel9
            // 
            tableLayoutPanel9.ColumnCount = 2;
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.2673264F));
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66.73267F));
            tableLayoutPanel9.Controls.Add(txbGiangvien, 1, 0);
            tableLayoutPanel9.Controls.Add(label7, 0, 0);
            tableLayoutPanel9.Dock = DockStyle.Fill;
            tableLayoutPanel9.Location = new Point(0, 240);
            tableLayoutPanel9.Margin = new Padding(0);
            tableLayoutPanel9.Name = "tableLayoutPanel9";
            tableLayoutPanel9.RowCount = 1;
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel9.Size = new Size(399, 60);
            tableLayoutPanel9.TabIndex = 4;
            // 
            // txbGiangvien
            // 
            txbGiangvien.Anchor = AnchorStyles.Left;
            txbGiangvien.BorderStyle = BorderStyle.FixedSingle;
            txbGiangvien.Font = new Font("Roboto Condensed", 14F);
            txbGiangvien.Location = new Point(135, 15);
            txbGiangvien.Name = "txbGiangvien";
            txbGiangvien.Size = new Size(261, 30);
            txbGiangvien.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = DockStyle.Fill;
            label7.Font = new Font("Roboto Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(3, 0);
            label7.Name = "label7";
            label7.Size = new Size(126, 60);
            label7.TabIndex = 0;
            label7.Text = "Giảng viên phụ trách:";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.2673264F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66.73267F));
            tableLayoutPanel5.Controls.Add(label4, 0, 0);
            tableLayoutPanel5.Controls.Add(cbxChuyennganh, 1, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(0, 120);
            tableLayoutPanel5.Margin = new Padding(0);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Size = new Size(399, 60);
            tableLayoutPanel5.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Roboto Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(3, 0);
            label4.Name = "label4";
            label4.Size = new Size(126, 60);
            label4.TabIndex = 0;
            label4.Text = "Ngành học:";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cbxChuyennganh
            // 
            cbxChuyennganh.Anchor = AnchorStyles.Left;
            cbxChuyennganh.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxChuyennganh.Font = new Font("Roboto Condensed", 14F);
            cbxChuyennganh.FormattingEnabled = true;
            cbxChuyennganh.Location = new Point(135, 14);
            cbxChuyennganh.Name = "cbxChuyennganh";
            cbxChuyennganh.Size = new Size(261, 31);
            cbxChuyennganh.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66.6666641F));
            tableLayoutPanel4.Controls.Add(label3, 0, 0);
            tableLayoutPanel4.Controls.Add(txbTenmonhoc, 1, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(0, 60);
            tableLayoutPanel4.Margin = new Padding(0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(399, 60);
            tableLayoutPanel4.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Roboto Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(126, 60);
            label3.TabIndex = 0;
            label3.Text = "Tên môn học:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txbTenmonhoc
            // 
            txbTenmonhoc.Anchor = AnchorStyles.Left;
            txbTenmonhoc.BorderStyle = BorderStyle.FixedSingle;
            txbTenmonhoc.Font = new Font("Roboto Condensed", 14F);
            txbTenmonhoc.Location = new Point(135, 15);
            txbTenmonhoc.Name = "txbTenmonhoc";
            txbTenmonhoc.Size = new Size(261, 30);
            txbTenmonhoc.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.2673264F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66.73267F));
            tableLayoutPanel3.Controls.Add(label2, 0, 0);
            tableLayoutPanel3.Controls.Add(txbMamonhoc, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Margin = new Padding(0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(399, 60);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Roboto Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(126, 60);
            label2.TabIndex = 0;
            label2.Text = "Mã môn học:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txbMamonhoc
            // 
            txbMamonhoc.Anchor = AnchorStyles.Left;
            txbMamonhoc.BorderStyle = BorderStyle.FixedSingle;
            txbMamonhoc.Font = new Font("Roboto Condensed", 14F);
            txbMamonhoc.Location = new Point(135, 15);
            txbMamonhoc.Name = "txbMamonhoc";
            txbMamonhoc.Size = new Size(261, 30);
            txbMamonhoc.TabIndex = 1;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 2;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Controls.Add(tableLayoutPanel8, 1, 0);
            tableLayoutPanel6.Controls.Add(tableLayoutPanel7, 0, 0);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(0, 180);
            tableLayoutPanel6.Margin = new Padding(0);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Size = new Size(399, 60);
            tableLayoutPanel6.TabIndex = 3;
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.ColumnCount = 2;
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 69.94819F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30.0518131F));
            tableLayoutPanel8.Controls.Add(label6, 0, 0);
            tableLayoutPanel8.Controls.Add(nudThuchanh, 1, 0);
            tableLayoutPanel8.Dock = DockStyle.Fill;
            tableLayoutPanel8.Location = new Point(199, 0);
            tableLayoutPanel8.Margin = new Padding(0);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 1;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.Size = new Size(200, 60);
            tableLayoutPanel8.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Fill;
            label6.Font = new Font("Roboto Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(3, 0);
            label6.Name = "label6";
            label6.Size = new Size(133, 60);
            label6.TabIndex = 1;
            label6.Text = "Thực hành:";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // nudThuchanh
            // 
            nudThuchanh.Anchor = AnchorStyles.Left;
            nudThuchanh.Font = new Font("Roboto Condensed", 14F);
            nudThuchanh.Location = new Point(142, 15);
            nudThuchanh.Name = "nudThuchanh";
            nudThuchanh.Size = new Size(55, 30);
            nudThuchanh.TabIndex = 2;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 2;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 68.75F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 31.25F));
            tableLayoutPanel7.Controls.Add(label5, 0, 0);
            tableLayoutPanel7.Controls.Add(nudLythuyet, 1, 0);
            tableLayoutPanel7.Dock = DockStyle.Fill;
            tableLayoutPanel7.Location = new Point(0, 0);
            tableLayoutPanel7.Margin = new Padding(0);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 1;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.Size = new Size(199, 60);
            tableLayoutPanel7.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Font = new Font("Roboto Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(3, 0);
            label5.Name = "label5";
            label5.Size = new Size(130, 60);
            label5.TabIndex = 0;
            label5.Text = "Lý thuyết:";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // nudLythuyet
            // 
            nudLythuyet.Anchor = AnchorStyles.Left;
            nudLythuyet.Font = new Font("Roboto Condensed", 14F);
            nudLythuyet.Location = new Point(139, 15);
            nudLythuyet.Name = "nudLythuyet";
            nudLythuyet.Size = new Size(57, 30);
            nudLythuyet.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnThem);
            flowLayoutPanel1.Controls.Add(btnXoa);
            flowLayoutPanel1.Controls.Add(btnSua);
            flowLayoutPanel1.Controls.Add(btnLammoi);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 360);
            flowLayoutPanel1.Margin = new Padding(0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(399, 60);
            flowLayoutPanel1.TabIndex = 6;
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Roboto Condensed", 14.25F);
            btnThem.Location = new Point(3, 3);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(92, 57);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Roboto Condensed", 14.25F);
            btnXoa.Location = new Point(101, 3);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(95, 57);
            btnXoa.TabIndex = 1;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Font = new Font("Roboto Condensed", 14.25F);
            btnSua.Location = new Point(202, 3);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(75, 57);
            btnSua.TabIndex = 2;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnLammoi
            // 
            btnLammoi.Font = new Font("Roboto Condensed", 14.25F);
            btnLammoi.Location = new Point(283, 3);
            btnLammoi.Name = "btnLammoi";
            btnLammoi.Size = new Size(113, 57);
            btnLammoi.TabIndex = 3;
            btnLammoi.Text = "Làm mới";
            btnLammoi.UseVisualStyleBackColor = true;
            btnLammoi.Click += btnLammoi_Click;
            // 
            // dgvDanhsachmonhoc
            // 
            dgvDanhsachmonhoc.AllowUserToAddRows = false;
            dgvDanhsachmonhoc.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Roboto Condensed", 12F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvDanhsachmonhoc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvDanhsachmonhoc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDanhsachmonhoc.Columns.AddRange(new DataGridViewColumn[] { MAMON, TINHTRANG, TENMON, MANGANH, SOTIETLYTHUYET, SOTIETTHUCHANH, GIANGVIEN });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Roboto Condensed", 12F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvDanhsachmonhoc.DefaultCellStyle = dataGridViewCellStyle2;
            dgvDanhsachmonhoc.Dock = DockStyle.Fill;
            dgvDanhsachmonhoc.Location = new Point(402, 3);
            dgvDanhsachmonhoc.Name = "dgvDanhsachmonhoc";
            dgvDanhsachmonhoc.ReadOnly = true;
            dgvDanhsachmonhoc.Size = new Size(655, 630);
            dgvDanhsachmonhoc.TabIndex = 1;
            // 
            // MAMON
            // 
            MAMON.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            MAMON.DataPropertyName = "MAMON";
            MAMON.HeaderText = "Mã môn học";
            MAMON.Name = "MAMON";
            MAMON.ReadOnly = true;
            MAMON.Width = 113;
            // 
            // TINHTRANG
            // 
            TINHTRANG.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            TINHTRANG.DataPropertyName = "TINHTRANG";
            TINHTRANG.HeaderText = "Tình trạng";
            TINHTRANG.Name = "TINHTRANG";
            TINHTRANG.ReadOnly = true;
            // 
            // TENMON
            // 
            TENMON.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            TENMON.DataPropertyName = "TENMON";
            TENMON.HeaderText = "Tên môn học";
            TENMON.Name = "TENMON";
            TENMON.ReadOnly = true;
            TENMON.Width = 116;
            // 
            // MANGANH
            // 
            MANGANH.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            MANGANH.DataPropertyName = "MANGANH";
            MANGANH.HeaderText = "Mã ngành";
            MANGANH.Name = "MANGANH";
            MANGANH.ReadOnly = true;
            MANGANH.Width = 98;
            // 
            // SOTIETLYTHUYET
            // 
            SOTIETLYTHUYET.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            SOTIETLYTHUYET.DataPropertyName = "SOTIETLYTHUYET";
            SOTIETLYTHUYET.HeaderText = "Tiết lý thuyết";
            SOTIETLYTHUYET.Name = "SOTIETLYTHUYET";
            SOTIETLYTHUYET.ReadOnly = true;
            SOTIETLYTHUYET.Width = 119;
            // 
            // SOTIETTHUCHANH
            // 
            SOTIETTHUCHANH.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            SOTIETTHUCHANH.DataPropertyName = "SOTIETTHUCHANH";
            SOTIETTHUCHANH.HeaderText = "Tiết thực hành";
            SOTIETTHUCHANH.Name = "SOTIETTHUCHANH";
            SOTIETTHUCHANH.ReadOnly = true;
            SOTIETTHUCHANH.Width = 128;
            // 
            // GIANGVIEN
            // 
            GIANGVIEN.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            GIANGVIEN.DataPropertyName = "GIANGVIEN";
            GIANGVIEN.HeaderText = "Giảng viên";
            GIANGVIEN.Name = "GIANGVIEN";
            GIANGVIEN.ReadOnly = true;
            GIANGVIEN.Width = 102;
            // 
            // Quanlimonhoc
            // 
            AutoScaleDimensions = new SizeF(6F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel1);
            Font = new Font("Roboto Condensed", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Quanlimonhoc";
            Size = new Size(1060, 721);
            Load += Quanlimonhoc_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel10.ResumeLayout(false);
            tableLayoutPanel10.PerformLayout();
            tableLayoutPanel9.ResumeLayout(false);
            tableLayoutPanel9.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel8.ResumeLayout(false);
            tableLayoutPanel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudThuchanh).EndInit();
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudLythuyet).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDanhsachmonhoc).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel5;
        private Label label4;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label3;
        private TextBox txbTenmonhoc;
        private TextBox txbMamonhoc;
        private ComboBox cbxChuyennganh;
        private TableLayoutPanel tableLayoutPanel6;
        private TableLayoutPanel tableLayoutPanel8;
        private TableLayoutPanel tableLayoutPanel7;
        private Label label5;
        private Label label6;
        private NumericUpDown nudLythuyet;
        private NumericUpDown nudThuchanh;
        private TableLayoutPanel tableLayoutPanel10;
        private Label label8;
        private TableLayoutPanel tableLayoutPanel9;
        private TextBox txbGiangvien;
        private Label label7;
        private TextBox textBox4;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnXoa;
        private Button btnSua;
        private Button btnLammoi;
        private Button button4;
        private DataGridView dgvDanhsachmonhoc;
        private ComboBox cbxTinhtrang;
        private Button btnThem;
        private DataGridViewTextBoxColumn MAMON;
        private DataGridViewTextBoxColumn TINHTRANG;
        private DataGridViewTextBoxColumn TENMON;
        private DataGridViewTextBoxColumn MANGANH;
        private DataGridViewTextBoxColumn SOTIETLYTHUYET;
        private DataGridViewTextBoxColumn SOTIETTHUCHANH;
        private DataGridViewTextBoxColumn GIANGVIEN;
    }
}
