﻿using AutoMapper;
using ComicWorld.Application.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace ComicWorld.Application.ViewModels.Comic
{
    public class ComicForListVm : IMapFrom<ComicWorld.Domain.Model.Comic>
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Issue { get; set; }
        public string Publisher { get; set; }
        public string ComicPhoto { get; set; }
        public virtual ComicWorld.Domain.Model.Type Type { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<ComicWorld.Domain.Model.Comic, ComicForListVm>();
        }
    }
}
