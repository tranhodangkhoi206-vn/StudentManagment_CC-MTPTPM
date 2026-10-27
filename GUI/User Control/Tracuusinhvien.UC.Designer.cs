namespace StudentManagment.GUI.User_Control
{
    partial class Tracuusinhvien
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
            drvDanhsachsinhvien = new DataGridView();
            panel1 = new Panel();
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            label2 = new Label();
            txbTimkiem = new TextBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            cbxNhomchuyennganh = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            cbxNhomlop = new ComboBox();
            MASV = new DataGridViewTextBoxColumn();
            HOVATEN = new DataGridViewTextBoxColumn();
            MALOP = new DataGridViewTextBoxColumn();
            NGAYSINH = new DataGridViewTextBoxColumn();
            GIOITINH = new DataGridViewTextBoxColumn();
            MANGANH = new DataGridViewTextBoxColumn();
            TINHTRANG = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)drvDanhsachsinhvien).BeginInit();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // drvDanhsachsinhvien
            // 
            drvDanhsachsinhvien.AllowUserToAddRows = false;
            drvDanhsachsinhvien.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Roboto Condensed", 16F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            drvDanhsachsinhvien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            drvDanhsachsinhvien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            drvDanhsachsinhvien.Columns.AddRange(new DataGridViewColumn[] { MASV, HOVATEN, MALOP, NGAYSINH, GIOITINH, MANGANH, TINHTRANG });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Roboto Condensed", 16F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            drvDanhsachsinhvien.DefaultCellStyle = dataGridViewCellStyle2;
            drvDanhsachsinhvien.Dock = DockStyle.Fill;
            drvDanhsachsinhvien.Location = new Point(3, 121);
            drvDanhsachsinhvien.Name = "drvDanhsachsinhvien";
            drvDanhsachsinhvien.ReadOnly = true;
            drvDanhsachsinhvien.Size = new Size(1054, 512);
            drvDanhsachsinhvien.TabIndex = 2;
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
            label1.Size = new Size(415, 58);
            label1.TabIndex = 0;
            label1.Text = "TRA CỨU SINH VIÊN";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 1);
            tableLayoutPanel1.Controls.Add(drvDanhsachsinhvien, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Font = new Font("Roboto Condensed", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tableLayoutPanel1.Location = new Point(0, 85);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 517F));
            tableLayoutPanel1.Size = new Size(1060, 636);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 318F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 591F));
            tableLayoutPanel2.Controls.Add(label2, 0, 0);
            tableLayoutPanel2.Controls.Add(txbTimkiem, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(1060, 59);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Roboto Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(312, 59);
            label2.TabIndex = 0;
            label2.Text = "Tìm kiếm theo tên sinh viên:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txbTimkiem
            // 
            txbTimkiem.Anchor = AnchorStyles.Left;
            txbTimkiem.BorderStyle = BorderStyle.FixedSingle;
            txbTimkiem.Font = new Font("Roboto Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbTimkiem.Location = new Point(321, 11);
            txbTimkiem.Name = "txbTimkiem";
            txbTimkiem.Size = new Size(736, 36);
            txbTimkiem.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 4;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 160F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 279F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 273F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 159F));
            tableLayoutPanel3.Controls.Add(cbxNhomchuyennganh, 3, 0);
            tableLayoutPanel3.Controls.Add(label4, 2, 0);
            tableLayoutPanel3.Controls.Add(label3, 0, 0);
            tableLayoutPanel3.Controls.Add(cbxNhomlop, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 59);
            tableLayoutPanel3.Margin = new Padding(0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(1060, 59);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // cbxNhomchuyennganh
            // 
            cbxNhomchuyennganh.Anchor = AnchorStyles.Left;
            cbxNhomchuyennganh.Font = new Font("Roboto Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbxNhomchuyennganh.FormattingEnabled = true;
            cbxNhomchuyennganh.Location = new Point(715, 11);
            cbxNhomchuyennganh.Name = "cbxNhomchuyennganh";
            cbxNhomchuyennganh.Size = new Size(342, 37);
            cbxNhomchuyennganh.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Roboto Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(439, 0);
            label4.Margin = new Padding(0);
            label4.Name = "label4";
            label4.Size = new Size(273, 59);
            label4.TabIndex = 2;
            label4.Text = "Nhóm theo ngành học:";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Roboto Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(0, 0);
            label3.Margin = new Padding(0);
            label3.Name = "label3";
            label3.Size = new Size(160, 59);
            label3.TabIndex = 0;
            label3.Text = "Nhóm theo lớp:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cbxNhomlop
            // 
            cbxNhomlop.Anchor = AnchorStyles.Left;
            cbxNhomlop.Font = new Font("Roboto Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbxNhomlop.FormattingEnabled = true;
            cbxNhomlop.Location = new Point(163, 11);
            cbxNhomlop.Name = "cbxNhomlop";
            cbxNhomlop.Size = new Size(273, 37);
            cbxNhomlop.TabIndex = 1;
            // 
            // MASV
            // 
            MASV.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            MASV.DataPropertyName = "MASV";
            MASV.HeaderText = "Mã sinh viên";
            MASV.Name = "MASV";
            MASV.ReadOnly = true;
            MASV.Width = 147;
            // 
            // HOVATEN
            // 
            HOVATEN.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            HOVATEN.DataPropertyName = "HOVATEN";
            HOVATEN.HeaderText = "Họ và tên";
            HOVATEN.Name = "HOVATEN";
            HOVATEN.ReadOnly = true;
            HOVATEN.Width = 120;
            // 
            // MALOP
            // 
            MALOP.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            MALOP.DataPropertyName = "MALOP";
            MALOP.HeaderText = "Mã lớp";
            MALOP.Name = "MALOP";
            MALOP.ReadOnly = true;
            MALOP.Width = 97;
            // 
            // NGAYSINH
            // 
            NGAYSINH.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            NGAYSINH.DataPropertyName = "NGAYSINH";
            NGAYSINH.HeaderText = "Ngày sinh";
            NGAYSINH.Name = "NGAYSINH";
            NGAYSINH.ReadOnly = true;
            NGAYSINH.Width = 124;
            // 
            // GIOITINH
            // 
            GIOITINH.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            GIOITINH.DataPropertyName = "GIOITINH";
            GIOITINH.HeaderText = "Giới tính";
            GIOITINH.Name = "GIOITINH";
            GIOITINH.ReadOnly = true;
            GIOITINH.Width = 110;
            // 
            // MANGANH
            // 
            MANGANH.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            MANGANH.DataPropertyName = "MANGANH";
            MANGANH.HeaderText = "Mã ngành";
            MANGANH.Name = "MANGANH";
            MANGANH.ReadOnly = true;
            MANGANH.Width = 125;
            // 
            // TINHTRANG
            // 
            TINHTRANG.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            TINHTRANG.DataPropertyName = "TINHTRANG";
            TINHTRANG.HeaderText = "Tình trạng";
            TINHTRANG.Name = "TINHTRANG";
            TINHTRANG.ReadOnly = true;
            TINHTRANG.Width = 127;
            // 
            // Tracuusinhvien
            // 
            AutoScaleDimensions = new SizeF(6F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel1);
            Font = new Font("Roboto Condensed", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Tracuusinhvien";
            Size = new Size(1060, 721);
            ((System.ComponentModel.ISupportInitialize)drvDanhsachsinhvien).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label2;
        private TextBox txbTimkiem;
        private TableLayoutPanel tableLayoutPanel3;
        private ComboBox cbxNhomchuyennganh;
        private Label label4;
        private Label label3;
        private ComboBox cbxNhomlop;
        private DataGridView drvDanhsachsinhvien;
        private DataGridViewTextBoxColumn MASV;
        private DataGridViewTextBoxColumn HOVATEN;
        private DataGridViewTextBoxColumn MALOP;
        private DataGridViewTextBoxColumn NGAYSINH;
        private DataGridViewTextBoxColumn GIOITINH;
        private DataGridViewTextBoxColumn MANGANH;
        private DataGridViewTextBoxColumn TINHTRANG;
    }
}
