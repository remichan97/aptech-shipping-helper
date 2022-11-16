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
        [Display(Name = "And your destination?")]
        public string EndAddress { get; set; }
        [Display(Name = "Additional Note to Shipping Merchant")]
        public string Note { get; set; }
        public double Price { get; set; }
        public ICollection<ProductOffers> ProductOffers { get; set; }
    }
}
