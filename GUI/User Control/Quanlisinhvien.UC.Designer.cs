namespace StudentManagment.GUI.User_Control
{
    partial class Quanlisinhvien
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
            label1 = new Label();
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            txbLop = new TextBox();
            label4 = new Label();
            txbHovaten = new TextBox();
            label3 = new Label();
            label2 = new Label();
            txbMasinhvien = new TextBox();
            dtpNgaySinh = new DateTimePicker();
            tableLayoutPanel3 = new TableLayoutPanel();
            tbtnNu = new RadioButton();
            rbtnNam = new RadioButton();
            cbxChuyennganh = new ComboBox();
            label8 = new Label();
            cbxTinhtrang = new ComboBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnThem = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnLammoi = new Button();
            drvDanhsachsinhvien = new DataGridView();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)drvDanhsachsinhvien).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Roboto Condensed", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(21, 14);
            label1.Name = "label1";
            label1.Size = new Size(398, 58);
            label1.TabIndex = 0;
            label1.Text = "QUẢN LÍ SINH VIÊN";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1060, 91);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(drvDanhsachsinhvien, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 91);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 27.7777786F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 72.22222F));
            tableLayoutPanel1.Size = new Size(1060, 630);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 6;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 158F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 176F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 118F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 228F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 168F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 129F));
            tableLayoutPanel2.Controls.Add(cbxTinhtrang, 1, 2);
            tableLayoutPanel2.Controls.Add(label8, 0, 2);
            tableLayoutPanel2.Controls.Add(label7, 4, 1);
            tableLayoutPanel2.Controls.Add(label6, 2, 1);
            tableLayoutPanel2.Controls.Add(label5, 0, 1);
            tableLayoutPanel2.Controls.Add(txbLop, 5, 0);
            tableLayoutPanel2.Controls.Add(label4, 4, 0);
            tableLayoutPanel2.Controls.Add(txbHovaten, 3, 0);
            tableLayoutPanel2.Controls.Add(label3, 2, 0);
            tableLayoutPanel2.Controls.Add(label2, 0, 0);
            tableLayoutPanel2.Controls.Add(txbMasinhvien, 1, 0);
            tableLayoutPanel2.Controls.Add(dtpNgaySinh, 1, 1);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 3, 1);
            tableLayoutPanel2.Controls.Add(cbxChuyennganh, 5, 1);
            tableLayoutPanel2.Controls.Add(flowLayoutPanel1, 2, 2);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.Size = new Size(1060, 175);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = DockStyle.Fill;
            label7.Font = new Font("Roboto Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ControlText;
            label7.Location = new Point(683, 58);
            label7.Name = "label7";
            label7.Size = new Size(162, 58);
            label7.TabIndex = 10;
            label7.Text = "Chuyên ngành:";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Fill;
            label6.Font = new Font("Roboto Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ControlText;
            label6.Location = new Point(337, 58);
            label6.Name = "label6";
            label6.Size = new Size(112, 58);
            label6.TabIndex = 8;
            label6.Text = "Giới tính:";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Font = new Font("Roboto Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ControlText;
            label5.Location = new Point(3, 58);
            label5.Name = "label5";
            label5.Size = new Size(152, 58);
            label5.TabIndex = 6;
            label5.Text = "Ngày sinh:";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txbLop
            // 
            txbLop.Anchor = AnchorStyles.Left;
            txbLop.BorderStyle = BorderStyle.FixedSingle;
            txbLop.Font = new Font("Roboto Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbLop.Location = new Point(851, 11);
            txbLop.Name = "txbLop";
            txbLop.Size = new Size(206, 36);
            txbLop.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Roboto Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlText;
            label4.Location = new Point(683, 0);
            label4.Name = "label4";
            label4.Size = new Size(162, 58);
            label4.TabIndex = 4;
            label4.Text = "Lớp:";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txbHovaten
            // 
            txbHovaten.Anchor = AnchorStyles.Left;
            txbHovaten.BorderStyle = BorderStyle.FixedSingle;
            txbHovaten.Font = new Font("Roboto Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbHovaten.Location = new Point(455, 11);
            txbHovaten.Name = "txbHovaten";
            txbHovaten.Size = new Size(222, 36);
            txbHovaten.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Roboto Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(337, 0);
            label3.Name = "label3";
            label3.Size = new Size(112, 58);
            label3.TabIndex = 2;
            label3.Text = "Họ và tên:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Roboto Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(152, 58);
            label2.TabIndex = 0;
            label2.Text = "Mã sinh viên:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txbMasinhvien
            // 
            txbMasinhvien.Anchor = AnchorStyles.Left;
            txbMasinhvien.BorderStyle = BorderStyle.FixedSingle;
            txbMasinhvien.Font = new Font("Roboto Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbMasinhvien.Location = new Point(161, 11);
            txbMasinhvien.Name = "txbMasinhvien";
            txbMasinhvien.Size = new Size(168, 36);
            txbMasinhvien.TabIndex = 1;
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.Anchor = AnchorStyles.Left;
            dtpNgaySinh.Font = new Font("Roboto Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpNgaySinh.Format = DateTimePickerFormat.Short;
            dtpNgaySinh.Location = new Point(161, 69);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(168, 36);
            dtpNgaySinh.TabIndex = 7;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(tbtnNu, 1, 0);
            tableLayoutPanel3.Controls.Add(rbtnNam, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(452, 58);
            tableLayoutPanel3.Margin = new Padding(0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(228, 58);
            tableLayoutPanel3.TabIndex = 9;
            // 
            // tbtnNu
            // 
            tbtnNu.AutoSize = true;
            tbtnNu.Dock = DockStyle.Fill;
            tbtnNu.Font = new Font("Roboto Condensed", 18F);
            tbtnNu.Location = new Point(117, 3);
            tbtnNu.Name = "tbtnNu";
            tbtnNu.Size = new Size(108, 52);
            tbtnNu.TabIndex = 1;
            tbtnNu.TabStop = true;
            tbtnNu.Text = "Nữ";
            tbtnNu.UseVisualStyleBackColor = true;
            // 
            // rbtnNam
            // 
            rbtnNam.AutoSize = true;
            rbtnNam.Dock = DockStyle.Fill;
            rbtnNam.Font = new Font("Roboto Condensed", 18F);
            rbtnNam.Location = new Point(3, 3);
            rbtnNam.Name = "rbtnNam";
            rbtnNam.Size = new Size(108, 52);
            rbtnNam.TabIndex = 0;
            rbtnNam.TabStop = true;
            rbtnNam.Text = "Nam";
            rbtnNam.UseVisualStyleBackColor = true;
            // 
            // cbxChuyennganh
            // 
            cbxChuyennganh.Anchor = AnchorStyles.Left;
            cbxChuyennganh.Font = new Font("Roboto Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbxChuyennganh.FormattingEnabled = true;
            cbxChuyennganh.Location = new Point(851, 68);
            cbxChuyennganh.Name = "cbxChuyennganh";
            cbxChuyennganh.Size = new Size(206, 37);
            cbxChuyennganh.TabIndex = 11;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Dock = DockStyle.Fill;
            label8.Font = new Font("Roboto Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ControlText;
            label8.Location = new Point(3, 116);
            label8.Name = "label8";
            label8.Size = new Size(152, 59);
            label8.TabIndex = 12;
            label8.Text = "Tình trạng:";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cbxTinhtrang
            // 
            cbxTinhtrang.Anchor = AnchorStyles.Left;
            cbxTinhtrang.Font = new Font("Roboto Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbxTinhtrang.FormattingEnabled = true;
            cbxTinhtrang.Location = new Point(161, 127);
            cbxTinhtrang.Name = "cbxTinhtrang";
            cbxTinhtrang.Size = new Size(170, 37);
            cbxTinhtrang.TabIndex = 13;
            // 
            // flowLayoutPanel1
            // 
            tableLayoutPanel2.SetColumnSpan(flowLayoutPanel1, 4);
            flowLayoutPanel1.Controls.Add(btnThem);
            flowLayoutPanel1.Controls.Add(btnXoa);
            flowLayoutPanel1.Controls.Add(btnSua);
            flowLayoutPanel1.Controls.Add(btnLammoi);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(334, 116);
            flowLayoutPanel1.Margin = new Padding(0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(726, 59);
            flowLayoutPanel1.TabIndex = 14;
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Roboto Condensed", 15.75F);
            btnThem.Location = new Point(0, 0);
            btnThem.Margin = new Padding(0);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(180, 59);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Roboto Condensed", 15.75F);
            btnXoa.Location = new Point(180, 0);
            btnXoa.Margin = new Padding(0);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(180, 59);
            btnXoa.TabIndex = 1;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Font = new Font("Roboto Condensed", 15.75F);
            btnSua.Location = new Point(360, 0);
            btnSua.Margin = new Padding(0);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(180, 59);
            btnSua.TabIndex = 2;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnLammoi
            // 
            btnLammoi.Font = new Font("Roboto Condensed", 15.75F);
            btnLammoi.Location = new Point(540, 0);
            btnLammoi.Margin = new Padding(0);
            btnLammoi.Name = "btnLammoi";
            btnLammoi.Size = new Size(180, 59);
            btnLammoi.TabIndex = 3;
            btnLammoi.Text = "Làm mới";
            btnLammoi.UseVisualStyleBackColor = true;
            // 
            // drvDanhsachsinhvien
            // 
            drvDanhsachsinhvien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            drvDanhsachsinhvien.Dock = DockStyle.Fill;
            drvDanhsachsinhvien.Location = new Point(3, 178);
            drvDanhsachsinhvien.Name = "drvDanhsachsinhvien";
            drvDanhsachsinhvien.Size = new Size(1054, 449);
            drvDanhsachsinhvien.TabIndex = 1;
            // 
            // Quanlisinhvien
            // 
            AutoScaleDimensions = new SizeF(6F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel1);
            Font = new Font("Roboto Condensed", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Quanlisinhvien";
            Size = new Size(1060, 721);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)drvDanhsachsinhvien).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TextBox txbLop;
        private Label label4;
        private TextBox txbHovaten;
        private Label label3;
        private Label label2;
        private TextBox txbMasinhvien;
        private Label label7;
        private Label label6;
        private Label label5;
        private DateTimePicker dtpNgaySinh;
        private TableLayoutPanel tableLayoutPanel3;
        private RadioButton tbtnNu;
        private RadioButton rbtnNam;
        private ComboBox cbxChuyennganh;
        private ComboBox cbxTinhtrang;
        private Label label8;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnThem;
        private Button btnXoa;
        private Button btnSua;
        private Button btnLammoi;
        private DataGridView drvDanhsachsinhvien;
    }
}
