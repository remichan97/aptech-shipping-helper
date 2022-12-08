using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ShippingHelper.Core.Data;
using ShippingHelper.Core.Models;
using ShippingHelper.Repository.Infrastructure;
using ShippingHelper.Repository.IRepository;

namespace ShippingHelper.Repository.Repository
{
    public class AcceptOffersRepository : BaseRepository<AcceptOffers>, IAcceptOffersRepository
	{
		public AcceptOffersRepository(AppDbContext context) : base(context)
		{
		}

        public async Task<string> GetUserIdByOfferId(Guid id)
        {
            var data = await (from offer in _DbContext.AcceptOffers where offer.OfferId == id select offer.UserId).FirstOrDefaultAsync();

            return data;
        }
    }
}