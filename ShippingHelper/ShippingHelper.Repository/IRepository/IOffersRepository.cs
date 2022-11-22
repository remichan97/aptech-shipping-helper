using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShippingHelper.Core.Models;
using ShippingHelper.Repository.Infrastructure;

namespace ShippingHelper.Core.IRepository
{
    public interface IOffersRepository : IBaseRepository<Offers>
    {
        Task<IEnumerable<Offers>> GetAllAsync();
        Task<IEnumerable<Offers>> GetOFfersCreatedByUser(string userId);
        Task<IEnumerable<Offers>> GetOFfersByCityId(int cityId);
        Task AcceptOffer(Guid id, string userId);
    }
}