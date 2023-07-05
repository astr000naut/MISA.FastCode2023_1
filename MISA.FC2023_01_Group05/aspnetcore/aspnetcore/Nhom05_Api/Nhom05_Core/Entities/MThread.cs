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
    public class MThread : BaseEntity
    {
        public Guid MThreadId { get; set; }
        public int MThreadType { get; set; } 
        public string MThreadTitle { get; set; }
        public string? MUserName { get; set; }
        public string MThreadContent { get; set; }
    }
}
