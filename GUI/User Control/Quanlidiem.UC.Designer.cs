namespace StudentManagment.GUI.User_Control
{
    partial class Quanlidiem
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
            dgvDanhsachmonhoc = new DataGridView();
            MASV = new DataGridViewTextBoxColumn();
            MAMON = new DataGridViewTextBoxColumn();
            DIEMCHUYENCAN = new DataGridViewTextBoxColumn();
            DIEMGIUAKY = new DataGridViewTextBoxColumn();
            DIEMCUOIKY = new DataGridViewTextBoxColumn();
            DIEMTONG = new DataGridViewTextBoxColumn();
            btnThem = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnLammoi = new Button();
            label2 = new Label();
            txbMasinhvien = new TextBox();
            label3 = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            txbMamonhoc = new TextBox();
            tableLayoutPanel4 = new TableLayoutPanel();
            txtDiemcuoiky = new TextBox();
            label7 = new Label();
            tableLayoutPanel9 = new TableLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel6 = new TableLayoutPanel();
            label5 = new Label();
            txbDiemgiuaky = new TextBox();
            tableLayoutPanel5 = new TableLayoutPanel();
            label4 = new Label();
            txbDiemchuyencan = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvDanhsachmonhoc).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel9.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvDanhsachmonhoc
            // 
            dgvDanhsachmonhoc.AllowUserToAddRows = false;
            dgvDanhsachmonhoc.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvDanhsachmonhoc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvDanhsachmonhoc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDanhsachmonhoc.Columns.AddRange(new DataGridViewColumn[] { MASV, MAMON, DIEMCHUYENCAN, DIEMGIUAKY, DIEMCUOIKY, DIEMTONG });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvDanhsachmonhoc.DefaultCellStyle = dataGridViewCellStyle2;
            dgvDanhsachmonhoc.Dock = DockStyle.Fill;
            dgvDanhsachmonhoc.Location = new Point(492, 3);
            dgvDanhsachmonhoc.Name = "dgvDanhsachmonhoc";
            dgvDanhsachmonhoc.ReadOnly = true;
            dgvDanhsachmonhoc.Size = new Size(565, 630);
            dgvDanhsachmonhoc.TabIndex = 1;
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
            // btnThem
            // 
            btnThem.Font = new Font("Roboto Condensed", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnThem.Location = new Point(3, 3);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(116, 57);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Roboto Condensed", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnXoa.Location = new Point(125, 3);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(116, 57);
            btnXoa.TabIndex = 1;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Font = new Font("Roboto Condensed", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSua.Location = new Point(247, 3);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(116, 57);
            btnSua.TabIndex = 2;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnThem);
            flowLayoutPanel1.Controls.Add(btnXoa);
            flowLayoutPanel1.Controls.Add(btnSua);
            flowLayoutPanel1.Controls.Add(btnLammoi);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 300);
            flowLayoutPanel1.Margin = new Padding(0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(489, 60);
            flowLayoutPanel1.TabIndex = 6;
            // 
            // btnLammoi
            // 
            btnLammoi.Font = new Font("Roboto Condensed", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLammoi.Location = new Point(369, 3);
            btnLammoi.Name = "btnLammoi";
            btnLammoi.Size = new Size(116, 57);
            btnLammoi.TabIndex = 3;
            btnLammoi.Text = "Làm mới";
            btnLammoi.UseVisualStyleBackColor = true;
            btnLammoi.Click += btnLammoi_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Roboto Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(156, 60);
            label2.TabIndex = 0;
            label2.Text = "Mã sinh viên:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txbMasinhvien
            // 
            txbMasinhvien.Anchor = AnchorStyles.Left;
            txbMasinhvien.BorderStyle = BorderStyle.FixedSingle;
            txbMasinhvien.Font = new Font("Roboto Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbMasinhvien.Location = new Point(165, 12);
            txbMasinhvien.Name = "txbMasinhvien";
            txbMasinhvien.Size = new Size(321, 36);
            txbMasinhvien.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Roboto Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(156, 60);
            label3.TabIndex = 0;
            label3.Text = "Mã môn học:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.2673264F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66.73267F));
            tableLayoutPanel3.Controls.Add(label2, 0, 0);
            tableLayoutPanel3.Controls.Add(txbMasinhvien, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Margin = new Padding(0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(489, 60);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // txbMamonhoc
            // 
            txbMamonhoc.Anchor = AnchorStyles.Left;
            txbMamonhoc.BorderStyle = BorderStyle.FixedSingle;
            txbMamonhoc.Font = new Font("Roboto Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbMamonhoc.Location = new Point(165, 12);
            txbMamonhoc.Name = "txbMamonhoc";
            txbMamonhoc.Size = new Size(321, 36);
            txbMamonhoc.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66.6666641F));
            tableLayoutPanel4.Controls.Add(label3, 0, 0);
            tableLayoutPanel4.Controls.Add(txbMamonhoc, 1, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(0, 60);
            tableLayoutPanel4.Margin = new Padding(0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(489, 60);
            tableLayoutPanel4.TabIndex = 1;
            // 
            // txtDiemcuoiky
            // 
            txtDiemcuoiky.Anchor = AnchorStyles.Left;
            txtDiemcuoiky.BorderStyle = BorderStyle.FixedSingle;
            txtDiemcuoiky.Font = new Font("Roboto Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDiemcuoiky.Location = new Point(165, 12);
            txtDiemcuoiky.Name = "txtDiemcuoiky";
            txtDiemcuoiky.Size = new Size(321, 36);
            txtDiemcuoiky.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = DockStyle.Fill;
            label7.Font = new Font("Roboto Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(3, 0);
            label7.Name = "label7";
            label7.Size = new Size(156, 60);
            label7.TabIndex = 0;
            label7.Text = "Điểm cuối kỳ:";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel9
            // 
            tableLayoutPanel9.ColumnCount = 2;
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.2673264F));
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66.73267F));
            tableLayoutPanel9.Controls.Add(txtDiemcuoiky, 1, 0);
            tableLayoutPanel9.Controls.Add(label7, 0, 0);
            tableLayoutPanel9.Dock = DockStyle.Fill;
            tableLayoutPanel9.Location = new Point(0, 240);
            tableLayoutPanel9.Margin = new Padding(0);
            tableLayoutPanel9.Name = "tableLayoutPanel9";
            tableLayoutPanel9.RowCount = 1;
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel9.Size = new Size(489, 60);
            tableLayoutPanel9.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 489F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 420F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(dgvDanhsachmonhoc, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 85);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1060, 636);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel6, 0, 3);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel5, 0, 2);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel9, 0, 4);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel4, 0, 1);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel2.Controls.Add(flowLayoutPanel1, 0, 5);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 7;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel2.Size = new Size(489, 636);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 2;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66.6666641F));
            tableLayoutPanel6.Controls.Add(label5, 0, 0);
            tableLayoutPanel6.Controls.Add(txbDiemgiuaky, 1, 0);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(0, 180);
            tableLayoutPanel6.Margin = new Padding(0);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Size = new Size(489, 60);
            tableLayoutPanel6.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Font = new Font("Roboto Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(3, 0);
            label5.Name = "label5";
            label5.Size = new Size(156, 60);
            label5.TabIndex = 0;
            label5.Text = "Điểm giữa kỳ:";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txbDiemgiuaky
            // 
            txbDiemgiuaky.Anchor = AnchorStyles.Left;
            txbDiemgiuaky.BorderStyle = BorderStyle.FixedSingle;
            txbDiemgiuaky.Font = new Font("Roboto Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbDiemgiuaky.Location = new Point(165, 12);
            txbDiemgiuaky.Name = "txbDiemgiuaky";
            txbDiemgiuaky.Size = new Size(321, 36);
            txbDiemgiuaky.TabIndex = 1;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66.6666641F));
            tableLayoutPanel5.Controls.Add(label4, 0, 0);
            tableLayoutPanel5.Controls.Add(txbDiemchuyencan, 1, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(0, 120);
            tableLayoutPanel5.Margin = new Padding(0);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Size = new Size(489, 60);
            tableLayoutPanel5.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Roboto Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(3, 0);
            label4.Name = "label4";
            label4.Size = new Size(156, 60);
            label4.TabIndex = 0;
            label4.Text = "Điểm chuyên cần:";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txbDiemchuyencan
            // 
            txbDiemchuyencan.Anchor = AnchorStyles.Left;
            txbDiemchuyencan.BorderStyle = BorderStyle.FixedSingle;
            txbDiemchuyencan.Font = new Font("Roboto Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbDiemchuyencan.Location = new Point(165, 12);
            txbDiemchuyencan.Name = "txbDiemchuyencan";
            txbDiemchuyencan.Size = new Size(321, 36);
            txbDiemchuyencan.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Roboto Condensed", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(18, 11);
            label1.Name = "label1";
            label1.Size = new Size(303, 58);
            label1.TabIndex = 0;
            label1.Text = "QUẢN LÝ ĐIỂM";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1060, 85);
            panel1.TabIndex = 3;
            // 
            // Quanlidiem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel1);
            Name = "Quanlidiem";
            Size = new Size(1060, 721);
            Load += Quanlidiem_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDanhsachmonhoc).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel9.ResumeLayout(false);
            tableLayoutPanel9.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvDanhsachmonhoc;
        private Button btnThem;
        private Button btnXoa;
        private Button btnSua;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnLammoi;
        private Label label2;
        private TextBox txbMasinhvien;
        private Label label3;
        private TableLayoutPanel tableLayoutPanel3;
        private TextBox txbMamonhoc;
        private TableLayoutPanel tableLayoutPanel4;
        private TextBox txtDiemcuoiky;
        private Label label7;
        private TableLayoutPanel tableLayoutPanel9;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label1;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel6;
        private Label label5;
        private TextBox txbDiemgiuaky;
        private TableLayoutPanel tableLayoutPanel5;
        private Label label4;
        private TextBox txbDiemchuyencan;
        private DataGridViewTextBoxColumn MASV;
        private DataGridViewTextBoxColumn MAMON;
        private DataGridViewTextBoxColumn DIEMCHUYENCAN;
        private DataGridViewTextBoxColumn DIEMGIUAKY;
        private DataGridViewTextBoxColumn DIEMCUOIKY;
        private DataGridViewTextBoxColumn DIEMTONG;
        private TableLayoutPanel tableLayoutPanel10;
        private Label label8;
        private Label lbDiemtongket;
    }
}
