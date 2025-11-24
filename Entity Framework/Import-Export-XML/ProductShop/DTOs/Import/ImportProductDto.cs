
using System.Xml.Serialization;

namespace ProductShop.DTOs.Import
{
    [XmlType("Product")]
    public class ImportProductDto
    {
        [XmlElement("name")]
        public string Name { get; set; } = null!;
        [XmlElement("price")]
        public string Price { get; set; } = null!;
        [XmlElement("sellerId")]
        public string SellerId { get; set; } = null!;
        [XmlElement("buyerId")]
        public string BuyerId { get; set; } = null!;
    }
}
