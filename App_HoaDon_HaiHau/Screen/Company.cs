using DocumentFormat.OpenXml.VariantTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_HoaDon_HaiHau.Screen
{
    public partial class ucCompany : UserControl
    {
        //private static ucCompany _instance;
        //public static ucCompany Instance
        //{
        //    get
        //    {
        //        if (_instance == null)
        //            _instance = new ucCompany();
        //        return _instance;
        //    }
        //}

        private readonly DbContextSql _context;


        public ucCompany(DbContextSql context)
        {
            _context = context;
            InitializeComponent();
            loadData();
        }

        private void loadData()
        {
            dataGridDsCongTy.DataSource = null;
            dataGridDsCongTy.DataSource = _context.CongTy.ToList();
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            _context.CongTy.Add(new Model.Entities.CongTy
            {
                DiaChi = txtDiaChi.Text,
                TenCongTy = txtTenCongTy.Text,
            });
            var boolSave = _context.SaveChanges();
            if (boolSave > 0)
            {
                MessageBox.Show("Lưu Thành Công");              
                loadData();
            }
            else
                MessageBox.Show("Lưu Thất Bại");
        }

    }
}
