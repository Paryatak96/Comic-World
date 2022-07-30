using AutoMapper;
using ComicWorld.Application.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace ComicWorld.Application.ViewModels.Comic
{
    public class NewTypeVm : IMapFrom<ComicWorld.Domain.Model.Type>
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<NewTypeVm, ComicWorld.Domain.Model.Type>();
        }
    }
}
