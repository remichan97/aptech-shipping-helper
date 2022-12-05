using ShippingHelper.Core.Models;
using ShippingHelper.ViewModels;

namespace ShippingHelper.Services.Offer
{
    public interface IOfferServices
    {
        Task<IEnumerable<Offers>> GetAllOffers();

        Task<IEnumerable<Offers>> GetOffersCreatedByUser(string userId);

        Task<IEnumerable<Offers>> GetOffersByCity(int cityId);

        Task<IEnumerable<Offers>> GetOffersByStatus(OfferStatus status);

        Task<IEnumerable<Offers>> GetOffersByUserAndByStatus(string userId, OfferStatus status);

        Task<IEnumerable<Offers>> GetCreatedOFferByUserAndStatus(string userId, OfferStatus status);

        Task<Offers> GetOffers(Guid id);

        void Add(ShippingOfferForm form);

        void Update(ShippingOfferForm form, Guid id);

        void Delete(Guid id);

        void AcceptOffer(Guid id, string userId);
    }
}