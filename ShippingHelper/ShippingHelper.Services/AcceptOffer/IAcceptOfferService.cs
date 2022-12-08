using ShippingHelper.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingHelper.Services.AcceptOffer
{
    public interface IAcceptOfferService
    {
        Task<string> GetUserIdForAcceptOffer(Guid id);
    }
}
