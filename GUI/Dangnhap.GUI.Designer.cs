namespace StudentManagment.GUI
{
    partial class frmDangnhap
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            txbMatkhau = new TextBox();
            label4 = new Label();
            label2 = new Label();
            txbTennguoidung = new TextBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnThoat = new Button();
            btnDangnhap = new Button();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Highlight;
            tableLayoutPanel1.SetColumnSpan(label1, 2);
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Roboto Condensed", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(540, 61);
            label1.TabIndex = 0;
            label1.Text = "Phần mền quản lý Sinh viên";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 363F));
            tableLayoutPanel1.Controls.Add(txbMatkhau, 1, 2);
            tableLayoutPanel1.Controls.Add(label4, 0, 2);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(txbTennguoidung, 1, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 61F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tableLayoutPanel1.Size = new Size(546, 288);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // txbMatkhau
            // 
            txbMatkhau.Anchor = AnchorStyles.Left;
            txbMatkhau.BorderStyle = BorderStyle.FixedSingle;
            txbMatkhau.Font = new Font("Roboto Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbMatkhau.Location = new Point(186, 148);
            txbMatkhau.Name = "txbMatkhau";
            txbMatkhau.Size = new Size(357, 36);
            txbMatkhau.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Roboto Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(3, 131);
            label4.Name = "label4";
            label4.Size = new Size(177, 70);
            label4.TabIndex = 3;
            label4.Text = "Mật khẩu:";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Roboto Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 61);
            label2.Name = "label2";
            label2.Size = new Size(177, 70);
            label2.TabIndex = 1;
            label2.Text = "Tên người dùng: ";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txbTennguoidung
            // 
            txbTennguoidung.Anchor = AnchorStyles.Left;
            txbTennguoidung.BorderStyle = BorderStyle.FixedSingle;
            txbTennguoidung.Font = new Font("Roboto Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbTennguoidung.Location = new Point(186, 78);
            txbTennguoidung.Name = "txbTennguoidung";
            txbTennguoidung.Size = new Size(357, 36);
            txbTennguoidung.TabIndex = 4;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(btnThoat, 1, 0);
            tableLayoutPanel2.Controls.Add(btnDangnhap, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(183, 201);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(363, 87);
            tableLayoutPanel2.TabIndex = 6;
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Roboto Condensed", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnThoat.Location = new Point(184, 3);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(123, 50);
            btnThoat.TabIndex = 1;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnDangnhap
            // 
            btnDangnhap.Font = new Font("Roboto Condensed", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDangnhap.Location = new Point(3, 3);
            btnDangnhap.Name = "btnDangnhap";
            btnDangnhap.Size = new Size(123, 50);
            btnDangnhap.TabIndex = 0;
            btnDangnhap.Text = "Đăng nhập";
            btnDangnhap.UseVisualStyleBackColor = true;
            // 
            // frmDangnhap
            // 
            AutoScaleDimensions = new SizeF(6F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(546, 288);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Roboto Condensed", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "frmDangnhap";
            Text = "Đăng nhập";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label4;
        private Label label2;
        private TextBox txbMatkhau;
        private TextBox txbTennguoidung;
        private TableLayoutPanel tableLayoutPanel2;
        private Button btnThoat;
        private Button btnDangnhap;
    }
}