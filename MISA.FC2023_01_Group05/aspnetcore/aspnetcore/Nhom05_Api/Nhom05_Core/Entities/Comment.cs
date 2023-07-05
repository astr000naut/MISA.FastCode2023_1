using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom05_Core.Entities
{
    /// <summary>
    /// Thực thể
    /// </summary>
    /// Created By: BNTIEN (05/07/2023)
    public class Comment : BaseEntity
    {
        public Guid CommentId { get; set; }
        public Guid MThreadId { get; set; }
        public string? UserName { get; set; }
        public string Content { get; set; }
    }
}
