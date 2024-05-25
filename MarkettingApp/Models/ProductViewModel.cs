using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace ProductMarketingApp.Models
{
    public class ProductViewModel
    {
        public ProductViewModel()
        {
            Title = string.Empty;
            Description = string.Empty;
        }

        public int ProductId { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        public IFormFile? Image { get; set; }    }
}
