using AutoMapper;
using ProjetoDeTeste.Domain.Entities;
using ProjetoDeTeste.MVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoDeTeste.MVC.AutoMapper
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {

            CreateMap<Fornecedores, FornecedoresViewModel>().ReverseMap();

        }

        public static void Registermappings()
        {
            Mapper.Initialize(c =>
            {
                c.AddProfile<AutoMapperConfig>();
            });
        }
    }
}