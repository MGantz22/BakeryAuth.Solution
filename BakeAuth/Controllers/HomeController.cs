using Microsoft.AspNetCore.Mvc;
using BakeAuth.Models;

namespace BakeAuth.Controllers
{
  public class HomeController : Controller
  {
    private readonly BakeAuthContext _db;
    public HomeController(BakeAuthContext db)
    {
      _db = db;
    }
    
    [HttpGet("/")]
    public ActionResult Index() {
      ViewBag.treats = _db.treats.ToList();
      ViewBag.flavors = _db.flavors.ToList();
      return View();
    }
  }
}