using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using showsapi.Models;
using showsapi.ViewModels;

namespace showsapi.Mappers
{
    public class ShowsProfile : Profile
    {
        public ShowsProfile(){
            CreateMap<ShowsViewModel, Shows>().ReverseMap();
        }
    }
}