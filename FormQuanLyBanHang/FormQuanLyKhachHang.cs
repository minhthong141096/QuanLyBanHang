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
    public partial class FormQuanLyKhachHang : Form
    {
        public FormQuanLyKhachHang()
        {
            InitializeComponent();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            try
            {
                KhachHang kh = GetInputKhachHang();
                KhachHang.Them(kh);
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Lỗi Hệ Thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private KhachHang GetInputKhachHang()
        {
           if(txtmakh.Text=="")
            {
                throw new Exception("Bạn Chưa nhập mã khách hàng");
            }
            if (txttenkh.Text == "")
            {
                throw new Exception("Bạn Chưa nhập tên khách hàng");
            }
            if (txtsodienthoai.Text == "")
            {
                throw new Exception("Bạn Chưa nhập số điện thoại");
            }
            if (txtdiachi.Text == "")
            {
                throw new Exception("Bạn Chưa nhập địa chỉ");
            }
            GioiTinh gt = (GioiTinh)
                cbbgioitinh.SelectedItem;
            return new KhachHang(txtmakh.Text, txttenkh.Text, txtdiachi.Text, txtsodienthoai.Text, gt.Id, dtpngaysinh.Value);
        }

        private void FormQuanLyKhachHang_Load(object sender, EventArgs e)
        {
            List<GioiTinh> lgt = GioiTinh.Get();
            cbbgioitinh.DataSource = lgt;
            cbbgioitinh.DisplayMember = "Name";
            cbbgioitinh.ValueMember = "Id";
            cbbgioitinh.SelectedIndex = 0;
        }

     

        private void FormQuanLyKhachHang_FormClosed(object sender, FormClosedEventArgs e)
        {
            var isOk = MessageBox.Show("Bạn có muốn thoát?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if(isOk == DialogResult.Cancel)
            {
                Close();
            }
        }
        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
