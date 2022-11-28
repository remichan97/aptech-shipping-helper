using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ShippingHelper.Core.Data;
using ShippingHelper.Core.Models;
using ShippingHelper.Repository.Infrastructure;
using ShippingHelper.Repository.IRepository;

namespace ShippingHelper.Repository.Repository
{
    public class ContactsRepository : BaseRepository<Contacts>, IContactsRepository
	{
		public ContactsRepository(AppDbContext context) : base(context)
		{
		}

		public async Task<IEnumerable<Contacts>> GetAllMessages()
		{
			return await _DbContext.Contacts.ToListAsync();
		}
	}
}