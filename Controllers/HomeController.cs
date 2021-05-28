using Microsoft.AspNetCore.Mvc;

namespace FactorySpace.Controllers
{
    public class HomeController : Controller
    {

      [HttpGet("/")]
      public ActionResult Index()
      {
        return View();
      }

    }
}