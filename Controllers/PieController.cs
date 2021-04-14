using BethanysPieShop.Models;
using BethanysPieShop.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShop.Controllers
{
    public class PieController : Controller
    {
        private readonly IPieRepository _pie;
        private readonly ICategoryRepository _category;

        public PieController (IPieRepository pie, ICategoryRepository category)
        {
            _pie = pie;
            _category = category;
        }

        // GET: PieController
        public ViewResult List()
        {
            PiesListViewModel piesListViewModel = new PiesListViewModel();

            piesListViewModel.Pies = _pie.AllPies;

            piesListViewModel.CurrentCategory = "Cheese Cakes";

            return View(piesListViewModel);
        }

        // GET: PieController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PieController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PieController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PieController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PieController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PieController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PieController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
