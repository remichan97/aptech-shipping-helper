using System;
using System.Collections.Generic;
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
		public virtual ICollection<Offers> Offers { get; set; } = new List<Offers>();
		public virtual ICollection<AcceptOffers> AcceptOffers { get; set; } = new List<AcceptOffers>();
	}
}