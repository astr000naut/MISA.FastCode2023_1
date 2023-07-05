using Microsoft.Extensions.Configuration;
using Nhom05_Core.Entities;
using Nhom05_Core.Interfaces.Infrastructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom05_Infrastructure.Repository
{
    public class CommentRepository : BaseRepository<Comment>, ICommentRepository
    {
        public CommentRepository(IConfiguration configuration) : base(configuration)
        {
        }
    }
}
