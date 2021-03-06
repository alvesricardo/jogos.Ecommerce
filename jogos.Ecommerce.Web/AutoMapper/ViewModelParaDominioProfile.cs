﻿using AutoMapper;
using jogos.Ecommerce.Dominio;
using jogos.Ecommerce.Web.ViewModel.FichaTecnica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using jogos.Ecommerce.Web.ViewModel.Plataforma;

namespace jogos.Ecommerce.Web.AutoMapper
{
    public class ViewModelParaDominioProfile : Profile
    {
        protected override void Configure()
        {
            Mapper.CreateMap<FichaTecnicaViewModel, FichaTecnica>();

            Mapper.CreateMap<PlataformaViewModel, Plataforma>();
        }
    }
}