using Microsoft.AspNetCore.Mvc;

namespace TutorialExploreCalifornia.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return new ContentResult { Content = "Blog Posts" };
        }

        public IActionResult Post(int? id)
        {
            if (id == null)
            {
                return new ContentResult { Content = "null" };
            }
            else
            {
                return new ContentResult { Content = id.ToString() };
            }
        }
    }
}
