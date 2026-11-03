namespace StudentManagment.GUI.User_Control
{
    partial class Quanlydiem
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
            tableLayoutPanel4 = new TableLayoutPanel();
            label2 = new Label();
            tbMasinhvien = new TextBox();
            dgvDiem = new DataGridView();
            MASV = new DataGridViewTextBoxColumn();
            MAMON = new DataGridViewTextBoxColumn();
            DIEMCHUYENCAN = new DataGridViewTextBoxColumn();
            DIEMGIUAKY = new DataGridViewTextBoxColumn();
            DIEMCUOIKY = new DataGridViewTextBoxColumn();
            DIEMTONG = new DataGridViewTextBoxColumn();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel12 = new TableLayoutPanel();
            label8 = new Label();
            lbDiemtong = new Label();
            tableLayoutPanel11 = new TableLayoutPanel();
            button4 = new Button();
            button5 = new Button();
            tableLayoutPanel10 = new TableLayoutPanel();
            btnDondep = new Button();
            button3 = new Button();
            tableLayoutPanel9 = new TableLayoutPanel();
            btnTimkiem = new Button();
            label7 = new Label();
            tableLayoutPanel8 = new TableLayoutPanel();
            label6 = new Label();
            tbDiemcuoiky = new TextBox();
            tableLayoutPanel7 = new TableLayoutPanel();
            label5 = new Label();
            tbDiemgiuaky = new TextBox();
            tableLayoutPanel6 = new TableLayoutPanel();
            label4 = new Label();
            tbDiemchuyencan = new TextBox();
            tableLayoutPanel5 = new TableLayoutPanel();
            label3 = new Label();
            tbMamonhoc = new TextBox();
            tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDiem).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel12.SuspendLayout();
            tableLayoutPanel11.SuspendLayout();
            tableLayoutPanel10.SuspendLayout();
            tableLayoutPanel9.SuspendLayout();
            tableLayoutPanel8.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            SuspendLayout();
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
            // dgvDiem
            // 
            dgvDiem.AllowUserToAddRows = false;
            dgvDiem.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvDiem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvDiem.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDiem.Columns.AddRange(new DataGridViewColumn[] { MASV, MAMON, DIEMCHUYENCAN, DIEMGIUAKY, DIEMCUOIKY, DIEMTONG });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvDiem.DefaultCellStyle = dataGridViewCellStyle2;
            dgvDiem.Dock = DockStyle.Fill;
            dgvDiem.Location = new Point(337, 6);
            dgvDiem.Margin = new Padding(0);
            dgvDiem.Name = "dgvDiem";
            dgvDiem.ReadOnly = true;
            dgvDiem.Size = new Size(447, 533);
            dgvDiem.TabIndex = 1;
            // 
            // MASV
            // 
            MASV.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            MASV.DataPropertyName = "MASV";
            MASV.HeaderText = "Mã sinh viên";
            MASV.Name = "MASV";
            MASV.ReadOnly = true;
            MASV.Width = 106;
            // 
            // MAMON
            // 
            MAMON.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            MAMON.DataPropertyName = "MAMON";
            MAMON.HeaderText = "Mã môn học";
            MAMON.Name = "MAMON";
            MAMON.ReadOnly = true;
            MAMON.Width = 104;
            // 
            // DIEMCHUYENCAN
            // 
            DIEMCHUYENCAN.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            DIEMCHUYENCAN.DataPropertyName = "DIEMCHUYENCAN";
            DIEMCHUYENCAN.HeaderText = "Điểm chuyên cần";
            DIEMCHUYENCAN.Name = "DIEMCHUYENCAN";
            DIEMCHUYENCAN.ReadOnly = true;
            DIEMCHUYENCAN.Width = 111;
            // 
            // DIEMGIUAKY
            // 
            DIEMGIUAKY.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            DIEMGIUAKY.DataPropertyName = "DIEMGIUAKY";
            DIEMGIUAKY.HeaderText = "Điểm giữa kỳ";
            DIEMGIUAKY.Name = "DIEMGIUAKY";
            DIEMGIUAKY.ReadOnly = true;
            DIEMGIUAKY.Width = 96;
            // 
            // DIEMCUOIKY
            // 
            DIEMCUOIKY.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            DIEMCUOIKY.DataPropertyName = "DIEMCUOIKY";
            DIEMCUOIKY.HeaderText = "Điểm cuối kỳ";
            DIEMCUOIKY.Name = "DIEMCUOIKY";
            DIEMCUOIKY.ReadOnly = true;
            DIEMCUOIKY.Width = 94;
            // 
            // DIEMTONG
            // 
            DIEMTONG.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            DIEMTONG.DataPropertyName = "DIEMTONG";
            DIEMTONG.HeaderText = "Điểm tổng";
            DIEMTONG.Name = "DIEMTONG";
            DIEMTONG.ReadOnly = true;
            DIEMTONG.Width = 92;
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
            label1.Size = new Size(790, 66);
            label1.TabIndex = 0;
            label1.Text = "QUẢN LÝ ĐIỂM";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 42.5449867F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 57.4550133F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel2.Controls.Add(dgvDiem, 1, 0);
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
            tableLayoutPanel3.Controls.Add(tableLayoutPanel12, 0, 5);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel11, 0, 6);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel10, 0, 7);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel9, 0, 8);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel8, 0, 4);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel7, 0, 3);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel6, 0, 2);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel5, 0, 1);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel4, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(6, 6);
            tableLayoutPanel3.Margin = new Padding(0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 10;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(331, 533);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // tableLayoutPanel12
            // 
            tableLayoutPanel12.ColumnCount = 2;
            tableLayoutPanel12.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 48.3383675F));
            tableLayoutPanel12.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 51.6616325F));
            tableLayoutPanel12.Controls.Add(label8, 0, 0);
            tableLayoutPanel12.Controls.Add(lbDiemtong, 1, 0);
            tableLayoutPanel12.Dock = DockStyle.Fill;
            tableLayoutPanel12.Location = new Point(0, 250);
            tableLayoutPanel12.Margin = new Padding(0);
            tableLayoutPanel12.Name = "tableLayoutPanel12";
            tableLayoutPanel12.RowCount = 1;
            tableLayoutPanel12.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel12.Size = new Size(331, 50);
            tableLayoutPanel12.TabIndex = 22;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Dock = DockStyle.Fill;
            label8.Font = new Font("Roboto Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(3, 0);
            label8.Name = "label8";
            label8.Size = new Size(154, 50);
            label8.TabIndex = 0;
            label8.Text = "Điểm tổng:";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbDiemtong
            // 
            lbDiemtong.AutoSize = true;
            lbDiemtong.Dock = DockStyle.Fill;
            lbDiemtong.Font = new Font("Roboto Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbDiemtong.Location = new Point(163, 0);
            lbDiemtong.Name = "lbDiemtong";
            lbDiemtong.Size = new Size(165, 50);
            lbDiemtong.TabIndex = 1;
            lbDiemtong.Text = "0";
            lbDiemtong.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel11
            // 
            tableLayoutPanel11.ColumnCount = 2;
            tableLayoutPanel11.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel11.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel11.Controls.Add(button4, 1, 0);
            tableLayoutPanel11.Controls.Add(button5, 0, 0);
            tableLayoutPanel11.Dock = DockStyle.Fill;
            tableLayoutPanel11.Location = new Point(0, 300);
            tableLayoutPanel11.Margin = new Padding(0);
            tableLayoutPanel11.Name = "tableLayoutPanel11";
            tableLayoutPanel11.RowCount = 1;
            tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel11.Size = new Size(331, 50);
            tableLayoutPanel11.TabIndex = 21;
            // 
            // button4
            // 
            button4.Dock = DockStyle.Left;
            button4.Font = new Font("Roboto Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Location = new Point(168, 3);
            button4.Name = "button4";
            button4.Size = new Size(114, 44);
            button4.TabIndex = 1;
            button4.Text = "Xóa";
            button4.UseVisualStyleBackColor = true;
            button4.Click += btnXoa_Click;
            // 
            // button5
            // 
            button5.Dock = DockStyle.Left;
            button5.Font = new Font("Roboto Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.Location = new Point(3, 3);
            button5.Name = "button5";
            button5.Size = new Size(114, 44);
            button5.TabIndex = 0;
            button5.Text = "Thêm";
            button5.UseVisualStyleBackColor = true;
            button5.Click += btnThem_Click;
            // 
            // tableLayoutPanel10
            // 
            tableLayoutPanel10.ColumnCount = 2;
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel10.Controls.Add(btnDondep, 1, 0);
            tableLayoutPanel10.Controls.Add(button3, 0, 0);
            tableLayoutPanel10.Dock = DockStyle.Fill;
            tableLayoutPanel10.Location = new Point(0, 350);
            tableLayoutPanel10.Margin = new Padding(0);
            tableLayoutPanel10.Name = "tableLayoutPanel10";
            tableLayoutPanel10.RowCount = 1;
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel10.Size = new Size(331, 50);
            tableLayoutPanel10.TabIndex = 20;
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
            // button3
            // 
            button3.Dock = DockStyle.Left;
            button3.Font = new Font("Roboto Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(3, 3);
            button3.Name = "button3";
            button3.Size = new Size(114, 44);
            button3.TabIndex = 1;
            button3.Text = "Sửa";
            button3.UseVisualStyleBackColor = true;
            button3.Click += btnSua_Click;
            // 
            // tableLayoutPanel9
            // 
            tableLayoutPanel9.ColumnCount = 2;
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.4622345F));
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 62.5377655F));
            tableLayoutPanel9.Controls.Add(btnTimkiem, 0, 0);
            tableLayoutPanel9.Controls.Add(label7, 1, 0);
            tableLayoutPanel9.Dock = DockStyle.Fill;
            tableLayoutPanel9.Location = new Point(0, 400);
            tableLayoutPanel9.Margin = new Padding(0);
            tableLayoutPanel9.Name = "tableLayoutPanel9";
            tableLayoutPanel9.RowCount = 1;
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel9.Size = new Size(331, 50);
            tableLayoutPanel9.TabIndex = 18;
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
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = DockStyle.Fill;
            label7.Font = new Font("Roboto Condensed", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(127, 0);
            label7.Name = "label7";
            label7.Size = new Size(201, 50);
            label7.TabIndex = 2;
            label7.Text = "(Nhập mã sinh viên và mã môn để tìm kiếm)";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.ColumnCount = 2;
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 48.3383675F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 51.6616325F));
            tableLayoutPanel8.Controls.Add(label6, 0, 0);
            tableLayoutPanel8.Controls.Add(tbDiemcuoiky, 1, 0);
            tableLayoutPanel8.Dock = DockStyle.Fill;
            tableLayoutPanel8.Location = new Point(0, 200);
            tableLayoutPanel8.Margin = new Padding(0);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 1;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.Size = new Size(331, 50);
            tableLayoutPanel8.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Fill;
            label6.Font = new Font("Roboto Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(3, 0);
            label6.Name = "label6";
            label6.Size = new Size(154, 50);
            label6.TabIndex = 0;
            label6.Text = "Điểm cuối kỳ:";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tbDiemcuoiky
            // 
            tbDiemcuoiky.Anchor = AnchorStyles.Left;
            tbDiemcuoiky.BorderStyle = BorderStyle.FixedSingle;
            tbDiemcuoiky.Font = new Font("Roboto Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbDiemcuoiky.Location = new Point(163, 9);
            tbDiemcuoiky.Name = "tbDiemcuoiky";
            tbDiemcuoiky.Size = new Size(165, 32);
            tbDiemcuoiky.TabIndex = 1;
            tbDiemcuoiky.TextChanged += tbDiemcuoiky_TextChanged;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 2;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 48.3383675F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 51.6616325F));
            tableLayoutPanel7.Controls.Add(label5, 0, 0);
            tableLayoutPanel7.Controls.Add(tbDiemgiuaky, 1, 0);
            tableLayoutPanel7.Dock = DockStyle.Fill;
            tableLayoutPanel7.Location = new Point(0, 150);
            tableLayoutPanel7.Margin = new Padding(0);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 1;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.Size = new Size(331, 50);
            tableLayoutPanel7.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Font = new Font("Roboto Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(3, 0);
            label5.Name = "label5";
            label5.Size = new Size(154, 50);
            label5.TabIndex = 0;
            label5.Text = "Điểm giữa kỳ:";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tbDiemgiuaky
            // 
            tbDiemgiuaky.Anchor = AnchorStyles.Left;
            tbDiemgiuaky.BorderStyle = BorderStyle.FixedSingle;
            tbDiemgiuaky.Font = new Font("Roboto Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbDiemgiuaky.Location = new Point(163, 9);
            tbDiemgiuaky.Name = "tbDiemgiuaky";
            tbDiemgiuaky.Size = new Size(165, 32);
            tbDiemgiuaky.TabIndex = 1;
            tbDiemgiuaky.TextChanged += tbDiemgiuaky_TextChanged;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 2;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 48.3383675F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 51.6616325F));
            tableLayoutPanel6.Controls.Add(label4, 0, 0);
            tableLayoutPanel6.Controls.Add(tbDiemchuyencan, 1, 0);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(0, 100);
            tableLayoutPanel6.Margin = new Padding(0);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Size = new Size(331, 50);
            tableLayoutPanel6.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Roboto Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(3, 0);
            label4.Name = "label4";
            label4.Size = new Size(154, 50);
            label4.TabIndex = 0;
            label4.Text = "Điểm chuyên cần:";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tbDiemchuyencan
            // 
            tbDiemchuyencan.Anchor = AnchorStyles.Left;
            tbDiemchuyencan.BorderStyle = BorderStyle.FixedSingle;
            tbDiemchuyencan.Font = new Font("Roboto Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbDiemchuyencan.Location = new Point(163, 9);
            tbDiemchuyencan.Name = "tbDiemchuyencan";
            tbDiemchuyencan.Size = new Size(165, 32);
            tbDiemchuyencan.TabIndex = 1;
            tbDiemchuyencan.TextChanged += tbDiemchuyencan_TextChanged;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.76435F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 62.23565F));
            tableLayoutPanel5.Controls.Add(label3, 0, 0);
            tableLayoutPanel5.Controls.Add(tbMamonhoc, 1, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(0, 50);
            tableLayoutPanel5.Margin = new Padding(0);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Size = new Size(331, 50);
            tableLayoutPanel5.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Roboto Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(119, 50);
            label3.TabIndex = 0;
            label3.Text = "Mã môn học:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tbMamonhoc
            // 
            tbMamonhoc.Anchor = AnchorStyles.Left;
            tbMamonhoc.BorderStyle = BorderStyle.FixedSingle;
            tbMamonhoc.Font = new Font("Roboto Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbMamonhoc.Location = new Point(128, 9);
            tbMamonhoc.Name = "tbMamonhoc";
            tbMamonhoc.Size = new Size(200, 32);
            tbMamonhoc.TabIndex = 1;
            // 
            // Quanlydiem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "Quanlydiem";
            Size = new Size(790, 611);
            Load += Quanlydiem_Load;
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDiem).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel12.ResumeLayout(false);
            tableLayoutPanel12.PerformLayout();
            tableLayoutPanel11.ResumeLayout(false);
            tableLayoutPanel10.ResumeLayout(false);
            tableLayoutPanel9.ResumeLayout(false);
            tableLayoutPanel9.PerformLayout();
            tableLayoutPanel8.ResumeLayout(false);
            tableLayoutPanel8.PerformLayout();
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel7.PerformLayout();
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label lbDiemtongket;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label2;
        private TextBox tbMasinhvien;
        private DataGridView dgvDiem;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel5;
        private Label label3;
        private TextBox tbMamonhoc;
        private TableLayoutPanel tableLayoutPanel6;
        private Label label4;
        private TextBox tbDiemchuyencan;
        private TableLayoutPanel tableLayoutPanel8;
        private Label label6;
        private TextBox tbDiemcuoiky;
        private TableLayoutPanel tableLayoutPanel7;
        private Label label5;
        private TextBox tbDiemgiuaky;
        private TableLayoutPanel tableLayoutPanel9;
        private Button btnTimkiem;
        private Label label7;
        private TableLayoutPanel tableLayoutPanel10;
        private Button btnDondep;
        private Button button3;
        private TableLayoutPanel tableLayoutPanel12;
        private Label label8;
        private TableLayoutPanel tableLayoutPanel11;
        private Button button4;
        private Button button5;
        private Label lbDiemtong;
        private DataGridViewTextBoxColumn MASV;
        private DataGridViewTextBoxColumn MAMON;
        private DataGridViewTextBoxColumn DIEMCHUYENCAN;
        private DataGridViewTextBoxColumn DIEMGIUAKY;
        private DataGridViewTextBoxColumn DIEMCUOIKY;
        private DataGridViewTextBoxColumn DIEMTONG;
    }
}
