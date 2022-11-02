using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShippingHelper.Core.Models;
using ShippingHelper.Repository.Infrastructure;

namespace ShippingHelper.Core.IRepository
{
    public interface IContactsRepository : IBaseRepository<Contacts>
    {
        Task<IEnumerable<Contacts>> GetAllMessages();
    }
}