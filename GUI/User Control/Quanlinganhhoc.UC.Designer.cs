namespace StudentManagment.GUI.User_Control
{
    partial class Quanlinganhhoc
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
            dgvDanhsachmonhoc = new DataGridView();
            btnThem = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnLammoi = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            panel1 = new Panel();
            label4 = new Label();
            tableLayoutPanel5 = new TableLayoutPanel();
            txbTennganh = new TextBox();
            label3 = new Label();
            tableLayoutPanel4 = new TableLayoutPanel();
            txbManganh = new TextBox();
            label2 = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            txbKhoa = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvDanhsachmonhoc).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // dgvDanhsachmonhoc
            // 
            dgvDanhsachmonhoc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDanhsachmonhoc.Dock = DockStyle.Fill;
            dgvDanhsachmonhoc.Location = new Point(492, 3);
            dgvDanhsachmonhoc.Name = "dgvDanhsachmonhoc";
            dgvDanhsachmonhoc.Size = new Size(565, 630);
            dgvDanhsachmonhoc.TabIndex = 1;
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
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnThem);
            flowLayoutPanel1.Controls.Add(btnXoa);
            flowLayoutPanel1.Controls.Add(btnSua);
            flowLayoutPanel1.Controls.Add(btnLammoi);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 180);
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
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel5, 0, 2);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel4, 0, 1);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel2.Controls.Add(flowLayoutPanel1, 0, 3);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 5;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel2.Size = new Size(489, 636);
            tableLayoutPanel2.TabIndex = 0;
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
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Roboto Condensed", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(19, 9);
            label1.Name = "label1";
            label1.Size = new Size(442, 58);
            label1.TabIndex = 0;
            label1.Text = "QUẢN LÝ NGÀNH HỌC";
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Roboto Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(3, 0);
            label4.Name = "label4";
            label4.Size = new Size(156, 60);
            label4.TabIndex = 0;
            label4.Text = "Khoa quản lý:";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.2673264F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66.73267F));
            tableLayoutPanel5.Controls.Add(txbKhoa, 1, 0);
            tableLayoutPanel5.Controls.Add(label4, 0, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(0, 120);
            tableLayoutPanel5.Margin = new Padding(0);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Size = new Size(489, 60);
            tableLayoutPanel5.TabIndex = 2;
            // 
            // txbTennganh
            // 
            txbTennganh.Anchor = AnchorStyles.Left;
            txbTennganh.BorderStyle = BorderStyle.FixedSingle;
            txbTennganh.Font = new Font("Roboto Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbTennganh.Location = new Point(165, 12);
            txbTennganh.Name = "txbTennganh";
            txbTennganh.Size = new Size(321, 36);
            txbTennganh.TabIndex = 1;
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
            label3.Text = "Tên ngành:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66.6666641F));
            tableLayoutPanel4.Controls.Add(label3, 0, 0);
            tableLayoutPanel4.Controls.Add(txbTennganh, 1, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(0, 60);
            tableLayoutPanel4.Margin = new Padding(0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(489, 60);
            tableLayoutPanel4.TabIndex = 1;
            // 
            // txbManganh
            // 
            txbManganh.Anchor = AnchorStyles.Left;
            txbManganh.BorderStyle = BorderStyle.FixedSingle;
            txbManganh.Font = new Font("Roboto Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbManganh.Location = new Point(165, 12);
            txbManganh.Name = "txbManganh";
            txbManganh.Size = new Size(321, 36);
            txbManganh.TabIndex = 1;
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
            label2.Text = "Mã ngành:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.2673264F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66.73267F));
            tableLayoutPanel3.Controls.Add(label2, 0, 0);
            tableLayoutPanel3.Controls.Add(txbManganh, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Margin = new Padding(0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(489, 60);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // txbKhoa
            // 
            txbKhoa.Anchor = AnchorStyles.Left;
            txbKhoa.BorderStyle = BorderStyle.FixedSingle;
            txbKhoa.Font = new Font("Roboto Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbKhoa.Location = new Point(165, 12);
            txbKhoa.Name = "txbKhoa";
            txbKhoa.Size = new Size(321, 36);
            txbKhoa.TabIndex = 2;
            // 
            // Quanlinganhhoc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel1);
            Name = "Quanlinganhhoc";
            Size = new Size(1060, 721);
            ((System.ComponentModel.ISupportInitialize)dgvDanhsachmonhoc).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvDanhsachmonhoc;
        private Button btnThem;
        private Button btnXoa;
        private Button btnSua;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnLammoi;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel5;
        private Label label4;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label3;
        private TextBox txbTennganh;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label2;
        private TextBox txbManganh;
        private TextBox txbKhoa;
    }
}
