using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ShippingHelper.Core.Configurations
{
	public class RoleSeedConfiguration : IEntityTypeConfiguration<IdentityRole>
	{
		public void Configure(EntityTypeBuilder<IdentityRole> builder)
		{
			builder.HasData(
                new IdentityRole
                {
                    Id = "40f71694-8d9d-4c9e-9698-4ebaad596253",
                    Name = "Administrator"
                },
                new IdentityRole
                {
                    Id = "433bef6f-10d9-44f3-9193-28a8bfa35c5c",
                    Name = "Shipping Merchant"
                },
                new IdentityRole
                {
                    Id = "d51059b9-ca3b-4fdd-ad1e-23b9e4956686",
                    Name = "Shop Merchant"
                }
            );
		}
	}
}