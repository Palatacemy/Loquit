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
    //Profile for mapping Dislike and its DTO
    public class DislikeProfile : Profile
    {
        public DislikeProfile()
        {
            CreateMap<Dislike, DislikeDTO>()
                .ReverseMap();
        }
    }
}
