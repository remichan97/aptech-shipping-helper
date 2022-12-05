using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ShippingHelper.ViewModels
{
    public class ShippingOrderEditForm
    {
        [Display(Name = "And your destination?")]
        public string EndAddress { get; set; }
        [Display(Name = "Additional Note to Shipping Merchant")]
        public string Note { get; set; }
        public double Price { get; set; }
    }
}
