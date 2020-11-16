using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
namespace MyFirstNews.Models
{
    public class NewsImage
    {

        public Guid Id { get; set; }
        public int NewsId { get; set; }
        public string PathLocation { get; set; }

        public string Extension { get; set; }


        [NotMapped]
        public string FullPath { get => Path.Combine(PathLocation, Id + Extension); }
        public News News { get; set; }


    }
}
