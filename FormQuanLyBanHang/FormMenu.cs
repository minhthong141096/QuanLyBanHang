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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            Form flogin = new FormLogin();
            flogin.ShowDialog();
        }

        private void quảnLýKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fThem = new FormQuanLyKhachHang();
            fThem.MdiParent = this;
            fThem.Show();

        }

        private void danhSáchKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fThem = new FormDanhSachKhachHang();
            fThem.MdiParent = this;
            fThem.Show();
        }
    }
}
