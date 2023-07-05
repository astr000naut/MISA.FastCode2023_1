using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Nhom05_Core.DTO;
using Nhom05_Core.Interfaces.Services;

namespace Nhom05_Api.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class CommentsController : BaseController<CommentDto, CommentCreateDto, CommentUpdateDto>
    {
        private readonly ICommentService _commentService;
        public CommentsController(ICommentService commentService) : base(commentService)
        {
            _commentService= commentService;    
        }
    }
}
