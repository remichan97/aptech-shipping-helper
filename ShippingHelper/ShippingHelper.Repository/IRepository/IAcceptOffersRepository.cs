using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShippingHelper.Core.Models;
using ShippingHelper.Repository.Infrastructure;

namespace ShippingHelper.Repository.IRepository
{
    public interface IAcceptOffersRepository : IBaseRepository<AcceptOffers>
    {
        Task<string> GetUserIdByOfferId(Guid id);
    }
}