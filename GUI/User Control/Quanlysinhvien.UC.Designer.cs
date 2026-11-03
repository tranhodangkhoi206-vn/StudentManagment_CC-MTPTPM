namespace StudentManagment.GUI.User_Control
{
    partial class Quanlysinhvien
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
            tableLayoutPanel10 = new TableLayoutPanel();
            cbTinhtrang = new ComboBox();
            label8 = new Label();
            tableLayoutPanel9 = new TableLayoutPanel();
            cbManganh = new ComboBox();
            label7 = new Label();
            tableLayoutPanel8 = new TableLayoutPanel();
            label6 = new Label();
            cbMalop = new ComboBox();
            tableLayoutPanel7 = new TableLayoutPanel();
            label5 = new Label();
            dtpNgaysinh = new DateTimePicker();
            tableLayoutPanel6 = new TableLayoutPanel();
            label4 = new Label();
            tableLayoutPanel11 = new TableLayoutPanel();
            rbNu = new RadioButton();
            rbNam = new RadioButton();
            tableLayoutPanel5 = new TableLayoutPanel();
            label3 = new Label();
            tbHovaten = new TextBox();
            tableLayoutPanel4 = new TableLayoutPanel();
            label2 = new Label();
            tbMasinhvien = new TextBox();
            tableLayoutPanel12 = new TableLayoutPanel();
            btnXoa = new Button();
            btnThem = new Button();
            dgvSinhvien = new DataGridView();
            MASV = new DataGridViewTextBoxColumn();
            HOVATEN = new DataGridViewTextBoxColumn();
            GIOITINH = new DataGridViewTextBoxColumn();
            NGAYSINH = new DataGridViewTextBoxColumn();
            MALOP = new DataGridViewTextBoxColumn();
            MANGANH = new DataGridViewTextBoxColumn();
            TINHTRANG = new DataGridViewTextBoxColumn();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel14.SuspendLayout();
            tableLayoutPanel13.SuspendLayout();
            tableLayoutPanel10.SuspendLayout();
            tableLayoutPanel9.SuspendLayout();
            tableLayoutPanel8.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            tableLayoutPanel11.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSinhvien).BeginInit();
            SuspendLayout();
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
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 66F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(790, 611);
            tableLayoutPanel1.TabIndex = 0;
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
            label1.Size = new Size(790, 66);
            label1.TabIndex = 0;
            label1.Text = "QUẢN LÝ SINH VIÊN";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 42.5449867F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 57.4550133F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel2.Controls.Add(dgvSinhvien, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 66);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.Padding = new Padding(6);
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(790, 545);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(tableLayoutPanel14, 0, 9);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel13, 0, 8);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel10, 0, 6);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel9, 0, 5);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel8, 0, 4);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel7, 0, 3);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel6, 0, 2);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel5, 0, 1);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel4, 0, 0);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel12, 0, 7);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(6, 6);
            tableLayoutPanel3.Margin = new Padding(0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 11;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel3.Size = new Size(331, 533);
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
            tableLayoutPanel14.Location = new Point(0, 450);
            tableLayoutPanel14.Margin = new Padding(0);
            tableLayoutPanel14.Name = "tableLayoutPanel14";
            tableLayoutPanel14.RowCount = 1;
            tableLayoutPanel14.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel14.Size = new Size(331, 50);
            tableLayoutPanel14.TabIndex = 9;
            // 
            // btnTimkiem
            // 
            btnTimkiem.Dock = DockStyle.Left;
            btnTimkiem.Font = new Font("Roboto Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTimkiem.Location = new Point(3, 3);
            btnTimkiem.Name = "btnTimkiem";
            btnTimkiem.Size = new Size(114, 44);
            btnTimkiem.TabIndex = 1;
            btnTimkiem.Text = "Tìm kiếm";
            btnTimkiem.UseVisualStyleBackColor = true;
            btnTimkiem.Click += btnTimkiem_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Dock = DockStyle.Fill;
            label9.Font = new Font("Roboto Condensed", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(127, 0);
            label9.Name = "label9";
            label9.Size = new Size(201, 50);
            label9.TabIndex = 2;
            label9.Text = "(Nhập mã sinh viên để tìm kiếm)";
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
            tableLayoutPanel13.Location = new Point(0, 400);
            tableLayoutPanel13.Margin = new Padding(0);
            tableLayoutPanel13.Name = "tableLayoutPanel13";
            tableLayoutPanel13.RowCount = 1;
            tableLayoutPanel13.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel13.Size = new Size(331, 50);
            tableLayoutPanel13.TabIndex = 8;
            // 
            // btnDondep
            // 
            btnDondep.Dock = DockStyle.Left;
            btnDondep.Font = new Font("Roboto Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDondep.Location = new Point(168, 3);
            btnDondep.Name = "btnDondep";
            btnDondep.Size = new Size(114, 44);
            btnDondep.TabIndex = 2;
            btnDondep.Text = "Dọn dẹp";
            btnDondep.UseVisualStyleBackColor = true;
            btnDondep.Click += btnDondep_Click;
            // 
            // btnSua
            // 
            btnSua.Dock = DockStyle.Left;
            btnSua.Font = new Font("Roboto Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSua.Location = new Point(3, 3);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(114, 44);
            btnSua.TabIndex = 1;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // tableLayoutPanel10
            // 
            tableLayoutPanel10.ColumnCount = 2;
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 36.2537766F));
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 63.7462234F));
            tableLayoutPanel10.Controls.Add(cbTinhtrang, 1, 0);
            tableLayoutPanel10.Controls.Add(label8, 0, 0);
            tableLayoutPanel10.Dock = DockStyle.Fill;
            tableLayoutPanel10.Location = new Point(0, 300);
            tableLayoutPanel10.Margin = new Padding(0);
            tableLayoutPanel10.Name = "tableLayoutPanel10";
            tableLayoutPanel10.RowCount = 1;
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel10.Size = new Size(331, 50);
            tableLayoutPanel10.TabIndex = 6;
            // 
            // cbTinhtrang
            // 
            cbTinhtrang.Anchor = AnchorStyles.Left;
            cbTinhtrang.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTinhtrang.Font = new Font("Roboto Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbTinhtrang.FormattingEnabled = true;
            cbTinhtrang.Items.AddRange(new object[] { "Đang học", "Đang bảo lưu", "Đã tốt nghiệp" });
            cbTinhtrang.Location = new Point(123, 9);
            cbTinhtrang.Name = "cbTinhtrang";
            cbTinhtrang.Size = new Size(205, 32);
            cbTinhtrang.TabIndex = 2;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Dock = DockStyle.Fill;
            label8.Font = new Font("Roboto Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(3, 0);
            label8.Name = "label8";
            label8.Size = new Size(114, 50);
            label8.TabIndex = 0;
            label8.Text = "Tình trạng:";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel9
            // 
            tableLayoutPanel9.ColumnCount = 2;
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 36.2537766F));
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 63.7462234F));
            tableLayoutPanel9.Controls.Add(cbManganh, 1, 0);
            tableLayoutPanel9.Controls.Add(label7, 0, 0);
            tableLayoutPanel9.Dock = DockStyle.Fill;
            tableLayoutPanel9.Location = new Point(0, 250);
            tableLayoutPanel9.Margin = new Padding(0);
            tableLayoutPanel9.Name = "tableLayoutPanel9";
            tableLayoutPanel9.RowCount = 1;
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel9.Size = new Size(331, 50);
            tableLayoutPanel9.TabIndex = 5;
            // 
            // cbManganh
            // 
            cbManganh.Anchor = AnchorStyles.Left;
            cbManganh.DropDownStyle = ComboBoxStyle.DropDownList;
            cbManganh.Font = new Font("Roboto Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbManganh.FormattingEnabled = true;
            cbManganh.Location = new Point(123, 9);
            cbManganh.Name = "cbManganh";
            cbManganh.Size = new Size(205, 32);
            cbManganh.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = DockStyle.Fill;
            label7.Font = new Font("Roboto Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(3, 0);
            label7.Name = "label7";
            label7.Size = new Size(114, 50);
            label7.TabIndex = 0;
            label7.Text = "Mã ngành:";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.ColumnCount = 2;
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 36.2537766F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 63.7462234F));
            tableLayoutPanel8.Controls.Add(label6, 0, 0);
            tableLayoutPanel8.Controls.Add(cbMalop, 1, 0);
            tableLayoutPanel8.Dock = DockStyle.Fill;
            tableLayoutPanel8.Location = new Point(0, 200);
            tableLayoutPanel8.Margin = new Padding(0);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 1;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.Size = new Size(331, 50);
            tableLayoutPanel8.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Fill;
            label6.Font = new Font("Roboto Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(3, 0);
            label6.Name = "label6";
            label6.Size = new Size(114, 50);
            label6.TabIndex = 0;
            label6.Text = "Mã lớp:";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cbMalop
            // 
            cbMalop.Anchor = AnchorStyles.Left;
            cbMalop.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMalop.Font = new Font("Roboto Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbMalop.FormattingEnabled = true;
            cbMalop.Location = new Point(123, 9);
            cbMalop.Name = "cbMalop";
            cbMalop.Size = new Size(205, 32);
            cbMalop.TabIndex = 1;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 2;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 36.2537766F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 63.7462234F));
            tableLayoutPanel7.Controls.Add(label5, 0, 0);
            tableLayoutPanel7.Controls.Add(dtpNgaysinh, 1, 0);
            tableLayoutPanel7.Dock = DockStyle.Fill;
            tableLayoutPanel7.Location = new Point(0, 150);
            tableLayoutPanel7.Margin = new Padding(0);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 1;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel7.Size = new Size(331, 50);
            tableLayoutPanel7.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Font = new Font("Roboto Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(3, 0);
            label5.Name = "label5";
            label5.Size = new Size(114, 50);
            label5.TabIndex = 0;
            label5.Text = "Ngày sinh:";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dtpNgaysinh
            // 
            dtpNgaysinh.Anchor = AnchorStyles.Left;
            dtpNgaysinh.CalendarFont = new Font("Roboto Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpNgaysinh.Font = new Font("Roboto Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpNgaysinh.Format = DateTimePickerFormat.Short;
            dtpNgaysinh.Location = new Point(123, 9);
            dtpNgaysinh.Name = "dtpNgaysinh";
            dtpNgaysinh.Size = new Size(205, 32);
            dtpNgaysinh.TabIndex = 1;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 2;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 36.2537766F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 63.7462234F));
            tableLayoutPanel6.Controls.Add(label4, 0, 0);
            tableLayoutPanel6.Controls.Add(tableLayoutPanel11, 1, 0);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(0, 100);
            tableLayoutPanel6.Margin = new Padding(0);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Size = new Size(331, 50);
            tableLayoutPanel6.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Roboto Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(3, 0);
            label4.Name = "label4";
            label4.Size = new Size(114, 50);
            label4.TabIndex = 0;
            label4.Text = "Giới tính:";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel11
            // 
            tableLayoutPanel11.ColumnCount = 2;
            tableLayoutPanel11.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel11.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel11.Controls.Add(rbNu, 1, 0);
            tableLayoutPanel11.Controls.Add(rbNam, 0, 0);
            tableLayoutPanel11.Dock = DockStyle.Fill;
            tableLayoutPanel11.Font = new Font("Roboto Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tableLayoutPanel11.Location = new Point(120, 0);
            tableLayoutPanel11.Margin = new Padding(0);
            tableLayoutPanel11.Name = "tableLayoutPanel11";
            tableLayoutPanel11.RowCount = 1;
            tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel11.Size = new Size(211, 50);
            tableLayoutPanel11.TabIndex = 1;
            // 
            // rbNu
            // 
            rbNu.AutoSize = true;
            rbNu.Dock = DockStyle.Fill;
            rbNu.Location = new Point(108, 3);
            rbNu.Name = "rbNu";
            rbNu.Size = new Size(100, 44);
            rbNu.TabIndex = 1;
            rbNu.TabStop = true;
            rbNu.Text = "Nữ";
            rbNu.UseVisualStyleBackColor = true;
            // 
            // rbNam
            // 
            rbNam.AutoSize = true;
            rbNam.Dock = DockStyle.Fill;
            rbNam.Location = new Point(3, 3);
            rbNam.Name = "rbNam";
            rbNam.Size = new Size(99, 44);
            rbNam.TabIndex = 0;
            rbNam.TabStop = true;
            rbNam.Text = "Nam";
            rbNam.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30.2114811F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 69.78852F));
            tableLayoutPanel5.Controls.Add(label3, 0, 0);
            tableLayoutPanel5.Controls.Add(tbHovaten, 1, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(0, 50);
            tableLayoutPanel5.Margin = new Padding(0);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Size = new Size(331, 50);
            tableLayoutPanel5.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Roboto Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(94, 50);
            label3.TabIndex = 0;
            label3.Text = "Họ và tên:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tbHovaten
            // 
            tbHovaten.Anchor = AnchorStyles.Left;
            tbHovaten.BorderStyle = BorderStyle.FixedSingle;
            tbHovaten.Font = new Font("Roboto Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbHovaten.Location = new Point(103, 9);
            tbHovaten.Name = "tbHovaten";
            tbHovaten.Size = new Size(225, 32);
            tbHovaten.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.76435F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 62.23565F));
            tableLayoutPanel4.Controls.Add(label2, 0, 0);
            tableLayoutPanel4.Controls.Add(tbMasinhvien, 1, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(0, 0);
            tableLayoutPanel4.Margin = new Padding(0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(331, 50);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Roboto Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(119, 50);
            label2.TabIndex = 0;
            label2.Text = "Mã sinh viên:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tbMasinhvien
            // 
            tbMasinhvien.Anchor = AnchorStyles.Left;
            tbMasinhvien.BorderStyle = BorderStyle.FixedSingle;
            tbMasinhvien.Font = new Font("Roboto Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbMasinhvien.Location = new Point(128, 9);
            tbMasinhvien.Name = "tbMasinhvien";
            tbMasinhvien.Size = new Size(200, 32);
            tbMasinhvien.TabIndex = 1;
            // 
            // tableLayoutPanel12
            // 
            tableLayoutPanel12.ColumnCount = 2;
            tableLayoutPanel12.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel12.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel12.Controls.Add(btnXoa, 1, 0);
            tableLayoutPanel12.Controls.Add(btnThem, 0, 0);
            tableLayoutPanel12.Dock = DockStyle.Fill;
            tableLayoutPanel12.Location = new Point(0, 350);
            tableLayoutPanel12.Margin = new Padding(0);
            tableLayoutPanel12.Name = "tableLayoutPanel12";
            tableLayoutPanel12.RowCount = 1;
            tableLayoutPanel12.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel12.Size = new Size(331, 50);
            tableLayoutPanel12.TabIndex = 7;
            // 
            // btnXoa
            // 
            btnXoa.Dock = DockStyle.Left;
            btnXoa.Font = new Font("Roboto Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnXoa.Location = new Point(168, 3);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(114, 44);
            btnXoa.TabIndex = 1;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThem
            // 
            btnThem.Dock = DockStyle.Left;
            btnThem.Font = new Font("Roboto Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnThem.Location = new Point(3, 3);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(114, 44);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // dgvSinhvien
            // 
            dgvSinhvien.AllowUserToAddRows = false;
            dgvSinhvien.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvSinhvien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvSinhvien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSinhvien.Columns.AddRange(new DataGridViewColumn[] { MASV, HOVATEN, GIOITINH, NGAYSINH, MALOP, MANGANH, TINHTRANG });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvSinhvien.DefaultCellStyle = dataGridViewCellStyle2;
            dgvSinhvien.Dock = DockStyle.Fill;
            dgvSinhvien.Location = new Point(337, 6);
            dgvSinhvien.Margin = new Padding(0);
            dgvSinhvien.Name = "dgvSinhvien";
            dgvSinhvien.ReadOnly = true;
            dgvSinhvien.RowHeadersWidth = 51;
            dgvSinhvien.Size = new Size(447, 533);
            dgvSinhvien.TabIndex = 1;
            // 
            // MASV
            // 
            MASV.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            MASV.DataPropertyName = "MASV";
            MASV.HeaderText = "Mã sinh viên";
            MASV.MinimumWidth = 6;
            MASV.Name = "MASV";
            MASV.ReadOnly = true;
            MASV.Width = 116;
            // 
            // HOVATEN
            // 
            HOVATEN.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            HOVATEN.DataPropertyName = "HOVATEN";
            HOVATEN.HeaderText = "Họ và tên";
            HOVATEN.MinimumWidth = 6;
            HOVATEN.Name = "HOVATEN";
            HOVATEN.ReadOnly = true;
            HOVATEN.Width = 96;
            // 
            // GIOITINH
            // 
            GIOITINH.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            GIOITINH.DataPropertyName = "GIOITINH";
            GIOITINH.HeaderText = "Giới tính";
            GIOITINH.MinimumWidth = 6;
            GIOITINH.Name = "GIOITINH";
            GIOITINH.ReadOnly = true;
            GIOITINH.Width = 88;
            // 
            // NGAYSINH
            // 
            NGAYSINH.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            NGAYSINH.DataPropertyName = "NGAYSINH";
            NGAYSINH.HeaderText = "Ngày sinh";
            NGAYSINH.MinimumWidth = 6;
            NGAYSINH.Name = "NGAYSINH";
            NGAYSINH.ReadOnly = true;
            NGAYSINH.Width = 98;
            // 
            // MALOP
            // 
            MALOP.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            MALOP.DataPropertyName = "MALOP";
            MALOP.HeaderText = "Mã lớp";
            MALOP.MinimumWidth = 6;
            MALOP.Name = "MALOP";
            MALOP.ReadOnly = true;
            MALOP.Width = 78;
            // 
            // MANGANH
            // 
            MANGANH.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            MANGANH.DataPropertyName = "MANGANH";
            MANGANH.HeaderText = "Mã ngành";
            MANGANH.MinimumWidth = 6;
            MANGANH.Name = "MANGANH";
            MANGANH.ReadOnly = true;
            MANGANH.Width = 98;
            // 
            // TINHTRANG
            // 
            TINHTRANG.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            TINHTRANG.DataPropertyName = "TINHTRANG";
            TINHTRANG.HeaderText = "Tình trạng";
            TINHTRANG.MinimumWidth = 6;
            TINHTRANG.Name = "TINHTRANG";
            TINHTRANG.ReadOnly = true;
            // 
            // Quanlysinhvien
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Quanlysinhvien";
            Size = new Size(790, 611);
            Load += Quanlysinhvien_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel14.ResumeLayout(false);
            tableLayoutPanel14.PerformLayout();
            tableLayoutPanel13.ResumeLayout(false);
            tableLayoutPanel10.ResumeLayout(false);
            tableLayoutPanel10.PerformLayout();
            tableLayoutPanel9.ResumeLayout(false);
            tableLayoutPanel9.PerformLayout();
            tableLayoutPanel8.ResumeLayout(false);
            tableLayoutPanel8.PerformLayout();
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel7.PerformLayout();
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            tableLayoutPanel11.ResumeLayout(false);
            tableLayoutPanel11.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel12.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSinhvien).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label2;
        private TextBox tbMasinhvien;
        private TableLayoutPanel tableLayoutPanel6;
        private Label label4;
        private TableLayoutPanel tableLayoutPanel5;
        private Label label3;
        private TextBox tbHovaten;
        private TableLayoutPanel tableLayoutPanel9;
        private Label label7;
        private TableLayoutPanel tableLayoutPanel8;
        private Label label6;
        private TableLayoutPanel tableLayoutPanel7;
        private Label label5;
        private TableLayoutPanel tableLayoutPanel10;
        private Label label8;
        private TableLayoutPanel tableLayoutPanel11;
        private RadioButton rbNam;
        private RadioButton rbNu;
        private DateTimePicker dtpNgaysinh;
        private ComboBox cbMalop;
        private ComboBox cbTinhtrang;
        private ComboBox cbManganh;
        private DataGridView dgvSinhvien;
        private TableLayoutPanel tableLayoutPanel12;
        private TableLayoutPanel tableLayoutPanel14;
        private TableLayoutPanel tableLayoutPanel13;
        private Button btnThem;
        private Button btnTimkiem;
        private Button btnDondep;
        private Button btnSua;
        private Button btnXoa;
        private Label label9;
        private DataGridViewTextBoxColumn MASV;
        private DataGridViewTextBoxColumn HOVATEN;
        private DataGridViewTextBoxColumn GIOITINH;
        private DataGridViewTextBoxColumn NGAYSINH;
        private DataGridViewTextBoxColumn MALOP;
        private DataGridViewTextBoxColumn MANGANH;
        private DataGridViewTextBoxColumn TINHTRANG;
    }
}
