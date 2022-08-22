using System;
using System.Collections.Generic;
using System.Text;

namespace ComicWorld.Domain.Model
{
    public class Comic
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Issue { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Publisher { get; set; }
        public string ComicPhoto { get; set; }
        public string Author { get; set; }
        public string Drawings { get; set; }
        public int TypeId { get; set; }
        public string Description { get; set; }
        public virtual Type Type { get; set; }
        public ICollection<ComicTag> ComicTags { get; set; }
    }
}
