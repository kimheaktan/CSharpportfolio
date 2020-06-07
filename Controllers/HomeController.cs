using Microsoft.AspNetCore.Mvc;
namespace Portfolio.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public string Index()
        {
            return "This is my Home page.";
        }

        [HttpGet("contact")]
        public string Contact()
        {
            return "This is my contact.";
        }

        [HttpGet("projects")]
        public string Projects()
        {
            return "These are my projects.";
        }
    }
}