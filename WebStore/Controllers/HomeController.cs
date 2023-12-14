﻿using Microsoft.AspNetCore.Mvc;

namespace WebStore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return Content("Home controller - action Index");
        }

        public IActionResult SomeAction()
        {
            return Content("Home controller - action SomeAction");
        }
    }
}
