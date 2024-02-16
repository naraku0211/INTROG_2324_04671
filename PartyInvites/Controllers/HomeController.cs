using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PartyInvites.Models;

namespace PartyInvites.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    [HttpGet]
    public ViewResult RsvpForm()
    {
        return View();
    }

    [HttpPost]
    public ViewResult RsvpForm(GuestInvite guestInvite)
    {
        Repository.AddResponse(guestInvite);
        return View("Thanks", guestInvite); 
    }

    public ViewResult ListResponses()
    {
        return View(Repository.Response.Where(r => r.WillAttend == true));
    }

 
}
