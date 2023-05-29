using App_HoaDon_HaiHau.Model;
using DocumentFormat.OpenXml.EMMA;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Spreadsheet;
using Microsoft.VisualBasic.Devices;
using System.Data;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using System.IO.Pipes;
using ClosedXML.Excel;
using static System.Net.WebRequestMethods;
using System;
using System.Text.RegularExpressions;
using System.Diagnostics;
using DocumentFormat.OpenXml.ExtendedProperties;
using App_HoaDon_HaiHau.Screen;

namespace App_HoaDon_HaiHau
{
    public partial class Form1 : Form
    {
        private ucCompany _ucCompany;
        private ucTaxXML _ucTaxXML;
        private ucHoaDonGTGT _ucHoaDonGTGT;
        public Form1(ucCompany ucCompany, ucTaxXML ucTaxXML, ucHoaDonGTGT ucHoaDonGTGT)
        {
            InitializeComponent();
            _ucCompany = ucCompany;
            _ucTaxXML = ucTaxXML;
            _ucHoaDonGTGT = ucHoaDonGTGT;   
        }

        private void btnDsCongTy_Click(object sender, EventArgs e)
        {
            if (!panelUser.Controls.Contains(_ucCompany))
            {
                panelUser.Controls.Add(_ucCompany);
                _ucCompany.Dock = DockStyle.Fill;
                _ucCompany.BringToFront();
            }
            else
                _ucCompany.BringToFront();
        }
        
        private void btnXuatHoaDon_Click(object sender, EventArgs e)
        {

            if (!panelUser.Controls.Contains(_ucTaxXML))
            {
                panelUser.Controls.Add(_ucTaxXML);
                _ucTaxXML.Dock = DockStyle.Fill;
                _ucTaxXML.BringToFront();
            }
            else
                _ucTaxXML.BringToFront();
        }

        private void btnHoadon_Click(object sender, EventArgs e)
        {

            if (!panelUser.Controls.Contains(_ucHoaDonGTGT))
            {
                panelUser.Controls.Add(_ucHoaDonGTGT);
                _ucHoaDonGTGT.Dock = DockStyle.Fill;
                _ucHoaDonGTGT.BringToFront();
            }
            else
                _ucHoaDonGTGT.BringToFront();
        }
    }
}