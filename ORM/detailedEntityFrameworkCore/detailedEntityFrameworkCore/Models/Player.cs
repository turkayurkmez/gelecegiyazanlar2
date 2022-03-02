using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace detailedEntityFrameworkCore.Models
{
   public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Info { get; set; }

        public List<FilmsPlayer> Films { get; set; }
    }
}
