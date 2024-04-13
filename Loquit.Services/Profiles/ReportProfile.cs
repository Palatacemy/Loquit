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
    //Profile for mapping Report and its DTO
    public class ReportProfile : Profile
    {
        public ReportProfile()
        {
            CreateMap<Report, ReportDTO>()
                .ReverseMap();
        }
    }
}
