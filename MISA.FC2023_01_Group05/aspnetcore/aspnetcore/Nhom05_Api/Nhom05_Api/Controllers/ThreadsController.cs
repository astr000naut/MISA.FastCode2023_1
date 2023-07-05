using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Nhom05_Core.DTO;
using Nhom05_Core.Interfaces.Services;

namespace Nhom05_Api.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ThreadsController : BaseController<ThreadDto, ThreadCreateDto, ThreadUpdateDto>
    {
        private readonly IThreadService _threadService;
        public ThreadsController(IThreadService threadService) : base(threadService)
        {
            _threadService = threadService;
        }
    }
}
