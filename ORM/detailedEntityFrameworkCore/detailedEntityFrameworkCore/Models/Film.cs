using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace detailedEntityFrameworkCore.Models
{
   public class Film
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public DateTime PublishDate { get; set; }
        public string Poster { get; set; }
        public int Duration { get; set; }
        public int Rating { get; set; }

        //Navigation property:
        public Director Director { get; set; }
        public int? DirectorId { get; set; }

        public ICollection<FilmsPlayer> Players { get; set; } = new HashSet<FilmsPlayer>();

    }
}
