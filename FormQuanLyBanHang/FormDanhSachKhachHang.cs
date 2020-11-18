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
    public partial class FormDanhSachKhachHang : Form
    {
        public FormDanhSachKhachHang()
        {
            InitializeComponent();
        }

        private void dgvdanhsachkhachhang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormDanhSachKhachHang_Load(object sender, EventArgs e)
        {
            resetdanhsachkhachhang();
        }

        private void resetdanhsachkhachhang()
        {
            KhachHang kh = new KhachHang();
            if (KhachHang.DanhSachKhachHang != null)
                dgvdanhsachkhachhang.DataSource = KhachHang.DanhSachKhachHang.ToList();
        }
    }
}
