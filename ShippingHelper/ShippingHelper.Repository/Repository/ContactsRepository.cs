using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ShippingHelper.Core.Data;
using ShippingHelper.Core.IRepository;
using ShippingHelper.Core.Models;
using ShippingHelper.Repository.Infrastructure;

namespace ShippingHelper.Core.Repository
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