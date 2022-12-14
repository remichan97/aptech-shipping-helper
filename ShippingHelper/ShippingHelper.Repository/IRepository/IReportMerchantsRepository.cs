using ShippingHelper.Core.Models;
using ShippingHelper.Repository.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingHelper.Repository.IRepository
{
    public interface IReportMerchantsRepository : IBaseRepository<ReportedMerchant>
    {
        Task<IEnumerable<ReportedMerchant>> GetAllReports();

        Task<ReportedMerchant> GetReportDetails(Guid id);
    }
}
