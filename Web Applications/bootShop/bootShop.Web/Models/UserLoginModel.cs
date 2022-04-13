using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace bootShop.Web.Models
{
    public class UserLoginModel
    {
        [Required(ErrorMessage = "Kullanıcı adı....")]
        public string UserName { get; set; }
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Şifre boş olamaz")]
        public string Password { get; set; }

    }
}
