﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using cloud_template_dotnet_core.Models;
using KenticoCloud.Delivery;

namespace cloud_template_dotnet_core.Controllers
{
    public class HomeController : Controller
    {
        private IDeliveryClient _deliveryClient;

        public HomeController(IDeliveryClient deliveryClient)
        {
            _deliveryClient = deliveryClient;
        }

        public IActionResult Index()
        {
            var items = _deliveryClient.GetItemsAsync().Result;
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
