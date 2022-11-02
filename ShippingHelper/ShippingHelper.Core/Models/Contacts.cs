using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShippingHelper.Core.Models
{
    public class Contacts
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        [Required(ErrorMessage = "Please enter your full name")]
        public string FullName { get; set; }
        [Required(ErrorMessage = "Your email address help us reach out to you")]
        [EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage = "A Subject help us have a quick understanding about your query")]
        public string Subjects { get; set; }
        [Required(ErrorMessage = "A Message help us understands you better!")]
        public string Message { get; set; }
	}
}