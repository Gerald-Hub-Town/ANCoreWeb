using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ANCoreWeb.Models
{
    public class Content
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ContentMsg { get; set; }
        public int Status { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? ModifyTime { get; set; }
    }
}
