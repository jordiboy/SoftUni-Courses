namespace ProductShop.DTOs.Import
{
    
    using Newtonsoft.Json;
    using System.ComponentModel.DataAnnotations;

    public class ImportUsersDto
    {
        [JsonProperty("firstName")]
        public string? FirstName { get; set; }

        [Required]
        [JsonProperty("lastName")]
        public string LastName { get; set; } = null!;

        [JsonProperty("age")]
        public string? Age { get; set; }
    }
}
