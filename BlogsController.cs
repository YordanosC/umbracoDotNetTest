using J2N.Text;
using Microsoft.AspNetCore.Mvc;
using NPoco.Expressions;
using Umbraco.Cms.Web.Common.Controllers;

namespace MyCustomUmbracoProject
{
    public class BlogsController : UmbracoApiController
    {
        [HttpPost]
        public JsonResult GetSearchBlogs(string search)
        {
            return new JsonResult(GetBlogs().Where(x => x.Title.Contains(search) || x.Body.Contains(search)));
        }

        public List<Blog> GetBlogs()
        {
           List<Blog> list = new List<Blog>();
            list.Add(new Blog
            {
                UserId = 1,
                Id = 1,
                Title = "sunt aut facere repellat provident occaecati excepturi optio reprehenderit",
                Body = "quia et suscipit\nsuscipit recusandae consequuntur expedita et cum\nreprehenderit molestiae ut ut quas totam\nnostrum rerum est autem sunt rem eveniet architecto"
            }
            ); 
            list.Add(new Blog
            {
                UserId = 1,
                Id = 2,
                Title = "qui est esse",
                Body = "est rerum tempore vitae\nsequi sint nihil reprehenderit dolor beatae ea dolores neque\nfugiat blanditiis voluptate porro vel nihil molestiae ut reiciendis\nqui aperiam non debitis possimus qui neque nisi nulla"
            }
            );

            return list;
        }
    }

    public class Blog
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public required string Title { get; set; }
        public required string Body { get; set; }
    }
}
