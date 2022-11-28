using ShippingHelper.Core.Models;
using ShippingHelper.Repository.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingHelper.Services.ContactsUs
{
    public class ContactServices : IContactServices
    {
        private readonly IUnitOfWork _unitOfWork;

        public ContactServices(IUnitOfWork unitOfWork) => this._unitOfWork = unitOfWork;

        public async Task<IEnumerable<Contacts>> GetAllMessages() => await _unitOfWork.ContactsRepository.GetAllMessages();

        public async Task SendMessage(Contacts contacts)
        {
            await _unitOfWork.ContactsRepository.Add(contacts);
            await _unitOfWork.SaveChanges();
        }
    }
}
