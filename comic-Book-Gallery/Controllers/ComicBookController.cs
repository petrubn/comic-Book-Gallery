using Microsoft.AspNetCore.Mvc;
using System;
using comic_Book_Gallery.Data;
using comic_Book_Gallery.Models;
using Microsoft.AspNetCore.Mvc.Formatters;

namespace comic_Book_Gallery.Controllers;

public class ComicBookController : Controller
{
    
    public ActionResult Index()
    {
        var comicBooks = _comicBookrepository.GetComicBooks();

        return View(comicBooks);
    }

    private ComicBookRepository _comicBookrepository = null;

    public ComicBookController()
    {
        _comicBookrepository = new ComicBookRepository();
    }
    
    public ActionResult Detail(int? id)
    {
        if (id == null)
        {
            return new NotFoundResult();
        }
        
        var comicBook = _comicBookrepository.GetComicBook((int)id);
        return View(comicBook);
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