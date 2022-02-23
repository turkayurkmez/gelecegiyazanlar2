using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace introEntityFramework.Models
{
   public class Director
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Info { get; set; }

        public List<Film> Films { get; set; }

    }
}
