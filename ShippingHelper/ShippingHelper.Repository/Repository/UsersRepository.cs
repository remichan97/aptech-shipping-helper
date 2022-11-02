using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShippingHelper.Core.Data;
using ShippingHelper.Core.IRepository;
using ShippingHelper.Core.Models;
using ShippingHelper.Repository.Infrastructure;

namespace ShippingHelper.Core.Repository
{
    public class UsersRepository : BaseRepository<Users>, IUsersRepository
	{
		public UsersRepository(AppDbContext context) : base(context)
		{
		}
	}
}