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

namespace App_HoaDon_HaiHau
{
    public partial class Form1 : Form
    {
        FolderBrowserDialog fbd;
        List<ExcelModel> _dataSource;
        List<ExcelModel> _dataGroup;
        public Form1()
        {
            InitializeComponent();
            _dataSource = new List<ExcelModel>();
            _dataGroup = new List<ExcelModel>();
            fbd = new FolderBrowserDialog();
        }

        private void btnNhapFile_Click(object sender, EventArgs e)
        {
            try
            {

                if (fbd.ShowDialog() == DialogResult.OK)
                {

                    string selectedPath = fbd.SelectedPath;
                    string[] filePaths = Directory.GetFiles(selectedPath).Where(x => x.IndexOf(".xml") >= 0).ToArray();

                    foreach (string filePath in filePaths)
                    {
                        string path = System.IO.Path.GetFullPath(filePath);

                        var data = loadXMLData(path);

                        loadDataToGrid(data);
                    }
                    dataGrid.AutoGenerateColumns = true;
                    foreach (DataGridViewColumn column in dataGrid.Columns)
                    {
                        column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    }
                    dataGrid.AutoResizeColumns();

                    sumData();

                    MessageBox.Show("Load Data Successfully.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            //OpenFileDialog fdlg = new OpenFileDialog();
            //fdlg.InitialDirectory = "C://Desktop";
            ////Your opendialog box title name.
            //fdlg.Title = "Select file to be upload.";
            ////which type file format you want to upload in database. just add them.
            //fdlg.Filter = "Select Valid Document(*.xml)|*.xml";
            ////FilterIndex property represents the index of the filter currently selected in the file dialog box.
            //fdlg.FilterIndex = 1;
            //try
            //{
            //    if (fdlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            //    {
            //        if (fdlg.CheckFileExists)
            //        {
            //            string path = System.IO.Path.GetFullPath(fdlg.FileName);

            //            var data = loadXMLData(path);

            //            loadDataToGrid(data);
            //        }
            //    }
            //    else
            //    {
            //        MessageBox.Show("Please Upload document.");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}

        }

        private void btnXuatFile_Click(object sender, EventArgs e)
        {

            var fileName = $"{DateTime.Now.ToString("ddMMyyyy")}_hoadon_{Random.Shared.Next()}.xlsx";

            SaveFileDialog saveFileDialog = new SaveFileDialog();

            // Set the default file name and extension
            saveFileDialog.FileName = fileName;
            saveFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx";
            // Display the dialog box to the user
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Get the selected file name and location
                string filePath = saveFileDialog.FileName;

                try
                {
                    using (var workbook = new XLWorkbook())
                    {
                        var worksheet = workbook.Worksheets.Add("Hóa Đơn");

                        var headerStyle = workbook.Style;
                        headerStyle.Font.Bold = true;

                        // Add data to the worksheet
                        worksheet.Cell("A1").Value = "STT";
                        worksheet.Cell("B1").Value = "MauSo";
                        worksheet.Cell("C1").Value = "KyHieu";
                        worksheet.Cell("D1").Value = "SoHoaDon";
                        worksheet.Cell("E1").Value = "NgayThangNamHD";
                        worksheet.Cell("F1").Value = "DonViBan";
                        worksheet.Cell("G1").Value = "DiaChi";
                        worksheet.Cell("H1").Value = "MaSoThue";
                        worksheet.Cell("I1").Value = "TenHangHoaDichVu";
                        worksheet.Cell("J1").Value = "SoLuong";
                        worksheet.Cell("K1").Value = "DonGia";
                        worksheet.Cell("L1").Value = "ThanhTien";
                        worksheet.Cell("M1").Value = "ThueSuat";
                        worksheet.Cell("N1").Value = "TienThueGTGT";
                        worksheet.Cell("O1").Value = "TongTienThanhToan";
                        worksheet.Cell("P1").Value = "HinhThucTT";
                        worksheet.Cell("Q1").Value = "MTC";
                        worksheet.Cell("R1").Value = "TrangThaiHoaDon";
                        worksheet.Cell("S1").Value = "GhiChu";
                        // Apply the header style to the header row
                        worksheet.Range("A1:S1").Style.Font.SetBold(true);
                        worksheet.Range("B1:E1").Style.Fill.SetBackgroundColor(XLColor.AliceBlue);
                        worksheet.Range("G1:H1").Style.Fill.SetBackgroundColor(XLColor.AliceBlue);
                        worksheet.Range("P1:R1").Style.Fill.SetBackgroundColor(XLColor.AliceBlue);
                        worksheet.Range("I1:O1").Style.Fill.SetBackgroundColor(XLColor.YellowProcess);
                        // Apply the border to the range A1:C3
                        var range = worksheet.Range("A1:S1");
                        range.Style
                            .Border.SetTopBorder(XLBorderStyleValues.Thick)
                            .Border.SetRightBorder(XLBorderStyleValues.Thick)
                            .Border.SetLeftBorder(XLBorderStyleValues.Thick)
                            .Border.SetBottomBorder(XLBorderStyleValues.Thick);

                        worksheet.Cell("A2").InsertData(_dataSource);
                        var format = "#,##";
                        worksheet.Column($"K").Style.NumberFormat.Format = format;
                        worksheet.Column($"L").Style.NumberFormat.Format = format;
                        worksheet.Column($"N").Style.NumberFormat.Format = format;
                        worksheet.Column($"O").Style.NumberFormat.Format = format;

                        worksheet.Column($"E").Style.NumberFormat.Format = "dd-mm-yyyy";



                        var rangeData = worksheet.Range($"A2:S{_dataSource.Count + 1}");

                        rangeData.Style
                            .Border.OutsideBorder = (XLBorderStyleValues.Thick);
                        worksheet.Columns().AdjustToContents();

                        //calculator total
                        worksheet.Cell($"L{_dataSource.Count + 3}").FormulaA1 = $"=Sum(L2:L{_dataSource.Count + 1})";
                        worksheet.Cell($"N{_dataSource.Count + 3}").FormulaA1 = $"=Sum(N2:N{_dataSource.Count + 1})";
                        worksheet.Cell($"O{_dataSource.Count + 3}").FormulaA1 = $"=Sum(O2:O{_dataSource.Count + 1})";

                        // add sheet ToTal
                        var worksheetTotal = workbook.Worksheets.Add("Nhóm Hóa Đơn");
                        worksheetTotal.Clear();

                        worksheetTotal.Cell("A1").Value = "STT";
                        worksheetTotal.Cell("B1").Value = "MauSo";
                        worksheetTotal.Cell("C1").Value = "KyHieu";
                        worksheetTotal.Cell("D1").Value = "SoHoaDon";
                        worksheetTotal.Cell("E1").Value = "NgayThangNamHD";
                        worksheetTotal.Cell("F1").Value = "DonViBan";
                        worksheetTotal.Cell("G1").Value = "DiaChi";
                        worksheetTotal.Cell("H1").Value = "MaSoThue";
                        worksheetTotal.Cell("I1").Value = "TenHangHoaDichVu";
                        worksheetTotal.Cell("J1").Value = "SoLuong";
                        worksheetTotal.Cell("K1").Value = "DonGia";
                        worksheetTotal.Cell("L1").Value = "ThanhTien";
                        worksheetTotal.Cell("M1").Value = "ThueSuat";
                        worksheetTotal.Cell("N1").Value = "TienThueGTGT";
                        worksheetTotal.Cell("O1").Value = "TongTienThanhToan";
                        worksheetTotal.Cell("P1").Value = "HinhThucTT";
                        worksheetTotal.Cell("Q1").Value = "MTC";
                        worksheetTotal.Cell("R1").Value = "TrangThaiHoaDon";
                        worksheetTotal.Cell("S1").Value = "GhiChu";

                        worksheetTotal.Range("I1:O1").Style.Fill.SetBackgroundColor(XLColor.YellowProcess);

                        worksheetTotal.Cell("A2").InsertData(_dataGroup);

                        worksheetTotal.Column($"K").Style.NumberFormat.Format = format;
                        worksheetTotal.Column($"L").Style.NumberFormat.Format = format;
                        worksheetTotal.Column($"N").Style.NumberFormat.Format = format;
                        worksheetTotal.Column($"O").Style.NumberFormat.Format = format;

                        worksheetTotal.Column($"E").Style.NumberFormat.Format = "dd-mm-yyyy";
                        worksheetTotal.Columns().AdjustToContents();

                        workbook.SaveAs(filePath);
                    }

                    DialogResult result = MessageBox.Show("Đã xuất dữ liệu thành công.\n Bạn có muốn giữ lại dữ liệu cũ không?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        // User clicked on Yes button
                        // Perform the desired action

                    }
                    else
                    {
                        // User clicked on No button or closed the dialog
                        // Do nothing or perform a different action
                        initDataGrid();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Tên File Bị Trùng");
                }

            }
        }

        private HDon loadXMLData(string path)
        {
            // Read the XML data from a file
            var fileName = path;

            HDon data = new HDon();

            using (var fileStream = new FileStream(fileName, FileMode.Open))
            {

                XmlDocument doc = new XmlDocument();
                doc.Load(fileStream);
                // Access the root element of the XML document
                XmlNode root = doc.DocumentElement;

                XmlNode dataRaw = null;
                XmlNode rawDSCKS = null;
                if (root.Name == "HDon") // Viettel, Misa, Bkav, Vnpt, Viettel
                {
                    dataRaw = root;
                }
                else if (root.Name == "TDiep") // only for template FPT, Vina
                {
                    var rootHDon = root.ChildNodes.Cast<XmlNode>().Last().ChildNodes.Cast<XmlNode>().Last();
                    dataRaw = rootHDon;
                }

                XmlSerializer serializerModel;

                serializerModel = new XmlSerializer(typeof(HDon));
                if (dataRaw != null)
                {
                    using (var reader = new StringReader(dataRaw.OuterXml))
                    {
                        data = (HDon)serializerModel.Deserialize(reader);


                        var anyDSCKS = dataRaw.OuterXml.IndexOf("</Signature>") >= 0 
                            && dataRaw.OuterXml.IndexOf("</SignedInfo>") >= 0 
                            && dataRaw.OuterXml.IndexOf("</SignatureValue>") >= 0
                            && dataRaw.OuterXml.IndexOf("</X509Certificate>") >= 0;

                        if (anyDSCKS)
                        {
                            data.DSCKS = new DSCKS();
                            data.DSCKS.CQT = new CQT();
                            data.DSCKS.CQT.Signature = new Signature();
                        }
                    }
                }


                // Close the file stream
                fileStream.Close();

                return data;
            }
        }

        private void initDataGrid()
        {
            dataGrid.DataSource = null;
            dataGridTotal.DataSource = null;
            _dataSource = new List<ExcelModel>();
            _dataGroup = new List<ExcelModel>();

            lblTongThanhTien.Text = "";
            lblTongTienThue.Text = "";
            lblTongTienThanhToan.Text = "";
        }

        private void loadDataToGrid(HDon data)
        {
            //// Add tables to the DataSet
            //DataTable table1 = new DataTable("Table1");
            //table1.Columns.Add("Id", typeof(int));
            //table1.Columns.Add("Name", typeof(string));
            //table1.Rows.Add(1, "John");
            //table1.Rows.Add(2, "Mary");
            //dataSet.Tables.Add(table1);
            mappingModelExcel(data);


            dataGrid.DataSource = null;
            dataGrid.DataSource = _dataSource;
            dataGridTotal.DataSource = null;
            dataGridTotal.DataSource = _dataGroup;

            foreach (DataGridViewTextBoxColumn item in dataGrid.Columns)
            {
                switch (item.DataPropertyName)
                {
                    case "DonGia":
                        item.DefaultCellStyle.Format = "#,##";
                        break;
                    case "ThanhTien":
                        item.DefaultCellStyle.Format = "#,##";
                        break;
                    case "TienThueGTGT":
                        item.DefaultCellStyle.Format = "#,##";
                        break;
                    case "TongTienThanhToan":
                        item.DefaultCellStyle.Format = "#,##";
                        break;
                    default:
                        break;
                }
            }

            foreach (DataGridViewTextBoxColumn item in dataGridTotal.Columns)
            {
                switch (item.DataPropertyName)
                {
                    case "DonGia":
                        item.DefaultCellStyle.Format = "#,##";
                        break;
                    case "ThanhTien":
                        item.DefaultCellStyle.Format = "#,##";
                        break;
                    case "TienThueGTGT":
                        item.DefaultCellStyle.Format = "#,##";
                        break;
                    case "TongTienThanhToan":
                        item.DefaultCellStyle.Format = "#,##";
                        break;
                    default:
                        break;
                }
            }
        }

        private void btnNewData_Click(object sender, EventArgs e)
        {
            initDataGrid();
        }

        private void sumData()
        {
            lblTongThanhTien.Text = _dataSource.Sum(x => x.ThanhTien).ToString("#,##");
            lblTongTienThue.Text = _dataSource.Sum(x => x.TienThueGTGT).ToString("#,##");
            lblTongTienThanhToan.Text = _dataSource.Sum(x => x.TongTienThanhToan).ToString("#,##");
        }

        private void mappingModelExcel(HDon HDon)
        {
            int index = 1;
            if (dataGrid.RowCount > 0)
            {
                index = dataGrid.RowCount + 1;
            }
            DLHDon data = HDon.DLHDon;
            DSCKS dSCKS = HDon.DSCKS;

            var dataSource = new List<ExcelModel>();
            if (data != null && data.NDHDon != null)
            {
                var MauSo = data.TTChung.KHMSHDon;
                var KyHieu = data.TTChung.KHHDon;
                var SHDon = data.TTChung.SHDon;
                string NLap = "";

                if (DateTime.TryParse(data.TTChung.NLap, out var dateTime))
                {
                    // The string was successfully parsed to a DateTime object
                    NLap = dateTime.ToString("dd/MM/yyyy");
                }
                else
                {
                    // The string could not be parsed to a DateTime object
                    Console.WriteLine("Invalid date string");
                }

                var HTTToan = data.TTChung.HTTToan;

                var DonViBan = data.NDHDon.NBan.Ten;
                var DChi = Regex.Replace(data.NDHDon.NBan.DChi.Replace("\n", " ").Replace("\t", " ").Trim(), "\\s+", " ");
                var MST = data.NDHDon.NBan.MST;

                string daPhatHanh = "ĐPH - Đã phát hành";
                string chuaPhatHanh = "CPH - Chưa phát hành";
                var TrangThaiHoaDon = dSCKS.CQT != null && dSCKS.CQT.Signature != null ? daPhatHanh : chuaPhatHanh;


                foreach (var item in data.NDHDon.DSHHDVu.HHDVu)
                {
                    string percentString = item.TSuat;
                    decimal percent = 0
                        , TienThueGTGT = 0
                        ;
                    try
                    {
                        if (percentString.Trim() == "KCT")
                        {
                            percent = 0;
                            TienThueGTGT = 0;
                        }
                        else
                        {
                            percent = decimal.Parse(percentString.TrimEnd('%'), NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands) / 100;
                            TienThueGTGT = Math.Round(item.ThTien * percent, 1);
                        }
                    }
                    catch
                    {
                    }




                    int.TryParse(item.SLuong, out int SLuong);


                    dataSource.Add(new ExcelModel
                    {
                        STT = index,
                        MauSo = MauSo,
                        KyHieu = KyHieu,
                        SoHoaDon = SHDon,
                        NgayThangNamHD = NLap,
                        DonViBan = DonViBan,
                        DiaChi = DChi,
                        MaSoThue = MST,
                        TenHangHoaDichVu = item.THHDVu,
                        SoLuong = SLuong,
                        DonGia = item.DGia,
                        ThanhTien = item.ThTien,
                        ThueSuat = item.TSuat,
                        TienThueGTGT = TienThueGTGT,
                        TongTienThanhToan = item.ThTien + TienThueGTGT,
                        HinhThucTT = HTTToan,
                        //MTC = item.mt
                        TrangThaiHoaDon = TrangThaiHoaDon,
                        //GhiChu = item.ghi
                    });
                    index++;
                }
            }
            _dataSource.AddRange(dataSource);

            var results =
                dataSource
                .GroupBy(n => new { n.MauSo, n.KyHieu, n.DonViBan, n.SoHoaDon, n.NgayThangNamHD, n.DiaChi, n.MaSoThue })
                .Select(r => new ExcelModel
                {
                    MauSo = r.Key.MauSo,
                    KyHieu = r.Key.KyHieu,
                    SoHoaDon = r.Key.SoHoaDon,
                    DonViBan = r.Key.DonViBan,
                    NgayThangNamHD = r.Key.NgayThangNamHD,
                    DiaChi = r.Key.DiaChi,
                    MaSoThue = r.Key.MaSoThue,
                    ThanhTien = r.Sum(x => x.ThanhTien),
                    ThueSuat = r.FirstOrDefault()?.ThueSuat,
                    HinhThucTT = r.FirstOrDefault()?.HinhThucTT,
                    TrangThaiHoaDon = r.FirstOrDefault()?.TrangThaiHoaDon,
                    TienThueGTGT = r.Sum(x => x.TienThueGTGT),
                    TongTienThanhToan = r.Sum(x => x.TongTienThanhToan),
                })
                .ToList();

            _dataGroup.AddRange(results);
        }
    }
}