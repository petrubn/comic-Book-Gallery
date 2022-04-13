using Microsoft.AspNetCore.Mvc;

namespace comic_Book_Gallery.Controllers;

public class ComicBookController : Controller
{
    public ActionResult Detail()
    {
        if (DateTime.Today.DayOfWeek == DayOfWeek.Wednesday)
        {
            return Redirect("/");
        }

        return Content("Hello from the comic book controller");
    }
        
}