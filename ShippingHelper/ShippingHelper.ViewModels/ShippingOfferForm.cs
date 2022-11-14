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
        public string StartAddress { get; set; }
        public string EndAddress { get; set; }
        public string Note { get; set; }
        public double Price { get; set; }
        public ICollection<ProductOffers> ProductOffers { get; set; }
    }
}
