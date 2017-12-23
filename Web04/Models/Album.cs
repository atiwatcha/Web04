using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Web04.Models
{
    public class Album
    {
        public Album()
        {
            Songs = new HashSet<Song>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Title { get; set; }
        public string Artist { get; set; }

        public string CoverImageUrl { get; set; }

        public ICollection<Song> Songs { get; set; }

        public TimeSpan TotalLength => TimeSpan.FromSeconds(Songs.Sum(s => s.Length.TotalSeconds));
    }
}
