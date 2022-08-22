using ComicWorld.Application.ViewModels.Comic;
using System;
using System.Collections.Generic;
using System.Text;

namespace ComicWorld.Application.Interfaces
{
    public interface IComicService
    {
        ListComicForListVm GetAllComicForList(int pageSize, int pageNo, string searchString);
        public int AddComic(NewComicVm comic);
        ComicDetailsVm GetComicDetails(int id);
        public int AddType(NewTypeVm type);
        NewComicVm GetComicForEdit(int id);
        void UpdateComic(NewComicVm model);
        void DeleteComic(int id);
        void DeleteTypeComic(int id);
    }
}
