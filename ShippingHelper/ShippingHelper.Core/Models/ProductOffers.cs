using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShippingHelper.Core.Models
{
    public class ProductOffers
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        [Display(Name = "Item name")]
        public string Name { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public string Image { get; set; }
        [ForeignKey("Offers")]
        public Guid OfferId { get; set; }
        public virtual Offers Offers { get; set; }
	}
}