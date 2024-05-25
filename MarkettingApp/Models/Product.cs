using System;
using System.ComponentModel.DataAnnotations;

namespace ProductMarketingApp.Models
{
    public class Product
    {
        public Product()
        {
            Title = string.Empty;
            Description = string.Empty;
            ImagePath = string.Empty;
            UserId = string.Empty;
            User = new User();
        }

        public int ProductId { get; set; }

        [Required]
        [MaxLength(200)]
        public string Title { get; set; }

        [Required]
        [MaxLength(500)]
        public string Description { get; set; }

        [MaxLength(255)]
        public string ImagePath { get; set; }

        public DateTime DatePosted { get; set; }

        public string UserId { get; set; }

        public virtual User User { get; set; }
    }
}
