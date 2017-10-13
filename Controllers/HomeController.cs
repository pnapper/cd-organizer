using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using CdOrganizer.Models;

namespace CdOrganizer.Controllers
{
  public class HomeController : Controller
  {

    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }

    [HttpGet("/albums")]
    public ActionResult Titles()
    {
      List<Album> allAlbums = Album.GetAll();
      return View(allAlbums);
    }

    [HttpGet("/albums/new")]
    public ActionResult AlbumForm()
    {
      return View();
    }

    [HttpPost("/albums")]
    public ActionResult AddAlbum()
    {
      Album newAlbum = new Album(Request.Form["new-album"]);
      List<Album> allAlbums = Album.GetAll();
      return View("Albums", allAlbums);
    }

    [HttpGet("/albums/{id}")]
    public ActionResult AlbumDetail(int id)
    {
      Album album = Album.Find(id);
      return View(album);
    }
  }
}
