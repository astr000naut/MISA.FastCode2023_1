using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom05_Core.DTO
{
    public class ThreadCreateDto
    {
        public int MThreadType { get; set; }
        public string MThreadTitle { get; set; }
        public string? MUserName { get; set; }
        public string MThreadContent { get; set; }
    }
}
