using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FormSubmission.Models;

namespace FormSubmission.Controllers;

public class HomeController : Controller
{
    [HttpGet("")]
    public IActionResult Index()
    {
        return View("Index");
    }

    [HttpPost("user/create")]
    public IActionResult NewUser(User user)
    {
        if (ModelState.IsValid)
        {
          return RedirectToAction("Result");
        }
        else 
        {
          return View("Index");
        }
    }

    [HttpGet("result")]
    public IActionResult Result()
    {
      return View("Result");
    }
}
