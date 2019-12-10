using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace QL_DatTiecNhaHang.XMLClasses
{
    public class XMLDichVu
    {
        [XmlAttribute()]
        public int IdDV { get; set; }
        [XmlAttribute()]
        public string TenDV { get; set; }
        [XmlAttribute()]
        public int DonGia { get; set; }
        [XmlAttribute()]
        public int SLDat { get; set; }

        public static string ToXML(List<XMLDichVu> dsDichVu)
        {
            try
            {
                XmlSerializer ser = new XmlSerializer(dsDichVu.GetType());
                var sb = new StringBuilder();
                using (var writer = XmlWriter.Create(sb))
                {
                    ser.Serialize(writer, dsDichVu);
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
