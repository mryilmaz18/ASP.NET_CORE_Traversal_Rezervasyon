using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Traversal_Rezervasyon_CORE.Models
{
    public class KullaniciSignInViewModel
    {
        [Required(ErrorMessage="Lütfen kullanıcı adınızı giriniz")]
        public string username { get; set; }

        [Required(ErrorMessage = "Lütfen şifrenizi giriniz")]
        public string password { get; set; }
    }
}
