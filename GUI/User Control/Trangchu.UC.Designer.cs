namespace StudentManagment.GUI.User_Control
{
    partial class Trangchu
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
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel5 = new TableLayoutPanel();
            lb0001 = new Label();
            lbTongmonhoc = new Label();
            tableLayoutPanel4 = new TableLayoutPanel();
            lb0002 = new Label();
            lbTonglophoc = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            label2 = new Label();
            lbTongsinhvien = new Label();
            pictureBox1 = new PictureBox();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            tableLayoutPanel1.TabIndex = 2;
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
            label1.Text = "TRANG CHỦ";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel5, 2, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel4, 1, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel2.Controls.Add(pictureBox1, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 66);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.Padding = new Padding(6);
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 162F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(790, 545);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Controls.Add(lb0001, 0, 0);
            tableLayoutPanel5.Controls.Add(lbTongmonhoc, 0, 1);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(524, 6);
            tableLayoutPanel5.Margin = new Padding(0);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 23.45679F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 76.54321F));
            tableLayoutPanel5.Size = new Size(260, 162);
            tableLayoutPanel5.TabIndex = 2;
            // 
            // lb0001
            // 
            lb0001.AutoSize = true;
            lb0001.BackColor = SystemColors.ControlDark;
            lb0001.Dock = DockStyle.Fill;
            lb0001.Font = new Font("Roboto Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb0001.Location = new Point(0, 0);
            lb0001.Margin = new Padding(0);
            lb0001.Name = "lb0001";
            lb0001.Size = new Size(260, 38);
            lb0001.TabIndex = 0;
            lb0001.Text = "Tổng số môn học";
            lb0001.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbTongmonhoc
            // 
            lbTongmonhoc.AutoSize = true;
            lbTongmonhoc.Dock = DockStyle.Fill;
            lbTongmonhoc.Font = new Font("Roboto Condensed", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbTongmonhoc.Location = new Point(3, 38);
            lbTongmonhoc.Name = "lbTongmonhoc";
            lbTongmonhoc.Size = new Size(254, 124);
            lbTongmonhoc.TabIndex = 1;
            lbTongmonhoc.Text = "0";
            lbTongmonhoc.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(lb0002, 0, 0);
            tableLayoutPanel4.Controls.Add(lbTonglophoc, 0, 1);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(265, 6);
            tableLayoutPanel4.Margin = new Padding(0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 23.45679F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 76.54321F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Size = new Size(259, 162);
            tableLayoutPanel4.TabIndex = 1;
            // 
            // lb0002
            // 
            lb0002.AutoSize = true;
            lb0002.BackColor = SystemColors.ControlDark;
            lb0002.Dock = DockStyle.Fill;
            lb0002.Font = new Font("Roboto Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb0002.Location = new Point(0, 0);
            lb0002.Margin = new Padding(0);
            lb0002.Name = "lb0002";
            lb0002.Size = new Size(259, 38);
            lb0002.TabIndex = 0;
            lb0002.Text = "Tổng số lớp học";
            lb0002.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbTonglophoc
            // 
            lbTonglophoc.AutoSize = true;
            lbTonglophoc.Dock = DockStyle.Fill;
            lbTonglophoc.Font = new Font("Roboto Condensed", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbTonglophoc.Location = new Point(3, 38);
            lbTonglophoc.Name = "lbTonglophoc";
            lbTonglophoc.Size = new Size(253, 124);
            lbTonglophoc.TabIndex = 1;
            lbTonglophoc.Text = "0";
            lbTonglophoc.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(label2, 0, 0);
            tableLayoutPanel3.Controls.Add(lbTongsinhvien, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(6, 6);
            tableLayoutPanel3.Margin = new Padding(0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 23.45679F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 76.54321F));
            tableLayoutPanel3.Size = new Size(259, 162);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ControlDark;
            label2.Dock = DockStyle.Fill;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Roboto Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(0, 0);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(259, 38);
            label2.TabIndex = 0;
            label2.Text = "Tổng số sinh viên";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbTongsinhvien
            // 
            lbTongsinhvien.AutoSize = true;
            lbTongsinhvien.Dock = DockStyle.Fill;
            lbTongsinhvien.Font = new Font("Roboto Condensed", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbTongsinhvien.Location = new Point(3, 38);
            lbTongsinhvien.Name = "lbTongsinhvien";
            lbTongsinhvien.Size = new Size(253, 124);
            lbTongsinhvien.TabIndex = 1;
            lbTongsinhvien.Text = "0";
            lbTongsinhvien.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            tableLayoutPanel2.SetColumnSpan(pictureBox1, 3);
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.business_dashboard_with_sales_performance_revenue_growth_profit_margin_purchase_activity_charts_439195_114;
            pictureBox1.Location = new Point(6, 168);
            pictureBox1.Margin = new Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(778, 371);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // Trangchu
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            Controls.Add(tableLayoutPanel1);
            Name = "Trangchu";
            Size = new Size(790, 611);
            Load += Trangchu_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label2;
        private Label lbTongsinhvien;
        private TableLayoutPanel tableLayoutPanel5;
        private Label lb0001;
        private Label lbTongmonhoc;
        private TableLayoutPanel tableLayoutPanel4;
        private Label lb0002;
        private Label lbTonglophoc;
        private PictureBox pictureBox1;
    }
}
