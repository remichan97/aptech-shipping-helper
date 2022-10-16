using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShippingHelper.Core.Models
{
    public class AcceptOffers
    {
        [ForeignKey("Users")]
        public string UserId { get; set; }
		public virtual Users Users { get; set; }
        [ForeignKey("Offers")]
        public Guid OfferId { get; set; }
		public virtual Offers Offers { get; set; }
	}
}