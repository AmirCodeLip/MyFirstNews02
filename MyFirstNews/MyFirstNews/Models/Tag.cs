using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstNews.Models
{
    public class Tag
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int? ParentId { get; set; }
        public Tag Parent { get; set; }
        public ICollection<Tag> Childs { get; set; }
        public ICollection<NewsAndTag> NewsAndTags { get; set; }

    }
}
