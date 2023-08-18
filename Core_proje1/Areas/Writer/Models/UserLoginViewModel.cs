using System.ComponentModel.DataAnnotations;

namespace Core_proje1.Areas.Writer.Models
{
    public class UserLoginViewModel
    {
        [Display(Name = "Kullanıcı Adı")]
        [Required(ErrorMessage = "Kullanıcı adınızı giriniz :)")]
	    public string Username { get; set; }

	    [Display(Name = "Şifre")]
	    [Required(ErrorMessage = "Şifrenizi giriniz :)")]
		public string Password { get; set; }
    }
}
