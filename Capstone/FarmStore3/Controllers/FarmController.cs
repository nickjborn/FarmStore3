using FarmStore3.FarmServices;
using FarmStore3.Models;
using Microsoft.AspNetCore.Mvc;

namespace FarmStore3.Controllers
{
    public class FarmController : Controller
    {
        private readonly IFarmService _FarmService;

        public FarmController(IFarmService farmService)
        {
            _FarmService = farmService;
        }

        public IActionResult Produce()
        {
            var result = _FarmService.GetProducts();
            return View(result);
        }
        public IActionResult AddProduce(Products model)
        {
            var addProduce = _FarmService.AddProduct(model);
            var result = _FarmService.GetProducts();
            return View("Produce", result);

        }

        public IActionResult UpdateProduce(int id, Products produce)
        {
            var updatedProduce = _FarmService.UpdateProduce(id, produce);
            var view = _FarmService.GetProducts();
            return View("Produce", view);
        }

    }
}
