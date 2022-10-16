using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ShippingHelper.Core.Configurations
{
	public class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
	{
		public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
		{
			builder.HasData(
                new IdentityUserRole<string>
                {
                    UserId = "afaf3585-a2a3-4157-b5a1-cebd30c53a1c",
                    RoleId = "40f71694-8d9d-4c9e-9698-4ebaad596253"
                },
                new IdentityUserRole<string>
                {
                    UserId = "f9f0d5c7-ba2f-4ac0-b7be-897983ae5236",
                    RoleId = "433bef6f-10d9-44f3-9193-28a8bfa35c5c"
                },
                new IdentityUserRole<string>
                {
                    UserId = "99ba2b16-99c6-41e5-b6be-7401c6896d02",
                    RoleId = "d51059b9-ca3b-4fdd-ad1e-23b9e4956686"
                }
            );
		}
	}
}