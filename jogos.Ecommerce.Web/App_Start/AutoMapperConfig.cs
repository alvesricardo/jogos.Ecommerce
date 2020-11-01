using AutoMapper;
using jogos.Ecommerce.Web.AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace jogos.Ecommerce.Web.App_Start
{
    public static class AutoMapperConfig
    {
        public static void configurar()
        {
            Mapper.AddProfile<DominioParaViewModelProfile>();
            Mapper.AddProfile<ViewModelParaDominioProfile>();
        }
    }
}