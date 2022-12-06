using ShippingHelper.Core.Models;
using ShippingHelper.Repository.Infrastructure;

namespace ShippingHelper.Repository.IRepository
{
    public interface IOffersRepository : IBaseRepository<Offers>
    {
        Task<IEnumerable<Offers>> GetAllAsync();

        Task<IEnumerable<Offers>> GetOFfersCreatedByUser(string userId);

        Task<IEnumerable<Offers>> GetOFfersByCityId(int cityId);

        Task<IEnumerable<Offers>> GetOffersByStatus(OfferStatus status);

        Task<IEnumerable<Offers>> GetOffersByUserAndByStatus(string userId, OfferStatus status);

        Task<IEnumerable<Offers>> GetCreatedOfferByStatus(string userId ,OfferStatus status);

        Task AcceptOffer(Guid id, string userId);

        Task ChangeOfferStatus(OfferStatus status, Guid id);

    }
}