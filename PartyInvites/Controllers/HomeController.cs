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
        if(ModelState.IsValid)
        {
            Repository.AddResponse(guestInvite);
            return View("Thanks", guestInvite);
        }
        else
        {
            return View();
        }
       
    }

    public ViewResult ListResponses()
    {
        return View(Repository.Response.Where(r => r.WillAttend == true));
    }

 
}
