using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace ShippingHelper.Core.Models
{
    public class Users : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
		public bool IsDisabled { get; set; } = false;
		public virtual ICollection<Offers> Offers { get; set; } = new List<Offers>();
		public virtual ICollection<AcceptOffers> AcceptOffers { get; set; } = new List<AcceptOffers>();
        [ForeignKey("Cities")]
        public int CityId { get; set; }
        public virtual Cities Cities { get; set; }
	}
}