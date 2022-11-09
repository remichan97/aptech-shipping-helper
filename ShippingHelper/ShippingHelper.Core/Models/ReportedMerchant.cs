using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingHelper.Core.Models
{
    public class ReportedMerchant
    {
        public enum ReportTypes
        {
            MissingOrBrokenPackage = 1,
            BadPersonality = 2,
            AcceptedButNotCompleteShipping = 3,
            Other = 4
        }
        public Guid Id { get; set; } = Guid.NewGuid();
        [ForeignKey("Users")]
        public string UserId { get; set; }
        public virtual Users Users { get; set; }
        [Required]
        public ReportTypes ReportType { get; set; }
        [Required]
        public string Description { get; set; }
    }
}
