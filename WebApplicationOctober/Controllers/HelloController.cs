namespace WebApplicationOctober.Controllers;
using Microsoft.AspNetCore.Mvc;

public class HelloController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public ActionResult Minnesota()
    {
        return View();
    }

        public ActionResult Wisconsin()
    {
        return View();
    }
}