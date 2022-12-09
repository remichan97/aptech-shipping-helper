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
    public class ReportedMerchantsRepository : BaseRepository<ReportedMerchant>, IReportMerchantsRepository
    {
        public ReportedMerchantsRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<ReportedMerchant>> GetAllReports() => await _DbContext.ReportedMerchants.Include(it => it.Users).ToListAsync();

        public async Task<ReportedMerchant> GetReportDetails(Guid id) => await _DbContext.ReportedMerchants.Include(it => it.Users).Where(it => it.Id == id).FirstOrDefaultAsync();
    }
}
