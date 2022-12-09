using ShippingHelper.Common.Methods;
using ShippingHelper.Core.Models;
using ShippingHelper.Repository.Infrastructure;
using ShippingHelper.ViewModels;

namespace ShippingHelper.Services.Offer
{
    public class OfferServices : IOfferServices
    {
        private readonly IUnitOfWork _unitOfWork;

        public OfferServices(IUnitOfWork unitOfWork) => this._unitOfWork = unitOfWork;

        public async Task AcceptOffer(Guid id, string userId)
        {
            await _unitOfWork.OffersRepository.AcceptOffer(id, userId);
            await _unitOfWork.SaveChanges();
        }

        public async Task Add(ShippingOfferForm form, string userId, int cityId)
        {

            form.ImagePath = await FileHelpers.CopyFiles(form.ImageFile);

            ProductOffers productOffers = new ProductOffers
            {
                Name = form.ProductName,
                Description = form.Description,
                Quantity = form.Quantity,
                Image = form.ImagePath
            };

            Offers offers = new Offers
            {
                StartAddress = form.StartAddress,
                EndAddress = form.EndAddress,
                Price = form.Price,
                Note = form.Note,
                ProductOffers = productOffers,
                UserId = userId,
                CityId = cityId
            };

            await _unitOfWork.OffersRepository.Add(offers);
            await _unitOfWork.SaveChanges();
        }

        public async Task ChangeOfferStatus(OfferStatus status, Guid id)
        {
            await _unitOfWork.OffersRepository.ChangeOfferStatus(status,id);
            await _unitOfWork.SaveChanges();
        }

        public async Task Delete(Guid id)
        {
            _unitOfWork.OffersRepository.Delete(id);
            await _unitOfWork.SaveChanges();
        }

        public async Task<IEnumerable<Offers>> GetAllOffers() => await _unitOfWork.OffersRepository.GetAllAsync();

        public async Task<IEnumerable<Offers>> GetCreatedOFferByUserAndStatus(string userId, OfferStatus status) => await _unitOfWork.OffersRepository.GetCreatedOfferByStatus(userId, status);

        public async Task<Offers> GetOffers(Guid id) => await _unitOfWork.OffersRepository.GetOfferById(id);

        public async Task<IEnumerable<Offers>> GetOffersByCity(int cityId) => await _unitOfWork.OffersRepository.GetOFfersByCityId(cityId);

        public async Task<IEnumerable<Offers>> GetOffersByStatus(OfferStatus status) => await _unitOfWork.OffersRepository.GetOffersByStatus(status);

        public async Task<IEnumerable<Offers>> GetOffersByUserAndByStatus(string userId, OfferStatus status) => await _unitOfWork.OffersRepository.GetOffersByUserAndByStatus(userId, status);

        public async Task<IEnumerable<Offers>> GetOffersCreatedByUser(string userId) => await _unitOfWork.OffersRepository.GetOFfersCreatedByUser(userId);

        public async Task ReportMerchants(ReportedMerchant merchant)
        {
            await _unitOfWork.ReportMerchantsRepository.Add(merchant);
            await _unitOfWork.SaveChanges();
        }

        public async Task Update(ShippingOfferForm form, Guid id)
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