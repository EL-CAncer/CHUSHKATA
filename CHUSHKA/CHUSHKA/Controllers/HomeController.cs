﻿using System.Diagnostics;
using CHUSHKA.Models;
using Microsoft.AspNetCore.Mvc;
using CHUSHKA.Services.Contracts;
using AutoMapper;

namespace CHUSHKA.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductsService productsService;

        public HomeController(IProductsService productsService)
        {
            this.productsService = productsService;
        }

        public async Task<IActionResult> Index()
        {
            if (!this.User.Identity.IsAuthenticated)
            {
                return this.View();
            }

            var products = (await this.productsService.GetAll())
                .Select(Mapper.Map<ProductListViewModel>)
                .ToArray();

            return this.View(products);

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return this.View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? this.HttpContext.TraceIdentifier });
        }
    }
}