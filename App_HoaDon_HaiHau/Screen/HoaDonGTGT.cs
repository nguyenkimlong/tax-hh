using App_HoaDon_HaiHau.Model;
using App_HoaDon_HaiHau.Model.Entities;
using DocumentFormat.OpenXml.VariantTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_HoaDon_HaiHau.Screen
{
    public partial class ucHoaDonGTGT : UserControl
    {
        private readonly DbContextSql _context;
        OpenFileDialog openFileDialog1;
        public ucHoaDonGTGT(DbContextSql context)
        {
            InitializeComponent();
            openFileDialog1 = new OpenFileDialog();
            _context = context;
        }

        private void btnImportDuLieu_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var fileName = openFileDialog1.FileName;

                    var excelData = ExcelUtility.ExcelDataToDataTable(fileName, "Hóa đơn WEB");
                    dataGrid.DataSource = excelData;

                  
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var dataSource = dataGrid.DataSource;
            if (dataSource != null) {
                DataTable excelData = (DataTable)dataSource;
                var data = (from DataRow dr in excelData.Rows
                            select new HoaDon
                            {
                                MauSo = Convert.ToInt32(dr["MauSo"]),
                                KyHieu = dr["KyHieu"].ToString(),
                                SoHoaDon = dr["SoHoaDon"].ToString(),
                                NgayThangNamHD = dr["NgayThangNamHD"].ToString(),
                                TenDonVi = dr["TenDonVi"].ToString(),
                                DiaChi = dr["DiaChi"].ToString(),
                                MaSoThue = dr["MaSoThue"].ToString(),
                                TenHangHoaDichVu = dr["TenHangHoaDichVu"].ToString(),
                                SoLuong = Convert.ToInt32(dr["SoLuong"].ToString() == "" ? 0 : dr["SoLuong"].ToString()),
                                DonGia = Convert.ToDecimal(dr["DonGia"].ToString()),
                                ThanhTien = Convert.ToDecimal(dr["ThanhTien"].ToString()),
                                ThueSuat = dr["ThueSuat"].ToString(),
                                TienThueGTGT = Convert.ToDecimal(dr["TienThueGTGT"].ToString()),
                                TongTienThanhToan = Convert.ToDecimal(dr["TongTienThanhToan"].ToString()),
                                HinhThucTT = dr["HinhThucTT"].ToString(),
                                MTC = dr["MTC"].ToString(),
                                GhiChu = dr["GhiChu"].ToString(),
                            }).ToList();

                _context.HoaDon.AddRange(data);

                _context.SaveChanges();
            }
        }
    }
}
