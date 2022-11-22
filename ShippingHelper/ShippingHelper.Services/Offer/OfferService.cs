using ShippingHelper.Core.Models;
using ShippingHelper.Repository.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingHelper.Services.Offer
{
    public class OfferService : IOfferService
    {
        private readonly IUnitOfWork _unitOfWork;

        public OfferService(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }
        public async void AcceptOffer(Guid id, string userId)
        {
            await _unitOfWork.OffersRepository.AcceptOffer(id, userId);
            await _unitOfWork.SaveChanges();
        }

        public async void Add(Offers offers)
        {
            await _unitOfWork.OffersRepository.Add(offers);
            await _unitOfWork.SaveChanges();
        }

        public async void Delete(Guid id)
        {
            _unitOfWork.OffersRepository.Delete(id);
            await _unitOfWork.SaveChanges();
        }

        public async Task<IEnumerable<Offers>> GetAllOffers()
        {
            return await _unitOfWork.OffersRepository.GetAllAsync();
        }

        public async Task<Offers> GetOffers(Guid id)
        {
            return await _unitOfWork.OffersRepository.GetById(id);
        }

        public async Task<IEnumerable<Offers>> GetOffersByCity(int cityId)
        {
            return await _unitOfWork.OffersRepository.GetOFfersByCityId(cityId);
        }

        public async Task<IEnumerable<Offers>> GetOffersCreatedByUser(string userId)
        {
            return await _unitOfWork.OffersRepository.GetOFfersCreatedByUser(userId);
        }

        public async void Update(Offers offers)
        {
            _unitOfWork.OffersRepository.Update(offers);
            await _unitOfWork.SaveChanges();
        }
    }
}
