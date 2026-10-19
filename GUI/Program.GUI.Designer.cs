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
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            lbTen = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            btnQuanlimonhoc = new Button();
            btnQuanlisinhvien = new Button();
            btnTracuusinhvien = new Button();
            btnDangxuat = new Button();
            btnQuanlidiem = new Button();
            btnQuanlichuyennganh = new Button();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(220, 682);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = SystemColors.Highlight;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 515F));
            tableLayoutPanel1.Size = new Size(220, 682);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(lbTen, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(214, 161);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // lbTen
            // 
            lbTen.AutoSize = true;
            lbTen.Dock = DockStyle.Fill;
            lbTen.Font = new Font("Roboto Condensed", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTen.ForeColor = SystemColors.ButtonHighlight;
            lbTen.Location = new Point(3, 0);
            lbTen.Name = "lbTen";
            lbTen.Size = new Size(208, 161);
            lbTen.TabIndex = 1;
            lbTen.Text = "Nguyễn Văn A";
            lbTen.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(btnQuanlichuyennganh, 0, 3);
            tableLayoutPanel3.Controls.Add(btnQuanlidiem, 0, 4);
            tableLayoutPanel3.Controls.Add(btnDangxuat, 0, 5);
            tableLayoutPanel3.Controls.Add(btnQuanlimonhoc, 0, 2);
            tableLayoutPanel3.Controls.Add(btnQuanlisinhvien, 0, 1);
            tableLayoutPanel3.Controls.Add(btnTracuusinhvien, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 167);
            tableLayoutPanel3.Margin = new Padding(0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 7;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(220, 515);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // btnQuanlimonhoc
            // 
            btnQuanlimonhoc.BackgroundImageLayout = ImageLayout.None;
            btnQuanlimonhoc.Cursor = Cursors.Hand;
            btnQuanlimonhoc.Dock = DockStyle.Fill;
            btnQuanlimonhoc.FlatAppearance.BorderColor = SystemColors.Highlight;
            btnQuanlimonhoc.FlatStyle = FlatStyle.Flat;
            btnQuanlimonhoc.Font = new Font("Roboto Condensed", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnQuanlimonhoc.ForeColor = SystemColors.ButtonHighlight;
            btnQuanlimonhoc.Location = new Point(0, 100);
            btnQuanlimonhoc.Margin = new Padding(0);
            btnQuanlimonhoc.Name = "btnQuanlimonhoc";
            btnQuanlimonhoc.Size = new Size(220, 50);
            btnQuanlimonhoc.TabIndex = 2;
            btnQuanlimonhoc.Text = "Quản lí môn học";
            btnQuanlimonhoc.UseVisualStyleBackColor = false;
            // 
            // btnQuanlisinhvien
            // 
            btnQuanlisinhvien.BackgroundImageLayout = ImageLayout.None;
            btnQuanlisinhvien.Cursor = Cursors.Hand;
            btnQuanlisinhvien.Dock = DockStyle.Fill;
            btnQuanlisinhvien.FlatAppearance.BorderColor = SystemColors.Highlight;
            btnQuanlisinhvien.FlatStyle = FlatStyle.Flat;
            btnQuanlisinhvien.Font = new Font("Roboto Condensed", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnQuanlisinhvien.ForeColor = SystemColors.ButtonHighlight;
            btnQuanlisinhvien.Location = new Point(0, 50);
            btnQuanlisinhvien.Margin = new Padding(0);
            btnQuanlisinhvien.Name = "btnQuanlisinhvien";
            btnQuanlisinhvien.Size = new Size(220, 50);
            btnQuanlisinhvien.TabIndex = 1;
            btnQuanlisinhvien.Text = "Quản lí sinh viên";
            btnQuanlisinhvien.UseVisualStyleBackColor = false;
            // 
            // btnTracuusinhvien
            // 
            btnTracuusinhvien.BackgroundImageLayout = ImageLayout.None;
            btnTracuusinhvien.Cursor = Cursors.Hand;
            btnTracuusinhvien.Dock = DockStyle.Fill;
            btnTracuusinhvien.FlatAppearance.BorderColor = SystemColors.Highlight;
            btnTracuusinhvien.FlatStyle = FlatStyle.Flat;
            btnTracuusinhvien.Font = new Font("Roboto Condensed", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTracuusinhvien.ForeColor = SystemColors.ButtonHighlight;
            btnTracuusinhvien.Location = new Point(0, 0);
            btnTracuusinhvien.Margin = new Padding(0);
            btnTracuusinhvien.Name = "btnTracuusinhvien";
            btnTracuusinhvien.Size = new Size(220, 50);
            btnTracuusinhvien.TabIndex = 0;
            btnTracuusinhvien.Text = "Tra cứu sinh viên";
            btnTracuusinhvien.UseVisualStyleBackColor = false;
            // 
            // btnDangxuat
            // 
            btnDangxuat.BackColor = Color.LimeGreen;
            btnDangxuat.BackgroundImageLayout = ImageLayout.None;
            btnDangxuat.Cursor = Cursors.Hand;
            btnDangxuat.Dock = DockStyle.Fill;
            btnDangxuat.FlatAppearance.BorderColor = SystemColors.Highlight;
            btnDangxuat.FlatStyle = FlatStyle.Flat;
            btnDangxuat.Font = new Font("Roboto Condensed", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDangxuat.ForeColor = SystemColors.ButtonHighlight;
            btnDangxuat.Location = new Point(0, 250);
            btnDangxuat.Margin = new Padding(0);
            btnDangxuat.Name = "btnDangxuat";
            btnDangxuat.Size = new Size(220, 50);
            btnDangxuat.TabIndex = 6;
            btnDangxuat.Text = "Đăng xuất";
            btnDangxuat.UseVisualStyleBackColor = false;
            // 
            // btnQuanlidiem
            // 
            btnQuanlidiem.BackgroundImageLayout = ImageLayout.None;
            btnQuanlidiem.Cursor = Cursors.Hand;
            btnQuanlidiem.Dock = DockStyle.Fill;
            btnQuanlidiem.FlatAppearance.BorderColor = SystemColors.Highlight;
            btnQuanlidiem.FlatStyle = FlatStyle.Flat;
            btnQuanlidiem.Font = new Font("Roboto Condensed", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnQuanlidiem.ForeColor = SystemColors.ButtonHighlight;
            btnQuanlidiem.Location = new Point(0, 200);
            btnQuanlidiem.Margin = new Padding(0);
            btnQuanlidiem.Name = "btnQuanlidiem";
            btnQuanlidiem.Size = new Size(220, 50);
            btnQuanlidiem.TabIndex = 8;
            btnQuanlidiem.Text = "Quản lí điểm";
            btnQuanlidiem.UseVisualStyleBackColor = false;
            // 
            // btnQuanlichuyennganh
            // 
            btnQuanlichuyennganh.BackgroundImageLayout = ImageLayout.None;
            btnQuanlichuyennganh.Cursor = Cursors.Hand;
            btnQuanlichuyennganh.Dock = DockStyle.Fill;
            btnQuanlichuyennganh.FlatAppearance.BorderColor = SystemColors.Highlight;
            btnQuanlichuyennganh.FlatStyle = FlatStyle.Flat;
            btnQuanlichuyennganh.Font = new Font("Roboto Condensed", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnQuanlichuyennganh.ForeColor = SystemColors.ButtonHighlight;
            btnQuanlichuyennganh.Location = new Point(0, 150);
            btnQuanlichuyennganh.Margin = new Padding(0);
            btnQuanlichuyennganh.Name = "btnQuanlichuyennganh";
            btnQuanlichuyennganh.Size = new Size(220, 50);
            btnQuanlichuyennganh.TabIndex = 9;
            btnQuanlichuyennganh.Text = "QL.Chuyên ngành";
            btnQuanlichuyennganh.UseVisualStyleBackColor = false;
            // 
            // frmQuanLySinhVien
            // 
            AutoScaleDimensions = new SizeF(6F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1266, 682);
            Controls.Add(panel1);
            Font = new Font("Roboto Condensed", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "frmQuanLySinhVien";
            Text = "Quản lý sinh viên";
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label lbTen;
        private TableLayoutPanel tableLayoutPanel3;
        private Button btnTracuusinhvien;
        private Button btnQuanlimonhoc;
        private Button btnQuanlisinhvien;
        private Button btnQuanlichuyennganh;
        private Button btnQuanlidiem;
        private Button btnDangxuat;
    }
}
