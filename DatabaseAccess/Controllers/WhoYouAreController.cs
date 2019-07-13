namespace todo.Controllers
{
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Models;

    public class WhoYouAreController : Controller {

        [HttpGet]
        [Route("WhoYouAre")]
        public IActionResult WhoYouAre()
        {
            return View("WhoYouAre");
        }
    }
}