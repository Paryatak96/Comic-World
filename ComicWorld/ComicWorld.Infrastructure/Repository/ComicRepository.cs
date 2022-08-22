using ComicWorld.Domain.Interface;
using ComicWorld.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComicWorld.Infrastructure.Repository
{
    public class ComicRepository : IComicRepository
    {
        private readonly Context _context;

        public ComicRepository(Context context)
        {
            _context = context;
        }

        public IQueryable<Comic> GetAllComics()
        {
            return _context.Comics;
        }

        public Comic GetComic(int comicId)
        {
            return _context.Comics.FirstOrDefault(p => p.Id == comicId);
        }

        public void DeleteComic(int id)
        {
            var comic = _context.Comics.Find(id);
            if (comic != null)
            {
                _context.Comics.Remove(comic);
                _context.SaveChanges();
            }
        }

        public int AddComic(Comic comic)
        {
            _context.Comics.Add(comic);
            _context.SaveChanges();
            return comic.Id;
        }

        public int AddType(Domain.Model.Type type)
        {
            _context.Types.Add(type);
            _context.SaveChanges();
            return type.Id;
        }

        public void UpdateComic(Comic comic)
        {
            _context.Attach(comic);
            _context.Entry(comic).Property("Title").IsModified = true;
            _context.Entry(comic).Property("Issue").IsModified = true;
            _context.Entry(comic).Property("Publisher").IsModified = true;
            _context.Entry(comic).Property("ReleaseDate").IsModified = true;
            _context.Entry(comic).Property("Description").IsModified = true;
            _context.Entry(comic).Property("TypeId").IsModified = true;
            _context.Entry(comic).Property("ComicPhoto").IsModified = true;
            _context.Entry(comic).Property("Author").IsModified = true;
            _context.Entry(comic).Property("Drawings").IsModified = true;
            _context.SaveChanges();
        }

        public void DeleteTypeComic(int id)
        {
            var type = _context.Types.Find(id);
            if (type != null)
            {
                _context.Types.Remove(type);
                _context.SaveChanges();
            }
        }
    }
}
