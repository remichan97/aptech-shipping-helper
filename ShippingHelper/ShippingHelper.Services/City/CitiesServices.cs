using Microsoft.AspNetCore.Mvc.Rendering;
using ShippingHelper.Repository.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingHelper.Services.City
{
    public class CitiesServices : ICitiesServices
    {
        private readonly IUnitOfWork _unitOfWork;

        public CitiesServices(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<SelectListItem>> GetSelectListItems() => (await _unitOfWork.CitiesRepository.GetAllCities()).Select(it => new SelectListItem { Text = it.Name, Value = it.Id.ToString() });
    }
}
