using ComicWorld.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComicWorld.Domain.Interface
{
    public interface IComicRepository
    {
        void DeleteComic(int comicId);

        int AddComic(Comic comic);

        IQueryable<Comic> GetAllComics();

        Comic GetComic(int comicId);

        int AddType(ComicWorld.Domain.Model.Type type);

        void UpdateComic(Comic comic);
        void DeleteTypeComic(int id);
    }
}
