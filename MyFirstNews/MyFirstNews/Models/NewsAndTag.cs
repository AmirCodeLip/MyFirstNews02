using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstNews.Models
{
    public class NewsAndTag
    {

        public int TagId { get; set; }
        public int NewsId { get; set; }
        public Tag Tag { get; set; }
        public News News { get; set; }


    }
}
