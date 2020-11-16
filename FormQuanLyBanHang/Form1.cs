using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormQuanLyBanHang
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        public bool Checkbutton()
        {
            if (txtdangnhap.Text == "")
            {
                MessageBox.Show("Bạn chưa đăng nhập tên đăng nhập", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtdangnhap.Focus();
                return false;
            }
            if (txtmatkhau.Text == "")
            {
                MessageBox.Show("Bạn chưa đăng nhập mật khẩu", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtmatkhau.Focus();
                return false;
            }
            return true;
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btndangnhap_Click(object sender, EventArgs e)
        {
            if (Checkbutton())
            {
                if (txtdangnhap.Text == "admin" && txtmatkhau.Text == "123456")
                {
                    this.Hide();
                }
                else
                    lblthongbao.Visible = true;
                    lblthongbao.Text = ("Bạn nhập sai tên hoặc mật khẩu");
            }
        }
    }
}
