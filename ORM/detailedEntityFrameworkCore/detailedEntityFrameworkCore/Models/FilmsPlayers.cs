using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace detailedEntityFrameworkCore.Models
{
    public class FilmsPlayer
    {
        public int FilmId { get; set; }
        public Film Film  { get; set; }
        public int PlayerId { get; set; }
        public Player Player { get; set; }


        public string  Role { get; set; }

        




    }
}
