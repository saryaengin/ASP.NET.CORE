using Microsoft.Build.Framework;
using Xunit.Sdk;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json.Serialization;
using Xunit.Abstractions;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.Build.Framework;
using RequiredAttribute = System.ComponentModel.DataAnnotations.RequiredAttribute;
using Xunit.Sdk;
using Xunit.Abstractions;

namespace Core_proje1.Areas.Writer.Models
{
    public class UserRegisterViewModel
    
    {
        [Required(ErrorMessage = "Adınızı giriniz.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Soyadınızı giriniz.")]
        public string Surname { get; set; }
        [Required(ErrorMessage = "Kullanıcı adınızı giriniz.")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Görsel Url giriniz.")]
        public string ImageUrl { get; set; }

        [Required(ErrorMessage = "Şifrenizi giriniz.")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Şifrenizi tekrar giriniz.")]
        [Compare("Password", ErrorMessage = "Şifreler uyumlu değil.")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Mail adresinizi giriniz.")]
        public string Mail { get; set; }
    }
}
