namespace asm
{
    partial class Form1
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
            label1 = new Label();
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            btnThoat = new Button();
            btndangnhap = new Button();
            txtMatKhau = new TextBox();
            txtTaiKhoan = new TextBox();
            label3 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19F, FontStyle.Bold);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(152, 38);
            label1.Name = "label1";
            label1.Size = new Size(469, 36);
            label1.TabIndex = 0;
            label1.Text = "Đăng nhập hệ thống Quản lí thư viện";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.tải_xuống__22_;
            pictureBox1.Location = new Point(53, 116);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(225, 234);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(btndangnhap);
            groupBox1.Controls.Add(txtMatKhau);
            groupBox1.Controls.Add(txtTaiKhoan);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 10F);
            groupBox1.Location = new Point(328, 116);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(418, 234);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin đăng nhập";
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(242, 161);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(90, 31);
            btnThoat.TabIndex = 6;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btndangnhap
            // 
            btndangnhap.Location = new Point(96, 161);
            btndangnhap.Name = "btndangnhap";
            btndangnhap.Size = new Size(90, 31);
            btndangnhap.TabIndex = 5;
            btndangnhap.Text = "Đăng nhập";
            btndangnhap.UseVisualStyleBackColor = true;
            btndangnhap.Click += btndangnhap_Click;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(145, 99);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(242, 25);
            txtMatKhau.TabIndex = 4;
            txtMatKhau.UseSystemPasswordChar = true;
            // 
            // txtTaiKhoan
            // 
            txtTaiKhoan.Location = new Point(145, 53);
            txtTaiKhoan.Name = "txtTaiKhoan";
            txtTaiKhoan.Size = new Size(242, 25);
            txtTaiKhoan.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label3.ForeColor = SystemColors.MenuHighlight;
            label3.Location = new Point(23, 97);
            label3.Name = "label3";
            label3.Size = new Size(96, 25);
            label3.TabIndex = 2;
            label3.Text = "Mật khẩu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label2.ForeColor = SystemColors.MenuHighlight;
            label2.Location = new Point(23, 53);
            label2.Name = "label2";
            label2.Size = new Size(97, 25);
            label2.TabIndex = 1;
            label2.Text = "Tài khoản";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(775, 393);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Đăng nhập";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private TextBox txtMatKhau;
        private TextBox txtTaiKhoan;
        private Label label3;
        private Label label2;
        private Button btnThoat;
        private Button btndangnhap;
    }
}
