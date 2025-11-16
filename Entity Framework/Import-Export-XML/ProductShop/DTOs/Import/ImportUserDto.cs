using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ProductShop.DTOs.Import
{
    [XmlType("User")]
    public class ImportUserDto
    {
        [XmlElement("firstName")]
        public string? FirstName { get; set; }

        [Required]
        [XmlElement("lastName")]
        public string LastName { get; set; } = null!;

        [XmlElement("age")]
        public string? Age { get; set; }
    }
}
