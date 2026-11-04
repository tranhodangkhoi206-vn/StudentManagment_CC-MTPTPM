namespace StudentManagment.GUI.User_Control
{
    partial class Quanlylophoc
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
            tbMalop = new TextBox();
            dgvLop = new DataGridView();
            MALOP = new DataGridViewTextBoxColumn();
            MANGANH = new DataGridViewTextBoxColumn();
            TENLOP = new DataGridViewTextBoxColumn();
            GIANGVIENPHUTRACH = new DataGridViewTextBoxColumn();
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
            tableLayoutPanel7 = new TableLayoutPanel();
            label5 = new Label();
            tbGiangvien = new TextBox();
            tableLayoutPanel6 = new TableLayoutPanel();
            label4 = new Label();
            tbTenlop = new TextBox();
            tableLayoutPanel5 = new TableLayoutPanel();
            label3 = new Label();
            tbManganh = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLop).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel14.SuspendLayout();
            tableLayoutPanel13.SuspendLayout();
            tableLayoutPanel12.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 36.8580055F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 63.1419945F));
            tableLayoutPanel4.Controls.Add(label2, 0, 0);
            tableLayoutPanel4.Controls.Add(tbMalop, 1, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(0, 0);
            tableLayoutPanel4.Margin = new Padding(0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(413, 62);
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
            label2.Text = "Mã lớp:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tbMalop
            // 
            tbMalop.Anchor = AnchorStyles.Left;
            tbMalop.BorderStyle = BorderStyle.FixedSingle;
            tbMalop.Font = new Font("Roboto Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbMalop.Location = new Point(156, 12);
            tbMalop.Margin = new Padding(4);
            tbMalop.Name = "tbMalop";
            tbMalop.Size = new Size(250, 38);
            tbMalop.TabIndex = 0;
            // 
            // dgvLop
            // 
            dgvLop.AllowUserToAddRows = false;
            dgvLop.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvLop.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvLop.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLop.Columns.AddRange(new DataGridViewColumn[] { MALOP, MANGANH, TENLOP, GIANGVIENPHUTRACH });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvLop.DefaultCellStyle = dataGridViewCellStyle2;
            dgvLop.Dock = DockStyle.Fill;
            dgvLop.Location = new Point(421, 8);
            dgvLop.Margin = new Padding(0);
            dgvLop.Name = "dgvLop";
            dgvLop.ReadOnly = true;
            dgvLop.RowHeadersWidth = 51;
            dgvLop.Size = new Size(559, 666);
            dgvLop.TabIndex = 1;
            // 
            // MALOP
            // 
            MALOP.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            MALOP.DataPropertyName = "MALOP";
            MALOP.HeaderText = "Mã lớp";
            MALOP.MinimumWidth = 6;
            MALOP.Name = "MALOP";
            MALOP.ReadOnly = true;
            MALOP.Width = 65;
            // 
            // MANGANH
            // 
            MANGANH.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            MANGANH.DataPropertyName = "MANGANH";
            MANGANH.HeaderText = "Mã ngành";
            MANGANH.MinimumWidth = 6;
            MANGANH.Name = "MANGANH";
            MANGANH.ReadOnly = true;
            MANGANH.Width = 110;
            // 
            // TENLOP
            // 
            TENLOP.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            TENLOP.DataPropertyName = "TENLOP";
            TENLOP.HeaderText = "Tên lớp";
            TENLOP.MinimumWidth = 6;
            TENLOP.Name = "TENLOP";
            TENLOP.ReadOnly = true;
            TENLOP.Width = 67;
            // 
            // GIANGVIENPHUTRACH
            // 
            GIANGVIENPHUTRACH.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            GIANGVIENPHUTRACH.DataPropertyName = "GIANGVIENPHUTRACH";
            GIANGVIENPHUTRACH.HeaderText = "Giảng viên phụ trách";
            GIANGVIENPHUTRACH.MinimumWidth = 6;
            GIANGVIENPHUTRACH.Name = "GIANGVIENPHUTRACH";
            GIANGVIENPHUTRACH.ReadOnly = true;
            GIANGVIENPHUTRACH.Width = 150;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 42.5449867F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 57.4550133F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel2.Controls.Add(dgvLop, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 82);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.Padding = new Padding(8);
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(988, 682);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(tableLayoutPanel14, 0, 6);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel13, 0, 5);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel12, 0, 4);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel7, 0, 3);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel6, 0, 2);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel5, 0, 1);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel4, 0, 0);
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
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 62F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 62F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanel3.Size = new Size(413, 666);
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
            tableLayoutPanel14.Location = new Point(0, 372);
            tableLayoutPanel14.Margin = new Padding(0);
            tableLayoutPanel14.Name = "tableLayoutPanel14";
            tableLayoutPanel14.RowCount = 1;
            tableLayoutPanel14.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel14.Size = new Size(413, 62);
            tableLayoutPanel14.TabIndex = 15;
            // 
            // btnTimkiem
            // 
            btnTimkiem.Dock = DockStyle.Left;
            btnTimkiem.Font = new Font("Roboto Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTimkiem.Location = new Point(4, 4);
            btnTimkiem.Margin = new Padding(4);
            btnTimkiem.Name = "btnTimkiem";
            btnTimkiem.Size = new Size(142, 54);
            btnTimkiem.TabIndex = 8;
            btnTimkiem.Text = "Tìm kiếm";
            btnTimkiem.UseVisualStyleBackColor = true;
            btnTimkiem.Click += btnTimkiem_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Dock = DockStyle.Fill;
            label9.Font = new Font("Roboto Condensed", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(158, 0);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(251, 62);
            label9.TabIndex = 2;
            label9.Text = "(Nhập mã lớp để tìm kiếm)";
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
            tableLayoutPanel13.Location = new Point(0, 310);
            tableLayoutPanel13.Margin = new Padding(0);
            tableLayoutPanel13.Name = "tableLayoutPanel13";
            tableLayoutPanel13.RowCount = 1;
            tableLayoutPanel13.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel13.Size = new Size(413, 62);
            tableLayoutPanel13.TabIndex = 14;
            // 
            // btnDondep
            // 
            btnDondep.Dock = DockStyle.Left;
            btnDondep.Font = new Font("Roboto Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDondep.Location = new Point(210, 4);
            btnDondep.Margin = new Padding(4);
            btnDondep.Name = "btnDondep";
            btnDondep.Size = new Size(142, 54);
            btnDondep.TabIndex = 7;
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
            btnSua.TabIndex = 6;
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
            tableLayoutPanel12.Location = new Point(0, 248);
            tableLayoutPanel12.Margin = new Padding(0);
            tableLayoutPanel12.Name = "tableLayoutPanel12";
            tableLayoutPanel12.RowCount = 1;
            tableLayoutPanel12.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel12.Size = new Size(413, 62);
            tableLayoutPanel12.TabIndex = 13;
            // 
            // btnXoa
            // 
            btnXoa.Dock = DockStyle.Left;
            btnXoa.Font = new Font("Roboto Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnXoa.Location = new Point(210, 4);
            btnXoa.Margin = new Padding(4);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(142, 54);
            btnXoa.TabIndex = 5;
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
            btnThem.TabIndex = 4;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 2;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.1601219F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 62.8398781F));
            tableLayoutPanel7.Controls.Add(label5, 0, 0);
            tableLayoutPanel7.Controls.Add(tbGiangvien, 1, 0);
            tableLayoutPanel7.Dock = DockStyle.Fill;
            tableLayoutPanel7.Location = new Point(0, 186);
            tableLayoutPanel7.Margin = new Padding(0);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 1;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.Size = new Size(413, 62);
            tableLayoutPanel7.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Font = new Font("Roboto Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(4, 0);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(145, 62);
            label5.TabIndex = 0;
            label5.Text = "Giảng viên phụ trách:";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tbGiangvien
            // 
            tbGiangvien.Anchor = AnchorStyles.Left;
            tbGiangvien.BorderStyle = BorderStyle.FixedSingle;
            tbGiangvien.Font = new Font("Roboto Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbGiangvien.Location = new Point(157, 12);
            tbGiangvien.Margin = new Padding(4);
            tbGiangvien.Name = "tbGiangvien";
            tbGiangvien.Size = new Size(250, 38);
            tbGiangvien.TabIndex = 3;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 2;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.1601219F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 62.8398781F));
            tableLayoutPanel6.Controls.Add(label4, 0, 0);
            tableLayoutPanel6.Controls.Add(tbTenlop, 1, 0);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(0, 124);
            tableLayoutPanel6.Margin = new Padding(0);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Size = new Size(413, 62);
            tableLayoutPanel6.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Roboto Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(4, 0);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(145, 62);
            label4.TabIndex = 0;
            label4.Text = "Tên lớp:";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tbTenlop
            // 
            tbTenlop.Anchor = AnchorStyles.Left;
            tbTenlop.BorderStyle = BorderStyle.FixedSingle;
            tbTenlop.Font = new Font("Roboto Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbTenlop.Location = new Point(157, 12);
            tbTenlop.Margin = new Padding(4);
            tbTenlop.Name = "tbTenlop";
            tbTenlop.Size = new Size(250, 38);
            tbTenlop.TabIndex = 2;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.1601219F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 62.8398781F));
            tableLayoutPanel5.Controls.Add(label3, 0, 0);
            tableLayoutPanel5.Controls.Add(tbManganh, 1, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(0, 62);
            tableLayoutPanel5.Margin = new Padding(0);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Size = new Size(413, 62);
            tableLayoutPanel5.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Roboto Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(4, 0);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(145, 62);
            label3.TabIndex = 0;
            label3.Text = "Mã ngành:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tbManganh
            // 
            tbManganh.Anchor = AnchorStyles.Left;
            tbManganh.BorderStyle = BorderStyle.FixedSingle;
            tbManganh.Font = new Font("Roboto Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbManganh.Location = new Point(157, 12);
            tbManganh.Margin = new Padding(4);
            tbManganh.Name = "tbManganh";
            tbManganh.Size = new Size(250, 38);
            tbManganh.TabIndex = 1;
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
            tableLayoutPanel1.Size = new Size(988, 764);
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
            label1.Size = new Size(988, 82);
            label1.TabIndex = 0;
            label1.Text = "QUẢN LÝ LỚP HỌC";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Quanlylophoc
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(4);
            Name = "Quanlylophoc";
            Size = new Size(988, 764);
            Load += Quanlylophoc_Load;
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLop).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel14.ResumeLayout(false);
            tableLayoutPanel14.PerformLayout();
            tableLayoutPanel13.ResumeLayout(false);
            tableLayoutPanel12.ResumeLayout(false);
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel7.PerformLayout();
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel4;
        private Label label2;
        private TextBox tbMalop;
        private DataGridView dgvLop;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel5;
        private Label label3;
        private TextBox tbManganh;
        private TableLayoutPanel tableLayoutPanel6;
        private Label label4;
        private TextBox tbTenlop;
        private TableLayoutPanel tableLayoutPanel7;
        private Label label5;
        private TextBox tbGiangvien;
        private TableLayoutPanel tableLayoutPanel14;
        private Button btnTimkiem;
        private Label label9;
        private TableLayoutPanel tableLayoutPanel13;
        private Button btnDondep;
        private Button btnSua;
        private TableLayoutPanel tableLayoutPanel12;
        private Button btnXoa;
        private Button btnThem;
        private DataGridViewTextBoxColumn MALOP;
        private DataGridViewTextBoxColumn MANGANH;
        private DataGridViewTextBoxColumn TENLOP;
        private DataGridViewTextBoxColumn GIANGVIENPHUTRACH;
    }
}
