using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web04.Models
{
    public class Playlist
    {
        public Playlist()
        {
            Item = new HashSet<MusicItem>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public ApplicationUser Owner { get; set; }

        public ICollection<MusicItem> Item { get; set; }
    }
}
