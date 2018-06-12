using Microsoft.AspNetCore.Mvc;

namespace TutorialExploreCalifornia.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return new ContentResult { Content = "Blog Posts" };
        }
    }
}
