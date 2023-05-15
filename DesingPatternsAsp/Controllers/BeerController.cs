using DesingPatterns.Models.Data;
using DesingPatterns.Repository;
using DesingPatternsAsp.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace DesingPatternsAsp.Controllers
{
    public class BeerController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public BeerController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            IEnumerable<BeerViewModel> beers = from d in _unitOfWork.Beers.Get()
                                               select new BeerViewModel
                                               {
                                                   Id = d.BeerId,
                                                   Name = d.Name,
                                                   Style = d.Style
                                               };

            return View(beers);
        }

        [HttpGet]
        public IActionResult Add()
        {
            var brands = _unitOfWork.Brands.Get();
            ViewBag.Brands = new SelectList(brands, "BrandId", "Name");

            return View();
        }

        [HttpPost]
        public IActionResult Add(FormBeerViewModel formBeerView)
        {
            if (!ModelState.IsValid)
            {
                var brands = _unitOfWork.Brands.Get();
                ViewBag.Brands = new SelectList(brands, "BrandId", "Name", formBeerView.BrandId);
                return View(formBeerView);
            }

            var beer = new Beer();

            beer.Name = formBeerView.Name;
            beer.Style = formBeerView.Style;

            if (formBeerView.BrandId == null)
            {
                var brand = new Brand();

                brand.Name = formBeerView.OtherBrand;
                brand.BrandId = Guid.NewGuid();
                beer.BrandId = brand.BrandId;
                _unitOfWork.Brands.Add(brand);
            }
            else
            {
                beer.BrandId = (Guid)formBeerView.BrandId;
            }

            _unitOfWork.Beers.Add(beer);
            _unitOfWork.Save();

            return RedirectToAction("Index");
        }
    }
}
