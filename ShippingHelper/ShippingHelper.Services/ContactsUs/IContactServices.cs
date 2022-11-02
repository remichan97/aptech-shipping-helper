using ShippingHelper.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingHelper.Services.ContactsUs
{
    public interface IContactServices
    {
        Task<IEnumerable<Contacts>> GetAllMessages();
        Task SendMessage(Contacts contacts);
    }
}
