using AutoMapper;
using ComicWorld.Application.Mapping;
using FluentValidation;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace ComicWorld.Application.ViewModels.Comic
{
    public class NewComicVm : IMapFrom<ComicWorld.Domain.Model.Comic>
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Issue { get; set; }
        public string Publisher { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public string Drawings { get; set; }
        public string ComicPhoto { get; set; }
        public int TypeId { get; set; }
        public virtual ComicWorld.Domain.Model.Type Type { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<NewComicVm, ComicWorld.Domain.Model.Comic>().ReverseMap();
        }
    }

    public class NewComicValidation : AbstractValidator<NewComicVm> 
    {
        public NewComicValidation()
        {
            RuleFor(x => x.Id).NotNull();
            RuleFor(x => x.Title).MaximumLength(100);
            RuleFor(x => x.Publisher).Length(1, 30);
            RuleFor(x => x.TypeId).NotNull();
        }
    }

}
