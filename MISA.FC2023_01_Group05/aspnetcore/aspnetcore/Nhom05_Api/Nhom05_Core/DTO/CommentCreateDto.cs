using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom05_Core.DTO
{
    public class CommentCreateDto
    {
        public Guid MThreadId { get; set; }
        public string? UserName { get; set; }
        public string Content { get; set; }
    }
}
