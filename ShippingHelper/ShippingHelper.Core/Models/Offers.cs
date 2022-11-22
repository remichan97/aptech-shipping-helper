using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShippingHelper.Core.Models
{
	public enum OfferStatus
	{
		Open = 1,
		Accepted = 2,
		PickedUp = 3,
		Delivering = 4,
		Finished = 0
	}

	public class Offers
	{
		public Guid Id { get; set; } = Guid.NewGuid();
		public string StartAddress { get; set; }
		public string EndAddress { get; set; }
		public string Note { get; set; }
		public double Price { get; set; }
		public DateTime PostedDate { get; set; } = DateTime.Now;
		public OfferStatus Status { get; set; } = OfferStatus.Open;
		[ForeignKey("Users")]
		public string UserId { get; set; }
		public virtual Users Users { get; set; }
		[ForeignKey("Cities")]
		public int CityId { get; set; }
		public virtual Cities Cities { get; set; }
		public virtual ICollection<ProductOffers> ProductOffers { get; set; } = new List<ProductOffers>();
	}
}