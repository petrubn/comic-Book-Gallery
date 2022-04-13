using Microsoft.AspNetCore.Mvc;
using System;

namespace comic_Book_Gallery.Controllers;

public class ComicBookController : Controller
{
    public ActionResult Detail()
    {
        return View();
    }

    public ActionResult Contacts()
    {
        return View();
    }

    public ActionResult Test()
    {
        return View("Test");
    }
        
}