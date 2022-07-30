using AutoMapper;
using AutoMapper.QueryableExtensions;
using ComicWorld.Application.Interfaces;
using ComicWorld.Application.ViewModels.Comic;
using ComicWorld.Domain.Interface;
using ComicWorld.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComicWorld.Application.Services
{
    public class ComicService : IComicService
    {
        private readonly IComicRepository _comicRepo;
        private readonly IMapper _mapper;

        public ComicService(IComicRepository comicRepo, IMapper mapper)
        {
            _comicRepo = comicRepo;
            _mapper = mapper;
        }

        public int AddComic(NewComicVm comic)
        {
            var com = _mapper.Map<Comic>(comic);
            var id = _comicRepo.AddComic(com);
            return id;
        }

        public ListComicForListVm GetAllComicForList(int pageSize, int pageNo, string searchString)
        {
            var comics = _comicRepo.GetAllComics().Where(p => p.Title.StartsWith(searchString))
                .ProjectTo<ComicForListVm>(_mapper.ConfigurationProvider).ToList();
            var comicToShow = comics.Skip(pageSize * (pageNo - 1)).Take(pageSize).ToList();
            var comicList = new ListComicForListVm()
            {
                PageSize = pageSize,
                CurrentPage = pageNo,
                SearchString = searchString,
                Comics = comicToShow,
                Count = comics.Count
            };
            return comicList;
        }

        public ComicDetailsVm GetComicDetails(int comicId)
        {
            var comic = _comicRepo.GetComic(comicId);
            var comicVm = _mapper.Map<ComicDetailsVm>(comic);
            return comicVm;
        }
        public int AddType(NewTypeVm type)
        {
            var typ = _mapper.Map<ComicWorld.Domain.Model.Type>(type);
            var id = _comicRepo.AddType(typ);
            return id;
        }

        public NewComicVm GetComicForEdit(int id)
        {
            var comic = _comicRepo.GetComic(id);
            var comicVm = _mapper.Map<NewComicVm>(comic);
            return comicVm;
        }

        public void UpdateComic(NewComicVm model)
        {
            var comic = _mapper.Map<Comic>(model);
            _comicRepo.UpdateComic(comic);
        }

        public void DeleteComic(int id)
        {
            _comicRepo.DeleteComic(id);
        }

        public ListComicForListVm GetComicPublisherForList(int pageSize, int pageNo, string searchString)
        {
            var comics = _comicRepo.GetAllComics().Where(p => p.Publisher.StartsWith(searchString))
            .ProjectTo<ComicForListVm>(_mapper.ConfigurationProvider).ToList();
            var comicToShow = comics.Skip(pageSize * (pageNo - 1)).Take(pageSize).ToList();
            var comicList = new ListComicForListVm()
            {
                PageSize = pageSize,
                CurrentPage = pageNo,
                SearchString = searchString,
                Comics = comicToShow,
                Count = comics.Count
            };
            return comicList;
        }

        public void DeleteTypeComic(int id)
        {
            _comicRepo.DeleteTypeComic(id);
        }
    }
}
