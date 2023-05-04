using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace App_HoaDon_HaiHau.Model
{

    [XmlRoot(ElementName = "TTChung")]
    public class TTChung
    {

        [XmlElement(ElementName = "PBan")]
        public string PBan { get; set; }

        [XmlElement(ElementName = "MNGui")]
        public string MNGui { get; set; }

        [XmlElement(ElementName = "MNNhan")]
        public string MNNhan { get; set; }

        [XmlElement(ElementName = "MLTDiep")]
        public int MLTDiep { get; set; }

        [XmlElement(ElementName = "MTDiep")]
        public string MTDiep { get; set; }

        [XmlElement(ElementName = "MTDTChieu")]
        public string MTDTChieu { get; set; }

        [XmlElement(ElementName = "MST")]
        public string MST { get; set; }

        [XmlElement(ElementName = "SLuong")]
        public int SLuong { get; set; }

        [XmlElement(ElementName = "THDon")]
        public string THDon { get; set; }

        [XmlElement(ElementName = "KHMSHDon")]
        public int KHMSHDon { get; set; }

        [XmlElement(ElementName = "KHHDon")]
        public string KHHDon { get; set; }

        [XmlElement(ElementName = "SHDon")]
        public string SHDon { get; set; }

        [XmlElement(ElementName = "NLap")]
        public string NLap { get; set; }

        [XmlElement(ElementName = "DVTTe")]
        public string DVTTe { get; set; }

        [XmlElement(ElementName = "TGia")]
        public string TGia { get; set; }

        [XmlElement(ElementName = "HTTToan")]
        public string HTTToan { get; set; }

        [XmlElement(ElementName = "MSTTCGP")]
        public string MSTTCGP { get; set; }

        [XmlElement(ElementName = "MSTDVNUNLHDon")]
        public string MSTDVNUNLHDon { get; set; }

        [XmlElement(ElementName = "TDVNUNLHDon")]
        public string TDVNUNLHDon { get; set; }  

        [XmlElement(ElementName = "DCDVNUNLHDon")]
        public string DCDVNUNLHDon { get; set; }

        [XmlElement(ElementName = "TTKhac")]
        public List<TTKhac> TTKhac { get; set; }
    }

    [XmlRoot(ElementName = "TTin")]
    public class TTin
    {

        [XmlElement(ElementName = "TTruong")]
        public string TTruong { get; set; }

        [XmlElement(ElementName = "DLieu")]
        public string DLieu { get; set; }

        [XmlElement(ElementName = "KDLieu")]
        public string KDLieu { get; set; }
    }

    [XmlRoot(ElementName = "TTKhac")]
    public class TTKhac
    {

        [XmlElement(ElementName = "TTin")]
        public List<TTin> TTin { get; set; }
    }

    [XmlRoot(ElementName = "NBan")]
    public class NBan
    {

        [XmlElement(ElementName = "Ten")]
        public string Ten { get; set; }

        [XmlElement(ElementName = "MST")]
        public string MST { get; set; }

        [XmlElement(ElementName = "DChi")]
        public string DChi { get; set; }

        [XmlElement(ElementName = "SDThoai")]
        public string SDThoai { get; set; }

        [XmlElement(ElementName = "STKNHang")]
        public string STKNHang { get; set; }

        [XmlElement(ElementName = "TNHang")]
        public string TNHang { get; set; }

        [XmlElement(ElementName = "Fax")]
        public string Fax { get; set; }

        [XmlElement(ElementName = "Website")]
        public string Website { get; set; }

        [XmlElement(ElementName = "Signature")]
        public Signature Signature { get; set; }
    }

    [XmlRoot(ElementName = "NMua")]
    public class NMua
    {

        [XmlElement(ElementName = "Ten")]
        public string Ten { get; set; }

        [XmlElement(ElementName = "MST")]
        public double MST { get; set; }

        [XmlElement(ElementName = "DChi")]
        public string DChi { get; set; }

        [XmlElement(ElementName = "MKHang")]
        public string MKHang { get; set; }

        [XmlElement(ElementName = "SDThoai")]
        public string SDThoai { get; set; }

        [XmlElement(ElementName = "DCTDTu")]
        public string DCTDTu { get; set; }

        [XmlElement(ElementName = "HVTNMHang")]
        public string HVTNMHang { get; set; } 
        
        [XmlElement(ElementName = "STKNHang")]
        public string STKNHang { get; set; }

        [XmlElement(ElementName = "TNHang")]
        public string TNHang { get; set; }

        [XmlElement(ElementName = "TTKhac")]
        public List<TTKhac> TTKhac { get; set; }
    }

    [XmlRoot(ElementName = "HHDVu")]
    public class HHDVu
    {

        [XmlElement(ElementName = "STT")]
        public int STT { get; set; }
        [XmlElement(ElementName = "TChat")]
        public int TChat { get; set; }     

        [XmlElement(ElementName = "THHDVu")]
        public string THHDVu { get; set; }

        [XmlElement(ElementName = "DVTinh")]
        public string DVTinh { get; set; }

        [XmlElement(ElementName = "SLuong")]
        public string SLuong { get; set; }

        [XmlElement(ElementName = "DGia")]
        public decimal DGia { get; set; }

        [XmlElement(ElementName = "TLCKhau")]
        public string TLCKhau { get; set; }

        [XmlElement(ElementName = "STCKhau")]
        public string STCKhau { get; set; }

        [XmlElement(ElementName = "ThTien")]
        public decimal ThTien { get; set; }

        [XmlElement(ElementName = "TSuat")]
        public string TSuat { get; set; }

        [XmlElement(ElementName = "TTKhac")]
        public List<TTKhac> TTKhac { get; set; }
    }

    [XmlRoot(ElementName = "DSHHDVu")]
    public class DSHHDVu
    {

        [XmlElement(ElementName = "HHDVu")]
        public List<HHDVu> HHDVu { get; set; }
    }

    [XmlRoot(ElementName = "LTSuat")]
    public class LTSuat
    {

        [XmlElement(ElementName = "TSuat")]
        public string TSuat { get; set; }

        [XmlElement(ElementName = "ThTien")]
        public decimal ThTien { get; set; }

        [XmlElement(ElementName = "TThue")]
        public decimal TThue { get; set; }
    }

    [XmlRoot(ElementName = "THTTLTSuat")]
    public class THTTLTSuat
    {

        [XmlElement(ElementName = "LTSuat")]
        public LTSuat LTSuat { get; set; }
    }

    [XmlRoot(ElementName = "TToan")]
    public class TToan
    {

        [XmlElement(ElementName = "THTTLTSuat")]
        public THTTLTSuat THTTLTSuat { get; set; }

        [XmlElement(ElementName = "TgTCThue")]
        public decimal TgTCThue { get; set; }

        [XmlElement(ElementName = "TgTThue")]
        public decimal TgTThue { get; set; }

        [XmlElement(ElementName = "TTCKTMai")]
        public decimal TTCKTMai { get; set; }

        [XmlElement(ElementName = "TgTTTBSo")]
        public decimal TgTTTBSo { get; set; }

        [XmlElement(ElementName = "TgTTTBChu")]
        public string TgTTTBChu { get; set; }

        [XmlElement(ElementName = "TTKhac")]
        public List<TTKhac> TTKhac { get; set; }
    }

    [XmlRoot(ElementName = "NDHDon")]
    public class NDHDon
    {
        public NDHDon()
        {
            this.DSHHDVu = new DSHHDVu();
        }
        [XmlElement(ElementName = "NBan")]
        public NBan NBan { get; set; }

        [XmlElement(ElementName = "NMua")]
        public NMua NMua { get; set; }

        [XmlElement(ElementName = "DSHHDVu")]
        public DSHHDVu DSHHDVu { get; set; }

        [XmlElement(ElementName = "TToan")]
        public TToan TToan { get; set; }
        [XmlElement(ElementName = "TTKhac")]
        public List<TTKhac> TTKhac { get; set; }
    }

    [XmlRoot(ElementName = "DLHDon")]
    public class DLHDon
    {
        public DLHDon()
        {
            this.NDHDon =new NDHDon();
        }

        [XmlElement(ElementName = "TTChung")]
        public TTChung TTChung { get; set; }

        [XmlElement(ElementName = "NDHDon")]
        public NDHDon NDHDon { get; set; }

        [XmlAttribute(AttributeName = "Id")]
        public string Id { get; set; }

        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "MCCQT")]
    public class MCCQT
    {

        [XmlAttribute(AttributeName = "Id")]
        public string Id { get; set; }

        [XmlText]
        public string Text { get; set; }
    }


    [XmlRoot(ElementName = "CanonicalizationMethod")]
    public class CanonicalizationMethod
    {

        [XmlAttribute(AttributeName = "Algorithm")]
        public string Algorithm { get; set; }
    }

    [XmlRoot(ElementName = "SignatureMethod")]
    public class SignatureMethod
    {

        [XmlAttribute(AttributeName = "Algorithm")]
        public string Algorithm { get; set; }
    }

    [XmlRoot(ElementName = "Transform")]
    public class Transform
    {

        [XmlAttribute(AttributeName = "Algorithm")]
        public string Algorithm { get; set; }
    }

    [XmlRoot(ElementName = "Transforms")]
    public class Transforms
    {

        [XmlElement(ElementName = "Transform")]
        public Transform Transform { get; set; }
    }

    [XmlRoot(ElementName = "DigestMethod")]
    public class DigestMethod
    {

        [XmlAttribute(AttributeName = "Algorithm")]
        public string Algorithm { get; set; }
    }

    [XmlRoot(ElementName = "Reference")]
    public class Reference
    {

        [XmlElement(ElementName = "Transforms")]
        public Transforms Transforms { get; set; }

        [XmlElement(ElementName = "DigestMethod")]
        public DigestMethod DigestMethod { get; set; }

        [XmlElement(ElementName = "DigestValue")]
        public string DigestValue { get; set; }

        [XmlAttribute(AttributeName = "URI")]
        public string URI { get; set; }

        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "SignedInfo")]
    public class SignedInfo
    {

        [XmlElement(ElementName = "CanonicalizationMethod")]
        public CanonicalizationMethod CanonicalizationMethod { get; set; }

        [XmlElement(ElementName = "SignatureMethod")]
        public SignatureMethod SignatureMethod { get; set; }

        [XmlElement(ElementName = "Reference")]
        public List<Reference> Reference { get; set; }
    }

    [XmlRoot(ElementName = "X509Data")]
    public class X509Data
    {

        [XmlElement(ElementName = "X509SubjectName")]
        public string X509SubjectName { get; set; }

        [XmlElement(ElementName = "X509Certificate")]
        public string X509Certificate { get; set; }
    }

    [XmlRoot(ElementName = "KeyInfo")]
    public class KeyInfo
    {

        [XmlElement(ElementName = "X509Data")]
        public X509Data X509Data { get; set; }
    }

    [XmlRoot(ElementName = "SignatureProperty")]
    public class SignatureProperty
    {

        [XmlElement(ElementName = "SigningTime")]
        public string SigningTime { get; set; }

        [XmlAttribute(AttributeName = "Id")]
        public string Id { get; set; }

        [XmlAttribute(AttributeName = "Target")]
        public string Target { get; set; }

        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "SignatureProperties")]
    public class SignatureProperties
    {

        [XmlElement(ElementName = "SignatureProperty")]
        public SignatureProperty SignatureProperty { get; set; }

        //[XmlAttribute(AttributeName = "xmlns")]
        //public object Xmlns { get; set; }

        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "Object")]
    public class Object
    {

        [XmlElement(ElementName = "SignatureProperties")]
        public SignatureProperties SignatureProperties { get; set; }

        [XmlAttribute(AttributeName = "Id")]
        public string Id { get; set; }

        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "Signature")]
    public class Signature
    {

        [XmlElement(ElementName = "SignedInfo")]
        public SignedInfo SignedInfo { get; set; }

        [XmlElement(ElementName = "SignatureValue")]
        public string SignatureValue { get; set; }

        [XmlElement(ElementName = "KeyInfo")]
        public KeyInfo KeyInfo { get; set; }

        [XmlElement(ElementName = "Object")]
        public Object Object { get; set; }

        //[XmlAttribute(AttributeName = "xmlns")]
        //public string Xmlns { get; set; }

        [XmlText]
        public string Text { get; set; }

        [XmlAttribute(AttributeName = "Id")]
        public string Id { get; set; }
    }


    [XmlRoot(ElementName = "CQT")]
    public class CQT
    {
        [XmlElement(ElementName = "Signature")]
        public Signature Signature { get; set; }
    }

    [XmlRoot(ElementName = "DSCKS")]
    public class DSCKS
    {

        [XmlElement(ElementName = "NBan")]
        public NBan NBan { get; set; }

        [XmlElement(ElementName = "CQT")]
        public CQT CQT { get; set; }
    }


    [XmlRoot(ElementName = "HDon")]
    public class HDon
    {

        [XmlElement(ElementName = "DLHDon")]
        public DLHDon DLHDon { get; set; }

        [XmlElement(ElementName = "MCCQT")]
        public MCCQT MCCQT { get; set; }

        [XmlElement(ElementName = "DSCKS")]
        public DSCKS DSCKS { get; set; }
    }

    [XmlRoot(ElementName = "DLieu")]
    public class DLieu
    {
        [XmlElement(ElementName = "HDon")]
        public HDon HDon { get; set; }
    }

    [XmlRoot(ElementName = "TDiep")]
    public class TDiep
    {
        public TDiep()
        {
            this.TTChung = new TTChung();
            this.DLieu = new DLieu();
        }

        [XmlElement(ElementName = "TTChung")]
        public TTChung TTChung { get; set; }

        [XmlElement(ElementName = "DLieu")]
        public DLieu DLieu { get; set; }
    }

}
