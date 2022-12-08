using ShippingHelper.Repository.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingHelper.Services.AcceptOffer
{
    public class AcceptOfferService : IAcceptOfferService
    {
        private readonly IUnitOfWork _unitOfWork;

        public AcceptOfferService(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        public async Task<string> GetUserIdForAcceptOffer(Guid id)
        {
            var data = await _unitOfWork.AcceptOffersRepository.GetUserIdByOfferId(id);

            return data;
        }
    }
}
