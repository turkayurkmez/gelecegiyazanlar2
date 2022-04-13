using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bootShop.Entities
{
   public class User
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string UserName { get; set; }
        public string Eposta { get; set; }
        public string Password { get; set; }

        public string Role { get; set; }


    }
}
