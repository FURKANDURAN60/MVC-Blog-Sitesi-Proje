using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class SifreDegistirme
    {
        [Required]
        [DisplayName("Şimdi ki Şifre")]
        public string OldPassword{ get; set; }

        [Required]
        [DisplayName("Yeni Şifre")]
        [StringLength(100,MinimumLength =5,ErrorMessage ="Şifreniz En Az 5 Karakterden Oluşmalıdır. ")]
        public string NewPassword { get; set; }

        [Required]
        [DisplayName("Yeni Şifre")]
        [Compare("NewPassword",ErrorMessage = "Şifreler Aynı Değil")]
        public string ConNewPassword { get; set; }
    }
}