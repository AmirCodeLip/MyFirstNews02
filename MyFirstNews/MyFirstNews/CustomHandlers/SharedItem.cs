using System;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace MyFirstNews
{
    public static class SharedItem
    {
        public static ContentResult JsonContent(object data)
        {
            string result = "";
            if (data is string)
                result = data.ToString();

            else
            {
                result = JsonConvert.SerializeObject(data, new JsonSerializerSettings
                {
                    ReferenceLoopHandling = ReferenceLoopHandling.Ignore

                });

            }

            return new ContentResult { ContentType = "Application/Json; charset=utf-8", Content = result };
        }



    }
}
