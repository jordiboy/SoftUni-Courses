
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace ProductShop.DTOs.Import
{
    [XmlType("CategoryProduct")]
    public class ImportCategoryProductDto
    {
        [Required]
        [XmlAnyElement("CategoryId")]
        public string CategoryId { get; set; } = null!;

        [Required]
        [XmlElement("ProductId")]
        public string ProductId { get; set; } = null!;
    }
}
