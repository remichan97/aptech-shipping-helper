using ShippingHelper.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingHelper.Services.Offer
{
    public interface IOfferService
    {
        Task<IEnumerable<Offers>> GetAllOffers();
        Task<IEnumerable<Offers>> GetOffersCreatedByUser(string userId);
        Task<IEnumerable<Offers>> GetOffersByCity(int cityId);
        Task<Offers> GetOffers(Guid id);
        void Add(Offers offers);
        void Update(Offers offers);
        void Delete(Guid id);
        void AcceptOffer(Guid id, string userId);

    }
}
