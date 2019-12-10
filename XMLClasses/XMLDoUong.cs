using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace QL_DatTiecNhaHang.XMLClasses
{
    public class XMLDoUong
    {
        [XmlAttribute()]
        public int IdDU { get; set; }
        [XmlAttribute()]
        public string TenDU { get; set; }
        [XmlAttribute()]
        public string DVT { get; set; }
        [XmlAttribute()]
        public int DonGia { get; set; }
        [XmlAttribute()]
        public int DonGia_PS { get; set; }
        [XmlAttribute()]
        public string GhiChu { get; set; }
        [XmlAttribute()]
        public int IdLDU { get; set; }
        [XmlAttribute()]
        public int SLDat { get; set; }
        [XmlAttribute()]
        public int SLPhatSinh { get; set; }

        public static string ToXML(List<XMLDoUong> dsDoUong)
        {
            try
            {
                XmlSerializer ser = new XmlSerializer(dsDoUong.GetType());
                var sb = new StringBuilder();
                using (var writer = XmlWriter.Create(sb))
                {
                    ser.Serialize(writer, dsDoUong);
                }
                return sb.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}
