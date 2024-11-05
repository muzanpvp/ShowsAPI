using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using showsapi.Models;
using showsapi.ViewModels;

namespace showsapi.Mappers
{
    public class UsuarioProfile : Profile
    {
        public UsuarioProfile(){
            CreateMap<UsuarioViewModel, Usuario>().ReverseMap();
        }
    }
}