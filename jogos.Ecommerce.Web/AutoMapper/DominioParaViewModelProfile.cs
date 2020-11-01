﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using jogos.Ecommerce.Dominio;
using jogos.Ecommerce.Web.ViewModel.FichaTecnica;

namespace jogos.Ecommerce.Web.AutoMapper
{
    public class DominioParaViewModelProfile : Profile
    {
        protected override void Configure()
        {
            Mapper.CreateMap<FichaTecnica, FichaTecnicaIndexViewModel>()
                .ForMember(p => p.Nome, opt => 
                { opt.MapFrom(src => string.Format("{0} {1}", src.Nome, src.AnoLancamento, ToString())); });
                    
            Mapper.CreateMap<FichaTecnica, FichaTecnicaViewModel>();
        }
    }
}