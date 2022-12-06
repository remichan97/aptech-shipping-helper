using Microsoft.EntityFrameworkCore;
using ShippingHelper.Core.Data;
using ShippingHelper.Core.Models;
using ShippingHelper.Repository.Infrastructure;
using ShippingHelper.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingHelper.Repository.Repository
{
    public class CitiesRepository : BaseRepository<Cities>, ICitiesRepository
    {
        public CitiesRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Cities>> GetAllCities() => await _DbContext.Cities.ToListAsync();
    }
}
