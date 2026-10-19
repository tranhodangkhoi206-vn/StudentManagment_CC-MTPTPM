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
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
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
            tableLayoutPanel3.Controls.Add(button5, 0, 4);
            tableLayoutPanel3.Controls.Add(button4, 0, 3);
            tableLayoutPanel3.Controls.Add(button3, 0, 2);
            tableLayoutPanel3.Controls.Add(button2, 0, 1);
            tableLayoutPanel3.Controls.Add(button1, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 167);
            tableLayoutPanel3.Margin = new Padding(0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 6;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 8F));
            tableLayoutPanel3.Size = new Size(220, 515);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // button5
            // 
            button5.BackColor = Color.LimeGreen;
            button5.BackgroundImageLayout = ImageLayout.None;
            button5.Cursor = Cursors.Hand;
            button5.Dock = DockStyle.Fill;
            button5.FlatAppearance.BorderColor = SystemColors.Highlight;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Roboto Condensed", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = SystemColors.ButtonHighlight;
            button5.Location = new Point(0, 200);
            button5.Margin = new Padding(0);
            button5.Name = "button5";
            button5.Size = new Size(220, 50);
            button5.TabIndex = 4;
            button5.Text = "Đăng xuất";
            button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackgroundImageLayout = ImageLayout.None;
            button4.Cursor = Cursors.Hand;
            button4.Dock = DockStyle.Fill;
            button4.FlatAppearance.BorderColor = SystemColors.Highlight;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Roboto Condensed", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = SystemColors.ButtonHighlight;
            button4.Location = new Point(0, 150);
            button4.Margin = new Padding(0);
            button4.Name = "button4";
            button4.Size = new Size(220, 50);
            button4.TabIndex = 3;
            button4.Text = "Quản lí điểm";
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackgroundImageLayout = ImageLayout.None;
            button3.Cursor = Cursors.Hand;
            button3.Dock = DockStyle.Fill;
            button3.FlatAppearance.BorderColor = SystemColors.Highlight;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Roboto Condensed", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(0, 100);
            button3.Margin = new Padding(0);
            button3.Name = "button3";
            button3.Size = new Size(220, 50);
            button3.TabIndex = 2;
            button3.Text = "Quản lí môn học";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackgroundImageLayout = ImageLayout.None;
            button2.Cursor = Cursors.Hand;
            button2.Dock = DockStyle.Fill;
            button2.FlatAppearance.BorderColor = SystemColors.Highlight;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Roboto Condensed", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(0, 50);
            button2.Margin = new Padding(0);
            button2.Name = "button2";
            button2.Size = new Size(220, 50);
            button2.TabIndex = 1;
            button2.Text = "Quản lí sinh viên";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.Cursor = Cursors.Hand;
            button1.Dock = DockStyle.Fill;
            button1.FlatAppearance.BorderColor = SystemColors.Highlight;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Roboto Condensed", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(0, 0);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(220, 50);
            button1.TabIndex = 0;
            button1.Text = "Tra cứu sinh viên";
            button1.UseVisualStyleBackColor = false;
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
        private Button button1;
        private Button button4;
        private Button button3;
        private Button button5;
        private Button button2;
    }
}
