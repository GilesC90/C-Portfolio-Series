using Microsoft.AspNetCore.Mvc;

namespace Portfolio1.Controllers
{
    public class HomeController : Controller
    {
        // Requests
        // localhost:5000
        // [Route("")]
        [HttpGet("")]
        public ViewResult Index()
        {
            // ViewResult myView = View();
            return View();
        }

        // localhost:5000/projects
        [Route("project")]
        [HttpGet]
        public ViewResult Project()
        {
            return View();
        }
        // localhost:5000/contact
            [Route("contact")]
            [HttpGet]
            public ViewResult Contact()
            {
                return View();
            }
        // localhost:5000/users/???
        // [HttpGet("users/{username}/{location}")]
        // public string HelloUser(string username, string location)
        // {
        //     return $"Hello {username} from {location}";
        // }
    }
}