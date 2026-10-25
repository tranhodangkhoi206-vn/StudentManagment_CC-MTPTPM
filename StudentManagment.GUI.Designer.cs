namespace StudentManagment
{
    partial class frmQuanLySinhVien
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnTimKiem = new Button();
            tableLayoutPanel7 = new TableLayoutPanel();
            label6 = new Label();
            txbKhoa = new TextBox();
            tableLayoutPanel6 = new TableLayoutPanel();
            label5 = new Label();
            txbDiem = new TextBox();
            tableLayoutPanel5 = new TableLayoutPanel();
            label4 = new Label();
            txbMSSV = new TextBox();
            tableLayoutPanel4 = new TableLayoutPanel();
            label3 = new Label();
            txbLop = new TextBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            label2 = new Label();
            txbHovaten = new TextBox();
            tableLayoutPanel8 = new TableLayoutPanel();
            btnLamMoi = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            tableLayoutPanel9 = new TableLayoutPanel();
            lblTimKien = new Label();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            folderBrowserDialog1 = new FolderBrowserDialog();
            toolTip1 = new ToolTip(components);
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel8.SuspendLayout();
            tableLayoutPanel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Controls.Add(dataGridView1, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 27.93893F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 72.0610657F));
            tableLayoutPanel1.Size = new Size(1224, 791);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Blue;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Arial Black", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(1218, 100);
            label1.TabIndex = 0;
            label1.Text = "QUẢN LÝ SINH VIÊN";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(btnTimKiem, 1, 3);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel7, 0, 2);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel6, 1, 1);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel5, 0, 1);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel4, 1, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel8, 1, 2);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel9, 0, 3);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 103);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 4;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25.0006237F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25.0006275F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25.0006275F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 24.9981289F));
            tableLayoutPanel2.Size = new Size(1218, 187);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Dock = DockStyle.Fill;
            btnTimKiem.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTimKiem.Location = new Point(612, 141);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(603, 43);
            btnTimKiem.TabIndex = 7;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 2;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30.5140953F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 69.4859F));
            tableLayoutPanel7.Controls.Add(label6, 0, 0);
            tableLayoutPanel7.Controls.Add(txbKhoa, 1, 0);
            tableLayoutPanel7.Dock = DockStyle.Fill;
            tableLayoutPanel7.Location = new Point(3, 95);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 1;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.Size = new Size(603, 40);
            tableLayoutPanel7.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Fill;
            label6.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(3, 0);
            label6.Name = "label6";
            label6.Size = new Size(178, 40);
            label6.TabIndex = 0;
            label6.Text = "Khoa:";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txbKhoa
            // 
            txbKhoa.BorderStyle = BorderStyle.FixedSingle;
            txbKhoa.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbKhoa.Location = new Point(187, 3);
            txbKhoa.Name = "txbKhoa";
            txbKhoa.Size = new Size(413, 42);
            txbKhoa.TabIndex = 1;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 2;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30.5140953F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 69.4859F));
            tableLayoutPanel6.Controls.Add(label5, 0, 0);
            tableLayoutPanel6.Controls.Add(txbDiem, 1, 0);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(612, 49);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Size = new Size(603, 40);
            tableLayoutPanel6.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(3, 0);
            label5.Name = "label5";
            label5.Size = new Size(178, 40);
            label5.TabIndex = 0;
            label5.Text = "Điểm (GPA):";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txbDiem
            // 
            txbDiem.BorderStyle = BorderStyle.FixedSingle;
            txbDiem.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbDiem.Location = new Point(187, 3);
            txbDiem.Name = "txbDiem";
            txbDiem.Size = new Size(413, 42);
            txbDiem.TabIndex = 1;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30.5140953F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 69.4859F));
            tableLayoutPanel5.Controls.Add(label4, 0, 0);
            tableLayoutPanel5.Controls.Add(txbMSSV, 1, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(3, 49);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Size = new Size(603, 40);
            tableLayoutPanel5.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(3, 0);
            label4.Name = "label4";
            label4.Size = new Size(178, 40);
            label4.TabIndex = 0;
            label4.Text = "MSSV:";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txbMSSV
            // 
            txbMSSV.BorderStyle = BorderStyle.FixedSingle;
            txbMSSV.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbMSSV.Location = new Point(187, 3);
            txbMSSV.Name = "txbMSSV";
            txbMSSV.Size = new Size(413, 42);
            txbMSSV.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30.5140953F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 69.4859F));
            tableLayoutPanel4.Controls.Add(label3, 0, 0);
            tableLayoutPanel4.Controls.Add(txbLop, 1, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(612, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(603, 40);
            tableLayoutPanel4.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(178, 40);
            label3.TabIndex = 0;
            label3.Text = "Lớp:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txbLop
            // 
            txbLop.BorderStyle = BorderStyle.FixedSingle;
            txbLop.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbLop.Location = new Point(187, 3);
            txbLop.Name = "txbLop";
            txbLop.Size = new Size(413, 42);
            txbLop.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30.5140953F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 69.4859F));
            tableLayoutPanel3.Controls.Add(label2, 0, 0);
            tableLayoutPanel3.Controls.Add(txbHovaten, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(603, 40);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(178, 40);
            label2.TabIndex = 0;
            label2.Text = "Họ và tên:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txbHovaten
            // 
            txbHovaten.BorderStyle = BorderStyle.FixedSingle;
            txbHovaten.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbHovaten.Location = new Point(187, 3);
            txbHovaten.Name = "txbHovaten";
            txbHovaten.Size = new Size(413, 42);
            txbHovaten.TabIndex = 1;
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.ColumnCount = 4;
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel8.Controls.Add(btnLamMoi, 3, 0);
            tableLayoutPanel8.Controls.Add(btnSua, 2, 0);
            tableLayoutPanel8.Controls.Add(btnXoa, 1, 0);
            tableLayoutPanel8.Controls.Add(btnThem, 0, 0);
            tableLayoutPanel8.Dock = DockStyle.Fill;
            tableLayoutPanel8.Location = new Point(612, 95);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 1;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel8.Size = new Size(603, 40);
            tableLayoutPanel8.TabIndex = 5;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Dock = DockStyle.Fill;
            btnLamMoi.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLamMoi.Location = new Point(453, 3);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(147, 34);
            btnLamMoi.TabIndex = 3;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnSua
            // 
            btnSua.Dock = DockStyle.Fill;
            btnSua.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSua.Location = new Point(303, 3);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(144, 34);
            btnSua.TabIndex = 2;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Dock = DockStyle.Fill;
            btnXoa.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnXoa.Location = new Point(153, 3);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(144, 34);
            btnXoa.TabIndex = 1;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThem
            // 
            btnThem.Dock = DockStyle.Fill;
            btnThem.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnThem.Location = new Point(3, 3);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(144, 34);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // tableLayoutPanel9
            // 
            tableLayoutPanel9.ColumnCount = 2;
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30.51F));
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 69.49F));
            tableLayoutPanel9.Controls.Add(lblTimKien, 0, 0);
            tableLayoutPanel9.Controls.Add(textBox1, 1, 0);
            tableLayoutPanel9.Dock = DockStyle.Fill;
            tableLayoutPanel9.Location = new Point(0, 138);
            tableLayoutPanel9.Margin = new Padding(0);
            tableLayoutPanel9.Name = "tableLayoutPanel9";
            tableLayoutPanel9.RowCount = 1;
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel9.Size = new Size(609, 49);
            tableLayoutPanel9.TabIndex = 6;
            tableLayoutPanel9.Paint += tableLayoutPanel9_Paint;
            // 
            // lblTimKien
            // 
            lblTimKien.AutoSize = true;
            lblTimKien.Dock = DockStyle.Fill;
            lblTimKien.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTimKien.Location = new Point(3, 0);
            lblTimKien.Name = "lblTimKien";
            lblTimKien.Size = new Size(179, 49);
            lblTimKien.TabIndex = 0;
            lblTimKien.Text = "Tìm Kiếm:";
            lblTimKien.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(188, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(413, 42);
            textBox1.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 296);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1218, 484);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // frmQuanLySinhVien
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1224, 791);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "frmQuanLySinhVien";
            Text = "Quản lý sinh viên";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel7.PerformLayout();
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel8.ResumeLayout(false);
            tableLayoutPanel9.ResumeLayout(false);
            tableLayoutPanel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel6;
        private Label label5;
        private TextBox txbDiem;
        private TableLayoutPanel tableLayoutPanel5;
        private Label label4;
        private TextBox txbMSSV;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label3;
        private TextBox txbLop;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label2;
        private TextBox txbHovaten;
        private TableLayoutPanel tableLayoutPanel7;
        private Label label6;
        private TextBox txbKhoa;
        private TableLayoutPanel tableLayoutPanel8;
        private Button btnLamMoi;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThem;
        private FolderBrowserDialog folderBrowserDialog1;
        private TableLayoutPanel tableLayoutPanel9;
        private Label lblTimKien;
        private Button btnTimKiem;
        private TextBox textBox1;
        private ToolTip toolTip1;
        private DataGridView dataGridView1;
    }
}
