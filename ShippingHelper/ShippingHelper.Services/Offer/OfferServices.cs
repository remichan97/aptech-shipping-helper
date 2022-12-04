using ShippingHelper.Core.Models;
using ShippingHelper.Repository.Infrastructure;
using ShippingHelper.ViewModels;

namespace ShippingHelper.Services.Offer
{
    public class OfferServices : IOfferServices
    {
        private readonly IUnitOfWork _unitOfWork;

        public OfferServices(IUnitOfWork unitOfWork) => this._unitOfWork = unitOfWork;

        public async void AcceptOffer(Guid id, string userId)
        {
            await _unitOfWork.OffersRepository.AcceptOffer(id, userId);
            await _unitOfWork.SaveChanges();
        }

        public async void Add(ShippingOfferForm form)
        {
            Offers offers = new Offers
            {
                StartAddress = form.StartAddress,
                EndAddress = form.EndAddress,
                Price = form.Price,
                Note = form.Note
            };

            await _unitOfWork.OffersRepository.Add(offers);
            await _unitOfWork.SaveChanges();
        }

        public async void Delete(Guid id)
        {
            _unitOfWork.OffersRepository.Delete(id);
            await _unitOfWork.SaveChanges();
        }

        public async Task<IEnumerable<Offers>> GetAllOffers() => await _unitOfWork.OffersRepository.GetAllAsync();

        public async Task<Offers> GetOffers(Guid id) => await _unitOfWork.OffersRepository.GetById(id);

        public async Task<IEnumerable<Offers>> GetOffersByCity(int cityId) => await _unitOfWork.OffersRepository.GetOFfersByCityId(cityId);

        public async Task<IEnumerable<Offers>> GetOffersCreatedByUser(string userId) => await _unitOfWork.OffersRepository.GetOFfersCreatedByUser(userId);

        public async void Update(ShippingOfferForm form, Guid id)
        {
            var offer = await GetOffers(id);

            if (offer is null) throw new ArgumentNullException(nameof(offer));

            if (offer.Status != OfferStatus.Open) throw new InvalidOperationException();

            Offers offers = new Offers
            {
                Id = id,
                StartAddress = form.StartAddress,
                EndAddress = form.EndAddress,
                Price = form.Price,
                Note = form.Note
            };

            _unitOfWork.OffersRepository.Update(offers);
            await _unitOfWork.SaveChanges();
        }
    }
}