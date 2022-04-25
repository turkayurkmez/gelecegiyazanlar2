using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace bootShop.API.Models
{
    public class UserLoginModel
    {
        [Required(ErrorMessage = "Kullanıcı adı....")]
        public string userName { get; set; }        
        [Required(ErrorMessage = "Şifre boş olamaz")]
        public string password { get; set; }

    }
}
