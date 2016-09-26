﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace AzureWebAppsDemo.Controllers
{
    public class HomeController : Controller
    {
        private IConfiguration config;
        private ILogger<HomeController> logger;

        public HomeController(IConfiguration config, ILogger<HomeController> logger)
        {
            this.config = config;
            this.logger = logger;
        }

        public IActionResult Index()
        {
            this.logger.LogInformation("**This is my cool info message!");
            this.logger.LogWarning("**This is my cool *warning* message!");

            this.ViewBag.SubTitle = this.config["General:subtitle"];
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

        public IActionResult Error()
        {
            return View();
        }
    }
}
