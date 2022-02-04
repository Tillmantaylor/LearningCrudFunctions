using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TVTLabW03Crud.Models.Entities;
using TVTLabW03Crud.Services;

namespace TVTLabW03Crud.Controllers
{
    public class VideoGameController : Controller
    {
        private readonly IVideoGameRepository _videogameRepo;

        public VideoGameController(IVideoGameRepository videogameRepo)
        {
            _videogameRepo = videogameRepo;
        }

        public IActionResult Index()
        {
            var model = _videogameRepo.ReadAll();
            return View(model);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(VideoGame videogame)
        {
            if (ModelState.IsValid)
            {
                _videogameRepo.Create(videogame);
                return RedirectToAction("Index");
            }
            return View(videogame);
        }

        public IActionResult Details(int id)
        {
            var videogame = _videogameRepo.Read(id);
            if (videogame == null)
            {
                return RedirectToAction("Index");
            }
            return View(videogame);
        }

        public IActionResult Edit(int id)
        {
            var videogame = _videogameRepo.Read(id);
            if (videogame == null)
            {
                return RedirectToAction("Index");
            }
            return View(videogame);
        }

        [HttpPost]
        public IActionResult Edit(VideoGame videogame)
        {
            if (ModelState.IsValid)
            {
                _videogameRepo.Update(videogame.Id, videogame);
                return RedirectToAction("Index");
            }
            return View(videogame);
        }

        public IActionResult Delete(int id)
        {
            var videogame = _videogameRepo.Read(id);
            if (videogame == null)
            {
                return RedirectToAction("Index");
            }
            return View(videogame);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            _videogameRepo.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
