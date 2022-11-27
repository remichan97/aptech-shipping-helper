using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ShippingHelper.Core.Data;
using ShippingHelper.Core.IRepository;
using ShippingHelper.Core.Models;
using ShippingHelper.Repository.Infrastructure;

namespace ShippingHelper.Core.Repository
{
    public class OffersRepository : BaseRepository<Offers>, IOffersRepository
	{
		public OffersRepository(AppDbContext context) : base(context)
		{
		}

        

        public async Task AcceptOffer(Guid id, string userId)
        {
            var offer = new AcceptOffers { OfferId = id, UserId = userId };
            await _DbContext.AcceptOffers.AddAsync(offer);
        }

        public async Task<IEnumerable<Offers>> GetAllAsync()
        {
            return await _DbContext.Offers.Include(it => it.Users).ToListAsync();
        }

        public async Task<IEnumerable<Offers>> GetOFfersByCityId(int cityId)
        {
            return await _DbContext.Offers.Include(it => it.Users).Where(it => it.CityId ==  cityId).ToListAsync();
        }

        public async Task<IEnumerable<Offers>> GetOFfersCreatedByUser(string userId)
        {
            return await _DbContext.Offers.Where(it => it.UserId == userId).ToListAsync();
        }
    }
}