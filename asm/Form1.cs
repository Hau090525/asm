namespace asm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btndangnhap_Click(object sender, EventArgs e)
        {

            if (txtTaiKhoan.Text == "hau" && txtMatKhau.Text == "090525")
            {
                Quanlithuvien quanlithuvien = new Quanlithuvien();
                quanlithuvien.Show();
            }

            else
                MessageBox.Show("Đăng nhập không thành công yêu cầu thử lại!");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
    

