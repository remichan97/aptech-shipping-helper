using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace ShippingHelper.ViewModels
{
    public class ShippingOfferForm
    {
        [Display(Name = "Where you want to start your delivery?")]
        public string StartAddress { get; set; }

        [Required]
        [Display(Name = "And your destination?")]
        public string EndAddress { get; set; }

        [Display(Name = "Additional Note to Shipping Merchant")]
        public string Note { get; set; }

        [Required]
        public double Price { get; set; }

        [Display(Name = "Package Name")]
        [Required]
        public string ProductName { get; set; }

        [Required]
        [Display(Name = "Package Description")]
        public string Description { get; set; }

        [Required]
        public int Quantity { get; set; }

        public string? ImagePath { get; set; }
        [Required]
        public IFormFile ImageFile { get; set; }
    }
}