using System;
using System.Collections.Generic;
using System.Text;

namespace ComicWorld.Domain.Model
{
    public class Type
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public ICollection<Comic> Comics { get; set; }
    }
}
