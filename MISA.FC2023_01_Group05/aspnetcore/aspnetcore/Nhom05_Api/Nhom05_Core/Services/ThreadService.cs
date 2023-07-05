using AutoMapper;
using Nhom05_Core.DTO;
using Nhom05_Core.Entities;
using Nhom05_Core.Interfaces.Infrastructures;
using Nhom05_Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom05_Core.Services
{
    public class ThreadService
        : BaseService<MThread, ThreadDto, ThreadCreateDto, ThreadUpdateDto>, IThreadService
    {
        protected readonly IThreadRepository _threadRepository;
        public ThreadService(IThreadRepository threadRepository, IMapper mapper) : base(threadRepository, mapper)
        {
            _threadRepository = threadRepository;
        }
    }
}
