using ShippingHelper.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingHelper.Services.Reports
{
    public interface IReportMechantServices
    {
        Task Add(ReportedMerchant reported);
    }
}
