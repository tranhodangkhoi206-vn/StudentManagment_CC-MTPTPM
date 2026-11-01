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
            pUserControl = new Panel();
            btnQuanlydiem = new Button();
            btnQuanlymonhoc = new Button();
            btnQuanlysinhvien = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnTrangchu = new Button();
            button1 = new Button();
            btnQuanlylophoc = new Button();
            btnQuanlychuyennganh = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // pUserControl
            // 
            pUserControl.Dock = DockStyle.Fill;
            pUserControl.Location = new Point(194, 0);
            pUserControl.Margin = new Padding(0);
            pUserControl.Name = "pUserControl";
            pUserControl.Size = new Size(790, 611);
            pUserControl.TabIndex = 1;
            // 
            // btnQuanlydiem
            // 
            btnQuanlydiem.BackColor = Color.FromArgb(26, 56, 90);
            btnQuanlydiem.BackgroundImageLayout = ImageLayout.None;
            btnQuanlydiem.Cursor = Cursors.Hand;
            btnQuanlydiem.Dock = DockStyle.Fill;
            btnQuanlydiem.FlatAppearance.BorderSize = 0;
            btnQuanlydiem.FlatStyle = FlatStyle.Flat;
            btnQuanlydiem.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnQuanlydiem.ForeColor = SystemColors.ButtonHighlight;
            btnQuanlydiem.Location = new Point(0, 300);
            btnQuanlydiem.Margin = new Padding(0);
            btnQuanlydiem.Name = "btnQuanlydiem";
            btnQuanlydiem.Size = new Size(194, 50);
            btnQuanlydiem.TabIndex = 8;
            btnQuanlydiem.Text = "Quản lý điểm";
            btnQuanlydiem.UseVisualStyleBackColor = false;
            btnQuanlydiem.Click += btnQuanlydiem_Click;
            btnQuanlydiem.Leave += btnQuanlydiem_Leave;
            // 
            // btnQuanlymonhoc
            // 
            btnQuanlymonhoc.BackgroundImageLayout = ImageLayout.None;
            btnQuanlymonhoc.Cursor = Cursors.Hand;
            btnQuanlymonhoc.Dock = DockStyle.Fill;
            btnQuanlymonhoc.FlatAppearance.BorderSize = 0;
            btnQuanlymonhoc.FlatStyle = FlatStyle.Flat;
            btnQuanlymonhoc.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnQuanlymonhoc.ForeColor = SystemColors.ButtonHighlight;
            btnQuanlymonhoc.Location = new Point(0, 150);
            btnQuanlymonhoc.Margin = new Padding(0);
            btnQuanlymonhoc.Name = "btnQuanlymonhoc";
            btnQuanlymonhoc.Size = new Size(194, 50);
            btnQuanlymonhoc.TabIndex = 2;
            btnQuanlymonhoc.Text = "Quản lý môn học";
            btnQuanlymonhoc.UseVisualStyleBackColor = false;
            btnQuanlymonhoc.Click += btnQuanlymonhoc_Click;
            btnQuanlymonhoc.Leave += btnQuanlymonhoc_Leave;
            // 
            // btnQuanlysinhvien
            // 
            btnQuanlysinhvien.BackgroundImageLayout = ImageLayout.None;
            btnQuanlysinhvien.Cursor = Cursors.Hand;
            btnQuanlysinhvien.Dock = DockStyle.Fill;
            btnQuanlysinhvien.FlatAppearance.BorderSize = 0;
            btnQuanlysinhvien.FlatStyle = FlatStyle.Flat;
            btnQuanlysinhvien.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnQuanlysinhvien.ForeColor = SystemColors.ButtonHighlight;
            btnQuanlysinhvien.Location = new Point(0, 100);
            btnQuanlysinhvien.Margin = new Padding(0);
            btnQuanlysinhvien.Name = "btnQuanlysinhvien";
            btnQuanlysinhvien.Size = new Size(194, 50);
            btnQuanlysinhvien.TabIndex = 1;
            btnQuanlysinhvien.Text = "Quản lý sinh viên";
            btnQuanlysinhvien.UseVisualStyleBackColor = false;
            btnQuanlysinhvien.Click += btnQuanlysinhvien_Click;
            btnQuanlysinhvien.Leave += btnQuanlysinhvien_Leave;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(26, 56, 90);
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.Controls.Add(btnTrangchu, 0, 1);
            tableLayoutPanel1.Controls.Add(button1, 0, 7);
            tableLayoutPanel1.Controls.Add(btnQuanlylophoc, 0, 5);
            tableLayoutPanel1.Controls.Add(btnQuanlychuyennganh, 0, 4);
            tableLayoutPanel1.Controls.Add(btnQuanlysinhvien, 0, 2);
            tableLayoutPanel1.Controls.Add(btnQuanlymonhoc, 0, 3);
            tableLayoutPanel1.Controls.Add(btnQuanlydiem, 0, 6);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 9;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(194, 611);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // btnTrangchu
            // 
            btnTrangchu.BackColor = Color.FromArgb(26, 56, 90);
            btnTrangchu.BackgroundImageLayout = ImageLayout.None;
            btnTrangchu.Cursor = Cursors.Hand;
            btnTrangchu.Dock = DockStyle.Fill;
            btnTrangchu.FlatAppearance.BorderSize = 0;
            btnTrangchu.FlatStyle = FlatStyle.Flat;
            btnTrangchu.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnTrangchu.ForeColor = SystemColors.ButtonHighlight;
            btnTrangchu.Location = new Point(0, 50);
            btnTrangchu.Margin = new Padding(0);
            btnTrangchu.Name = "btnTrangchu";
            btnTrangchu.Size = new Size(194, 50);
            btnTrangchu.TabIndex = 13;
            btnTrangchu.Text = "Trang chủ";
            btnTrangchu.UseVisualStyleBackColor = false;
            btnTrangchu.Click += btnTrangchu_Click;
            btnTrangchu.Leave += btnTrangchu_Leave;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(31, 73, 120);
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.Cursor = Cursors.Hand;
            button1.Dock = DockStyle.Fill;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(0, 350);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(194, 50);
            button1.TabIndex = 12;
            button1.Text = "Quản lý lớp học";
            button1.UseVisualStyleBackColor = false;
            // 
            // btnQuanlylophoc
            // 
            btnQuanlylophoc.BackColor = Color.FromArgb(26, 56, 90);
            btnQuanlylophoc.BackgroundImageLayout = ImageLayout.None;
            btnQuanlylophoc.Cursor = Cursors.Hand;
            btnQuanlylophoc.Dock = DockStyle.Fill;
            btnQuanlylophoc.FlatAppearance.BorderSize = 0;
            btnQuanlylophoc.FlatStyle = FlatStyle.Flat;
            btnQuanlylophoc.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnQuanlylophoc.ForeColor = SystemColors.ButtonHighlight;
            btnQuanlylophoc.Location = new Point(0, 250);
            btnQuanlylophoc.Margin = new Padding(0);
            btnQuanlylophoc.Name = "btnQuanlylophoc";
            btnQuanlylophoc.Size = new Size(194, 50);
            btnQuanlylophoc.TabIndex = 11;
            btnQuanlylophoc.Text = "Quản lý lớp học";
            btnQuanlylophoc.UseVisualStyleBackColor = false;
            btnQuanlylophoc.Click += btnQuanlylophoc_Click;
            btnQuanlylophoc.Leave += btnQuanlylophoc_Leave;
            // 
            // btnQuanlychuyennganh
            // 
            btnQuanlychuyennganh.BackColor = Color.FromArgb(26, 56, 90);
            btnQuanlychuyennganh.BackgroundImageLayout = ImageLayout.None;
            btnQuanlychuyennganh.Cursor = Cursors.Hand;
            btnQuanlychuyennganh.Dock = DockStyle.Fill;
            btnQuanlychuyennganh.FlatAppearance.BorderSize = 0;
            btnQuanlychuyennganh.FlatStyle = FlatStyle.Flat;
            btnQuanlychuyennganh.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnQuanlychuyennganh.ForeColor = SystemColors.ButtonHighlight;
            btnQuanlychuyennganh.Location = new Point(0, 200);
            btnQuanlychuyennganh.Margin = new Padding(0);
            btnQuanlychuyennganh.Name = "btnQuanlychuyennganh";
            btnQuanlychuyennganh.Size = new Size(194, 50);
            btnQuanlychuyennganh.TabIndex = 9;
            btnQuanlychuyennganh.Text = "Quản lý ngành";
            btnQuanlychuyennganh.UseVisualStyleBackColor = false;
            btnQuanlychuyennganh.Click += btnQuanlychuyennganh_Click;
            btnQuanlychuyennganh.Leave += btnQuanlychuyennganh_Leave;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.7154465F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80.28455F));
            tableLayoutPanel2.Controls.Add(pUserControl, 1, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel1, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(984, 611);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // frmQuanLySinhVien
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(984, 611);
            Controls.Add(tableLayoutPanel2);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "frmQuanLySinhVien";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý sinh viên";
            FormClosed += frmQuanLySinhVien_FormClosed;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel pUserControl;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnQuanlysinhvien;
        private Button btnQuanlymonhoc;
        private Button btnQuanlydiem;
        private TableLayoutPanel tableLayoutPanel2;
        private Button btnQuanlychuyennganh;
        private Button btnQuanlylophoc;
        private Button button1;
        private Button btnTrangchu;
    }
}
