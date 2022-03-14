using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace detailedEntityFrameworkCore.Models
{

    //POCO: Plain Old C# Object
   public class Director
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Info { get; set; }

        //Navigation Property
        public List<Film> Films { get; set; }

    }
}
