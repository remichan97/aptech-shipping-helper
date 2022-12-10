using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ShippingHelper.Core.Data;
using ShippingHelper.Repository.IRepository;
using ShippingHelper.Core.Models;
using ShippingHelper.Repository.Infrastructure;

namespace ShippingHelper.Repository.Repository
{
    public class OffersRepository : BaseRepository<Offers>, IOffersRepository
	{
		public OffersRepository(AppDbContext context) : base(context)
		{
		}

        public async Task AcceptOffer(Guid id, string userId)
        {
            var offer = new AcceptOffers { OfferId = id, UserId = userId };

            var data = await GetById(id);

            data.Status = OfferStatus.Accepted;

            await _DbContext.AcceptOffers.AddAsync(offer);

            _DbContext.Offers.Update(data);
        }

        public async Task ChangeOfferStatus(OfferStatus status, Guid id)
        {
            var offer = await GetById(id);

            if (offer is null) throw new ArgumentNullException(nameof(offer));

            offer.Status = status;

            _DbContext.Offers.Update(offer);
        }

        public async Task<IEnumerable<Offers>> GetAllAsync() => await _DbContext.Offers.Include(it => it.Users).ThenInclude(it  => it.Cities).ToListAsync();

        public async Task<IEnumerable<Offers>> GetCreatedOfferByStatus(string userId, OfferStatus status) => await _DbContext.Offers.Include(it => it.Users).Where(it => it.Status == status && it.UserId == userId).ToListAsync();

        public async Task<Offers> GetOfferById(Guid id) => await _DbContext.Offers.Include(it => it.ProductOffers).Where(it => it.Id == id).Include(it => it.Users).FirstOrDefaultAsync();

        public async Task<IEnumerable<Offers>> GetOFfersByCityId(int cityId) => await _DbContext.Offers.Include(it => it.Users).Where(it => it.CityId == cityId).ToListAsync();

        public async Task<IEnumerable<Offers>> GetOffersByShipperAndByStatus(string userId, OfferStatus status)
        {
            var data = (from offer in _DbContext.Offers join user in _DbContext.Users on offer.UserId equals user.Id join accept in _DbContext.AcceptOffers on offer.Id equals accept.OfferId where offer.Status == status && accept.UserId == userId select offer).Include(it => it.Users);

            return await data.ToListAsync();
        }

        public async Task<IEnumerable<Offers>> GetOffersByStatus(OfferStatus status) => await _DbContext.Offers.Include(it => it.Users).Where(it => it.Status == status).ToListAsync();

        public async Task<IEnumerable<Offers>> GetOffersByUserAndByStatus(string userId, OfferStatus status) => await _DbContext.Offers.Include(it => it.Users).Where(it => it.UserId == userId && it.Status == status).ToListAsync();

        public async Task<IEnumerable<Offers>> GetOFfersCreatedByUser(string userId) => await _DbContext.Offers.Where(it => it.UserId == userId).ToListAsync();
    }
}