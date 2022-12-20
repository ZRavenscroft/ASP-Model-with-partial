using System.ComponentModel.DataAnnotations;

namespace PustokLayout.ViewModels
{
    public class ForgotPasswordViewModel
    {
        [MaxLength(100)]
        public string Email { get; set; }
    }
}
