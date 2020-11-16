using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyFirstNews.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstNews.Controllers
{
    public partial class HomeController : Controller
    {
        [HttpPost]
        public IActionResult GetNews(string tags)
        {

            List<News> model = null;
            if (!string.IsNullOrWhiteSpace(tags))
            {
                var tagsArray = Array.ConvertAll<string, int>(tags.Split(","), int.Parse);

                model = _db.NewsAndTags.Where(x => tagsArray.Contains(x.TagId)).
                    Include(x => x.News).Include(x => x.News.NewsImages).Select(x => x.News)
                    .ToList();



            }
            else
            {
                model = _db.Newses.Include(i => i.NewsImages).ToList();
            }
            return SharedItem.JsonContent(model);

        }



    }
}
