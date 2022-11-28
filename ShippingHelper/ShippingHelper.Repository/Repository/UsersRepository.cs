using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShippingHelper.Core.Data;
using ShippingHelper.Repository.IRepository;
using ShippingHelper.Core.Models;
using ShippingHelper.Repository.Infrastructure;

namespace ShippingHelper.Repository.Repository
{
    public class UsersRepository : BaseRepository<Users>, IUsersRepository
	{
		public UsersRepository(AppDbContext context) : base(context)
		{
		}
	}
}