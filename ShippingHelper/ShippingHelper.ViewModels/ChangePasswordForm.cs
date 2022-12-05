using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ShippingHelper.ViewModels
{
    public class ChangePasswordForm
    {
        [Required]
        [PasswordPropertyText(true)]
        public string OldPassword { get; set; }

        [Required]
        [PasswordPropertyText(true)]
        public string NewPassword { get; set; }

        [Required]
        [PasswordPropertyText(true)]
        [Compare("NewPassword", ErrorMessage = "Password do not match")]
        public string ConfirmPassword { get; set; }
    }
}