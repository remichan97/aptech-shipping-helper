using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShippingHelper.Core.Data;
using ShippingHelper.Core.Infrastructure;
using ShippingHelper.Core.IRepository;
using ShippingHelper.Core.Models;

namespace ShippingHelper.Core.Repository
{
	public class ProductOffersRepository : BaseRepository<ProductOffers>, IProductOffersRepository
	{
		public ProductOffersRepository(AppDbContext context) : base(context)
		{
		}
	}
}