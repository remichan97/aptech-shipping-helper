using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShippingHelper.Core.Models;

namespace ShippingHelper.Core.Configurations
{
	public class UserSeedConfiguration : IEntityTypeConfiguration<Users>
	{
		public void Configure(EntityTypeBuilder<Users> builder)
		{
			var hasher = new PasswordHasher<Users>();

			builder.Property(it => it.IsDisabled).HasDefaultValue(false);

			builder.HasData(
				new Users
				{
					Id = "afaf3585-a2a3-4157-b5a1-cebd30c53a1c",
					FirstName = "System",
					LastName = "Admin",
					Email = "admin@shiplink.com",
					NormalizedEmail = "ADMIN@SHPLINK.COM",
					UserName = "admin@shiplink.com",
					NormalizedUserName = "ADMIN@SHIPLINK.COM",
					Address = "Admin",
					PasswordHash = hasher.HashPassword(null, "remichan97"),
					CityId = 1
		        },
				new Users
				{
					Id = "f9f0d5c7-ba2f-4ac0-b7be-897983ae5236",
					FirstName = "Demo",
					LastName = "Shipper",
					Email = "shipper@shiplink.com",
					NormalizedEmail = "SHIPPER@SHPLINK.COM",
					UserName = "shipper@shiplink.com",
					NormalizedUserName = "SHIPPER@SHIPLINK.COM",
					Address = "Shipping",
					PasswordHash = hasher.HashPassword(null, "remichan97"),
					CityId = 2
		        },
				new Users
				{
					Id = "99ba2b16-99c6-41e5-b6be-7401c6896d02",
					FirstName = "Demo",
					LastName = "Shop Merchant",
					Email = "shop@shiplink.com",
					NormalizedEmail = "SHOP@SHPLINK.COM",
					Address = "Shop Address",
					UserName = "shop@shiplink.com",
					NormalizedUserName = "SHOP@SHIPLINK.COM",
					PasswordHash = hasher.HashPassword(null, "remichan97"),
					CityId = 2
		        }
			);
		}
	}
}