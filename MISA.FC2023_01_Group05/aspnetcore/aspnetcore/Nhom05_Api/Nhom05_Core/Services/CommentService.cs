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
    public class CommentService
        : BaseService<Comment, CommentDto, CommentCreateDto, CommentUpdateDto>, ICommentService
    {
        protected readonly ICommentRepository _commentRepository;
        public CommentService(ICommentRepository commentRepository, IMapper mapper) : base(commentRepository, mapper)
        {
            _commentRepository = commentRepository;
        }
    }
}
