using System;
using System.ComponentModel.DataAnnotations;

namespace ProductMarketingApp.Models
{
    public class Product
    {
        public int ProductId { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        public string ImagePath { get; set; }

        public DateTime DatePosted { get; set; }

        public int UserId { get; set; }

        public virtual User User { get; set; }
    }
}
