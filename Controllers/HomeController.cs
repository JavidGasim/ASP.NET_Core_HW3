using ASP.NET_Core_HW3.Entities;
using ASP.NET_Core_HW3.Models;
using ASP.NET_Core_HW3.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Core_HW3.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductService _productService;

        public HomeController(IProductService productService)
        {
            _productService = productService;
        }

        public async Task<IActionResult> Index(string key = "")
        {
            var result = await _productService.GetAllByKey(key);

            ProductViewModel viewModel = new ProductViewModel()
            {
                Products = result
            };

            return View(viewModel);
        }

        public async Task<IActionResult> Delete(int id)
        {
            await _productService.DeleteAsync(id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var result = await _productService.GetById(id);

            EditViewModel viewModel = new EditViewModel()
            {
                Product = result
            };

            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(EditViewModel editView)
        {
            await _productService.Edit(editView.Product);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var addModel = new AddViewModel()
            {
                Product = new Product()
            };

            return View(addModel);
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddViewModel addView)
        {
            await _productService.AddAsync(addView.Product);
            return RedirectToAction("Index");
        }
    }
}
