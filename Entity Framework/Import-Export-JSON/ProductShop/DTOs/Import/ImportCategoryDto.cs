using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace ProductShop.DTOs.Import
{
    public class ImportCategoryDto
    {
        [Required]
        [JsonProperty("name")]
        public string? Name { get; set; }
    }
}
