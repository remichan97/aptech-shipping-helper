using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShippingHelper.Core.Models
{
    public class ProductOffers
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public string Image { get; set; }
        public virtual Offers Offers { get; set; }
	}
}