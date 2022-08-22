using ComicWorld.Application.Interfaces;
using ComicWorld.Application.ViewModels.Comic;
using ComicWorld.Infrastructure.Repository;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;


namespace ComicWorld.Controllers
{
    public class ComicController : Controller
    {
        private readonly IComicService _comService;

        public ComicController(IComicService comService)
        {
            _comService = comService;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var model = _comService.GetAllComicForList(5, 1, "");
            return View(model);
        }
        [HttpPost]
        public IActionResult Index(int pageSize, int? pageNo, string searchString)
        {
            if (!pageNo.HasValue)
            {
                pageNo = 1;
            }
            if (searchString is null)
            {
                searchString = String.Empty;
            }
            var model = _comService.GetAllComicForList(pageSize, pageNo.Value, searchString);
            return View(model);
        }
        [HttpGet]
        public IActionResult AddComic()
        {
            return View(new NewComicVm());
        }
        [HttpPost]
        public IActionResult AddComic(NewComicVm model)
        {
            var id = _comService.AddComic(model);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult AddType()
        {
            return View(new NewTypeVm());
        }
        [HttpPost]
        public IActionResult AddType(NewTypeVm model)
        {
            var id = _comService.AddType(model);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditComic(int id)
        {
            var comic = _comService.GetComicForEdit(id);
            return View(comic);
        }
        [HttpPost]
        public IActionResult EditComic(NewComicVm model)
        {
            _comService.UpdateComic(model);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteComic(int id)
        {
            _comService.DeleteComic(id);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult ComicDetails(int id)
        {
            var model = _comService.GetComicDetails(id);
            return View(model);
        }
        [HttpGet]
        public IActionResult GetComicFromMarvel()
        {
            var model = _comService.GetAllComicForList(5, 1, "Marvel");
            return View(model);
        }
        [HttpPost]
        public IActionResult GetComicFromMarvel(int pageSize, int? pageNo, string searchString)
        {
            if (!pageNo.HasValue)
            {
                pageNo = 1;
            }
            var model = _comService.GetAllComicForList(pageSize, pageNo.Value, searchString);
            return View(model);
        }
        [HttpGet]
        public IActionResult GetComicFromDC()
        {
            var model = _comService.GetAllComicForList(5, 1, "DC Comics");
            return View(model);
        }
        [HttpPost]
        public IActionResult GetComicFromDC(int pageSize, int? pageNo, string searchString)
        {
            if (!pageNo.HasValue)
            {
                pageNo = 1;
            }
            var model = _comService.GetAllComicForList(pageSize, pageNo.Value, searchString);
            return View(model);
        }
        [HttpGet]
        public IActionResult GetComicFromImage()
        {
            var model = _comService.GetAllComicForList(5, 1, "Image");
            return View(model);
        }
        [HttpPost]
        public IActionResult GetComicFromImage(int pageSize, int? pageNo, string searchString)
        {
            if (!pageNo.HasValue)
            {
                pageNo = 1;
            }
            var model = _comService.GetAllComicForList(pageSize, pageNo.Value, searchString);
            return View(model);
        }
        [HttpGet]
        public IActionResult GetComicFromDarkHorse()
        {
            var model = _comService.GetAllComicForList(5, 1, "Dark Horse");
            return View(model);
        }
        [HttpPost]
        public IActionResult GetComicFromDarkHorse(int pageSize, int? pageNo, string searchString)
        {
            if (!pageNo.HasValue)
            {
                pageNo = 1;
            }
            var model = _comService.GetAllComicForList(pageSize, pageNo.Value, searchString);
            return View(model);
        }
        public IActionResult DeleteTypeComic(int id)
        {
            _comService.DeleteTypeComic(id);
            return RedirectToAction("Index");
        }
    }
}
