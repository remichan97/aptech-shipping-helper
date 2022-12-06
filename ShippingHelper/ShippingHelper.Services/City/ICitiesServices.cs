using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingHelper.Services.City
{
    public interface ICitiesServices
    {
        Task<IEnumerable<SelectListItem>> GetSelectListItems();
    }
}
