
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace ProductShop.DTOs.Import
{
    [XmlType("Category")]
    public class ImportCategoryDto
    {
        [Required]
        [XmlElement("name")]
        public string Name { get; set; } = null!;
    }
}
