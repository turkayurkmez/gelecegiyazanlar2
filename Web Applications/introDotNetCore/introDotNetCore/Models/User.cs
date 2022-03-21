using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace introDotNetCore.Models
{
    public class User
    {
        [Required(ErrorMessage ="Kullanıcı adı boş olamaz")]
        [MinLength(2,ErrorMessage ="En az iki karakter olmalı")]
        [Display(Name = "Kullanıcı adı")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Eposta boş olamaz")]
        [EmailAddress(ErrorMessage ="Eposta formatı hatalı")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Doğum tarihi boş olamaz")]
        public DateTime? BirthDate { get; set; }
    }
}
