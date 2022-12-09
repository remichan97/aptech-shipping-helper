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

        Task<IEnumerable<Offers>> GetOffersByShipperAndByStatus(string userId, OfferStatus status);

        Task<IEnumerable<Offers>> GetCreatedOFferByUserAndStatus(string userId, OfferStatus status);

        Task<Offers> GetOffers(Guid id);

        Task Add(ShippingOfferForm form, string userId, int cityId);

        Task Update(ShippingOfferForm form, Guid id);

        Task Delete(Guid id);

        Task AcceptOffer(Guid id, string userId);

        Task ChangeOfferStatus(OfferStatus status, Guid id);

        Task ReportMerchants(ReportedMerchant merchant);
    }
}