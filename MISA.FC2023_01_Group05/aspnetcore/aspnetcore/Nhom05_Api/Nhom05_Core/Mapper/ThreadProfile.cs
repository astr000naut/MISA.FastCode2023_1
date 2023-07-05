using AutoMapper;
using Nhom05_Core.DTO;
using Nhom05_Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom05_Core.Mapper
{
    public class ThreadProfile : Profile
    {
        public ThreadProfile() 
        {
            CreateMap<MThread, ThreadDto>();
            CreateMap<ThreadCreateDto, MThread>();
            CreateMap<ThreadUpdateDto, MThread>();
        }

    }
}
