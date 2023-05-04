using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_HoaDon_HaiHau.Model
{
    public class ExcelModel
    {

        public int STT { get; set; }
        public int MauSo { get; set; }
        public string KyHieu { get; set; }
        public string SoHoaDon { get; set; }
        public string NgayThangNamHD { get; set; }
        public string DonViBan { get; set; }
        public string DiaChi { get; set; }
        public string MaSoThue { get; set; }
        public string TenHangHoaDichVu { get; set; }
        public int SoLuong { get; set; }
        public decimal DonGia { get; set; }
        public decimal ThanhTien { get; set; }
        public string ThueSuat { get; set; }
        public decimal TienThueGTGT { get; set; }
        public decimal TongTienThanhToan { get; set; }
        public string HinhThucTT { get; set; }
        public string MTC { get; set; } = "";
        public string TrangThaiHoaDon { get; set; }
        public string GhiChu { get; set; } = "";
    }


}
