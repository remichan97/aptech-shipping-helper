using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ShippingHelper.Core.Configurations;
using ShippingHelper.Core.Models;

namespace ShippingHelper.Core.Data
{
	public class AppDbContext : IdentityDbContext
	{
		public AppDbContext()
		{

		}

		public AppDbContext(DbContextOptions<AppDbContext> options)
			: base(options)
		{

		}

		public DbSet<Contacts> Contacts { get; set; }
		public DbSet<Offers> Offers { get; set; }
		public DbSet<ProductOffers> ProductOffers { get; set; }
		public DbSet<AcceptOffers> AcceptOffers { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			base.OnConfiguring(optionsBuilder);
			optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=ShippingProject;Trusted_Connection=True;MultipleActiveResultSets=true");
		}

		protected override void OnModelCreating(ModelBuilder builder)
		{
			base.OnModelCreating(builder);
			builder.ApplyConfigurationsFromAssembly(typeof(AcceptOffersConfiguration).Assembly);
		}
	}
}