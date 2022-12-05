using System.ComponentModel.DataAnnotations;
using ShippingHelper.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        [Required]
        [FileExtensions(Extensions ="jpg|png", ErrorMessage = "Please select jpg and png files only")]
        public string Image { get; set; }
    }
}
