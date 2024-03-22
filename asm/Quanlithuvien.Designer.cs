namespace asm
{
    partial class Quanlithuvien
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
            menuStrip1 = new MenuStrip();
            quảnLíToolStripMenuItem = new ToolStripMenuItem();
            quảnLíTàiKhoảnToolStripMenuItem = new ToolStripMenuItem();
            quảnLíĐộcGiảToolStripMenuItem = new ToolStripMenuItem();
            quảnLíMượnTrảToolStripMenuItem = new ToolStripMenuItem();
            báoCáoThốngKêToolStripMenuItem = new ToolStripMenuItem();
            plQLS = new Panel();
            groupBox2 = new GroupBox();
            btnTimKiem = new Button();
            txtTimKiem = new TextBox();
            groupBox1 = new GroupBox();
            btnLamMoi = new Button();
            btnXoa = new Button();
            btncatnhat = new Button();
            btnThem = new Button();
            grbThongtin = new GroupBox();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            txtTacGia = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            label7 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtMaSach = new TextBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            menuStrip1.SuspendLayout();
            plQLS.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            grbThongtin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            menuStrip1.Items.AddRange(new ToolStripItem[] { quảnLíToolStripMenuItem, quảnLíTàiKhoảnToolStripMenuItem, quảnLíĐộcGiảToolStripMenuItem, quảnLíMượnTrảToolStripMenuItem, báoCáoThốngKêToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(748, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // quảnLíToolStripMenuItem
            // 
            quảnLíToolStripMenuItem.Name = "quảnLíToolStripMenuItem";
            quảnLíToolStripMenuItem.Size = new Size(105, 24);
            quảnLíToolStripMenuItem.Text = "Quản lí sách";
            quảnLíToolStripMenuItem.Click += quảnLíToolStripMenuItem_Click;
            // 
            // quảnLíTàiKhoảnToolStripMenuItem
            // 
            quảnLíTàiKhoảnToolStripMenuItem.Name = "quảnLíTàiKhoảnToolStripMenuItem";
            quảnLíTàiKhoảnToolStripMenuItem.Size = new Size(139, 24);
            quảnLíTàiKhoảnToolStripMenuItem.Text = "Quản lí tài khoản";
            // 
            // quảnLíĐộcGiảToolStripMenuItem
            // 
            quảnLíĐộcGiảToolStripMenuItem.Name = "quảnLíĐộcGiảToolStripMenuItem";
            quảnLíĐộcGiảToolStripMenuItem.Size = new Size(124, 24);
            quảnLíĐộcGiảToolStripMenuItem.Text = "Quản lí độc giả";
            quảnLíĐộcGiảToolStripMenuItem.Click += qunarLíĐộcGiảToolStripMenuItem_Click;
            // 
            // quảnLíMượnTrảToolStripMenuItem
            // 
            quảnLíMượnTrảToolStripMenuItem.Name = "quảnLíMượnTrảToolStripMenuItem";
            quảnLíMượnTrảToolStripMenuItem.Size = new Size(140, 24);
            quảnLíMượnTrảToolStripMenuItem.Text = "Quản lí mượn trả";
            // 
            // báoCáoThốngKêToolStripMenuItem
            // 
            báoCáoThốngKêToolStripMenuItem.Name = "báoCáoThốngKêToolStripMenuItem";
            báoCáoThốngKêToolStripMenuItem.Size = new Size(142, 24);
            báoCáoThốngKêToolStripMenuItem.Text = "Báo cáo thống kê";
            // 
            // plQLS
            // 
            plQLS.Controls.Add(dataGridView1);
            plQLS.Controls.Add(groupBox2);
            plQLS.Controls.Add(groupBox1);
            plQLS.Controls.Add(grbThongtin);
            plQLS.Location = new Point(10, 40);
            plQLS.Name = "plQLS";
            plQLS.Size = new Size(726, 405);
            plQLS.TabIndex = 10;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnTimKiem);
            groupBox2.Controls.Add(txtTimKiem);
            groupBox2.Location = new Point(451, 350);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(275, 43);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tìm kiếm";
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(185, 14);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(75, 23);
            btnTimKiem.TabIndex = 4;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(6, 14);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(163, 23);
            txtTimKiem.TabIndex = 12;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnLamMoi);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btncatnhat);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Location = new Point(3, 350);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(437, 43);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Công cụ";
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(356, 13);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(75, 23);
            btnLamMoi.TabIndex = 3;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(242, 14);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(75, 23);
            btnXoa.TabIndex = 2;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btncatnhat
            // 
            btncatnhat.Location = new Point(120, 13);
            btncatnhat.Name = "btncatnhat";
            btncatnhat.Size = new Size(75, 23);
            btncatnhat.TabIndex = 1;
            btncatnhat.Text = "Cật nhật";
            btncatnhat.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(16, 13);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(75, 23);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // grbThongtin
            // 
            grbThongtin.AutoSize = true;
            grbThongtin.Controls.Add(textBox6);
            grbThongtin.Controls.Add(textBox5);
            grbThongtin.Controls.Add(txtTacGia);
            grbThongtin.Controls.Add(textBox3);
            grbThongtin.Controls.Add(textBox2);
            grbThongtin.Controls.Add(label7);
            grbThongtin.Controls.Add(label5);
            grbThongtin.Controls.Add(label4);
            grbThongtin.Controls.Add(label3);
            grbThongtin.Controls.Add(label2);
            grbThongtin.Controls.Add(txtMaSach);
            grbThongtin.Controls.Add(label1);
            grbThongtin.Location = new Point(0, 3);
            grbThongtin.Name = "grbThongtin";
            grbThongtin.Size = new Size(721, 112);
            grbThongtin.TabIndex = 10;
            grbThongtin.TabStop = false;
            grbThongtin.Text = "Thông tin sách";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(542, 28);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 23);
            textBox6.TabIndex = 11;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(542, 67);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 10;
            // 
            // txtTacGia
            // 
            txtTacGia.Location = new Point(120, 67);
            txtTacGia.Name = "txtTacGia";
            txtTacGia.Size = new Size(100, 23);
            txtTacGia.TabIndex = 9;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(339, 67);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 8;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(339, 26);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(467, 75);
            label7.Name = "label7";
            label7.Size = new Size(30, 15);
            label7.TabIndex = 6;
            label7.Text = "NXB";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(467, 34);
            label5.Name = "label5";
            label5.Size = new Size(48, 15);
            label5.TabIndex = 5;
            label5.Text = "Thể loại";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(60, 75);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 4;
            label4.Text = "Tác giả";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(252, 75);
            label3.Name = "label3";
            label3.Size = new Size(82, 15);
            label3.TabIndex = 3;
            label3.Text = "Năm xuất bản";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(252, 34);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 2;
            label2.Text = "Tên sách";
            // 
            // txtMaSach
            // 
            txtMaSach.Location = new Point(120, 26);
            txtMaSach.Name = "txtMaSach";
            txtMaSach.Size = new Size(100, 23);
            txtMaSach.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(60, 34);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Mã sách";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 121);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(726, 223);
            dataGridView1.TabIndex = 14;
            // 
            // Quanlithuvien
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(748, 480);
            Controls.Add(plQLS);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Quanlithuvien";
            Text = "Quanlithuvien";
            Load += Quanlithuvien_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            plQLS.ResumeLayout(false);
            plQLS.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            grbThongtin.ResumeLayout(false);
            grbThongtin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem quảnLíToolStripMenuItem;
        private ToolStripMenuItem quảnLíTàiKhoảnToolStripMenuItem;
        private ToolStripMenuItem quảnLíĐộcGiảToolStripMenuItem;
        private ToolStripMenuItem quảnLíMượnTrảToolStripMenuItem;
        private ToolStripMenuItem báoCáoThốngKêToolStripMenuItem;
        private Panel plQLS;
        private GroupBox groupBox2;
        private Button btnTimKiem;
        private TextBox txtTimKiem;
        private GroupBox groupBox1;
        private Button btnLamMoi;
        private Button btnXoa;
        private Button btncatnhat;
        private Button btnThem;
        private GroupBox grbThongtin;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox txtTacGia;
        private TextBox textBox3;
        private TextBox textBox2;
        private Label label7;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtMaSach;
        private Label label1;
        private DataGridView dataGridView1;
    }
}