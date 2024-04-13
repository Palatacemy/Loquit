using AutoMapper;
using Loquit.Data.Entities;
using Loquit.Services.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loquit.Services.Profiles
{
    //Profile for mapping Like and its DTO
    public class LikeProfile : Profile
    {
        public LikeProfile()
        {
            CreateMap<Like, LikeDTO>()
                .ReverseMap();
        }
    }
}
