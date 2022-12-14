using Microsoft.AspNetCore.Mvc.Rendering;
using ShippingHelper.Core.Models;
using ShippingHelper.Repository.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingHelper.Repository.IRepository;

public interface ICitiesRepository : IBaseRepository<Cities>
{
    Task<IEnumerable<Cities>> GetAllCities();
}
