using ShippingHelper.Core.Models;
using ShippingHelper.Repository.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingHelper.Services.Reports
{
    public class ReportMerchantServices : IReportMechantServices
    {
        private readonly IUnitOfWork _unitOfWork;

        public ReportMerchantServices(IUnitOfWork unitOfWork) => this._unitOfWork = unitOfWork;

        public async Task Add(ReportedMerchant reported)
        {
            await _unitOfWork.ReportMerchantsRepository.Add(reported);
            await _unitOfWork.SaveChanges();
        }

        public async Task<IEnumerable<ReportedMerchant>> GetAll() => await _unitOfWork.ReportMerchantsRepository.GetAllReports();
    }
}
