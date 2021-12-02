using Microsoft.AspNetCore.Mvc;

namespace Portfolio1.Controllers
{
    public class HomeController : Controller
    {
        // Requests
        // localhost:5000
        // [Route("")]
        [HttpGet("")]
        public string Index()
        {
            return "This is my index";
        }

        // localhost:5000/projects
        [Route("projects")]
        [HttpGet]
        public string Projects()
        {
            return "These are my projects";
        }
        // localhost:5000/contact
            [Route("contact")]
            [HttpGet]
            public string Contact()
            {
                return "This is my Contact";
            }
        // localhost:5000/users/???
        // [HttpGet("users/{username}/{location}")]
        // public string HelloUser(string username, string location)
        // {
        //     return $"Hello {username} from {location}";
        // }
    }
}