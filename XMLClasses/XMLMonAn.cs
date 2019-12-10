using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace QL_DatTiecNhaHang.XMLClasses
{
    public class XMLMonAn
    {
        [XmlAttribute()]
        public int IdMA { get; set; }
        [XmlAttribute()]
        public string TenMA { get; set; }
        [XmlAttribute()]
        public string DVT { get; set; }
        [XmlAttribute()]
        public int DonGia { get; set; }
        [XmlAttribute()]
        public string GhiChu { get; set; }
        [XmlAttribute()]
        public int IdLMA { get; set; }
        [XmlAttribute()]
        public int SLDat { get; set; }
        [XmlAttribute()]
        public int SLPhatSinh { get; set; }

        public static string ToXML(List<XMLMonAn> dsMonAn)
        {
            try
            {
                XmlSerializer ser = new XmlSerializer(dsMonAn.GetType());
                var sb = new StringBuilder();
                using (var writer = XmlWriter.Create(sb))
                {
                    ser.Serialize(writer, dsMonAn);
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
