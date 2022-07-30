using System;
using System.Collections.Generic;
using System.Text;

namespace ComicWorld.Domain.Model
{
    public class Tag
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<ComicTag> ComicTags { get; set; }
    }
}
