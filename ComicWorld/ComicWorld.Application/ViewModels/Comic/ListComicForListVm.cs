using System;
using System.Collections.Generic;
using System.Text;

namespace ComicWorld.Application.ViewModels.Comic
{
    public class ListComicForListVm
    {
        public List<ComicForListVm> Comics { get; set; }
        public int Count { get; set; }
        public int CurrentPage { get; set; }
        public int PageSize { get; set; }
        public string SearchString { get; set; }
        public object Comic { get; internal set; }
    }
}
