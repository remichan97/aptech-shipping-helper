using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShippingHelper.Core.Models;

namespace ShippingHelper.Core.Configurations
{
	public class AcceptOffersConfiguration : IEntityTypeConfiguration<AcceptOffers>
	{
		public void Configure(EntityTypeBuilder<AcceptOffers> builder)
		{
			builder.HasKey(it => new { it.UserId, it.OfferId });
		}
	}
}