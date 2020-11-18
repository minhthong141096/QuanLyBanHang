using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormQuanLyBanHang
{
    class KhachHang
    {
        public string MaKH { get; set; }
        public string TenKH { get; set; }
        public string DiaChi { get; set; }
        public string SoDienThoai { get; set; }
        public bool GioiTinh { get; set; }
        public DateTime NgaySinh { get; set; }
        public static List<KhachHang> DanhSachKhachHang;
        public KhachHang(string maKH, string tenKH, string diaChi, string soDienThoai, bool gioiTinh, DateTime ngaySinh)
        {
            MaKH = maKH;
            TenKH = tenKH;
            DiaChi = diaChi;
            SoDienThoai = soDienThoai;
            GioiTinh = gioiTinh;
            NgaySinh = ngaySinh;
        }

        public KhachHang()
        {
        }
        public static List<KhachHang> GetDanhSachKhachHang()
        {
            if (DanhSachKhachHang == null)
                return new List<KhachHang>();
            return DanhSachKhachHang;
        }
        public String KhachHang2String()
        {
            return String.Format(@"{0},{1},{2},{3},{4},{5}", MaKH, TenKH, NgaySinh, GioiTinh, SoDienThoai, DiaChi);
        }
        public static void Them(KhachHang kh)
        {
            if (DanhSachKhachHang == null)
                DanhSachKhachHang = new List<KhachHang>();
            DanhSachKhachHang.Add(kh);
        }
    }

}
